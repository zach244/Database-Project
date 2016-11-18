namespace Database_Project

{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Actor = new System.Windows.Forms.TabPage();
            this.ComboBoxCustom = new System.Windows.Forms.ComboBox();
            this.CustomLblShowall = new System.Windows.Forms.Label();
            this.SubmitCustom = new System.Windows.Forms.Button();
            this.CustomDataGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomTxt = new System.Windows.Forms.TextBox();
            this.Planet = new System.Windows.Forms.TabPage();
            this.PlanetDataGrid = new System.Windows.Forms.DataGridView();
            this.PlanetNameTxt = new System.Windows.Forms.TextBox();
            this.ClimateTxt = new System.Windows.Forms.TextBox();
            this.PlanetIdTxt = new System.Windows.Forms.TextBox();
            this.PlanetNameLbl = new System.Windows.Forms.Label();
            this.ClimateLbl = new System.Windows.Forms.Label();
            this.SubmitPlanet = new System.Windows.Forms.Button();
            this.PlanetIDLbl = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LoginButton = new System.Windows.Forms.Button();
            this.DatabaseNameTxt = new System.Windows.Forms.TextBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.ServerNameTxt = new System.Windows.Forms.TextBox();
            this.LoginDatabaseNameLbl = new System.Windows.Forms.Label();
            this.ServerName = new System.Windows.Forms.Label();
            this.LoginPasswordLbl = new System.Windows.Forms.Label();
            this.LoginUsernameLbl = new System.Windows.Forms.Label();
            this.Tab = new System.Windows.Forms.TabControl();
            this.Actor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomDataGrid)).BeginInit();
            this.Planet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlanetDataGrid)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.Tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // Actor
            // 
            this.Actor.Controls.Add(this.ComboBoxCustom);
            this.Actor.Controls.Add(this.CustomLblShowall);
            this.Actor.Controls.Add(this.SubmitCustom);
            this.Actor.Controls.Add(this.CustomDataGrid);
            this.Actor.Controls.Add(this.label2);
            this.Actor.Controls.Add(this.CustomTxt);
            this.Actor.Location = new System.Drawing.Point(4, 22);
            this.Actor.Name = "Actor";
            this.Actor.Padding = new System.Windows.Forms.Padding(3);
            this.Actor.Size = new System.Drawing.Size(957, 596);
            this.Actor.TabIndex = 0;
            this.Actor.Text = "Custom";
            this.Actor.UseVisualStyleBackColor = true;
            // 
            // ComboBoxCustom
            // 
            this.ComboBoxCustom.FormattingEnabled = true;
            this.ComboBoxCustom.Items.AddRange(new object[] {
            "Movies",
            "Characters",
            "Actors",
            "Acted In",
            "Directed",
            "Droids",
            "Manufacturers",
            "Directors",
            "Pilots",
            "Planets",
            "Ships",
            "Species",
            "Vehicles",
            "Weapons"});
            this.ComboBoxCustom.Location = new System.Drawing.Point(0, 136);
            this.ComboBoxCustom.Name = "ComboBoxCustom";
            this.ComboBoxCustom.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxCustom.TabIndex = 21;
            this.ComboBoxCustom.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CustomLblShowall
            // 
            this.CustomLblShowall.AutoSize = true;
            this.CustomLblShowall.Location = new System.Drawing.Point(-1, 120);
            this.CustomLblShowall.Name = "CustomLblShowall";
            this.CustomLblShowall.Size = new System.Drawing.Size(86, 13);
            this.CustomLblShowall.TabIndex = 19;
            this.CustomLblShowall.Text = "Show All Results";
            // 
            // SubmitCustom
            // 
            this.SubmitCustom.Location = new System.Drawing.Point(46, 45);
            this.SubmitCustom.Name = "SubmitCustom";
            this.SubmitCustom.Size = new System.Drawing.Size(75, 23);
            this.SubmitCustom.TabIndex = 4;
            this.SubmitCustom.Text = "Submit";
            this.SubmitCustom.UseVisualStyleBackColor = true;
            this.SubmitCustom.Click += new System.EventHandler(this.SubmitCustom_Click);
            // 
            // CustomDataGrid
            // 
            this.CustomDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomDataGrid.Location = new System.Drawing.Point(191, 0);
            this.CustomDataGrid.Name = "CustomDataGrid";
            this.CustomDataGrid.Size = new System.Drawing.Size(766, 600);
            this.CustomDataGrid.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please Enter a Custom SQL Command";
            // 
            // CustomTxt
            // 
            this.CustomTxt.Location = new System.Drawing.Point(0, 19);
            this.CustomTxt.Name = "CustomTxt";
            this.CustomTxt.Size = new System.Drawing.Size(176, 20);
            this.CustomTxt.TabIndex = 1;
            // 
            // Planet
            // 
            this.Planet.Controls.Add(this.PlanetDataGrid);
            this.Planet.Controls.Add(this.PlanetNameTxt);
            this.Planet.Controls.Add(this.ClimateTxt);
            this.Planet.Controls.Add(this.PlanetIdTxt);
            this.Planet.Controls.Add(this.PlanetNameLbl);
            this.Planet.Controls.Add(this.ClimateLbl);
            this.Planet.Controls.Add(this.SubmitPlanet);
            this.Planet.Controls.Add(this.PlanetIDLbl);
            this.Planet.Location = new System.Drawing.Point(4, 22);
            this.Planet.Name = "Planet";
            this.Planet.Size = new System.Drawing.Size(957, 596);
            this.Planet.TabIndex = 2;
            this.Planet.Text = "Planet";
            this.Planet.UseVisualStyleBackColor = true;
            // 
            // PlanetDataGrid
            // 
            this.PlanetDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlanetDataGrid.Location = new System.Drawing.Point(176, 3);
            this.PlanetDataGrid.Name = "PlanetDataGrid";
            this.PlanetDataGrid.Size = new System.Drawing.Size(781, 597);
            this.PlanetDataGrid.TabIndex = 9;
            // 
            // PlanetNameTxt
            // 
            this.PlanetNameTxt.AutoCompleteCustomSource.AddRange(new string[] {
            "tatooine"});
            this.PlanetNameTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.PlanetNameTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.PlanetNameTxt.Location = new System.Drawing.Point(0, 139);
            this.PlanetNameTxt.Name = "PlanetNameTxt";
            this.PlanetNameTxt.Size = new System.Drawing.Size(170, 20);
            this.PlanetNameTxt.TabIndex = 8;
            this.PlanetNameTxt.TextChanged += new System.EventHandler(this.PlanetNameTxt_TextChanged);
            // 
            // ClimateTxt
            // 
            this.ClimateTxt.Location = new System.Drawing.Point(0, 83);
            this.ClimateTxt.Name = "ClimateTxt";
            this.ClimateTxt.Size = new System.Drawing.Size(170, 20);
            this.ClimateTxt.TabIndex = 6;
            // 
            // PlanetIdTxt
            // 
            this.PlanetIdTxt.Location = new System.Drawing.Point(0, 27);
            this.PlanetIdTxt.Name = "PlanetIdTxt";
            this.PlanetIdTxt.Size = new System.Drawing.Size(170, 20);
            this.PlanetIdTxt.TabIndex = 1;
            // 
            // PlanetNameLbl
            // 
            this.PlanetNameLbl.AutoSize = true;
            this.PlanetNameLbl.Location = new System.Drawing.Point(0, 122);
            this.PlanetNameLbl.Name = "PlanetNameLbl";
            this.PlanetNameLbl.Size = new System.Drawing.Size(138, 13);
            this.PlanetNameLbl.TabIndex = 7;
            this.PlanetNameLbl.Text = "Please Enter Planet\'s Name";
            // 
            // ClimateLbl
            // 
            this.ClimateLbl.AutoSize = true;
            this.ClimateLbl.Location = new System.Drawing.Point(0, 67);
            this.ClimateLbl.Name = "ClimateLbl";
            this.ClimateLbl.Size = new System.Drawing.Size(162, 13);
            this.ClimateLbl.TabIndex = 5;
            this.ClimateLbl.Text = "Please Enter the Planet\'s Climate";
            // 
            // SubmitPlanet
            // 
            this.SubmitPlanet.Location = new System.Drawing.Point(63, 540);
            this.SubmitPlanet.Name = "SubmitPlanet";
            this.SubmitPlanet.Size = new System.Drawing.Size(75, 23);
            this.SubmitPlanet.TabIndex = 3;
            this.SubmitPlanet.Text = "Submit";
            this.SubmitPlanet.UseVisualStyleBackColor = true;
            this.SubmitPlanet.Click += new System.EventHandler(this.SubmitPlanet_Click);
            // 
            // PlanetIDLbl
            // 
            this.PlanetIDLbl.AutoSize = true;
            this.PlanetIDLbl.Location = new System.Drawing.Point(-3, 11);
            this.PlanetIDLbl.Name = "PlanetIDLbl";
            this.PlanetIDLbl.Size = new System.Drawing.Size(109, 13);
            this.PlanetIDLbl.TabIndex = 2;
            this.PlanetIDLbl.Text = "Please Enter PlanetId";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LoginButton);
            this.tabPage1.Controls.Add(this.DatabaseNameTxt);
            this.tabPage1.Controls.Add(this.PasswordTxt);
            this.tabPage1.Controls.Add(this.UsernameTxt);
            this.tabPage1.Controls.Add(this.ServerNameTxt);
            this.tabPage1.Controls.Add(this.LoginDatabaseNameLbl);
            this.tabPage1.Controls.Add(this.ServerName);
            this.tabPage1.Controls.Add(this.LoginPasswordLbl);
            this.tabPage1.Controls.Add(this.LoginUsernameLbl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(957, 596);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Login";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(391, 322);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(100, 23);
            this.LoginButton.TabIndex = 8;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // DatabaseNameTxt
            // 
            this.DatabaseNameTxt.Location = new System.Drawing.Point(391, 278);
            this.DatabaseNameTxt.Name = "DatabaseNameTxt";
            this.DatabaseNameTxt.Size = new System.Drawing.Size(100, 20);
            this.DatabaseNameTxt.TabIndex = 7;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(391, 223);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '*';
            this.PasswordTxt.Size = new System.Drawing.Size(100, 20);
            this.PasswordTxt.TabIndex = 6;
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Location = new System.Drawing.Point(391, 170);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(100, 20);
            this.UsernameTxt.TabIndex = 5;
            // 
            // ServerNameTxt
            // 
            this.ServerNameTxt.Location = new System.Drawing.Point(391, 112);
            this.ServerNameTxt.Name = "ServerNameTxt";
            this.ServerNameTxt.Size = new System.Drawing.Size(100, 20);
            this.ServerNameTxt.TabIndex = 4;
            // 
            // LoginDatabaseNameLbl
            // 
            this.LoginDatabaseNameLbl.AutoSize = true;
            this.LoginDatabaseNameLbl.Location = new System.Drawing.Point(388, 262);
            this.LoginDatabaseNameLbl.Name = "LoginDatabaseNameLbl";
            this.LoginDatabaseNameLbl.Size = new System.Drawing.Size(96, 13);
            this.LoginDatabaseNameLbl.TabIndex = 3;
            this.LoginDatabaseNameLbl.Text = "Name of Database";
            // 
            // ServerName
            // 
            this.ServerName.AutoSize = true;
            this.ServerName.Location = new System.Drawing.Point(388, 95);
            this.ServerName.Name = "ServerName";
            this.ServerName.Size = new System.Drawing.Size(69, 13);
            this.ServerName.TabIndex = 2;
            this.ServerName.Text = "Server Name";
            // 
            // LoginPasswordLbl
            // 
            this.LoginPasswordLbl.AutoSize = true;
            this.LoginPasswordLbl.Location = new System.Drawing.Point(388, 207);
            this.LoginPasswordLbl.Name = "LoginPasswordLbl";
            this.LoginPasswordLbl.Size = new System.Drawing.Size(53, 13);
            this.LoginPasswordLbl.TabIndex = 1;
            this.LoginPasswordLbl.Text = "Password";
            // 
            // LoginUsernameLbl
            // 
            this.LoginUsernameLbl.AutoSize = true;
            this.LoginUsernameLbl.Location = new System.Drawing.Point(388, 153);
            this.LoginUsernameLbl.Name = "LoginUsernameLbl";
            this.LoginUsernameLbl.Size = new System.Drawing.Size(55, 13);
            this.LoginUsernameLbl.TabIndex = 0;
            this.LoginUsernameLbl.Text = "Username";
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.tabPage1);
            this.Tab.Controls.Add(this.Planet);
            this.Tab.Controls.Add(this.Actor);
            this.Tab.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Tab.Location = new System.Drawing.Point(3, 1);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(965, 622);
            this.Tab.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 621);
            this.Controls.Add(this.Tab);
            this.Name = "Form1";
            this.Text = "BanthaFodder Gui";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Actor.ResumeLayout(false);
            this.Actor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomDataGrid)).EndInit();
            this.Planet.ResumeLayout(false);
            this.Planet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlanetDataGrid)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.Tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Actor;
        private System.Windows.Forms.ComboBox ComboBoxCustom;
        private System.Windows.Forms.Label CustomLblShowall;
        private System.Windows.Forms.Button SubmitCustom;
        private System.Windows.Forms.DataGridView CustomDataGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CustomTxt;
        private System.Windows.Forms.TabPage Planet;
        private System.Windows.Forms.DataGridView PlanetDataGrid;
        private System.Windows.Forms.TextBox PlanetNameTxt;
        private System.Windows.Forms.TextBox ClimateTxt;
        private System.Windows.Forms.TextBox PlanetIdTxt;
        private System.Windows.Forms.Label PlanetNameLbl;
        private System.Windows.Forms.Label ClimateLbl;
        private System.Windows.Forms.Button SubmitPlanet;
        private System.Windows.Forms.Label PlanetIDLbl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox DatabaseNameTxt;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.TextBox ServerNameTxt;
        private System.Windows.Forms.Label LoginDatabaseNameLbl;
        private System.Windows.Forms.Label ServerName;
        private System.Windows.Forms.Label LoginPasswordLbl;
        private System.Windows.Forms.Label LoginUsernameLbl;
        private System.Windows.Forms.TabControl Tab;
    }
}

