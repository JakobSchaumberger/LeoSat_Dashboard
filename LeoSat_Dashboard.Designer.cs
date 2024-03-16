
namespace LeoSat_Dashboard
{
    partial class LeoSat_Dashboard
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeoSat_Dashboard));
            this.menuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cb_PortSelect = new System.Windows.Forms.ComboBox();
            this.menuTransistion = new System.Windows.Forms.Timer(this.components);
            this.button_icons = new System.Windows.Forms.ImageList(this.components);
            this.icon_Micorcontroller = new System.Windows.Forms.ImageList(this.components);
            this.bt_Menu = new System.Windows.Forms.PictureBox();
            this.pb_Microcontroller = new System.Windows.Forms.PictureBox();
            this.bt_Connect = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bt_Overview = new System.Windows.Forms.Button();
            this.bt_LiveData = new System.Windows.Forms.Button();
            this.bt_Statistics = new System.Windows.Forms.Button();
            this.bt_GPS = new System.Windows.Forms.Button();
            this.menuContainer.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Microcontroller)).BeginInit();
            this.SuspendLayout();
            // 
            // menuContainer
            // 
            this.menuContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.menuContainer.Controls.Add(this.bt_Menu);
            this.menuContainer.Controls.Add(this.flowLayoutPanel1);
            this.menuContainer.Controls.Add(this.bt_Overview);
            this.menuContainer.Controls.Add(this.bt_LiveData);
            this.menuContainer.Controls.Add(this.bt_Statistics);
            this.menuContainer.Controls.Add(this.bt_GPS);
            this.menuContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuContainer.Location = new System.Drawing.Point(0, 0);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(250, 585);
            this.menuContainer.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pb_Microcontroller);
            this.flowLayoutPanel1.Controls.Add(this.cb_PortSelect);
            this.flowLayoutPanel1.Controls.Add(this.bt_Connect);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 51);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(286, 80);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // cb_PortSelect
            // 
            this.cb_PortSelect.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cb_PortSelect.FormattingEnabled = true;
            this.cb_PortSelect.Location = new System.Drawing.Point(70, 30);
            this.cb_PortSelect.Margin = new System.Windows.Forms.Padding(20, 30, 3, 3);
            this.cb_PortSelect.Name = "cb_PortSelect";
            this.cb_PortSelect.Size = new System.Drawing.Size(100, 28);
            this.cb_PortSelect.TabIndex = 0;
            // 
            // menuTransistion
            // 
            this.menuTransistion.Enabled = true;
            this.menuTransistion.Interval = 10;
            this.menuTransistion.Tick += new System.EventHandler(this.menuTransistion_Tick);
            // 
            // button_icons
            // 
            this.button_icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("button_icons.ImageStream")));
            this.button_icons.TransparentColor = System.Drawing.Color.Transparent;
            this.button_icons.Images.SetKeyName(0, "icon_statistics.drawio.png");
            this.button_icons.Images.SetKeyName(1, "icon_liveData.drawio.png");
            this.button_icons.Images.SetKeyName(2, "icon_overview.drawio.png");
            this.button_icons.Images.SetKeyName(3, "icon_gps.drawio.png");
            // 
            // icon_Micorcontroller
            // 
            this.icon_Micorcontroller.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.icon_Micorcontroller.ImageSize = new System.Drawing.Size(16, 16);
            this.icon_Micorcontroller.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // bt_Menu
            // 
            this.bt_Menu.Image = global::Anbindung_mit_Mikrocontroller.Properties.Resources.icon_menu1;
            this.bt_Menu.Location = new System.Drawing.Point(20, 15);
            this.bt_Menu.Margin = new System.Windows.Forms.Padding(20, 15, 3, 3);
            this.bt_Menu.Name = "bt_Menu";
            this.bt_Menu.Size = new System.Drawing.Size(30, 30);
            this.bt_Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_Menu.TabIndex = 4;
            this.bt_Menu.TabStop = false;
            this.bt_Menu.Click += new System.EventHandler(this.bt_Menu_Click);
            // 
            // pb_Microcontroller
            // 
            this.pb_Microcontroller.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pb_Microcontroller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.pb_Microcontroller.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pb_Microcontroller.Image = global::Anbindung_mit_Mikrocontroller.Properties.Resources.icon_microcontroller_disconnected_drawio;
            this.pb_Microcontroller.Location = new System.Drawing.Point(17, 26);
            this.pb_Microcontroller.Margin = new System.Windows.Forms.Padding(17, 25, 3, 3);
            this.pb_Microcontroller.Name = "pb_Microcontroller";
            this.pb_Microcontroller.Size = new System.Drawing.Size(30, 30);
            this.pb_Microcontroller.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Microcontroller.TabIndex = 7;
            this.pb_Microcontroller.TabStop = false;
            // 
            // bt_Connect
            // 
            this.bt_Connect.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bt_Connect.BackgroundImage = global::Anbindung_mit_Mikrocontroller.Properties.Resources.Icon_bt_connect;
            this.bt_Connect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Connect.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bt_Connect.Location = new System.Drawing.Point(183, 32);
            this.bt_Connect.Margin = new System.Windows.Forms.Padding(10, 27, 3, 3);
            this.bt_Connect.Name = "bt_Connect";
            this.bt_Connect.Size = new System.Drawing.Size(21, 21);
            this.bt_Connect.TabIndex = 7;
            this.bt_Connect.UseVisualStyleBackColor = true;
            this.bt_Connect.Click += new System.EventHandler(this.bt_Connect_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button3.BackgroundImage = global::Anbindung_mit_Mikrocontroller.Properties.Resources.icon_bt_disconnect;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button3.Location = new System.Drawing.Point(212, 32);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 27, 3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 21);
            this.button3.TabIndex = 8;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // bt_Overview
            // 
            this.bt_Overview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.bt_Overview.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bt_Overview.FlatAppearance.BorderSize = 0;
            this.bt_Overview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Overview.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.bt_Overview.ForeColor = System.Drawing.Color.White;
            this.bt_Overview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Overview.ImageIndex = 2;
            this.bt_Overview.ImageList = this.button_icons;
            this.bt_Overview.Location = new System.Drawing.Point(3, 164);
            this.bt_Overview.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.bt_Overview.Name = "bt_Overview";
            this.bt_Overview.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.bt_Overview.Size = new System.Drawing.Size(247, 80);
            this.bt_Overview.TabIndex = 9;
            this.bt_Overview.Text = "  Overview";
            this.bt_Overview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Overview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Overview.UseVisualStyleBackColor = false;
            // 
            // bt_LiveData
            // 
            this.bt_LiveData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.bt_LiveData.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bt_LiveData.FlatAppearance.BorderSize = 0;
            this.bt_LiveData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_LiveData.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.bt_LiveData.ForeColor = System.Drawing.Color.White;
            this.bt_LiveData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_LiveData.ImageIndex = 1;
            this.bt_LiveData.ImageList = this.button_icons;
            this.bt_LiveData.Location = new System.Drawing.Point(3, 257);
            this.bt_LiveData.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.bt_LiveData.Name = "bt_LiveData";
            this.bt_LiveData.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.bt_LiveData.Size = new System.Drawing.Size(247, 80);
            this.bt_LiveData.TabIndex = 13;
            this.bt_LiveData.Text = "  Live Data";
            this.bt_LiveData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_LiveData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_LiveData.UseVisualStyleBackColor = false;
            this.bt_LiveData.Click += new System.EventHandler(this.bt_LiveData_Click);
            // 
            // bt_Statistics
            // 
            this.bt_Statistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.bt_Statistics.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bt_Statistics.FlatAppearance.BorderSize = 0;
            this.bt_Statistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Statistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.bt_Statistics.ForeColor = System.Drawing.Color.White;
            this.bt_Statistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Statistics.ImageIndex = 0;
            this.bt_Statistics.ImageList = this.button_icons;
            this.bt_Statistics.Location = new System.Drawing.Point(3, 350);
            this.bt_Statistics.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.bt_Statistics.Name = "bt_Statistics";
            this.bt_Statistics.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.bt_Statistics.Size = new System.Drawing.Size(247, 80);
            this.bt_Statistics.TabIndex = 16;
            this.bt_Statistics.Text = "  Statistics";
            this.bt_Statistics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Statistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Statistics.UseVisualStyleBackColor = false;
            this.bt_Statistics.Click += new System.EventHandler(this.bt_Statistics_Click);
            // 
            // bt_GPS
            // 
            this.bt_GPS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.bt_GPS.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bt_GPS.FlatAppearance.BorderSize = 0;
            this.bt_GPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_GPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.bt_GPS.ForeColor = System.Drawing.Color.White;
            this.bt_GPS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_GPS.ImageIndex = 3;
            this.bt_GPS.ImageList = this.button_icons;
            this.bt_GPS.Location = new System.Drawing.Point(3, 443);
            this.bt_GPS.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.bt_GPS.Name = "bt_GPS";
            this.bt_GPS.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.bt_GPS.Size = new System.Drawing.Size(247, 80);
            this.bt_GPS.TabIndex = 15;
            this.bt_GPS.Text = "  GPS";
            this.bt_GPS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_GPS.UseVisualStyleBackColor = false;
            this.bt_GPS.Click += new System.EventHandler(this.bt_GPS_Click);
            // 
            // LeoSat_Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1115, 585);
            this.Controls.Add(this.menuContainer);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LeoSat_Dashboard";
            this.Text = "LeoSat | Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuContainer.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bt_Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Microcontroller)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel menuContainer;
        private System.Windows.Forms.Button bt_Overview;
        private System.Windows.Forms.Button bt_LiveData;
        private System.Windows.Forms.Timer menuTransistion;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bt_Connect;
        private System.Windows.Forms.PictureBox pb_Microcontroller;
        private System.Windows.Forms.ComboBox cb_PortSelect;
        private System.Windows.Forms.PictureBox bt_Menu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bt_GPS;
        private System.Windows.Forms.Button bt_Statistics;
        private System.Windows.Forms.ImageList button_icons;
        private System.Windows.Forms.ImageList icon_Micorcontroller;
    }
}

