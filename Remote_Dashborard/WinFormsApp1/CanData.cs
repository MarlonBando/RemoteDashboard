using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Dashboard
{

    class Fault
    {
        //Each fault has stored in a bit of fault[0] and fault[1]
        //here we assign the bit number at each fault
        public const int APPS_FAULT = 0;
        public const int PRECHARGE_FAULT = 1;
        public const int BMS_FAULT = 2;
        public const int BMS_OVERTEMPERATURE_FAULT = 3;
        public const int BMS_OVERVOLTAGE_FAULT = 4;
        public const int BMS_UNDERVOLTAGE_FAULT = 5;
        public const int INVERTERLEFT_FAULT = 6;
        public const int INVERTERRIGHT_FAULT = 7;
        public const int BMS_TIMEOUT = 8;
        public const int INVERTERLEFT_TIMEOUT = 9;
        public const int INVERTERRIGHT_TIMEOUT = 10;
        public const int CONTACTOR_FAULT = 11;
        public const int PEDALSENSOR_DISCONNECTED = 12;

        public const int CELLTEMPFAULT = 60;   //°C
        public const int CELLVMAXFAULT = 4300; //mV
        public const int CELLVMINFAULT = 3500; //mV
        public const int MOTORTEMPFAULT = 150; //°C
        public const int INVERTERTEMPFAULT = 150; //°C

    }

    class Warning
    {
        public const int MOTORSXTEMP_WARNING = 0;
        public const int MOTORRXTEMP_WARNING = 1;
        public const int INVERTERSXTEMP_WARNING = 2;
        public const int INVERTERDXTEMP_WARNING = 3;
        public const int BMSMASTERTEMP_WARNING = 4;
        public const int BMSMAXCELLTEMP_WARNING = 5;
        public const int BMSMAXCELLVOLTAGE_WARNING = 6;
        public const int BMSMINCELLVOLTAGE_WARNING = 7;
        public const int ACCELLEROMETER_TIMEOUT = 8;
        public const int STEERING_TIMEOUT = 9;
    }

    class CanData
    {
        // here we create all the data we are going to receive
        private const int control_index = 59;
        private int charge;
        private static int batteryVoltageStart;
        private int batteryVoltage;
        private int vmaxCell;
        private int vminCell;
        private float tmaxCell;
        private float tmeanCell;
        private float motorsxTemp;
        private float motordxTemp;
        private float invertersxTemp;
        private float inverterdxTemp;
        private bool tractionControl; // 0 OFF, 1 ON 
        private bool torqueVectoring; // 0 OFF, 1 ON
        private bool regen;
        private int regenTorque;
        private int maxPower;
        private int maxTorque;
        private int map; //0 don't care, 1 Nessun controllo, 2 TV,3 TC, 4 TV TC
        private int consume;
        private int speed;
        private double lastCall; //quanti secondi sono trascorsi quando viene effettuata la chiamata
        private int distance;
        private byte[] fault;
        private byte[] warning;
        private bool posClosed;
        private bool prechargheClosed;
        private bool negClosed;
        private float superB;

        private Stopwatch crono;

        public CanData(byte[] data)
        {
            batteryVoltageStart = 0;
            crono = new Stopwatch();
            crono.Start();
            fault = new byte[2];
            warning = new byte[2];
        }

        public void update(byte[] data)
        { 
                batteryVoltage = (data[0] + data[1]*256) / 10;
                if (batteryVoltageStart == 0)
                {
                    batteryVoltageStart = batteryVoltage;
                }
                int charge_temp = (int)((data[10] + data[11]*256)*0.01);
                if (charge_temp >= 0 && charge_temp <= 100)
                    charge = charge_temp;
                vmaxCell = data[2] + data[3]*256;
                vminCell = data[8] + data[9]*256;
                tmaxCell = (data[4] + data[5]*256)/10;
                tmeanCell = (data[6] + data[7]*256)/10;
                motordxTemp = (data[30] * 256 + data[31])/10;
                motorsxTemp = (data[28] * 256 + data[29])/10;
                inverterdxTemp = (data[26] * 256 + data[27])/10;
                invertersxTemp = (data[24] * 256 + data[25])/10;
                map = data[50];
                if (data[51] > 0)
                    torqueVectoring = true;
                else
                    torqueVectoring = false;

                if (data[52] > 0)
                    tractionControl = true;
                else
                    tractionControl = false;

                regenTorque = data[55];
                if (regenTorque > 0)
                    regen = true;
                else
                    regen = false;

                consume = batteryVoltageStart - batteryVoltage;
                fault[0] = data[20];
                fault[1] = data[21];
                warning[0] = data[22];
                warning[1] = data[23];
                maxPower = data[53];
                maxTorque = data[54];
                speed = (data[48] * 256 + data[49])/100;
                distance += (int)(speed * (crono.Elapsed.TotalSeconds - lastCall)); //speed deve essere in metri al secondo
                posClosed = (data[56] & 1) > 0;
                negClosed = (data[56] & (1 << 1)) > 0;
                prechargheClosed = (data[56] & (1 << 2)) > 0;
                superB = (float)((data[57] + data[58]*256)*0.01);
                lastCall = crono.Elapsed.TotalSeconds;
            }       

        public string getFault()
        {
            if ((fault[1]  & (1 << Fault.APPS_FAULT)) >= 1)
                return "APPS FAULT";
            if ((fault[1] & (1 << Fault.PRECHARGE_FAULT)) >= 1)
                return "PRECHARGE FAULT";
            if ((fault[1] & (1 << Fault.BMS_FAULT)) >= 1)
                return "BMS FAULT";
            if ((fault[1] & (1 << Fault.BMS_OVERTEMPERATURE_FAULT)) >= 1)
                return "BMS OVER TEMP FAULT";
            if ((fault[1] & (1 << Fault.BMS_OVERVOLTAGE_FAULT)) >= 1)
                return "BMS OVERVOLTAGE FAULT";
            if ((fault[1] & (1 << Fault.BMS_UNDERVOLTAGE_FAULT)) >= 1)
                return "BMS UNDERVOLTAGE FAULT";
            if ((fault[1] & (1 << Fault.INVERTERLEFT_FAULT)) >= 1)
                return "INVERTER LEFT FAULT";
            if ((fault[1] & (1 << Fault.INVERTERRIGHT_FAULT)) >= 1)
                return "INVERTER RIGHT FAULT";

            if ((fault[0] & (1 << (Fault.INVERTERLEFT_TIMEOUT-8))) >= 1)
                return "INVERTER LEFT TIMEOUT";
            if ((fault[0] & (1 << (Fault.INVERTERRIGHT_TIMEOUT-8))) >= 1)
                return "INVERTER RIGHT TIMEOUT";
            if ((fault[0] & (1 << (Fault.BMS_TIMEOUT-8))) >= 1)
                return "BMS TIMEOUT";
            if ((fault[0] & (1 << (Fault.CONTACTOR_FAULT-8))) >= 1)
                return "CONTACTOR FAULT";
            if ((fault[0] & (1 << (Fault.PEDALSENSOR_DISCONNECTED-8))) >= 1)
                return "PEDAL SENSOR DISCONNECTED";

            return "NESSUN FAULT";
        }

        public string getWarning()
        {
            if ((warning[1] & (1 << Warning.BMSMAXCELLTEMP_WARNING)) >= 1)
                return "WARNING CELL OVER TEMPERATURE";
            if ((warning[1] & (1 << Warning.INVERTERDXTEMP_WARNING)) >= 1)
                return "WARNING INVERTER TEMP DX";
            if ((warning[1] & (1 << Warning.BMSMASTERTEMP_WARNING)) >= 1)
                return "WARNING BMS MASTER TEMP";
            if ((warning[1] & (1 << Warning.MOTORSXTEMP_WARNING)) >= 1)
                return "WARNING TEMP MOTOR SX";
            if ((warning[1] & (1 << Warning.MOTORRXTEMP_WARNING)) >= 1)
                return "WARNING TEMP MOTOR DX";
            if ((warning[1] & (1 << Warning.INVERTERSXTEMP_WARNING)) >= 1)
                return "WARNING INVERTER TEMP SX";
            
            
            
            if ((warning[1] & (1 << Warning.BMSMINCELLVOLTAGE_WARNING)) >= 1)
                return "WARNING CELL UNDER VOLTAGE";

            if ((warning[0] & (1 << (Warning.ACCELLEROMETER_TIMEOUT - 8))) >= 1)
                return "ACCELEROMETER TIMEOUT";
            if ((warning[0] & (1 << (Warning.STEERING_TIMEOUT - 8))) >= 1)
                return "STEERING TIMEOUT";

            return "Nessun Fault";
        }

        public bool isFault()
        {
            return fault[0] > 0 || fault[1] > 0;
        }
        public bool isWarning()
        {
            return warning[0] > 0;
        }
        public int BatteryVoltage { get => batteryVoltage; set => batteryVoltage = value; }
        public int VmaxCell { get => vmaxCell; set => vmaxCell = value; }
        public int VminCell { get => vminCell; set => vminCell = value; }
        public float TmaxCell { get => tmaxCell; set => tmaxCell = value; }
        public float TmeanCell { get => tmeanCell; set => tmeanCell = value; }
        public bool TractionControl { get => tractionControl; set => tractionControl = value; }
        public bool TorqueVectoring { get => torqueVectoring; set => torqueVectoring = value; }
        public int RegenTorque { get => regenTorque; set => regenTorque = value; }
        public int MaxPower { get => maxPower; set => maxPower = value; }
        public int MaxTorque { get => maxTorque; set => maxTorque = value; }
        public int Map { get => map; set => map = value; }
        public int Consume { get => consume; set => consume = value; }
        public bool Regen { get => regen; set => regen = value; }
        public float InverterdxTemp { get => inverterdxTemp; set => inverterdxTemp = value; }
        public float MotordxTemp { get => motordxTemp; set => motordxTemp = value; }
        public float InvertersxTemp { get => invertersxTemp; set => invertersxTemp = value; }
        public float MotorsxTemp { get => motorsxTemp; set => motorsxTemp = value; }
        public int Distance { get => distance; set => distance = value; }
        public int Charge { get => charge; set => charge = value; }
        public int Speed { get => speed; set => speed = value; }
        public bool PosClosed { get => posClosed; set => posClosed = value; }
        public bool PrechargheClosed { get => prechargheClosed; set => prechargheClosed = value; }
        public bool NegClosed { get => negClosed; set => negClosed = value; }
        public float SuperB { get => superB; set => superB = value; }

        public string getTime()
        {
            return crono.Elapsed.ToString("mm\\:ss");
        }
    }
}
