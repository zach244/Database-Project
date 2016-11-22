namespace Database_Project

{
    partial class BanthaFodderGui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BanthaFodderGui));
            this.Custom = new System.Windows.Forms.TabPage();
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
            this.Login = new System.Windows.Forms.TabPage();
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
            this.Movie = new System.Windows.Forms.TabPage();
            this.ActorsMovieDropLbl = new System.Windows.Forms.Label();
            this.MovieComboBox1 = new System.Windows.Forms.ComboBox();
            this.MovieDirectedBy = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.charInMovie = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.MoviesDataGrid = new System.Windows.Forms.DataGridView();
            this.Actor = new System.Windows.Forms.TabPage();
            this.ActorDataGrid = new System.Windows.Forms.DataGridView();
            this.ActorLabalFName = new System.Windows.Forms.Label();
            this.ActorTextBoxFname = new System.Windows.Forms.TextBox();
            this.ActorTxtLName = new System.Windows.Forms.Label();
            this.ActorsLNametxt = new System.Windows.Forms.TextBox();
            this.ChNameLbl = new System.Windows.Forms.Label();
            this.chNameTxt = new System.Windows.Forms.TextBox();
            this.ActorSubmitBtn = new System.Windows.Forms.Button();
            this.Custom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomDataGrid)).BeginInit();
            this.Planet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlanetDataGrid)).BeginInit();
            this.Login.SuspendLayout();
            this.Tab.SuspendLayout();
            this.Movie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviesDataGrid)).BeginInit();
            this.Actor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActorDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Custom
            // 
            this.Custom.Controls.Add(this.ComboBoxCustom);
            this.Custom.Controls.Add(this.CustomLblShowall);
            this.Custom.Controls.Add(this.SubmitCustom);
            this.Custom.Controls.Add(this.CustomDataGrid);
            this.Custom.Controls.Add(this.label2);
            this.Custom.Controls.Add(this.CustomTxt);
            this.Custom.Location = new System.Drawing.Point(4, 25);
            this.Custom.Margin = new System.Windows.Forms.Padding(4);
            this.Custom.Name = "Custom";
            this.Custom.Padding = new System.Windows.Forms.Padding(4);
            this.Custom.Size = new System.Drawing.Size(1279, 737);
            this.Custom.TabIndex = 0;
            this.Custom.Text = "Custom";
            this.Custom.UseVisualStyleBackColor = true;
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
            this.ComboBoxCustom.Location = new System.Drawing.Point(0, 167);
            this.ComboBoxCustom.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxCustom.Name = "ComboBoxCustom";
            this.ComboBoxCustom.Size = new System.Drawing.Size(160, 24);
            this.ComboBoxCustom.TabIndex = 21;
            this.ComboBoxCustom.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CustomLblShowall
            // 
            this.CustomLblShowall.AutoSize = true;
            this.CustomLblShowall.Location = new System.Drawing.Point(-1, 148);
            this.CustomLblShowall.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomLblShowall.Name = "CustomLblShowall";
            this.CustomLblShowall.Size = new System.Drawing.Size(112, 17);
            this.CustomLblShowall.TabIndex = 19;
            this.CustomLblShowall.Text = "Show All Results";
            // 
            // SubmitCustom
            // 
            this.SubmitCustom.Location = new System.Drawing.Point(61, 55);
            this.SubmitCustom.Margin = new System.Windows.Forms.Padding(4);
            this.SubmitCustom.Name = "SubmitCustom";
            this.SubmitCustom.Size = new System.Drawing.Size(100, 28);
            this.SubmitCustom.TabIndex = 4;
            this.SubmitCustom.Text = "Submit";
            this.SubmitCustom.UseVisualStyleBackColor = true;
            this.SubmitCustom.Click += new System.EventHandler(this.SubmitCustom_Click);
            // 
            // CustomDataGrid
            // 
            this.CustomDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomDataGrid.Location = new System.Drawing.Point(255, 0);
            this.CustomDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.CustomDataGrid.Name = "CustomDataGrid";
            this.CustomDataGrid.Size = new System.Drawing.Size(1021, 738);
            this.CustomDataGrid.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-4, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please Enter a Custom SQL Command";
            // 
            // CustomTxt
            // 
            this.CustomTxt.Location = new System.Drawing.Point(0, 23);
            this.CustomTxt.Margin = new System.Windows.Forms.Padding(4);
            this.CustomTxt.Name = "CustomTxt";
            this.CustomTxt.Size = new System.Drawing.Size(233, 22);
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
            this.Planet.Location = new System.Drawing.Point(4, 25);
            this.Planet.Margin = new System.Windows.Forms.Padding(4);
            this.Planet.Name = "Planet";
            this.Planet.Size = new System.Drawing.Size(1279, 737);
            this.Planet.TabIndex = 2;
            this.Planet.Text = "Planet";
            this.Planet.UseVisualStyleBackColor = true;
            // 
            // PlanetDataGrid
            // 
            this.PlanetDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlanetDataGrid.Location = new System.Drawing.Point(235, 4);
            this.PlanetDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.PlanetDataGrid.Name = "PlanetDataGrid";
            this.PlanetDataGrid.Size = new System.Drawing.Size(1041, 735);
            this.PlanetDataGrid.TabIndex = 9;
            // 
            // PlanetNameTxt
            // 
            this.PlanetNameTxt.AutoCompleteCustomSource.AddRange(new string[] {
            "tatooine"});
            this.PlanetNameTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.PlanetNameTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.PlanetNameTxt.Location = new System.Drawing.Point(0, 171);
            this.PlanetNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.PlanetNameTxt.Name = "PlanetNameTxt";
            this.PlanetNameTxt.Size = new System.Drawing.Size(225, 22);
            this.PlanetNameTxt.TabIndex = 8;
            this.PlanetNameTxt.TextChanged += new System.EventHandler(this.PlanetNameTxt_TextChanged);
            // 
            // ClimateTxt
            // 
            this.ClimateTxt.Location = new System.Drawing.Point(0, 102);
            this.ClimateTxt.Margin = new System.Windows.Forms.Padding(4);
            this.ClimateTxt.Name = "ClimateTxt";
            this.ClimateTxt.Size = new System.Drawing.Size(225, 22);
            this.ClimateTxt.TabIndex = 6;
            // 
            // PlanetIdTxt
            // 
            this.PlanetIdTxt.Location = new System.Drawing.Point(0, 33);
            this.PlanetIdTxt.Margin = new System.Windows.Forms.Padding(4);
            this.PlanetIdTxt.Name = "PlanetIdTxt";
            this.PlanetIdTxt.Size = new System.Drawing.Size(225, 22);
            this.PlanetIdTxt.TabIndex = 1;
            // 
            // PlanetNameLbl
            // 
            this.PlanetNameLbl.AutoSize = true;
            this.PlanetNameLbl.Location = new System.Drawing.Point(0, 150);
            this.PlanetNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlanetNameLbl.Name = "PlanetNameLbl";
            this.PlanetNameLbl.Size = new System.Drawing.Size(184, 17);
            this.PlanetNameLbl.TabIndex = 7;
            this.PlanetNameLbl.Text = "Please Enter Planet\'s Name";
            // 
            // ClimateLbl
            // 
            this.ClimateLbl.AutoSize = true;
            this.ClimateLbl.Location = new System.Drawing.Point(0, 82);
            this.ClimateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClimateLbl.Name = "ClimateLbl";
            this.ClimateLbl.Size = new System.Drawing.Size(217, 17);
            this.ClimateLbl.TabIndex = 5;
            this.ClimateLbl.Text = "Please Enter the Planet\'s Climate";
            // 
            // SubmitPlanet
            // 
            this.SubmitPlanet.Location = new System.Drawing.Point(55, 667);
            this.SubmitPlanet.Margin = new System.Windows.Forms.Padding(4);
            this.SubmitPlanet.Name = "SubmitPlanet";
            this.SubmitPlanet.Size = new System.Drawing.Size(100, 28);
            this.SubmitPlanet.TabIndex = 3;
            this.SubmitPlanet.Text = "Submit";
            this.SubmitPlanet.UseVisualStyleBackColor = true;
            this.SubmitPlanet.Click += new System.EventHandler(this.SubmitPlanet_Click);
            // 
            // PlanetIDLbl
            // 
            this.PlanetIDLbl.AutoSize = true;
            this.PlanetIDLbl.Location = new System.Drawing.Point(-4, 14);
            this.PlanetIDLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlanetIDLbl.Name = "PlanetIDLbl";
            this.PlanetIDLbl.Size = new System.Drawing.Size(144, 17);
            this.PlanetIDLbl.TabIndex = 2;
            this.PlanetIDLbl.Text = "Please Enter PlanetId";
            // 
            // Login
            // 
            this.Login.Controls.Add(this.LoginButton);
            this.Login.Controls.Add(this.DatabaseNameTxt);
            this.Login.Controls.Add(this.PasswordTxt);
            this.Login.Controls.Add(this.UsernameTxt);
            this.Login.Controls.Add(this.ServerNameTxt);
            this.Login.Controls.Add(this.LoginDatabaseNameLbl);
            this.Login.Controls.Add(this.ServerName);
            this.Login.Controls.Add(this.LoginPasswordLbl);
            this.Login.Controls.Add(this.LoginUsernameLbl);
            this.Login.Location = new System.Drawing.Point(4, 25);
            this.Login.Margin = new System.Windows.Forms.Padding(4);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(1279, 737);
            this.Login.TabIndex = 3;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(521, 396);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(133, 28);
            this.LoginButton.TabIndex = 8;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // DatabaseNameTxt
            // 
            this.DatabaseNameTxt.Location = new System.Drawing.Point(521, 342);
            this.DatabaseNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.DatabaseNameTxt.Name = "DatabaseNameTxt";
            this.DatabaseNameTxt.Size = new System.Drawing.Size(132, 22);
            this.DatabaseNameTxt.TabIndex = 7;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(521, 274);
            this.PasswordTxt.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '*';
            this.PasswordTxt.Size = new System.Drawing.Size(132, 22);
            this.PasswordTxt.TabIndex = 6;
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Location = new System.Drawing.Point(521, 209);
            this.UsernameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(132, 22);
            this.UsernameTxt.TabIndex = 5;
            // 
            // ServerNameTxt
            // 
            this.ServerNameTxt.Location = new System.Drawing.Point(521, 138);
            this.ServerNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.ServerNameTxt.Name = "ServerNameTxt";
            this.ServerNameTxt.Size = new System.Drawing.Size(132, 22);
            this.ServerNameTxt.TabIndex = 4;
            // 
            // LoginDatabaseNameLbl
            // 
            this.LoginDatabaseNameLbl.AutoSize = true;
            this.LoginDatabaseNameLbl.Location = new System.Drawing.Point(517, 322);
            this.LoginDatabaseNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginDatabaseNameLbl.Name = "LoginDatabaseNameLbl";
            this.LoginDatabaseNameLbl.Size = new System.Drawing.Size(126, 17);
            this.LoginDatabaseNameLbl.TabIndex = 3;
            this.LoginDatabaseNameLbl.Text = "Name of Database";
            // 
            // ServerName
            // 
            this.ServerName.AutoSize = true;
            this.ServerName.Location = new System.Drawing.Point(517, 117);
            this.ServerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServerName.Name = "ServerName";
            this.ServerName.Size = new System.Drawing.Size(91, 17);
            this.ServerName.TabIndex = 2;
            this.ServerName.Text = "Server Name";
            // 
            // LoginPasswordLbl
            // 
            this.LoginPasswordLbl.AutoSize = true;
            this.LoginPasswordLbl.Location = new System.Drawing.Point(517, 255);
            this.LoginPasswordLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginPasswordLbl.Name = "LoginPasswordLbl";
            this.LoginPasswordLbl.Size = new System.Drawing.Size(69, 17);
            this.LoginPasswordLbl.TabIndex = 1;
            this.LoginPasswordLbl.Text = "Password";
            // 
            // LoginUsernameLbl
            // 
            this.LoginUsernameLbl.AutoSize = true;
            this.LoginUsernameLbl.Location = new System.Drawing.Point(517, 188);
            this.LoginUsernameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginUsernameLbl.Name = "LoginUsernameLbl";
            this.LoginUsernameLbl.Size = new System.Drawing.Size(73, 17);
            this.LoginUsernameLbl.TabIndex = 0;
            this.LoginUsernameLbl.Text = "Username";
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.Login);
            this.Tab.Controls.Add(this.Actor);
            this.Tab.Controls.Add(this.Movie);
            this.Tab.Controls.Add(this.Planet);
            this.Tab.Controls.Add(this.Custom);
            this.Tab.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Tab.Location = new System.Drawing.Point(4, 1);
            this.Tab.Margin = new System.Windows.Forms.Padding(4);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(1287, 766);
            this.Tab.TabIndex = 0;
            // 
            // Movie
            // 
            this.Movie.Controls.Add(this.MoviesDataGrid);
            this.Movie.Controls.Add(this.comboBox2);
            this.Movie.Controls.Add(this.charInMovie);
            this.Movie.Controls.Add(this.comboBox1);
            this.Movie.Controls.Add(this.MovieDirectedBy);
            this.Movie.Controls.Add(this.MovieComboBox1);
            this.Movie.Controls.Add(this.ActorsMovieDropLbl);
            this.Movie.Location = new System.Drawing.Point(4, 25);
            this.Movie.Name = "Movie";
            this.Movie.Size = new System.Drawing.Size(1279, 737);
            this.Movie.TabIndex = 4;
            this.Movie.Text = "Movie";
            this.Movie.UseVisualStyleBackColor = true;
            // 
            // ActorsMovieDropLbl
            // 
            this.ActorsMovieDropLbl.AutoSize = true;
            this.ActorsMovieDropLbl.Location = new System.Drawing.Point(4, 32);
            this.ActorsMovieDropLbl.Name = "ActorsMovieDropLbl";
            this.ActorsMovieDropLbl.Size = new System.Drawing.Size(104, 17);
            this.ActorsMovieDropLbl.TabIndex = 0;
            this.ActorsMovieDropLbl.Text = "Actors In Movie";
            // 
            // MovieComboBox1
            // 
            this.MovieComboBox1.FormattingEnabled = true;
            this.MovieComboBox1.Location = new System.Drawing.Point(7, 52);
            this.MovieComboBox1.Name = "MovieComboBox1";
            this.MovieComboBox1.Size = new System.Drawing.Size(121, 24);
            this.MovieComboBox1.TabIndex = 1;
            this.MovieComboBox1.SelectedIndexChanged += new System.EventHandler(this.MovieComboBox1_SelectedIndexChanged);
            // 
            // MovieDirectedBy
            // 
            this.MovieDirectedBy.AutoSize = true;
            this.MovieDirectedBy.Location = new System.Drawing.Point(4, 97);
            this.MovieDirectedBy.Name = "MovieDirectedBy";
            this.MovieDirectedBy.Size = new System.Drawing.Size(121, 17);
            this.MovieDirectedBy.TabIndex = 2;
            this.MovieDirectedBy.Text = "Movie Directed by";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 117);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // charInMovie
            // 
            this.charInMovie.AutoSize = true;
            this.charInMovie.Location = new System.Drawing.Point(4, 170);
            this.charInMovie.Name = "charInMovie";
            this.charInMovie.Size = new System.Drawing.Size(133, 17);
            this.charInMovie.TabIndex = 4;
            this.charInMovie.Text = "Characters in Movie";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(7, 190);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 5;
            // 
            // MoviesDataGrid
            // 
            this.MoviesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MoviesDataGrid.Location = new System.Drawing.Point(143, 0);
            this.MoviesDataGrid.Name = "MoviesDataGrid";
            this.MoviesDataGrid.RowTemplate.Height = 24;
            this.MoviesDataGrid.Size = new System.Drawing.Size(1136, 713);
            this.MoviesDataGrid.TabIndex = 6;
            // 
            // Actor
            // 
            this.Actor.Controls.Add(this.ActorSubmitBtn);
            this.Actor.Controls.Add(this.chNameTxt);
            this.Actor.Controls.Add(this.ChNameLbl);
            this.Actor.Controls.Add(this.ActorsLNametxt);
            this.Actor.Controls.Add(this.ActorTxtLName);
            this.Actor.Controls.Add(this.ActorTextBoxFname);
            this.Actor.Controls.Add(this.ActorLabalFName);
            this.Actor.Controls.Add(this.ActorDataGrid);
            this.Actor.Location = new System.Drawing.Point(4, 25);
            this.Actor.Name = "Actor";
            this.Actor.Size = new System.Drawing.Size(1279, 737);
            this.Actor.TabIndex = 5;
            this.Actor.Text = "Actor";
            this.Actor.UseVisualStyleBackColor = true;
            // 
            // ActorDataGrid
            // 
            this.ActorDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActorDataGrid.Location = new System.Drawing.Point(223, 3);
            this.ActorDataGrid.Name = "ActorDataGrid";
            this.ActorDataGrid.RowTemplate.Height = 24;
            this.ActorDataGrid.Size = new System.Drawing.Size(1053, 723);
            this.ActorDataGrid.TabIndex = 0;
            // 
            // ActorLabalFName
            // 
            this.ActorLabalFName.AutoSize = true;
            this.ActorLabalFName.Location = new System.Drawing.Point(4, 20);
            this.ActorLabalFName.Name = "ActorLabalFName";
            this.ActorLabalFName.Size = new System.Drawing.Size(123, 17);
            this.ActorLabalFName.TabIndex = 1;
            this.ActorLabalFName.Text = "Actor\'s First Name";
            // 
            // ActorTextBoxFname
            // 
            this.ActorTextBoxFname.Location = new System.Drawing.Point(7, 41);
            this.ActorTextBoxFname.Name = "ActorTextBoxFname";
            this.ActorTextBoxFname.Size = new System.Drawing.Size(192, 22);
            this.ActorTextBoxFname.TabIndex = 2;
            // 
            // ActorTxtLName
            // 
            this.ActorTxtLName.AutoSize = true;
            this.ActorTxtLName.Location = new System.Drawing.Point(4, 78);
            this.ActorTxtLName.Name = "ActorTxtLName";
            this.ActorTxtLName.Size = new System.Drawing.Size(123, 17);
            this.ActorTxtLName.TabIndex = 3;
            this.ActorTxtLName.Text = "Actor\'s Last Name";
            // 
            // ActorsLNametxt
            // 
            this.ActorsLNametxt.Location = new System.Drawing.Point(7, 99);
            this.ActorsLNametxt.Name = "ActorsLNametxt";
            this.ActorsLNametxt.Size = new System.Drawing.Size(192, 22);
            this.ActorsLNametxt.TabIndex = 4;
            // 
            // ChNameLbl
            // 
            this.ChNameLbl.AutoSize = true;
            this.ChNameLbl.Location = new System.Drawing.Point(4, 141);
            this.ChNameLbl.Name = "ChNameLbl";
            this.ChNameLbl.Size = new System.Drawing.Size(121, 17);
            this.ChNameLbl.TabIndex = 5;
            this.ChNameLbl.Text = "Character\'s Name";
            // 
            // chNameTxt
            // 
            this.chNameTxt.Location = new System.Drawing.Point(7, 161);
            this.chNameTxt.Name = "chNameTxt";
            this.chNameTxt.Size = new System.Drawing.Size(192, 22);
            this.chNameTxt.TabIndex = 6;
            // 
            // ActorSubmitBtn
            // 
            this.ActorSubmitBtn.Location = new System.Drawing.Point(7, 684);
            this.ActorSubmitBtn.Name = "ActorSubmitBtn";
            this.ActorSubmitBtn.Size = new System.Drawing.Size(192, 23);
            this.ActorSubmitBtn.TabIndex = 7;
            this.ActorSubmitBtn.Text = "Submit";
            this.ActorSubmitBtn.UseVisualStyleBackColor = true;
            this.ActorSubmitBtn.Click += new System.EventHandler(this.ActorSubmitBtn_Click);
            // 
            // BanthaFodderGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1292, 764);
            this.Controls.Add(this.Tab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BanthaFodderGui";
            this.Text = "BanthaFodder Gui";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Custom.ResumeLayout(false);
            this.Custom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomDataGrid)).EndInit();
            this.Planet.ResumeLayout(false);
            this.Planet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlanetDataGrid)).EndInit();
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            this.Tab.ResumeLayout(false);
            this.Movie.ResumeLayout(false);
            this.Movie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviesDataGrid)).EndInit();
            this.Actor.ResumeLayout(false);
            this.Actor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActorDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Custom;
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
        private System.Windows.Forms.TabPage Login;
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
        private System.Windows.Forms.TabPage Movie;
        private System.Windows.Forms.DataGridView MoviesDataGrid;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label charInMovie;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label MovieDirectedBy;
        private System.Windows.Forms.ComboBox MovieComboBox1;
        private System.Windows.Forms.Label ActorsMovieDropLbl;
        private System.Windows.Forms.TabPage Actor;
        private System.Windows.Forms.Button ActorSubmitBtn;
        private System.Windows.Forms.TextBox chNameTxt;
        private System.Windows.Forms.Label ChNameLbl;
        private System.Windows.Forms.TextBox ActorsLNametxt;
        private System.Windows.Forms.Label ActorTxtLName;
        private System.Windows.Forms.TextBox ActorTextBoxFname;
        private System.Windows.Forms.Label ActorLabalFName;
        private System.Windows.Forms.DataGridView ActorDataGrid;
    }
}

