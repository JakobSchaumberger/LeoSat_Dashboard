
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
            this.menuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_Menu = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cb_PortSelect = new System.Windows.Forms.ComboBox();
            this.bt_Connect = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_LiveData = new System.Windows.Forms.Button();
            this.bt_Statistics = new System.Windows.Forms.Button();
            this.bt_GPS = new System.Windows.Forms.Button();
            this.menuTransistion = new System.Windows.Forms.Timer(this.components);
            this.menuContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Menu)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuContainer
            // 
            this.menuContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.menuContainer.Controls.Add(this.bt_Menu);
            this.menuContainer.Controls.Add(this.flowLayoutPanel1);
            this.menuContainer.Controls.Add(this.button1);
            this.menuContainer.Controls.Add(this.bt_LiveData);
            this.menuContainer.Controls.Add(this.bt_Statistics);
            this.menuContainer.Controls.Add(this.bt_GPS);
            this.menuContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuContainer.Location = new System.Drawing.Point(0, 0);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(250, 585);
            this.menuContainer.TabIndex = 6;
            this.menuContainer.UseWaitCursor = true;
            // 
            // bt_Menu
            // 
            this.bt_Menu.Image = global::Anbindung_mit_Mikrocontroller.Properties.Resources.kisspng_hamburger_button_computer_icons_menu_5afa4b5d99b094_9007658615263527336295;
            this.bt_Menu.Location = new System.Drawing.Point(15, 15);
            this.bt_Menu.Margin = new System.Windows.Forms.Padding(15, 15, 3, 3);
            this.bt_Menu.Name = "bt_Menu";
            this.bt_Menu.Size = new System.Drawing.Size(30, 30);
            this.bt_Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_Menu.TabIndex = 4;
            this.bt_Menu.TabStop = false;
            this.bt_Menu.UseWaitCursor = true;
            this.bt_Menu.Click += new System.EventHandler(this.bt_Menu_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBox2);
            this.flowLayoutPanel1.Controls.Add(this.cb_PortSelect);
            this.flowLayoutPanel1.Controls.Add(this.bt_Connect);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 51);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(286, 80);
            this.flowLayoutPanel1.TabIndex = 14;
            this.flowLayoutPanel1.UseWaitCursor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.pictureBox2.Location = new System.Drawing.Point(15, 25);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(15, 25, 3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.UseWaitCursor = true;
            // 
            // cb_PortSelect
            // 
            this.cb_PortSelect.FormattingEnabled = true;
            this.cb_PortSelect.Location = new System.Drawing.Point(53, 30);
            this.cb_PortSelect.Margin = new System.Windows.Forms.Padding(5, 30, 3, 3);
            this.cb_PortSelect.Name = "cb_PortSelect";
            this.cb_PortSelect.Size = new System.Drawing.Size(120, 21);
            this.cb_PortSelect.TabIndex = 0;
            this.cb_PortSelect.UseWaitCursor = true;
            // 
            // bt_Connect
            // 
            this.bt_Connect.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bt_Connect.Location = new System.Drawing.Point(181, 30);
            this.bt_Connect.Margin = new System.Windows.Forms.Padding(5, 30, 3, 3);
            this.bt_Connect.Name = "bt_Connect";
            this.bt_Connect.Size = new System.Drawing.Size(25, 25);
            this.bt_Connect.TabIndex = 7;
            this.bt_Connect.Text = "button2";
            this.bt_Connect.UseVisualStyleBackColor = true;
            this.bt_Connect.UseWaitCursor = true;
            this.bt_Connect.Click += new System.EventHandler(this.bt_Connect_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button3.Location = new System.Drawing.Point(214, 28);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 22, 3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 21);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 164);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(247, 60);
            this.button1.TabIndex = 9;
            this.button1.Text = "Overview";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.UseWaitCursor = true;
            // 
            // bt_LiveData
            // 
            this.bt_LiveData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.bt_LiveData.FlatAppearance.BorderSize = 0;
            this.bt_LiveData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_LiveData.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_LiveData.ForeColor = System.Drawing.Color.White;
            this.bt_LiveData.Location = new System.Drawing.Point(3, 237);
            this.bt_LiveData.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.bt_LiveData.Name = "bt_LiveData";
            this.bt_LiveData.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.bt_LiveData.Size = new System.Drawing.Size(247, 60);
            this.bt_LiveData.TabIndex = 13;
            this.bt_LiveData.Text = "Live Data";
            this.bt_LiveData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_LiveData.UseVisualStyleBackColor = false;
            this.bt_LiveData.UseWaitCursor = true;
            this.bt_LiveData.Click += new System.EventHandler(this.bt_LiveData_Click);
            // 
            // bt_Statistics
            // 
            this.bt_Statistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.bt_Statistics.FlatAppearance.BorderSize = 0;
            this.bt_Statistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Statistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Statistics.ForeColor = System.Drawing.Color.White;
            this.bt_Statistics.Location = new System.Drawing.Point(3, 310);
            this.bt_Statistics.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.bt_Statistics.Name = "bt_Statistics";
            this.bt_Statistics.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.bt_Statistics.Size = new System.Drawing.Size(247, 60);
            this.bt_Statistics.TabIndex = 16;
            this.bt_Statistics.Text = "Statistics";
            this.bt_Statistics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Statistics.UseVisualStyleBackColor = false;
            this.bt_Statistics.UseWaitCursor = true;
            this.bt_Statistics.Click += new System.EventHandler(this.bt_Statistics_Click);
            // 
            // bt_GPS
            // 
            this.bt_GPS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.bt_GPS.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.bt_GPS.FlatAppearance.BorderSize = 0;
            this.bt_GPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_GPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_GPS.ForeColor = System.Drawing.Color.White;
            this.bt_GPS.Location = new System.Drawing.Point(3, 383);
            this.bt_GPS.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.bt_GPS.Name = "bt_GPS";
            this.bt_GPS.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.bt_GPS.Size = new System.Drawing.Size(247, 60);
            this.bt_GPS.TabIndex = 15;
            this.bt_GPS.Text = "GPS";
            this.bt_GPS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_GPS.UseVisualStyleBackColor = false;
            this.bt_GPS.UseWaitCursor = true;
            this.bt_GPS.Click += new System.EventHandler(this.bt_GPS_Click);
            // 
            // menuTransistion
            // 
            this.menuTransistion.Enabled = true;
            this.menuTransistion.Interval = 10;
            this.menuTransistion.Tick += new System.EventHandler(this.menuTransistion_Tick);
            // 
            // LeoSat_Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1115, 585);
            this.Controls.Add(this.menuContainer);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LeoSat_Dashboard";
            this.Text = "LeoSat | Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bt_Menu)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel menuContainer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_LiveData;
        private System.Windows.Forms.Timer menuTransistion;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bt_Connect;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cb_PortSelect;
        private System.Windows.Forms.PictureBox bt_Menu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bt_GPS;
        private System.Windows.Forms.Button bt_Statistics;
    }
}

