
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chargePanel = new System.Windows.Forms.Panel();
            this.charge = new System.Windows.Forms.Label();
            this.chargebar = new System.Windows.Forms.ProgressBar();
            this.cellpanel = new System.Windows.Forms.Panel();
            this.tmeancell = new System.Windows.Forms.Label();
            this.tmaxcell = new System.Windows.Forms.Label();
            this.vmincell = new System.Windows.Forms.Label();
            this.vmaxcell = new System.Windows.Forms.Label();
            this.tmeanncell_label = new System.Windows.Forms.Label();
            this.vmincell_label = new System.Windows.Forms.Label();
            this.tmaxcell_label = new System.Windows.Forms.Label();
            this.vmaxcell_label = new System.Windows.Forms.Label();
            this.temppanel = new System.Windows.Forms.Panel();
            this.inverterdxtemp = new System.Windows.Forms.Label();
            this.motordxtemp = new System.Windows.Forms.Label();
            this.invertersxtemp = new System.Windows.Forms.Label();
            this.motorosxtemp = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.motorsx_label = new System.Windows.Forms.Label();
            this.faultbar_panel = new System.Windows.Forms.Panel();
            this.fault = new System.Windows.Forms.Label();
            this.inforun_panel = new System.Windows.Forms.Panel();
            this.consume = new System.Windows.Forms.Label();
            this.consume_label = new System.Windows.Forms.Label();
            this.distance = new System.Windows.Forms.Label();
            this.distance_label = new System.Windows.Forms.Label();
            this.durata = new System.Windows.Forms.Label();
            this.time_label = new System.Windows.Forms.Label();
            this.map_panel = new System.Windows.Forms.Panel();
            this.map = new System.Windows.Forms.Label();
            this.map_label = new System.Windows.Forms.Label();
            this.regen = new System.Windows.Forms.Label();
            this.traction = new System.Windows.Forms.Label();
            this.torquevectoring = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.settings_panel = new System.Windows.Forms.Panel();
            this.maxregen = new System.Windows.Forms.Label();
            this.maxtorque = new System.Windows.Forms.Label();
            this.maxpower = new System.Windows.Forms.Label();
            this.maxregen_label = new System.Windows.Forms.Label();
            this.maxtorque_power = new System.Windows.Forms.Label();
            this.maxpower_label = new System.Windows.Forms.Label();
            this.startprocedure_panel = new System.Windows.Forms.Panel();
            this.contactorneg = new System.Windows.Forms.Label();
            this.precharghe = new System.Windows.Forms.Label();
            this.contactorpos = new System.Windows.Forms.Label();
            this.suberb_panel = new System.Windows.Forms.Panel();
            this.superb = new System.Windows.Forms.Label();
            this.suberb_label = new System.Windows.Forms.Label();
            this.chargePanel.SuspendLayout();
            this.cellpanel.SuspendLayout();
            this.temppanel.SuspendLayout();
            this.faultbar_panel.SuspendLayout();
            this.inforun_panel.SuspendLayout();
            this.map_panel.SuspendLayout();
            this.settings_panel.SuspendLayout();
            this.startprocedure_panel.SuspendLayout();
            this.suberb_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // chargePanel
            // 
            this.chargePanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.chargePanel.Controls.Add(this.charge);
            this.chargePanel.Controls.Add(this.chargebar);
            this.chargePanel.Location = new System.Drawing.Point(50, 10);
            this.chargePanel.Name = "chargePanel";
            this.chargePanel.Size = new System.Drawing.Size(1100, 100);
            this.chargePanel.TabIndex = 0;
            // 
            // charge
            // 
            this.charge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.charge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.charge.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.charge.ForeColor = System.Drawing.Color.White;
            this.charge.Location = new System.Drawing.Point(461, 20);
            this.charge.Name = "charge";
            this.charge.Size = new System.Drawing.Size(232, 60);
            this.charge.TabIndex = 1;
            this.charge.Text = "ND";
            this.charge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chargebar
            // 
            this.chargebar.ForeColor = System.Drawing.Color.LimeGreen;
            this.chargebar.Location = new System.Drawing.Point(0, 0);
            this.chargebar.Name = "chargebar";
            this.chargebar.Size = new System.Drawing.Size(1100, 100);
            this.chargebar.TabIndex = 0;
            this.chargebar.Value = 100;
            // 
            // cellpanel
            // 
            this.cellpanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cellpanel.Controls.Add(this.tmeancell);
            this.cellpanel.Controls.Add(this.tmaxcell);
            this.cellpanel.Controls.Add(this.vmincell);
            this.cellpanel.Controls.Add(this.vmaxcell);
            this.cellpanel.Controls.Add(this.tmeanncell_label);
            this.cellpanel.Controls.Add(this.vmincell_label);
            this.cellpanel.Controls.Add(this.tmaxcell_label);
            this.cellpanel.Controls.Add(this.vmaxcell_label);
            this.cellpanel.Location = new System.Drawing.Point(50, 125);
            this.cellpanel.Name = "cellpanel";
            this.cellpanel.Size = new System.Drawing.Size(634, 173);
            this.cellpanel.TabIndex = 1;
            // 
            // tmeancell
            // 
            this.tmeancell.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tmeancell.BackColor = System.Drawing.Color.PaleGreen;
            this.tmeancell.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tmeancell.ForeColor = System.Drawing.Color.Black;
            this.tmeancell.Location = new System.Drawing.Point(461, 92);
            this.tmeancell.Name = "tmeancell";
            this.tmeancell.Size = new System.Drawing.Size(149, 48);
            this.tmeancell.TabIndex = 4;
            this.tmeancell.Text = "ND";
            this.tmeancell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmaxcell
            // 
            this.tmaxcell.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tmaxcell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tmaxcell.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tmaxcell.ForeColor = System.Drawing.Color.Black;
            this.tmaxcell.Location = new System.Drawing.Point(157, 92);
            this.tmaxcell.Name = "tmaxcell";
            this.tmaxcell.Size = new System.Drawing.Size(149, 48);
            this.tmaxcell.TabIndex = 4;
            this.tmaxcell.Text = "ND";
            this.tmaxcell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vmincell
            // 
            this.vmincell.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vmincell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.vmincell.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vmincell.ForeColor = System.Drawing.Color.Black;
            this.vmincell.Location = new System.Drawing.Point(461, 13);
            this.vmincell.Name = "vmincell";
            this.vmincell.Size = new System.Drawing.Size(149, 48);
            this.vmincell.TabIndex = 6;
            this.vmincell.Text = "ND";
            this.vmincell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vmaxcell
            // 
            this.vmaxcell.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vmaxcell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.vmaxcell.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vmaxcell.ForeColor = System.Drawing.Color.Black;
            this.vmaxcell.Location = new System.Drawing.Point(157, 13);
            this.vmaxcell.Name = "vmaxcell";
            this.vmaxcell.Size = new System.Drawing.Size(149, 48);
            this.vmaxcell.TabIndex = 3;
            this.vmaxcell.Text = "ND";
            this.vmaxcell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmeanncell_label
            // 
            this.tmeanncell_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tmeanncell_label.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tmeanncell_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tmeanncell_label.ForeColor = System.Drawing.Color.White;
            this.tmeanncell_label.Location = new System.Drawing.Point(323, 92);
            this.tmeanncell_label.Name = "tmeanncell_label";
            this.tmeanncell_label.Size = new System.Drawing.Size(147, 48);
            this.tmeanncell_label.TabIndex = 5;
            this.tmeanncell_label.Text = "Mean T:";
            this.tmeanncell_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vmincell_label
            // 
            this.vmincell_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vmincell_label.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.vmincell_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vmincell_label.ForeColor = System.Drawing.Color.White;
            this.vmincell_label.Location = new System.Drawing.Point(323, 13);
            this.vmincell_label.Name = "vmincell_label";
            this.vmincell_label.Size = new System.Drawing.Size(121, 48);
            this.vmincell_label.TabIndex = 4;
            this.vmincell_label.Text = "Min V:";
            this.vmincell_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmaxcell_label
            // 
            this.tmaxcell_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tmaxcell_label.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tmaxcell_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tmaxcell_label.ForeColor = System.Drawing.Color.White;
            this.tmaxcell_label.Location = new System.Drawing.Point(19, 92);
            this.tmaxcell_label.Name = "tmaxcell_label";
            this.tmaxcell_label.Size = new System.Drawing.Size(133, 48);
            this.tmaxcell_label.TabIndex = 3;
            this.tmaxcell_label.Text = "Max T:";
            this.tmaxcell_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vmaxcell_label
            // 
            this.vmaxcell_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vmaxcell_label.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.vmaxcell_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vmaxcell_label.ForeColor = System.Drawing.Color.White;
            this.vmaxcell_label.Location = new System.Drawing.Point(19, 13);
            this.vmaxcell_label.Name = "vmaxcell_label";
            this.vmaxcell_label.Size = new System.Drawing.Size(133, 48);
            this.vmaxcell_label.TabIndex = 2;
            this.vmaxcell_label.Text = "Max V:";
            this.vmaxcell_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // temppanel
            // 
            this.temppanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.temppanel.Controls.Add(this.inverterdxtemp);
            this.temppanel.Controls.Add(this.motordxtemp);
            this.temppanel.Controls.Add(this.invertersxtemp);
            this.temppanel.Controls.Add(this.motorosxtemp);
            this.temppanel.Controls.Add(this.label5);
            this.temppanel.Controls.Add(this.label4);
            this.temppanel.Controls.Add(this.label3);
            this.temppanel.Controls.Add(this.motorsx_label);
            this.temppanel.Location = new System.Drawing.Point(50, 303);
            this.temppanel.Name = "temppanel";
            this.temppanel.Size = new System.Drawing.Size(634, 187);
            this.temppanel.TabIndex = 2;
            // 
            // inverterdxtemp
            // 
            this.inverterdxtemp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inverterdxtemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.inverterdxtemp.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inverterdxtemp.ForeColor = System.Drawing.Color.Black;
            this.inverterdxtemp.Location = new System.Drawing.Point(514, 108);
            this.inverterdxtemp.Name = "inverterdxtemp";
            this.inverterdxtemp.Size = new System.Drawing.Size(109, 48);
            this.inverterdxtemp.TabIndex = 18;
            this.inverterdxtemp.Text = "ND";
            this.inverterdxtemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // motordxtemp
            // 
            this.motordxtemp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.motordxtemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.motordxtemp.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.motordxtemp.ForeColor = System.Drawing.Color.Black;
            this.motordxtemp.Location = new System.Drawing.Point(514, 28);
            this.motordxtemp.Name = "motordxtemp";
            this.motordxtemp.Size = new System.Drawing.Size(109, 48);
            this.motordxtemp.TabIndex = 17;
            this.motordxtemp.Text = "ND";
            this.motordxtemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // invertersxtemp
            // 
            this.invertersxtemp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.invertersxtemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.invertersxtemp.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.invertersxtemp.ForeColor = System.Drawing.Color.Black;
            this.invertersxtemp.Location = new System.Drawing.Point(209, 108);
            this.invertersxtemp.Name = "invertersxtemp";
            this.invertersxtemp.Size = new System.Drawing.Size(109, 48);
            this.invertersxtemp.TabIndex = 16;
            this.invertersxtemp.Text = "ND";
            this.invertersxtemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // motorosxtemp
            // 
            this.motorosxtemp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.motorosxtemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.motorosxtemp.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.motorosxtemp.ForeColor = System.Drawing.Color.Black;
            this.motorosxtemp.Location = new System.Drawing.Point(209, 28);
            this.motorosxtemp.Name = "motorosxtemp";
            this.motorosxtemp.Size = new System.Drawing.Size(109, 48);
            this.motorosxtemp.TabIndex = 15;
            this.motorosxtemp.Text = "ND";
            this.motorosxtemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(323, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 48);
            this.label5.TabIndex = 14;
            this.label5.Text = "Inverter dx:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 48);
            this.label4.TabIndex = 13;
            this.label4.Text = "Inverter sx:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(323, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 48);
            this.label3.TabIndex = 12;
            this.label3.Text = "Motor dx:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // motorsx_label
            // 
            this.motorsx_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.motorsx_label.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.motorsx_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.motorsx_label.ForeColor = System.Drawing.Color.White;
            this.motorsx_label.Location = new System.Drawing.Point(11, 28);
            this.motorsx_label.Name = "motorsx_label";
            this.motorsx_label.Size = new System.Drawing.Size(170, 48);
            this.motorsx_label.TabIndex = 11;
            this.motorsx_label.Text = "Motor sx:";
            this.motorsx_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // faultbar_panel
            // 
            this.faultbar_panel.BackColor = System.Drawing.Color.Red;
            this.faultbar_panel.Controls.Add(this.fault);
            this.faultbar_panel.Location = new System.Drawing.Point(50, 707);
            this.faultbar_panel.Name = "faultbar_panel";
            this.faultbar_panel.Size = new System.Drawing.Size(1100, 75);
            this.faultbar_panel.TabIndex = 4;
            // 
            // fault
            // 
            this.fault.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fault.ForeColor = System.Drawing.Color.White;
            this.fault.Location = new System.Drawing.Point(0, 0);
            this.fault.Name = "fault";
            this.fault.Size = new System.Drawing.Size(1100, 75);
            this.fault.TabIndex = 0;
            this.fault.Text = "NESSUNA CONNESSIONE";
            this.fault.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inforun_panel
            // 
            this.inforun_panel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.inforun_panel.Controls.Add(this.consume);
            this.inforun_panel.Controls.Add(this.consume_label);
            this.inforun_panel.Controls.Add(this.distance);
            this.inforun_panel.Controls.Add(this.distance_label);
            this.inforun_panel.Controls.Add(this.durata);
            this.inforun_panel.Controls.Add(this.time_label);
            this.inforun_panel.Location = new System.Drawing.Point(50, 597);
            this.inforun_panel.Name = "inforun_panel";
            this.inforun_panel.Size = new System.Drawing.Size(1100, 98);
            this.inforun_panel.TabIndex = 19;
            // 
            // consume
            // 
            this.consume.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consume.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.consume.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.consume.ForeColor = System.Drawing.Color.White;
            this.consume.Location = new System.Drawing.Point(964, 23);
            this.consume.Name = "consume";
            this.consume.Size = new System.Drawing.Size(86, 48);
            this.consume.TabIndex = 17;
            this.consume.Text = "0V";
            this.consume.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // consume_label
            // 
            this.consume_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consume_label.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.consume_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.consume_label.ForeColor = System.Drawing.Color.White;
            this.consume_label.Location = new System.Drawing.Point(774, 23);
            this.consume_label.Name = "consume_label";
            this.consume_label.Size = new System.Drawing.Size(184, 48);
            this.consume_label.TabIndex = 16;
            this.consume_label.Text = "Consumo:";
            this.consume_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // distance
            // 
            this.distance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.distance.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.distance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.distance.ForeColor = System.Drawing.Color.White;
            this.distance.Location = new System.Drawing.Point(594, 23);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(174, 48);
            this.distance.TabIndex = 15;
            this.distance.Text = "0 Km";
            this.distance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // distance_label
            // 
            this.distance_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.distance_label.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.distance_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.distance_label.ForeColor = System.Drawing.Color.White;
            this.distance_label.Location = new System.Drawing.Point(424, 23);
            this.distance_label.Name = "distance_label";
            this.distance_label.Size = new System.Drawing.Size(164, 48);
            this.distance_label.TabIndex = 14;
            this.distance_label.Text = "Distanza:";
            this.distance_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // durata
            // 
            this.durata.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.durata.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.durata.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.durata.ForeColor = System.Drawing.Color.White;
            this.durata.Location = new System.Drawing.Point(231, 23);
            this.durata.Name = "durata";
            this.durata.Size = new System.Drawing.Size(104, 48);
            this.durata.TabIndex = 13;
            this.durata.Text = "00:00";
            this.durata.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // time_label
            // 
            this.time_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.time_label.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.time_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.time_label.ForeColor = System.Drawing.Color.White;
            this.time_label.Location = new System.Drawing.Point(19, 23);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(209, 48);
            this.time_label.TabIndex = 12;
            this.time_label.Text = "Durata Run:";
            this.time_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // map_panel
            // 
            this.map_panel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.map_panel.Controls.Add(this.map);
            this.map_panel.Controls.Add(this.map_label);
            this.map_panel.Controls.Add(this.regen);
            this.map_panel.Controls.Add(this.traction);
            this.map_panel.Controls.Add(this.torquevectoring);
            this.map_panel.Location = new System.Drawing.Point(719, 125);
            this.map_panel.Name = "map_panel";
            this.map_panel.Size = new System.Drawing.Size(431, 140);
            this.map_panel.TabIndex = 7;
            // 
            // map
            // 
            this.map.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.map.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.map.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.map.ForeColor = System.Drawing.Color.White;
            this.map.Location = new System.Drawing.Point(219, 12);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(70, 48);
            this.map.TabIndex = 11;
            this.map.Text = "1";
            this.map.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // map_label
            // 
            this.map_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.map_label.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.map_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.map_label.ForeColor = System.Drawing.Color.White;
            this.map_label.Location = new System.Drawing.Point(116, 10);
            this.map_label.Name = "map_label";
            this.map_label.Size = new System.Drawing.Size(111, 48);
            this.map_label.TabIndex = 10;
            this.map_label.Text = "MAP:";
            this.map_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // regen
            // 
            this.regen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regen.BackColor = System.Drawing.Color.Gainsboro;
            this.regen.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.regen.ForeColor = System.Drawing.Color.White;
            this.regen.Location = new System.Drawing.Point(329, 70);
            this.regen.Name = "regen";
            this.regen.Size = new System.Drawing.Size(71, 48);
            this.regen.TabIndex = 9;
            this.regen.Text = "RB";
            this.regen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // traction
            // 
            this.traction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.traction.BackColor = System.Drawing.Color.Gainsboro;
            this.traction.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.traction.ForeColor = System.Drawing.Color.White;
            this.traction.Location = new System.Drawing.Point(174, 72);
            this.traction.Name = "traction";
            this.traction.Size = new System.Drawing.Size(71, 48);
            this.traction.TabIndex = 8;
            this.traction.Text = "TC";
            this.traction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // torquevectoring
            // 
            this.torquevectoring.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.torquevectoring.BackColor = System.Drawing.Color.Gainsboro;
            this.torquevectoring.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.torquevectoring.ForeColor = System.Drawing.Color.White;
            this.torquevectoring.Location = new System.Drawing.Point(24, 70);
            this.torquevectoring.Name = "torquevectoring";
            this.torquevectoring.Size = new System.Drawing.Size(74, 48);
            this.torquevectoring.TabIndex = 7;
            this.torquevectoring.Text = "TV";
            this.torquevectoring.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 0);
            this.label9.TabIndex = 20;
            this.label9.Text = "Max T:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // settings_panel
            // 
            this.settings_panel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.settings_panel.Controls.Add(this.maxregen);
            this.settings_panel.Controls.Add(this.maxtorque);
            this.settings_panel.Controls.Add(this.maxpower);
            this.settings_panel.Controls.Add(this.maxregen_label);
            this.settings_panel.Controls.Add(this.maxtorque_power);
            this.settings_panel.Controls.Add(this.maxpower_label);
            this.settings_panel.Location = new System.Drawing.Point(719, 277);
            this.settings_panel.Name = "settings_panel";
            this.settings_panel.Size = new System.Drawing.Size(431, 233);
            this.settings_panel.TabIndex = 21;
            // 
            // maxregen
            // 
            this.maxregen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maxregen.BackColor = System.Drawing.Color.Cyan;
            this.maxregen.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maxregen.ForeColor = System.Drawing.Color.Black;
            this.maxregen.Location = new System.Drawing.Point(219, 157);
            this.maxregen.Name = "maxregen";
            this.maxregen.Size = new System.Drawing.Size(159, 48);
            this.maxregen.TabIndex = 7;
            this.maxregen.Text = "ND";
            this.maxregen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxtorque
            // 
            this.maxtorque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maxtorque.BackColor = System.Drawing.Color.Cyan;
            this.maxtorque.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maxtorque.ForeColor = System.Drawing.Color.Black;
            this.maxtorque.Location = new System.Drawing.Point(219, 83);
            this.maxtorque.Name = "maxtorque";
            this.maxtorque.Size = new System.Drawing.Size(159, 48);
            this.maxtorque.TabIndex = 7;
            this.maxtorque.Text = "ND";
            this.maxtorque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxpower
            // 
            this.maxpower.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maxpower.BackColor = System.Drawing.Color.Cyan;
            this.maxpower.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maxpower.ForeColor = System.Drawing.Color.Black;
            this.maxpower.Location = new System.Drawing.Point(219, 13);
            this.maxpower.Name = "maxpower";
            this.maxpower.Size = new System.Drawing.Size(159, 48);
            this.maxpower.TabIndex = 6;
            this.maxpower.Text = "ND";
            this.maxpower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxregen_label
            // 
            this.maxregen_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maxregen_label.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.maxregen_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maxregen_label.ForeColor = System.Drawing.Color.White;
            this.maxregen_label.Location = new System.Drawing.Point(51, 157);
            this.maxregen_label.Name = "maxregen_label";
            this.maxregen_label.Size = new System.Drawing.Size(156, 48);
            this.maxregen_label.TabIndex = 5;
            this.maxregen_label.Text = "Regen :";
            this.maxregen_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxtorque_power
            // 
            this.maxtorque_power.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maxtorque_power.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.maxtorque_power.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maxtorque_power.ForeColor = System.Drawing.Color.White;
            this.maxtorque_power.Location = new System.Drawing.Point(51, 83);
            this.maxtorque_power.Name = "maxtorque_power";
            this.maxtorque_power.Size = new System.Drawing.Size(156, 48);
            this.maxtorque_power.TabIndex = 4;
            this.maxtorque_power.Text = "Torque :";
            this.maxtorque_power.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxpower_label
            // 
            this.maxpower_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maxpower_label.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.maxpower_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maxpower_label.ForeColor = System.Drawing.Color.White;
            this.maxpower_label.Location = new System.Drawing.Point(51, 13);
            this.maxpower_label.Name = "maxpower_label";
            this.maxpower_label.Size = new System.Drawing.Size(156, 48);
            this.maxpower_label.TabIndex = 3;
            this.maxpower_label.Text = "Power :";
            this.maxpower_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startprocedure_panel
            // 
            this.startprocedure_panel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.startprocedure_panel.Controls.Add(this.contactorneg);
            this.startprocedure_panel.Controls.Add(this.precharghe);
            this.startprocedure_panel.Controls.Add(this.contactorpos);
            this.startprocedure_panel.Location = new System.Drawing.Point(50, 502);
            this.startprocedure_panel.Name = "startprocedure_panel";
            this.startprocedure_panel.Size = new System.Drawing.Size(634, 80);
            this.startprocedure_panel.TabIndex = 22;
            // 
            // contactorneg
            // 
            this.contactorneg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactorneg.BackColor = System.Drawing.Color.Gainsboro;
            this.contactorneg.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contactorneg.ForeColor = System.Drawing.Color.White;
            this.contactorneg.Location = new System.Drawing.Point(447, 17);
            this.contactorneg.Name = "contactorneg";
            this.contactorneg.Size = new System.Drawing.Size(74, 48);
            this.contactorneg.TabIndex = 10;
            this.contactorneg.Text = "-";
            this.contactorneg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // precharghe
            // 
            this.precharghe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.precharghe.BackColor = System.Drawing.Color.Gainsboro;
            this.precharghe.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.precharghe.ForeColor = System.Drawing.Color.White;
            this.precharghe.Location = new System.Drawing.Point(280, 17);
            this.precharghe.Name = "precharghe";
            this.precharghe.Size = new System.Drawing.Size(74, 48);
            this.precharghe.TabIndex = 9;
            this.precharghe.Text = "P";
            this.precharghe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contactorpos
            // 
            this.contactorpos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactorpos.BackColor = System.Drawing.Color.Gainsboro;
            this.contactorpos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contactorpos.ForeColor = System.Drawing.Color.White;
            this.contactorpos.Location = new System.Drawing.Point(106, 17);
            this.contactorpos.Name = "contactorpos";
            this.contactorpos.Size = new System.Drawing.Size(74, 48);
            this.contactorpos.TabIndex = 8;
            this.contactorpos.Text = "+";
            this.contactorpos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // suberb_panel
            // 
            this.suberb_panel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.suberb_panel.Controls.Add(this.superb);
            this.suberb_panel.Controls.Add(this.suberb_label);
            this.suberb_panel.Location = new System.Drawing.Point(719, 518);
            this.suberb_panel.Name = "suberb_panel";
            this.suberb_panel.Size = new System.Drawing.Size(431, 62);
            this.suberb_panel.TabIndex = 23;
            // 
            // superb
            // 
            this.superb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.superb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.superb.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.superb.ForeColor = System.Drawing.Color.Black;
            this.superb.Location = new System.Drawing.Point(243, 7);
            this.superb.Name = "superb";
            this.superb.Size = new System.Drawing.Size(149, 48);
            this.superb.TabIndex = 7;
            this.superb.Text = "ND";
            this.superb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // suberb_label
            // 
            this.suberb_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.suberb_label.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.suberb_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.suberb_label.ForeColor = System.Drawing.Color.White;
            this.suberb_label.Location = new System.Drawing.Point(70, 3);
            this.suberb_label.Name = "suberb_label";
            this.suberb_label.Size = new System.Drawing.Size(156, 48);
            this.suberb_label.TabIndex = 6;
            this.suberb_label.Text = "Super B:";
            this.suberb_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.suberb_panel);
            this.Controls.Add(this.startprocedure_panel);
            this.Controls.Add(this.settings_panel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.map_panel);
            this.Controls.Add(this.inforun_panel);
            this.Controls.Add(this.faultbar_panel);
            this.Controls.Add(this.temppanel);
            this.Controls.Add(this.cellpanel);
            this.Controls.Add(this.chargePanel);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remote Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.chargePanel.ResumeLayout(false);
            this.cellpanel.ResumeLayout(false);
            this.temppanel.ResumeLayout(false);
            this.faultbar_panel.ResumeLayout(false);
            this.inforun_panel.ResumeLayout(false);
            this.map_panel.ResumeLayout(false);
            this.settings_panel.ResumeLayout(false);
            this.startprocedure_panel.ResumeLayout(false);
            this.suberb_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel chargePanel;
        private System.Windows.Forms.Label charge;
        private System.Windows.Forms.ProgressBar chargebar;
        private System.Windows.Forms.Panel cellpanel;
        private System.Windows.Forms.Label vmaxcell_label;
        private System.Windows.Forms.Label tmeanncell_label;
        private System.Windows.Forms.Label vmincell_label;
        private System.Windows.Forms.Label tmaxcell_label;
        private System.Windows.Forms.Label vmaxcell;
        private System.Windows.Forms.Label vmincell;
        private System.Windows.Forms.Label tmaxcell;
        private System.Windows.Forms.Label tmeancell;
        private System.Windows.Forms.Panel temppanel;
        private System.Windows.Forms.Label inverterdxtemp;
        private System.Windows.Forms.Label motordxtemp;
        private System.Windows.Forms.Label invertersxtemp;
        private System.Windows.Forms.Label motorosxtemp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label motorsx_label;
        private System.Windows.Forms.Panel faultbar_panel;
        private System.Windows.Forms.Label fault;
        private System.Windows.Forms.Panel inforun_panel;
        private System.Windows.Forms.Label consume;
        private System.Windows.Forms.Label consume_label;
        private System.Windows.Forms.Label distance;
        private System.Windows.Forms.Label distance_label;
        private System.Windows.Forms.Label durata;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Panel map_panel;
        private System.Windows.Forms.Label map;
        private System.Windows.Forms.Label map_label;
        private System.Windows.Forms.Label regen;
        private System.Windows.Forms.Label traction;
        private System.Windows.Forms.Label torquevectoring;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel settings_panel;
        private System.Windows.Forms.Label maxregen;
        private System.Windows.Forms.Label maxtorque;
        private System.Windows.Forms.Label maxpower;
        private System.Windows.Forms.Label maxregen_label;
        private System.Windows.Forms.Label maxtorque_power;
        private System.Windows.Forms.Label maxpower_label;
        private System.Windows.Forms.Panel startprocedure_panel;
        private System.Windows.Forms.Label contactorneg;
        private System.Windows.Forms.Label precharghe;
        private System.Windows.Forms.Label contactorpos;
        private System.Windows.Forms.Panel suberb_panel;
        private System.Windows.Forms.Label superb;
        private System.Windows.Forms.Label suberb_label;
    }
}

