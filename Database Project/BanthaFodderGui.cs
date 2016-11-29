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
            //toggleBoxes(Settings.Off);
        }


        /// <summary>
        ///     Log in Variables
        /// </summary>
        public string LoginServerName { get; set; }

        public string UseridName { get; set; }
        public string PasswordName { get; set; }
        public string DatabaseName { get; set; }

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
            var builder = new MySqlConnectionStringBuilder();
            builder.Server = LoginServerName;
            builder.UserID = UseridName;
            builder.Password = PasswordName;
            builder.Database = DatabaseName;
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
            var connection = new MySqlConnection(ConnectionBuilder().ToString());

            var sqlCmd = new MySqlCommand
            {
                Connection = connection,
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
                connection.Open();
                var sqlDataAdap = new MySqlDataAdapter(sqlCmd);
                var dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                if (dtRecord.Rows.Count == 0)
                    MessageBox.Show("No Results from Parameters");
                PlanetDataGrid.ReadOnly = true;
                PlanetDataGrid.DataSource = dtRecord;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            connection.Close();
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

            var connection = new MySqlConnection(ConnectionBuilder().ToString());
            var sqlCmd = new MySqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = CustomTxt.Text
            };
            if (string.IsNullOrEmpty(CustomTxt.Text))
                MessageBox.Show("Must enter a valid Sql Command");
            try
            {
                connection.Open();
                var sqlDataAdap = new MySqlDataAdapter(sqlCmd);
                var dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);

                if (dtRecord.Rows.Count == 0)
                    MessageBox.Show("No Results from Parameters");

                CustomDataGrid.ReadOnly = true;
                CustomDataGrid.DataSource = dtRecord;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            connection.Close();
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
            var connection = new MySqlConnection(ConnectionBuilder().ToString());
            var query = "";

            if (ComboBoxCustom.SelectedIndex.Equals(0))
                query = "Select * from Movie";
            if (ComboBoxCustom.SelectedIndex.Equals(1))
                query = "Select * from `Character`";
            if (ComboBoxCustom.SelectedIndex.Equals(2))
                query = "Select * from Actor";
            if (ComboBoxCustom.SelectedIndex.Equals(3))
                query = "Select * from ActedIn";
            if (ComboBoxCustom.SelectedIndex.Equals(4))
                query = "Select * from Directed";
            if (ComboBoxCustom.SelectedIndex.Equals(5))
                query = "Select * from Droid";
            if (ComboBoxCustom.SelectedIndex.Equals(6))
                query = "Select * from Manufacturer";
            if (ComboBoxCustom.SelectedIndex.Equals(7))
                query = "Select * from Director";
            if (ComboBoxCustom.SelectedIndex.Equals(8))
                query = "Select * from Pilot";
            if (ComboBoxCustom.SelectedIndex.Equals(9))
                query = "Select * from Planet";
            if (ComboBoxCustom.SelectedIndex.Equals(10))
                query = "Select * from VehicleAndShip";
            if (ComboBoxCustom.SelectedIndex.Equals(11))
                query = "Select * from Species";
            if (ComboBoxCustom.SelectedIndex.Equals(12))
                query = "Select * from Weapon";
            try
            {
                connection.Open();
                var sqlCmd = new MySqlCommand(query, connection);
                var sqlDataAdap = new MySqlDataAdapter(sqlCmd);
                var dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);

                if (dtRecord.Rows.Count == 0)
                    MessageBox.Show("No Results from Parameters");

                CustomDataGrid.ReadOnly = true;
                CustomDataGrid.DataSource = dtRecord;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
            var connection = new MySqlConnection(ConnectionBuilder().ToString());

            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            Image red = Image.FromFile("C:\\Users\\zach\\Documents\\GitHub\\Database-Project\\Database Project\\Green.png");
            Image green = Image.FromFile("C:\\Users\\zach\\Documents\\GitHub\\Database-Project\\Database Project\\Green.png");
           
            if (connection.State == ConnectionState.Closed)
            {
                LoginPicture.Image = red;
                LoginConnectionLbl.ForeColor = Color.Red;
                LoginConnectionLbl.Text = "Not Connected";
            }
            else
            {
                LoginPicture.Image = green;
                LoginConnectionLbl.ForeColor = Color.LimeGreen;
                LoginConnectionLbl.Text = "Connected";
            }
            connection.Close();
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
            //moviecomboboxpopulate();
            /* if (MovieACtorsCombbo.SelectedIndex > -1)
             {
                 string m = MovieACtorsCombbo.SelectedIndex.ToString();
                 string query = string.Format("Select *  from Movie where movieName = \"{0}\"",m); // Need sql command to get actors from 
                 MySqlConnection connection = new MySqlConnection(ConnectionBuilder().ToString());
                 MySqlCommand cmd = new MySqlCommand(query,connection);
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
            var connection = new MySqlConnection(ConnectionBuilder().ToString());
            connection.Open();
            if (string.IsNullOrEmpty(movieAddName.Text) || string.IsNullOrEmpty(movieAddYear.Text) ||
                string.IsNullOrEmpty(movieAddLength.Text))
                MessageBox.Show("Must equal in proper results for insert and no box can be left empty!");
            try
            {
                string query =
                    $"INSERT INTO Movie (movieName,releaseYear,lengthMinutes) VALUES(\"{movieAddName.Text}\",\"{movieAddYear.Text}\",\"{movieAddLength.Text}\")";
                var sqlCmd = new MySqlCommand(query, connection);
                sqlCmd.ExecuteNonQuery();
                connection.Close();
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
                MessageBox.Show("Must equal in proper results for insert and no box can be left empty!");
            var connection = new MySqlConnection(ConnectionBuilder().ToString());
            connection.Open();

            try
            {
                string query =
                    $"INSERT INTO Director (fName,lName,birthday) VALUES(\"{directorADDFName.Text}\",\"{directorADDlnametxt.Text}\",\"{DirectorBdayADD.Text}\")";
                var sqlCmd = new MySqlCommand(query, connection);
                sqlCmd.ExecuteNonQuery();
                connection.Close();
                directorADDFName.Clear();
                directorADDlnametxt.Clear();
                DirectorBdayADD.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}