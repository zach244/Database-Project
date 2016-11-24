using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Database_Project
{
    enum settings { ON,OFF};

    public partial class BanthaFodderGui : Form
    {   //need to create login class / method and write unit tests
        public string LoginServerName { get; set; }
        public string useridName { get; set; }
        public string passwordName { get; set; }
        public string databaseName { get; set; }
        // MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        //MySqlConnection connection = new MySqlConnection();*/
        public BanthaFodderGui()
        {
            InitializeComponent();
            toggleBoxes(settings.OFF);

        }

        private void movieAddBoxes(settings x)
        {
            if (x == settings.ON)
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
        private void directorAddBoxes(settings x)
        {
            if(x == settings.ON)
            {
                directorADDFName.Visible = true;
                directorAddLName.Visible = true;
                directorADDBday.Visible = true;
                directorADDlnametxt.Visible = true;
                directorADDSubmit.Visible = true;
                directorBdayLBL.Visible = true;
                directorFnameAddLbl.Visible = true;
            }
            else
            {
                directorADDFName.Visible = false;
                directorAddLName.Visible = false;
                directorADDBday.Visible = false;
                directorADDlnametxt.Visible = false; 
                directorADDSubmit.Visible = false;
                directorBdayLBL.Visible = false;
                directorFnameAddLbl.Visible = false;
            }
        }
        private void toggleBoxes(settings x)
        {
            if(x == settings.ON)
            {
                movieAddBoxes(settings.ON);
                directorAddBoxes(settings.ON);
            }
            else
            {
                movieAddBoxes(settings.OFF);
                directorAddBoxes(settings.OFF);
            }
        }
        private MySqlConnectionStringBuilder connectionBuilder()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = LoginServerName;
            builder.UserID = useridName;
            builder.Password = passwordName;
            builder.Database = databaseName;
            return builder;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SubmitPlanet_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            if (LoginServerName == null || useridName == null || passwordName == null || databaseName == null)
            {
                MessageBox.Show("You have not logged in with the right creditentials please re-login");
            }

            MySqlConnection connection = new MySqlConnection(connectionBuilder().ToString());
            MySqlCommand sqlCmd = new MySqlCommand();
            sqlCmd.Connection = connection;
            sqlCmd.CommandType = CommandType.Text;

            if (!string.IsNullOrEmpty(PlanetIdTxt.Text) && string.IsNullOrEmpty(ClimateTxt.Text) && string.IsNullOrEmpty(PlanetNameTxt.Text))
            {
                sqlCmd.CommandText = "Select * from Planet where idPlanet =" + PlanetIdTxt.Text;
            }
            else if (string.IsNullOrEmpty(PlanetIdTxt.Text) && !string.IsNullOrEmpty(ClimateTxt.Text) && string.IsNullOrEmpty(PlanetNameTxt.Text))
            {
                sqlCmd.CommandText = string.Format("Select * from Planet where climate = \"{0}\"", ClimateTxt.Text);
            }
            else if (string.IsNullOrEmpty(PlanetIdTxt.Text) && string.IsNullOrEmpty(ClimateTxt.Text) && !string.IsNullOrEmpty(PlanetNameTxt.Text))
            {
                sqlCmd.CommandText = string.Format("Select * from Planet where name = \"{0}\"", PlanetNameTxt.Text);
            }
            else if (!string.IsNullOrEmpty(PlanetIdTxt.Text) && !string.IsNullOrEmpty(ClimateTxt.Text) && string.IsNullOrEmpty(PlanetNameTxt.Text))
            {
                sqlCmd.CommandText = string.Format("Select * from Planet where idPlanet = {0} and climate = \"{1}\"", PlanetIdTxt.Text, ClimateTxt.Text);
            }
            else if (!string.IsNullOrEmpty(PlanetIdTxt.Text) && string.IsNullOrEmpty(ClimateTxt.Text) && !string.IsNullOrEmpty(PlanetNameTxt.Text))
            {
                sqlCmd.CommandText = string.Format("Select * from Planet where idPlanet = {0} and name = \"{1}\"", PlanetIdTxt.Text, PlanetNameTxt.Text);
            }
            else if (!string.IsNullOrEmpty(PlanetIdTxt.Text) && !string.IsNullOrEmpty(ClimateTxt.Text) && string.IsNullOrEmpty(PlanetNameTxt.Text))
            {
                sqlCmd.CommandText = string.Format("Select * from Planet where idPlanet = {0} and climate = \"{1}\"", PlanetIdTxt.Text, ClimateTxt.Text);
            }
            else if (string.IsNullOrEmpty(PlanetIdTxt.Text) && !string.IsNullOrEmpty(ClimateTxt.Text) && !string.IsNullOrEmpty(PlanetNameTxt.Text))
            {
                sqlCmd.CommandText = string.Format("Select * from Planet where climate = \"{0}\" and name = \"{1}\"", ClimateTxt.Text, PlanetNameTxt.Text);
            }
            else if (!string.IsNullOrEmpty(PlanetIdTxt.Text) && !string.IsNullOrEmpty(ClimateTxt.Text) && !string.IsNullOrEmpty(PlanetNameTxt.Text))
            {
                sqlCmd.CommandText = string.Format("Select * from Planet where idPlanet = {0} and climate = \"{1}\" and name = \"{2}\" ", PlanetIdTxt.Text, ClimateTxt.Text, PlanetNameTxt.Text);
            }
            else
            {
                MessageBox.Show("Must enter a value to have a valid Sql Query");
            }
            try
            {
                MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(sqlCmd);
                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                if (dtRecord != null && dtRecord.Rows.Count == 0)
                {
                    MessageBox.Show("No Results from Parameters");
                }
                PlanetDataGrid.ReadOnly = true;
                PlanetDataGrid.DataSource = dtRecord;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void PlanetNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitCustom_Click(object sender, EventArgs e)
        {
            if (LoginServerName == null || useridName == null || passwordName == null || databaseName == null)
            {
                MessageBox.Show("You have not logged in with the right creditentials please re-login");
            }

            MySqlConnection connection = new MySqlConnection(connectionBuilder().ToString());
            MySqlCommand sqlCmd = new MySqlCommand();
            sqlCmd.Connection = connection;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = CustomTxt.Text;
            if (string.IsNullOrEmpty(CustomTxt.Text))
            {
                MessageBox.Show("Must enter a valid Sql Command");
            }
            try
            {
                MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(sqlCmd);
                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);

                if (dtRecord != null && dtRecord.Rows.Count == 0)
                {
                    MessageBox.Show("No Results from Parameters");
                }

                CustomDataGrid.ReadOnly = true;
                CustomDataGrid.DataSource = dtRecord;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LoginServerName == null || useridName == null || passwordName == null || databaseName == null)
            {
                MessageBox.Show("You have not logged in with the right creditentials please re-login");
            }
            if (ComboBoxCustom.Text == "Planets")
            {
                MySqlConnection connection = new MySqlConnection(connectionBuilder().ToString());
                MySqlCommand sqlCmd = new MySqlCommand();
                sqlCmd.Connection = connection;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "select * from planet";
                try
                {
                    MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(sqlCmd);
                    DataTable dtRecord = new DataTable();
                    sqlDataAdap.Fill(dtRecord);

                    if (dtRecord != null && dtRecord.Rows.Count == 0)
                    {
                        MessageBox.Show("No Results from Parameters");
                    }

                    CustomDataGrid.ReadOnly = true;
                    CustomDataGrid.DataSource = dtRecord;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginServerName = ServerNameTxt.Text;
            useridName = UsernameTxt.Text;
            passwordName = PasswordTxt.Text;
            databaseName = DatabaseNameTxt.Text;
            MySqlConnection connection = new MySqlConnection(connectionBuilder().ToString());

            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            if (connection.State == ConnectionState.Open)
            {
                LoginConnectionLbl.ForeColor = System.Drawing.Color.LimeGreen; //possible connection indicator on everytab. 
                Tab.SelectedTab = Actor; //could possiblye do a message box and on click it changes tabs. 
            }
            else
            {
                LoginConnectionLbl.ForeColor = System.Drawing.Color.Red;
            }

        }

        private void MovieComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ActorSubmitBtn_Click(object sender, EventArgs e)
        {
            //Need to mimic Planet class but for Actor

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AddComboBox.Text == "Movie")
            {
                toggleBoxes(settings.OFF);
                //needs to set visibilty for textbox to allow data input / submit button / labels
                movieAddBoxes(settings.ON);
            }
            else if (AddComboBox.Text == "Director")
            {
                toggleBoxes(settings.OFF);
                directorAddBoxes(settings.ON);

            }
            else if (AddComboBox.Text == "Actor")
            {
                toggleBoxes(settings.OFF);

            }
            else if (AddComboBox.Text == "Character")
            {
                toggleBoxes(settings.OFF);

            }
            else if (AddComboBox.Text == "Planet")
            {
                toggleBoxes(settings.OFF);
            }
            else if (AddComboBox.Text == "Pilot")
            {
                toggleBoxes(settings.OFF);
            }
            //Need to add rest of tables
        }

        private void Add_Click(object sender, EventArgs e)
        {

        }

        private void movieAddSubmit_Click(object sender, EventArgs e)
        {

           
            if (string.IsNullOrEmpty(movieAddName.Text) == true || string.IsNullOrEmpty(movieAddYear.Text) == true || string.IsNullOrEmpty(movieAddLength.Text) == true)
                {
                MessageBox.Show("Must equal in proper results for insert and no box can be left empty!");
            }
            try
            {   
                MySqlConnection connection = new MySqlConnection(connectionBuilder().ToString());
                connection.Open();
                string query = string.Format("INSERT INTO Movie (idMovie,movieName,releaseYear,lengthMinutes) VALUES(LAST_INSERT_ID(),\"{0}\",\"{1}\",\"{2}\")", movieAddName.Text.ToString(),movieAddYear.Text.ToString(),movieAddLength.Text.ToString());
                MySqlCommand sqlCmd = new MySqlCommand(query,connection);
                sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void directorADDSubmit_Click(object sender, EventArgs e)//need to check the query and make sure it adds properly!!!!!
        {
            if (string.IsNullOrEmpty(directorADDFName.Text) == true || string.IsNullOrEmpty(directorAddLName.Text) == true || string.IsNullOrEmpty(directorADDBday.Text) == true)
            {
                MessageBox.Show("Must equal in proper results for insert and no box can be left empty!");
            }
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionBuilder().ToString());
                connection.Open();
                string query = string.Format("INSERT INTO Director (idDirector,fName,lName,birthday) VALUES(LAST_INSERT_ID(),\"{0}\",\"{1}\",{2})", directorADDFName.Text.ToString(), directorADDlnametxt.Text.ToString(), directorADDBday.Text.ToString());
                MySqlCommand sqlCmd = new MySqlCommand(query, connection);
                sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
