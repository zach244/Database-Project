using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Database_Project
{
    /// <summary>
    ///     Enum to toggle boxes on and off
    /// </summary>
    internal enum Settings
    {
        On,
        Off
    }

    public partial class BanthaFodderGui : Form
    {
        public BanthaFodderGui()
        {
            InitializeComponent();
            ToggleBoxes(Settings.Off);
        }


        /// <summary>
        ///     Log in Variables
        /// </summary>
        public string LoginServerName { get; set; }

        public string UseridName { get; set; }
        public string PasswordName { get; set; }
        public string DatabaseName { get; set; }
        public MySqlConnection Connection { get; set; }

        /// <summary>
        ///     Method to turn on Movie Add Boxes using enum On,Off
        /// </summary>
        /// <param name="x"></param>
        private void MovieAddBoxes(Settings x)
        {
            if (x == Settings.On)
            {
                MovieNameAdd.Visible = true;
                movieAddLblYear.Visible = true;
                movieAddLengthLbl.Visible = true;
                movieAddName.Visible = true;
                movieAddYear.Visible = true;
                movieAddLength.Visible = true;
                movieAddSubmit.Visible = true;
            }
            else
            {
                MovieNameAdd.Visible = false;
                movieAddLblYear.Visible = false;
                movieAddLengthLbl.Visible = false;
                movieAddName.Visible = false;
                movieAddYear.Visible = false;
                movieAddLength.Visible = false;
                movieAddSubmit.Visible = false;
            }
        }

        /// <summary>
        ///     Turns on Director Add Boxes using enum On,Off
        /// </summary>
        /// <param name="x"></param>
        private void DirectorAddBoxes(Settings x)
        {
            if (x == Settings.On)
            {
                directorADDFName.Visible = true;
                directorAddLName.Visible = true;
                DirectorBdayADD.Visible = true;
                directorADDlnametxt.Visible = true;
                directorADDSubmit.Visible = true;
                directorBdayLBL.Visible = true;
                directorFnameAddLbl.Visible = true;
            }
            else
            {
                directorADDFName.Visible = false;
                directorAddLName.Visible = false;
                DirectorBdayADD.Visible = false;
                directorADDlnametxt.Visible = false;
                directorADDSubmit.Visible = false;
                directorBdayLBL.Visible = false;
                directorFnameAddLbl.Visible = false;
            }
        }

        /// <summary>
        ///     Toggles All Add Boxes on and off using Enum On,Off
        /// </summary>
        /// <param name="x"></param>
        private void ToggleBoxes(Settings x)
        {
            if (x == Settings.On)
            {
                MovieAddBoxes(Settings.On);
                DirectorAddBoxes(Settings.On);
            }
            else
            {
                MovieAddBoxes(Settings.Off);
                DirectorAddBoxes(Settings.Off);
            }
        }

        /// <summary>
        ///     Creates the Login String for executing commands from the text boxes from login menu
        /// </summary>
        /// <returns></returns>
        private MySqlConnectionStringBuilder ConnectionBuilder()
        {
            var builder = new MySqlConnectionStringBuilder
            {
                Server = LoginServerName,
                UserID = UseridName,
                Password = PasswordName,
                Database = DatabaseName
            };
            return builder;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        ///     When clicked Takes the entered information in the Planet text boxes and converts them into Sql Query and returns
        ///     result.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitPlanet_Click(object sender, EventArgs e)
        {
            if ((LoginServerName == null) || (UseridName == null) || (PasswordName == null) || (DatabaseName == null))
                MessageBox.Show("You have not logged in with the right creditentials please re-login");

            var sqlCmd = new MySqlCommand
            {
                Connection = Connection,
                CommandType = CommandType.Text
            };

            if (!string.IsNullOrEmpty(PlanetIdTxt.Text) && string.IsNullOrEmpty(ClimateTxt.Text) &&
                string.IsNullOrEmpty(PlanetNameTxt.Text))
                sqlCmd.CommandText = "Select * from Planet where idPlanet =" + PlanetIdTxt.Text;
            else if (string.IsNullOrEmpty(PlanetIdTxt.Text) && !string.IsNullOrEmpty(ClimateTxt.Text) &&
                     string.IsNullOrEmpty(PlanetNameTxt.Text))
                sqlCmd.CommandText = $"Select * from Planet where climate = \"{ClimateTxt.Text}\"";
            else if (string.IsNullOrEmpty(PlanetIdTxt.Text) && string.IsNullOrEmpty(ClimateTxt.Text) &&
                     !string.IsNullOrEmpty(PlanetNameTxt.Text))
                sqlCmd.CommandText = $"Select * from Planet where name = \"{PlanetNameTxt.Text}\"";
            else if (!string.IsNullOrEmpty(PlanetIdTxt.Text) && !string.IsNullOrEmpty(ClimateTxt.Text) &&
                     string.IsNullOrEmpty(PlanetNameTxt.Text))
                sqlCmd.CommandText =
                    $"Select * from Planet where idPlanet = {PlanetIdTxt.Text} and climate = \"{ClimateTxt.Text}\"";
            else if (!string.IsNullOrEmpty(PlanetIdTxt.Text) && string.IsNullOrEmpty(ClimateTxt.Text) &&
                     !string.IsNullOrEmpty(PlanetNameTxt.Text))
                sqlCmd.CommandText =
                    $"Select * from Planet where idPlanet = {PlanetIdTxt.Text} and name = \"{PlanetNameTxt.Text}\"";
            else if (!string.IsNullOrEmpty(PlanetIdTxt.Text) && !string.IsNullOrEmpty(ClimateTxt.Text) &&
                     string.IsNullOrEmpty(PlanetNameTxt.Text))
                sqlCmd.CommandText =
                    $"Select * from Planet where idPlanet = {PlanetIdTxt.Text} and climate = \"{ClimateTxt.Text}\"";
            else if (string.IsNullOrEmpty(PlanetIdTxt.Text) && !string.IsNullOrEmpty(ClimateTxt.Text) &&
                     !string.IsNullOrEmpty(PlanetNameTxt.Text))
                sqlCmd.CommandText =
                    $"Select * from Planet where climate = \"{ClimateTxt.Text}\" and name = \"{PlanetNameTxt.Text}\"";
            else if (!string.IsNullOrEmpty(PlanetIdTxt.Text) && !string.IsNullOrEmpty(ClimateTxt.Text) &&
                     !string.IsNullOrEmpty(PlanetNameTxt.Text))
                sqlCmd.CommandText =
                    $"Select * from Planet where idPlanet = {PlanetIdTxt.Text} and climate = \"{ClimateTxt.Text}\" and name = \"{PlanetNameTxt.Text}\" ";
            else
                MessageBox.Show("Must enter a value to have a valid Sql Query");

            try
            {
                var sqlDataAdap = new MySqlDataAdapter(sqlCmd);
                var dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                if (dtRecord.Rows.Count == 0)
                    MessageBox.Show("No Results from Parameters");
                PlanetDataGrid.ReadOnly = true;
                PlanetDataGrid.DataSource = dtRecord;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        ///     Executes Custom sql command when filled into Custom Textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitCustom_Click(object sender, EventArgs e)
        {
            if ((LoginServerName == null) || (UseridName == null) || (PasswordName == null) || (DatabaseName == null))
                MessageBox.Show("You have not logged in with the right creditentials please re-login");
            var sqlCmd = new MySqlCommand
            {
                Connection = Connection,
                CommandType = CommandType.Text,
                CommandText = CustomTxt.Text
            };
            if (string.IsNullOrEmpty(CustomTxt.Text))
                MessageBox.Show("Must enter a valid Sql Command");
            try
            {
                var sqlDataAdap = new MySqlDataAdapter(sqlCmd);
                var dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                if (dtRecord.Rows.Count == 0)
                    MessageBox.Show("No Results from Parameters");

                CustomDataGrid.ReadOnly = true;
                CustomDataGrid.DataSource = dtRecord;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        ///     When the Combobox is changed, executes sql query based on selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((LoginServerName == null) || (UseridName == null) || (PasswordName == null) || (DatabaseName == null))
                MessageBox.Show("You have not logged in with the right creditentials please re-login");

            if (!ComboBoxCustom.SelectedIndex.Equals(0))
            {
                var query = !ComboBoxCustom.SelectedIndex.Equals(2)
                    ? $"Select * from {ComboBoxCustom.SelectedItem}"
                    : $"Select * from `{ComboBoxCustom.SelectedItem}`";
                try
                {
                    var sqlCmd = new MySqlCommand(query, Connection);
                    var sqlDataAdap = new MySqlDataAdapter(sqlCmd);
                    var dtRecord = new DataTable();
                    sqlDataAdap.Fill(dtRecord);

                    if (dtRecord.Rows.Count == 0)
                        MessageBox.Show("No Results from Parameters");

                    CustomDataGrid.ReadOnly = true;
                    CustomDataGrid.DataSource = dtRecord;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                CustomDataGrid.DataSource = null;
            }
        }

        /// <summary>
        ///     When Pressed sets the login information for all of the connections in client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginServerName = ServerNameTxt.Text;
            UseridName = UsernameTxt.Text;
            PasswordName = PasswordTxt.Text;
            DatabaseName = DatabaseNameTxt.Text;
            Connection = new MySqlConnection(ConnectionBuilder().ToString());

            try
            {
                Connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            var red = Image.FromFile("C:\\Users\\zach\\Documents\\GitHub\\Database-Project\\Database Project\\Green.png");
            var green =
                Image.FromFile("C:\\Users\\zach\\Documents\\GitHub\\Database-Project\\Database Project\\Green.png");

            if (Connection.State == ConnectionState.Closed)
            {
                LoginPicture.Image = red;
                LoginConnectionLbl.ForeColor = Color.Red;
                LoginConnectionLbl.Text = "Not Connected";
            }
            else if (Connection.State == ConnectionState.Open)
            {
                LoginPicture.Image = green;
                LoginConnectionLbl.ForeColor = Color.Aquamarine;
                LoginConnectionLbl.Text = "Connected";
            }
        }

        /* private void moviecomboboxpopulate()
        {
            try
            {
                string query = "SELECT movieName From Movie";
                MySqlConnection connect = new MySqlConnection(ConnectionBuilder().ToString());
                connect.Open();
                MySqlCommand command = new MySqlCommand(query,connect);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    MovieComboBox1.Items.Add(reader.GetString("movieName"));
                }

            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show(ex.ToString());
                }
                
            }
        }*/

        private void MovieComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!MovieACtorsCombbo.SelectedIndex.Equals(0))
            {
                var query =
                    $"SELECT* FROM Actor,ActedIn, Movie where Movie.movieName = \'{MovieACtorsCombbo.SelectedItem}\' AND Movie.idMovie = ActedIn.idMovie AND Actor.idActor = ActedIn.idActor";
                try
                {
                    var sqlCmd = new MySqlCommand(query, Connection);
                    var sqlDataAdap = new MySqlDataAdapter(sqlCmd);
                    var dtRecord = new DataTable();
                    sqlDataAdap.Fill(dtRecord);

                    if (dtRecord.Rows.Count == 0)
                        MessageBox.Show("No Results from Parameters");

                    MoviesDataGrid.ReadOnly = true;
                    MoviesDataGrid.DataSource = dtRecord;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MoviesDataGrid.DataSource = null;
            }
            //moviecomboboxpopulate();
            /* if (MovieACtorsCombbo.SelectedIndex > -1)
             {
                 string m = MovieACtorsCombbo.SelectedIndex.ToString();
                 string query = string.Format("Select *  from Movie where movieName = \"{0}\"",m); // Need sql command to get actors from 
                 MySqlConnection Connection = new MySqlConnection(ConnectionBuilder().ToString());
                 MySqlCommand cmd = new MySqlCommand(query,Connection);
                 MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
                 DataTable dtRecord = new DataTable();
                 sqlDataAdap.Fill(dtRecord);
                 CustomDataGrid.ReadOnly = true;
                 CustomDataGrid.DataSource = dtRecord;
             }*/

            //use if statements instead
        }

        /// <summary>
        ///     When selected toggles correct boxes on, to add information into database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AddComboBox.Text == "Movie")
            {
                ToggleBoxes(Settings.Off);
                //needs to set visibilty for textbox to allow data input / submit button / labels
                MovieAddBoxes(Settings.On);
            }
            else if (AddComboBox.Text == "Director")
            {
                ToggleBoxes(Settings.Off);
                DirectorAddBoxes(Settings.On);
            }
        }

        /// <summary>
        ///     When clicked Adds the information added into the text boxes in Movie, to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void movieAddSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(movieAddName.Text) || string.IsNullOrEmpty(movieAddYear.Text) ||
                string.IsNullOrEmpty(movieAddLength.Text))
                MessageBox.Show("Must enter in proper results for insert and no box can be left empty!");
            try
            {
                string query =
                    $"INSERT INTO Movie (movieName,releaseYear,lengthMinutes) VALUES(\"{movieAddName.Text}\",\"{movieAddYear.Text}\",\"{movieAddLength.Text}\")";
                var sqlCmd = new MySqlCommand(query, Connection);
                sqlCmd.ExecuteNonQuery();

                movieAddName.Clear();
                movieAddLength.Clear();
                movieAddYear.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        ///     When clicked adds all the information in text boxes to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void directorADDSubmit_Click(object sender, EventArgs e)

        {
            if (string.IsNullOrEmpty(directorADDFName.Text) || string.IsNullOrEmpty(directorAddLName.Text) ||
                string.IsNullOrEmpty(DirectorBdayADD.Text))
                MessageBox.Show("Must enter in proper results for insert and no box can be left empty!");

            try
            {
                string query =
                    $"INSERT INTO Director (fName,lName,birthday) VALUES(\"{directorADDFName.Text}\",\"{directorADDlnametxt.Text}\",\"{DirectorBdayADD.Text}\")";
                var sqlCmd = new MySqlCommand(query, Connection);
                sqlCmd.ExecuteNonQuery();
                directorADDFName.Clear();
                directorADDlnametxt.Clear();
                DirectorBdayADD.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// Shows the movieName,releaseYear and lengthMinutes from a movie where directed by a single person
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MovieDirectorCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!MovieDirectorCombo.SelectedIndex.Equals(0))
            {
                var names = MovieDirectorCombo.SelectedItem.ToString().Split(' ');
                var query =
                    $"select movieName, releaseYear, lengthMinutes from Movie,Directed,Director where Director.fName = \"{names[0]}\" and Director.lName = \"{names[1]}\" and Director.idDirector = Directed.idDirector and Directed.idMovie = Movie.idMovie";
                try
                {
                    var sqlCmd = new MySqlCommand(query, Connection);
                    var sqlDataAdap = new MySqlDataAdapter(sqlCmd);
                    var dtRecord = new DataTable();
                    sqlDataAdap.Fill(dtRecord);
                    if (dtRecord.Rows.Count == 0)
                        MessageBox.Show("No Results from Parameters");

                    MoviesDataGrid.ReadOnly = true;
                    MoviesDataGrid.DataSource = dtRecord;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MoviesDataGrid.DataSource = null;
            }
        }
        /// <summary>
        /// Gets the Characters from a single movie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MovieCharCombo_SelectedIndexChanged(object sender, EventArgs e) //Still Need Sql Statement
        {
            if (!MovieCharCombo.SelectedIndex.Equals(0))
            {
                var query = "";
                //needsql statement;
                try
                {
                    var sqlCmd = new MySqlCommand(query, Connection);
                    var sqlDataAdap = new MySqlDataAdapter(sqlCmd);
                    var dtRecord = new DataTable();
                    sqlDataAdap.Fill(dtRecord);
                    if (dtRecord.Rows.Count == 0)
                        MessageBox.Show("No Results from Parameters");

                    MoviesDataGrid.ReadOnly = true;
                    MoviesDataGrid.DataSource = dtRecord;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MoviesDataGrid.DataSource = null;
            }
        }
        /// <summary>
        /// Combobox event to pick which table to remove from
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboxRemove_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((LoginServerName == null) || (UseridName == null) || (PasswordName == null) || (DatabaseName == null))
                MessageBox.Show("You have not logged in with the right creditentials please re-login");


            var query = $"Select * from {ComboxRemove.SelectedItem}";
            try
            {
                var sqlCmd = new MySqlCommand(query, Connection);
                var sqlDataAdap = new MySqlDataAdapter(sqlCmd);
                var dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                if (dtRecord.Rows.Count == 0)
                    MessageBox.Show("No Results from Parameters");

                dataGridRemove.ReadOnly = true;
                dataGridRemove.DataSource = dtRecord;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// delete button when pressed removes the chosen row
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridRemove.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please Select Row/Rows to delete");
                return;
            }
            if (dataGridRemove.CurrentRow != null)
            {
                var index = Convert.ToInt32(dataGridRemove.CurrentRow.Cells[0].Value);
                var query = $"Delete from {ComboxRemove.SelectedItem} where id{ComboxRemove.SelectedItem}= {index}";
                try
                {
                    var sqlCmd = new MySqlCommand(query, Connection);
                    var sqlDataAdap = new MySqlDataAdapter(sqlCmd);
                    var dtRecord = new DataTable();
                    sqlDataAdap.Fill(dtRecord);
                    dataGridRemove.ReadOnly = true;
                    dataGridRemove.DataSource = dtRecord;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            

            var query2 = $"Select * from {ComboxRemove.SelectedItem}";
            try
            {
                var sqlCmd = new MySqlCommand(query2, Connection);
                var sqlDataAdap = new MySqlDataAdapter(sqlCmd);
                var dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                if (dtRecord.Rows.Count == 0)
                    MessageBox.Show("No Results from Parameters");

                dataGridRemove.ReadOnly = true;
                dataGridRemove.DataSource = dtRecord;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// 
        /// When the application is closed, closes connection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BanthaFodderGui_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}