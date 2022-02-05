using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using Dashboard;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ReadCanData()
        {
            try
            {
                byte[] data = new byte[80];
                IPEndPoint ipep = new IPEndPoint(IPAddress.Any,5005);
                UdpClient newsock = new UdpClient(ipep);
                data = newsock.Receive(ref ipep);
                CanData livedata = new CanData(data);
                while (true)
                {
                    data = newsock.Receive(ref ipep);
                    livedata.update(data);
                    UpdateDashBoard(livedata);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Errore nella lettura da socket: " + e.Message.ToString());
            }
        }

        private void UpdateDashBoard(CanData livedata)
        {
            //Here I update the charge bar on the top of the screen
            chargePanel.Invoke((MethodInvoker)delegate ()
            {  
                chargebar.Value = livedata.Charge;
                charge.Text = livedata.BatteryVoltage.ToString() + "V  " + livedata.Charge.ToString() + "%";
            });

            //Update battery cell value
            cellpanel.Invoke((MethodInvoker)delegate ()
            {
                vmaxcell.Text = livedata.VmaxCell.ToString()+"mV"; //scrivo il valore nella label
                if (livedata.VmaxCell > Fault.CELLVMAXFAULT) //controllo che il valore non superi i limiti, se li supera coloro di rosso lo sfondo
                    vmaxcell.BackColor = Color.Red;
                else
                    vmaxcell.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))); ;

                vmincell.Text = livedata.VminCell.ToString() + "mV";
                if (livedata.VminCell < Fault.CELLVMINFAULT)
                    vmincell.BackColor = Color.Red;
                else
                    vmincell.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
                
                tmeancell.Text = livedata.TmeanCell.ToString() + "°C";
                if (livedata.TmeanCell > Fault.CELLTEMPFAULT)
                    tmeancell.BackColor = Color.Red;
                else
                    tmeancell.BackColor = Color.PaleGreen;

                tmaxcell.Text = livedata.TmaxCell.ToString() + "°C";
                if (livedata.TmaxCell > Fault.CELLTEMPFAULT)
                    tmaxcell.BackColor = Color.Red;
                else
                    tmaxcell.BackColor = Color.PaleGreen;
            });

            //Here I update run info
            inforun_panel.Invoke((MethodInvoker)delegate () 
            {
                durata.Text = livedata.getTime();
                distance.Text = livedata.Distance.ToString()+"m";
                consume.Text = livedata.Consume.ToString()+"V";
            });

            //Here I update Motor Map section
            map_panel.Invoke((MethodInvoker)delegate ()
            {
                map.Text = livedata.Map.ToString(); //update label map.
                if (livedata.TractionControl)       //If the control is active the background color will be green.
                    traction.BackColor = Color.Lime;
                else
                    traction.BackColor = Color.Gainsboro;
                if (livedata.TorqueVectoring)
                    torquevectoring.BackColor = Color.Lime;
                else
                    torquevectoring.BackColor = Color.Gainsboro;
                if (livedata.Regen)
                    regen.BackColor = Color.Lime;
                else
                    regen.BackColor = Color.Gainsboro;
            });

            //Here I update max Value for Power,Torque,Regen
            settings_panel.Invoke((MethodInvoker)delegate () 
            {
                maxpower.Text = livedata.MaxPower.ToString() + "kW";
                maxregen.Text = livedata.RegenTorque.ToString() + "Nm";
                maxtorque.Text = livedata.MaxTorque.ToString() + "Nm";
            });

            //Here I update PowerTrain temperature
            temppanel.Invoke((MethodInvoker)delegate ()
            {
                motorosxtemp.Text = livedata.MotorsxTemp.ToString() + "°C";
                if (livedata.MotorsxTemp > Fault.MOTORTEMPFAULT)
                    motorosxtemp.BackColor = Color.Red;
                else
                    motorosxtemp.BackColor = Color.PaleGreen;
                motordxtemp.Text = livedata.MotordxTemp.ToString() + "°C";
                if (livedata.MotordxTemp > Fault.MOTORTEMPFAULT)
                    motordxtemp.BackColor = Color.Red;
                else
                    motorosxtemp.BackColor = Color.PaleGreen;
                invertersxtemp.Text = livedata.InvertersxTemp.ToString() + "°C";
                if (livedata.InvertersxTemp > Fault.INVERTERTEMPFAULT)
                    invertersxtemp.BackColor = Color.Red;
                else
                    invertersxtemp.BackColor = Color.PaleGreen;
                inverterdxtemp.Text = livedata.InverterdxTemp.ToString() + "°C";
                if (livedata.InverterdxTemp > Fault.INVERTERTEMPFAULT)
                    inverterdxtemp.BackColor = Color.Red;
                else
                    inverterdxtemp.BackColor = Color.PaleGreen;
            });

            //Update Fault Bar
            faultbar_panel.Invoke((MethodInvoker)delegate ()
            {
                
                if (livedata.isFault())
                {
                    fault.BackColor = Color.Red;
                    fault.Text = livedata.getFault();
                }else if (livedata.isWarning())
                {
                    fault.BackColor = Color.Yellow;
                    fault.ForeColor = Color.Red;
                    fault.Text = livedata.getWarning();
                }
                else
                {
                    fault.BackColor = Color.Gainsboro;
                    fault.ForeColor = Color.White;
                    fault.Text = "Nessun Fault";
                }
                    
            });

            //Update the procedure
            startprocedure_panel.Invoke((MethodInvoker)delegate () 
            {
                if(livedata.PosClosed && (!livedata.PrechargheClosed) && livedata.NegClosed)
                {
                    contactorpos.BackColor = Color.Lime;
                    precharghe.BackColor = Color.Lime;
                    contactorneg.BackColor = Color.Lime;
                }
                else
                {
                    if (livedata.NegClosed)
                        contactorneg.BackColor = Color.Red;
                    else
                        contactorneg.BackColor = Color.Gainsboro;

                    if (livedata.PosClosed)
                        contactorpos.BackColor = Color.Red;
                    else
                        contactorpos.BackColor = Color.Gainsboro;

                    if (livedata.PrechargheClosed)
                        precharghe.BackColor = Color.Red;
                    else
                        precharghe.BackColor = Color.Gainsboro;

                    
                }

                //Update LV battery charge 
                suberb_panel.Invoke((MethodInvoker)delegate () {
                    superb.Text = livedata.SuperB.ToString() + "V";
                    if(livedata.SuperB > 10)
                    {
                        superb.BackColor = Color.Yellow;
                    }
                    else
                    {
                        superb.BackColor = Color.Red;
                    }
                }); 
                
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(t =>
            {
                ReadCanData();
            })
            { IsBackground = true };
            thread.Start();
        }
    }
}
