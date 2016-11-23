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
        public string useridName{ get; set; }
        public string passwordName { get; set; }
        public string databaseName { get; set; }
       // MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        //MySqlConnection connection = new MySqlConnection();*/
        public BanthaFodderGui()
        {
            InitializeComponent();
            movieAddBoxes(settings.OFF);

        }

        private void movieAddBoxes(settings x)
        {
            if(x == settings.ON)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
            }
            else
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
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
            if(LoginServerName == null || useridName == null || passwordName == null || databaseName == null)
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            if(connection.State == ConnectionState.Open)
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
            if(AddComboBox.Text == "Movie")
            {
                //needs to set visibilty for textbox to allow data input / submit button / labels
                movieAddBoxes(settings.ON);
            }
            else if(AddComboBox.Text == "Director")
            {

            }
             else if(AddComboBox.Text == "Actor")
            {

            }
            else if(AddComboBox.Text == "Character")
            {

            }
            else if(AddComboBox.Text == "Planet")
            {

            }
            else if(AddComboBox.Text == "Pilot")
            {

            }
            //Need to add rest of tables
        }
    }
}
