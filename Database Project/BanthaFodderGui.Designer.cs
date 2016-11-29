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
            this.LoginConnectionLbl = new System.Windows.Forms.Label();
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
            this.Actor = new System.Windows.Forms.TabPage();
            this.ActorSubmitBtn = new System.Windows.Forms.Button();
            this.chNameTxt = new System.Windows.Forms.TextBox();
            this.ChNameLbl = new System.Windows.Forms.Label();
            this.ActorsLNametxt = new System.Windows.Forms.TextBox();
            this.ActorTxtLName = new System.Windows.Forms.Label();
            this.ActorTextBoxFname = new System.Windows.Forms.TextBox();
            this.ActorLabalFName = new System.Windows.Forms.Label();
            this.ActorDataGrid = new System.Windows.Forms.DataGridView();
            this.Movie = new System.Windows.Forms.TabPage();
            this.MoviesDataGrid = new System.Windows.Forms.DataGridView();
            this.MovieCharCombo = new System.Windows.Forms.ComboBox();
            this.charInMovie = new System.Windows.Forms.Label();
            this.MovieDirectorCombo = new System.Windows.Forms.ComboBox();
            this.MovieDirectedBy = new System.Windows.Forms.Label();
            this.MovieACtorsCombbo = new System.Windows.Forms.ComboBox();
            this.ActorsMovieDropLbl = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.TabPage();
            this.DirectorBdayADD = new System.Windows.Forms.DateTimePicker();
            this.directorADDSubmit = new System.Windows.Forms.Button();
            this.directorADDlnametxt = new System.Windows.Forms.TextBox();
            this.directorBdayLBL = new System.Windows.Forms.Label();
            this.directorAddLName = new System.Windows.Forms.Label();
            this.directorADDFName = new System.Windows.Forms.TextBox();
            this.directorFnameAddLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.movieAddSubmit = new System.Windows.Forms.Button();
            this.movieAddLength = new System.Windows.Forms.TextBox();
            this.movieAddYear = new System.Windows.Forms.TextBox();
            this.movieAddName = new System.Windows.Forms.TextBox();
            this.movieAddLengthLbl = new System.Windows.Forms.Label();
            this.movieAddLblYear = new System.Windows.Forms.Label();
            this.MovieNameAdd = new System.Windows.Forms.Label();
            this.InsertLabel = new System.Windows.Forms.Label();
            this.AddComboBox = new System.Windows.Forms.ComboBox();
            this.Custom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomDataGrid)).BeginInit();
            this.Planet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlanetDataGrid)).BeginInit();
            this.Login.SuspendLayout();
            this.Tab.SuspendLayout();
            this.Actor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActorDataGrid)).BeginInit();
            this.Movie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviesDataGrid)).BeginInit();
            this.Add.SuspendLayout();
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
            this.Custom.Location = new System.Drawing.Point(4, 22);
            this.Custom.Name = "Custom";
            this.Custom.Padding = new System.Windows.Forms.Padding(3);
            this.Custom.Size = new System.Drawing.Size(957, 596);
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
            this.ComboBoxCustom.Location = new System.Drawing.Point(0, 136);
            this.ComboBoxCustom.Name = "ComboBoxCustom";
            this.ComboBoxCustom.Size = new System.Drawing.Size(171, 21);
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
            this.CustomDataGrid.Location = new System.Drawing.Point(196, 0);
            this.CustomDataGrid.Name = "CustomDataGrid";
            this.CustomDataGrid.Size = new System.Drawing.Size(766, 597);
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
            this.CustomTxt.Size = new System.Drawing.Size(171, 20);
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
            this.PlanetDataGrid.Location = new System.Drawing.Point(196, 3);
            this.PlanetDataGrid.Name = "PlanetDataGrid";
            this.PlanetDataGrid.Size = new System.Drawing.Size(766, 597);
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
            this.SubmitPlanet.Location = new System.Drawing.Point(41, 542);
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
            // Login
            // 
            this.Login.Controls.Add(this.LoginConnectionLbl);
            this.Login.Controls.Add(this.LoginButton);
            this.Login.Controls.Add(this.DatabaseNameTxt);
            this.Login.Controls.Add(this.PasswordTxt);
            this.Login.Controls.Add(this.UsernameTxt);
            this.Login.Controls.Add(this.ServerNameTxt);
            this.Login.Controls.Add(this.LoginDatabaseNameLbl);
            this.Login.Controls.Add(this.ServerName);
            this.Login.Controls.Add(this.LoginPasswordLbl);
            this.Login.Controls.Add(this.LoginUsernameLbl);
            this.Login.Location = new System.Drawing.Point(4, 22);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(957, 596);
            this.Login.TabIndex = 3;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            // 
            // LoginConnectionLbl
            // 
            this.LoginConnectionLbl.AutoSize = true;
            this.LoginConnectionLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LoginConnectionLbl.Location = new System.Drawing.Point(391, 363);
            this.LoginConnectionLbl.Name = "LoginConnectionLbl";
            this.LoginConnectionLbl.Size = new System.Drawing.Size(61, 13);
            this.LoginConnectionLbl.TabIndex = 9;
            this.LoginConnectionLbl.Text = "Connection";
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
            this.Tab.Controls.Add(this.Login);
            this.Tab.Controls.Add(this.Actor);
            this.Tab.Controls.Add(this.Movie);
            this.Tab.Controls.Add(this.Planet);
            this.Tab.Controls.Add(this.Custom);
            this.Tab.Controls.Add(this.Add);
            this.Tab.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Tab.Location = new System.Drawing.Point(3, 1);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(965, 622);
            this.Tab.TabIndex = 0;
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
            this.Actor.Location = new System.Drawing.Point(4, 22);
            this.Actor.Margin = new System.Windows.Forms.Padding(2);
            this.Actor.Name = "Actor";
            this.Actor.Size = new System.Drawing.Size(957, 596);
            this.Actor.TabIndex = 5;
            this.Actor.Text = "Actor";
            this.Actor.UseVisualStyleBackColor = true;
            // 
            // ActorSubmitBtn
            // 
            this.ActorSubmitBtn.Location = new System.Drawing.Point(5, 556);
            this.ActorSubmitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ActorSubmitBtn.Name = "ActorSubmitBtn";
            this.ActorSubmitBtn.Size = new System.Drawing.Size(144, 19);
            this.ActorSubmitBtn.TabIndex = 7;
            this.ActorSubmitBtn.Text = "Submit";
            this.ActorSubmitBtn.UseVisualStyleBackColor = true;
            this.ActorSubmitBtn.Click += new System.EventHandler(this.ActorSubmitBtn_Click);
            // 
            // chNameTxt
            // 
            this.chNameTxt.Location = new System.Drawing.Point(5, 131);
            this.chNameTxt.Margin = new System.Windows.Forms.Padding(2);
            this.chNameTxt.Name = "chNameTxt";
            this.chNameTxt.Size = new System.Drawing.Size(167, 20);
            this.chNameTxt.TabIndex = 6;
            // 
            // ChNameLbl
            // 
            this.ChNameLbl.AutoSize = true;
            this.ChNameLbl.Location = new System.Drawing.Point(3, 115);
            this.ChNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ChNameLbl.Name = "ChNameLbl";
            this.ChNameLbl.Size = new System.Drawing.Size(91, 13);
            this.ChNameLbl.TabIndex = 5;
            this.ChNameLbl.Text = "Character\'s Name";
            // 
            // ActorsLNametxt
            // 
            this.ActorsLNametxt.Location = new System.Drawing.Point(5, 80);
            this.ActorsLNametxt.Margin = new System.Windows.Forms.Padding(2);
            this.ActorsLNametxt.Name = "ActorsLNametxt";
            this.ActorsLNametxt.Size = new System.Drawing.Size(167, 20);
            this.ActorsLNametxt.TabIndex = 4;
            // 
            // ActorTxtLName
            // 
            this.ActorTxtLName.AutoSize = true;
            this.ActorTxtLName.Location = new System.Drawing.Point(3, 63);
            this.ActorTxtLName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ActorTxtLName.Name = "ActorTxtLName";
            this.ActorTxtLName.Size = new System.Drawing.Size(93, 13);
            this.ActorTxtLName.TabIndex = 3;
            this.ActorTxtLName.Text = "Actor\'s Last Name";
            // 
            // ActorTextBoxFname
            // 
            this.ActorTextBoxFname.Location = new System.Drawing.Point(5, 33);
            this.ActorTextBoxFname.Margin = new System.Windows.Forms.Padding(2);
            this.ActorTextBoxFname.Name = "ActorTextBoxFname";
            this.ActorTextBoxFname.Size = new System.Drawing.Size(167, 20);
            this.ActorTextBoxFname.TabIndex = 2;
            // 
            // ActorLabalFName
            // 
            this.ActorLabalFName.AutoSize = true;
            this.ActorLabalFName.Location = new System.Drawing.Point(3, 16);
            this.ActorLabalFName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ActorLabalFName.Name = "ActorLabalFName";
            this.ActorLabalFName.Size = new System.Drawing.Size(92, 13);
            this.ActorLabalFName.TabIndex = 1;
            this.ActorLabalFName.Text = "Actor\'s First Name";
            // 
            // ActorDataGrid
            // 
            this.ActorDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActorDataGrid.Location = new System.Drawing.Point(196, 3);
            this.ActorDataGrid.Name = "ActorDataGrid";
            this.ActorDataGrid.RowTemplate.Height = 24;
            this.ActorDataGrid.Size = new System.Drawing.Size(766, 597);
            this.ActorDataGrid.TabIndex = 0;
            // 
            // Movie
            // 
            this.Movie.Controls.Add(this.MoviesDataGrid);
            this.Movie.Controls.Add(this.MovieCharCombo);
            this.Movie.Controls.Add(this.charInMovie);
            this.Movie.Controls.Add(this.MovieDirectorCombo);
            this.Movie.Controls.Add(this.MovieDirectedBy);
            this.Movie.Controls.Add(this.MovieACtorsCombbo);
            this.Movie.Controls.Add(this.ActorsMovieDropLbl);
            this.Movie.Location = new System.Drawing.Point(4, 22);
            this.Movie.Margin = new System.Windows.Forms.Padding(2);
            this.Movie.Name = "Movie";
            this.Movie.Size = new System.Drawing.Size(957, 596);
            this.Movie.TabIndex = 4;
            this.Movie.Text = "Movie";
            this.Movie.UseVisualStyleBackColor = true;
            // 
            // MoviesDataGrid
            // 
            this.MoviesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MoviesDataGrid.Location = new System.Drawing.Point(196, 3);
            this.MoviesDataGrid.Name = "MoviesDataGrid";
            this.MoviesDataGrid.RowTemplate.Height = 24;
            this.MoviesDataGrid.Size = new System.Drawing.Size(766, 597);
            this.MoviesDataGrid.TabIndex = 6;
            // 
            // MovieCharCombo
            // 
            this.MovieCharCombo.FormattingEnabled = true;
            this.MovieCharCombo.Items.AddRange(new object[] {
            "Episode IV - A New Hope",
            "Episode V - The Empire Strikes Back",
            "Episode VI - Return of the Jedi",
            "Episode I - The Phantom Menace",
            "Episode II - Attack of the Clones",
            "Episode III - Revenge of the Sith",
            "Episode VII - The Force Awakens",
            "Rogue One"});
            this.MovieCharCombo.Location = new System.Drawing.Point(4, 125);
            this.MovieCharCombo.Margin = new System.Windows.Forms.Padding(2);
            this.MovieCharCombo.Name = "MovieCharCombo";
            this.MovieCharCombo.Size = new System.Drawing.Size(167, 21);
            this.MovieCharCombo.TabIndex = 5;
            this.MovieCharCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // charInMovie
            // 
            this.charInMovie.AutoSize = true;
            this.charInMovie.Location = new System.Drawing.Point(2, 109);
            this.charInMovie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.charInMovie.Name = "charInMovie";
            this.charInMovie.Size = new System.Drawing.Size(101, 13);
            this.charInMovie.TabIndex = 4;
            this.charInMovie.Text = "Characters in Movie";
            // 
            // MovieDirectorCombo
            // 
            this.MovieDirectorCombo.FormattingEnabled = true;
            this.MovieDirectorCombo.Items.AddRange(new object[] {
            "George Lucas",
            "Irvin Kershner",
            "Richard Marquand",
            "J.J Abrams",
            "Gareth Edwards"});
            this.MovieDirectorCombo.Location = new System.Drawing.Point(4, 80);
            this.MovieDirectorCombo.Margin = new System.Windows.Forms.Padding(2);
            this.MovieDirectorCombo.Name = "MovieDirectorCombo";
            this.MovieDirectorCombo.Size = new System.Drawing.Size(167, 21);
            this.MovieDirectorCombo.TabIndex = 3;
            // 
            // MovieDirectedBy
            // 
            this.MovieDirectedBy.AutoSize = true;
            this.MovieDirectedBy.Location = new System.Drawing.Point(3, 63);
            this.MovieDirectedBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MovieDirectedBy.Name = "MovieDirectedBy";
            this.MovieDirectedBy.Size = new System.Drawing.Size(93, 13);
            this.MovieDirectedBy.TabIndex = 2;
            this.MovieDirectedBy.Text = "Movie Directed by";
            // 
            // MovieACtorsCombbo
            // 
            this.MovieACtorsCombbo.FormattingEnabled = true;
            this.MovieACtorsCombbo.Items.AddRange(new object[] {
            "Episode IV - A New Hope",
            "Episode V - The Empire Strikes Back",
            "Episode VI - Return of the Jedi",
            "Episode I - The Phantom Menace",
            "Episode II - Attack of the Clones",
            "Episode III - Revenge of the Sith",
            "Episode VII - The Force Awakens",
            "Rogue One"});
            this.MovieACtorsCombbo.Location = new System.Drawing.Point(4, 32);
            this.MovieACtorsCombbo.Margin = new System.Windows.Forms.Padding(2);
            this.MovieACtorsCombbo.Name = "MovieACtorsCombbo";
            this.MovieACtorsCombbo.Size = new System.Drawing.Size(167, 21);
            this.MovieACtorsCombbo.TabIndex = 1;
            this.MovieACtorsCombbo.SelectedIndexChanged += new System.EventHandler(this.MovieComboBox1_SelectedIndexChanged);
            // 
            // ActorsMovieDropLbl
            // 
            this.ActorsMovieDropLbl.AutoSize = true;
            this.ActorsMovieDropLbl.Location = new System.Drawing.Point(2, 16);
            this.ActorsMovieDropLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ActorsMovieDropLbl.Name = "ActorsMovieDropLbl";
            this.ActorsMovieDropLbl.Size = new System.Drawing.Size(81, 13);
            this.ActorsMovieDropLbl.TabIndex = 0;
            this.ActorsMovieDropLbl.Text = "Actors In Movie";
            // 
            // Add
            // 
            this.Add.Controls.Add(this.DirectorBdayADD);
            this.Add.Controls.Add(this.directorADDSubmit);
            this.Add.Controls.Add(this.directorADDlnametxt);
            this.Add.Controls.Add(this.directorBdayLBL);
            this.Add.Controls.Add(this.directorAddLName);
            this.Add.Controls.Add(this.directorADDFName);
            this.Add.Controls.Add(this.directorFnameAddLbl);
            this.Add.Controls.Add(this.label1);
            this.Add.Controls.Add(this.movieAddSubmit);
            this.Add.Controls.Add(this.movieAddLength);
            this.Add.Controls.Add(this.movieAddYear);
            this.Add.Controls.Add(this.movieAddName);
            this.Add.Controls.Add(this.movieAddLengthLbl);
            this.Add.Controls.Add(this.movieAddLblYear);
            this.Add.Controls.Add(this.MovieNameAdd);
            this.Add.Controls.Add(this.InsertLabel);
            this.Add.Controls.Add(this.AddComboBox);
            this.Add.Location = new System.Drawing.Point(4, 22);
            this.Add.Margin = new System.Windows.Forms.Padding(2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(957, 596);
            this.Add.TabIndex = 6;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // DirectorBdayADD
            // 
            this.DirectorBdayADD.CustomFormat = "yyyy-MM-dd";
            this.DirectorBdayADD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DirectorBdayADD.Location = new System.Drawing.Point(290, 204);
            this.DirectorBdayADD.Name = "DirectorBdayADD";
            this.DirectorBdayADD.Size = new System.Drawing.Size(269, 20);
            this.DirectorBdayADD.TabIndex = 17;
            // 
            // directorADDSubmit
            // 
            this.directorADDSubmit.Location = new System.Drawing.Point(370, 287);
            this.directorADDSubmit.Name = "directorADDSubmit";
            this.directorADDSubmit.Size = new System.Drawing.Size(75, 23);
            this.directorADDSubmit.TabIndex = 16;
            this.directorADDSubmit.Text = "Submit";
            this.directorADDSubmit.UseVisualStyleBackColor = true;
            this.directorADDSubmit.Click += new System.EventHandler(this.directorADDSubmit_Click);
            // 
            // directorADDlnametxt
            // 
            this.directorADDlnametxt.Location = new System.Drawing.Point(290, 141);
            this.directorADDlnametxt.Name = "directorADDlnametxt";
            this.directorADDlnametxt.Size = new System.Drawing.Size(269, 20);
            this.directorADDlnametxt.TabIndex = 14;
            // 
            // directorBdayLBL
            // 
            this.directorBdayLBL.AutoSize = true;
            this.directorBdayLBL.Location = new System.Drawing.Point(290, 188);
            this.directorBdayLBL.Name = "directorBdayLBL";
            this.directorBdayLBL.Size = new System.Drawing.Size(120, 13);
            this.directorBdayLBL.TabIndex = 13;
            this.directorBdayLBL.Text = "Enter Director\'s Birthday";
            // 
            // directorAddLName
            // 
            this.directorAddLName.AutoSize = true;
            this.directorAddLName.Location = new System.Drawing.Point(287, 124);
            this.directorAddLName.Name = "directorAddLName";
            this.directorAddLName.Size = new System.Drawing.Size(133, 13);
            this.directorAddLName.TabIndex = 12;
            this.directorAddLName.Text = "Enter Director\'s Last Name";
            // 
            // directorADDFName
            // 
            this.directorADDFName.Location = new System.Drawing.Point(290, 74);
            this.directorADDFName.Name = "directorADDFName";
            this.directorADDFName.Size = new System.Drawing.Size(269, 20);
            this.directorADDFName.TabIndex = 11;
            // 
            // directorFnameAddLbl
            // 
            this.directorFnameAddLbl.AutoSize = true;
            this.directorFnameAddLbl.Location = new System.Drawing.Point(287, 57);
            this.directorFnameAddLbl.Name = "directorFnameAddLbl";
            this.directorFnameAddLbl.Size = new System.Drawing.Size(125, 13);
            this.directorFnameAddLbl.TabIndex = 10;
            this.directorFnameAddLbl.Text = "Enter Director First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // movieAddSubmit
            // 
            this.movieAddSubmit.Location = new System.Drawing.Point(370, 287);
            this.movieAddSubmit.Name = "movieAddSubmit";
            this.movieAddSubmit.Size = new System.Drawing.Size(75, 23);
            this.movieAddSubmit.TabIndex = 9;
            this.movieAddSubmit.Text = "Submit";
            this.movieAddSubmit.UseVisualStyleBackColor = true;
            this.movieAddSubmit.Click += new System.EventHandler(this.movieAddSubmit_Click);
            // 
            // movieAddLength
            // 
            this.movieAddLength.Location = new System.Drawing.Point(290, 204);
            this.movieAddLength.Name = "movieAddLength";
            this.movieAddLength.Size = new System.Drawing.Size(269, 20);
            this.movieAddLength.TabIndex = 8;
            // 
            // movieAddYear
            // 
            this.movieAddYear.Location = new System.Drawing.Point(290, 141);
            this.movieAddYear.Name = "movieAddYear";
            this.movieAddYear.Size = new System.Drawing.Size(269, 20);
            this.movieAddYear.TabIndex = 7;
            // 
            // movieAddName
            // 
            this.movieAddName.Location = new System.Drawing.Point(290, 73);
            this.movieAddName.Name = "movieAddName";
            this.movieAddName.Size = new System.Drawing.Size(269, 20);
            this.movieAddName.TabIndex = 6;
            // 
            // movieAddLengthLbl
            // 
            this.movieAddLengthLbl.AutoSize = true;
            this.movieAddLengthLbl.Location = new System.Drawing.Point(287, 188);
            this.movieAddLengthLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.movieAddLengthLbl.Name = "movieAddLengthLbl";
            this.movieAddLengthLbl.Size = new System.Drawing.Size(84, 13);
            this.movieAddLengthLbl.TabIndex = 4;
            this.movieAddLengthLbl.Text = "Lenght of Movie";
            // 
            // movieAddLblYear
            // 
            this.movieAddLblYear.AutoSize = true;
            this.movieAddLblYear.Location = new System.Drawing.Point(287, 124);
            this.movieAddLblYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.movieAddLblYear.Name = "movieAddLblYear";
            this.movieAddLblYear.Size = new System.Drawing.Size(158, 13);
            this.movieAddLblYear.TabIndex = 3;
            this.movieAddLblYear.Text = "Please Enter the Year Released";
            // 
            // MovieNameAdd
            // 
            this.MovieNameAdd.AutoSize = true;
            this.MovieNameAdd.Location = new System.Drawing.Point(287, 57);
            this.MovieNameAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MovieNameAdd.Name = "MovieNameAdd";
            this.MovieNameAdd.Size = new System.Drawing.Size(95, 13);
            this.MovieNameAdd.TabIndex = 2;
            this.MovieNameAdd.Text = "Enter Movie Name";
            // 
            // InsertLabel
            // 
            this.InsertLabel.AutoSize = true;
            this.InsertLabel.Location = new System.Drawing.Point(3, 46);
            this.InsertLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InsertLabel.Name = "InsertLabel";
            this.InsertLabel.Size = new System.Drawing.Size(106, 13);
            this.InsertLabel.TabIndex = 1;
            this.InsertLabel.Text = "Table To Insert Entry";
            // 
            // AddComboBox
            // 
            this.AddComboBox.FormattingEnabled = true;
            this.AddComboBox.Items.AddRange(new object[] {
            "Movie",
            "Director",
            "Actor",
            "Character",
            "Planet",
            "Pilot"});
            this.AddComboBox.Location = new System.Drawing.Point(3, 63);
            this.AddComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.AddComboBox.Name = "AddComboBox";
            this.AddComboBox.Size = new System.Drawing.Size(170, 21);
            this.AddComboBox.TabIndex = 0;
            this.AddComboBox.SelectedIndexChanged += new System.EventHandler(this.AddComboBox_SelectedIndexChanged);
            // 
            // BanthaFodderGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(969, 621);
            this.Controls.Add(this.Tab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.Actor.ResumeLayout(false);
            this.Actor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActorDataGrid)).EndInit();
            this.Movie.ResumeLayout(false);
            this.Movie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviesDataGrid)).EndInit();
            this.Add.ResumeLayout(false);
            this.Add.PerformLayout();
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
        private System.Windows.Forms.ComboBox MovieCharCombo;
        private System.Windows.Forms.Label charInMovie;
        private System.Windows.Forms.ComboBox MovieDirectorCombo;
        private System.Windows.Forms.Label MovieDirectedBy;
        private System.Windows.Forms.ComboBox MovieACtorsCombbo;
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
        private System.Windows.Forms.Label LoginConnectionLbl;
        private System.Windows.Forms.TabPage Add;
        private System.Windows.Forms.ComboBox AddComboBox;
        private System.Windows.Forms.Label InsertLabel;
        private System.Windows.Forms.Label movieAddLengthLbl;
        private System.Windows.Forms.Label movieAddLblYear;
        private System.Windows.Forms.Label MovieNameAdd;
        private System.Windows.Forms.TextBox movieAddName;
        private System.Windows.Forms.TextBox movieAddYear;
        private System.Windows.Forms.Button movieAddSubmit;
        private System.Windows.Forms.TextBox movieAddLength;
        private System.Windows.Forms.Button directorADDSubmit;
        private System.Windows.Forms.TextBox directorADDlnametxt;
        private System.Windows.Forms.Label directorBdayLBL;
        private System.Windows.Forms.Label directorAddLName;
        private System.Windows.Forms.TextBox directorADDFName;
        private System.Windows.Forms.Label directorFnameAddLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DirectorBdayADD;
    }
}

