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


    public partial class BanthaFodderGui : Form
    {   //need to create login class / method and write unit tests
        public string LoginServerName { get; set; }
        public string useridName{ get; set; }
        public string passwordName { get; set; }
        public string databaseName { get; set; }

        public BanthaFodderGui()
        {
            InitializeComponent();
          
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
            /* MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
             builder.Server = "localhost";
             builder.UserID = "root";
             builder.Password = "skiutah1982";
             builder.Database = "mydb";
             MySqlConnection connection = new MySqlConnection(builder.ToString());
             string sql = "SELECT * FROM planet";
             try
             {
                 connection.Open();


                 MySqlDataAdapter adp = new MySqlDataAdapter(sql, connection);
                 MySqlCommandBuilder cmd = new MySqlCommandBuilder(adp);
                 DataTable record = new DataTable();

                 adp.Fill(record);
                 PlanetDataGrid.ReadOnly = true;
                 PlanetDataGrid.DataSource = record.DefaultView;

                 connection.Close();
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.ToString());

             }*/
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            if(LoginServerName == null || useridName == null || passwordName == null || databaseName == null)
            {
                MessageBox.Show("You have not logged in with the right creditentials please re-login");
            }
            builder.Server = LoginServerName;
            builder.UserID = useridName;
            builder.Password = passwordName;
            builder.Database = databaseName;
            MySqlConnection connection = new MySqlConnection(builder.ToString());
            MySqlCommand sqlCmd = new MySqlCommand();
            sqlCmd.Connection = connection;
            sqlCmd.CommandType = CommandType.Text;

            if (!string.IsNullOrEmpty(PlanetIdTxt.Text) && string.IsNullOrEmpty(ClimateTxt.Text) && string.IsNullOrEmpty(PlanetNameTxt.Text))
            {
                sqlCmd.CommandText = "Select * from planet where idPlanet =" + PlanetIdTxt.Text;
            }
            else if (string.IsNullOrEmpty(PlanetIdTxt.Text) && !string.IsNullOrEmpty(ClimateTxt.Text) && string.IsNullOrEmpty(PlanetNameTxt.Text))
            {
                sqlCmd.CommandText = string.Format("Select * from planet where climate = \"{0}\"", ClimateTxt.Text);
            }
            else if (string.IsNullOrEmpty(PlanetIdTxt.Text) && string.IsNullOrEmpty(ClimateTxt.Text) && !string.IsNullOrEmpty(PlanetNameTxt.Text))
            {
                sqlCmd.CommandText = string.Format("Select * from planet where name = \"{0}\"", PlanetNameTxt.Text);
            }
            else if (!string.IsNullOrEmpty(PlanetIdTxt.Text) && !string.IsNullOrEmpty(ClimateTxt.Text) && string.IsNullOrEmpty(PlanetNameTxt.Text))
            {
                sqlCmd.CommandText = string.Format("Select * from planet where idPlanet = {0} and climate = \"{1}\"", PlanetIdTxt.Text, ClimateTxt.Text);
            }
            else if (!string.IsNullOrEmpty(PlanetIdTxt.Text) && string.IsNullOrEmpty(ClimateTxt.Text) && !string.IsNullOrEmpty(PlanetNameTxt.Text))
            {
                sqlCmd.CommandText = string.Format("Select * from planet where idPlanet = {0} and name = \"{1}\"", PlanetIdTxt.Text, PlanetNameTxt.Text);
            }
            else if (!string.IsNullOrEmpty(PlanetIdTxt.Text) && !string.IsNullOrEmpty(ClimateTxt.Text) && string.IsNullOrEmpty(PlanetNameTxt.Text))
            {
                sqlCmd.CommandText = string.Format("Select * from planet where idPlanet = {0} and climate = \"{1}\"", PlanetIdTxt.Text, ClimateTxt.Text);
            }
            else if (string.IsNullOrEmpty(PlanetIdTxt.Text) && !string.IsNullOrEmpty(ClimateTxt.Text) && !string.IsNullOrEmpty(PlanetNameTxt.Text))
            {
                sqlCmd.CommandText = string.Format("Select * from planet where climate = \"{0}\" and name = \"{1}\"", ClimateTxt.Text, PlanetNameTxt.Text);
            }
            else if (!string.IsNullOrEmpty(PlanetIdTxt.Text) && !string.IsNullOrEmpty(ClimateTxt.Text) && !string.IsNullOrEmpty(PlanetNameTxt.Text))
            {
                sqlCmd.CommandText = string.Format("Select * from planet where idPlanet = {0} and climate = \"{1}\" and name = \"{2}\" ", PlanetIdTxt.Text, ClimateTxt.Text, PlanetNameTxt.Text);
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
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = LoginServerName;
            builder.UserID = useridName;
            builder.Password = passwordName;
            builder.Database = databaseName;
            MySqlConnection connection = new MySqlConnection(builder.ToString());
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
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = LoginServerName;
                builder.UserID = useridName;
                builder.Password = passwordName;
                builder.Database = databaseName;
                MySqlConnection connection = new MySqlConnection(builder.ToString());
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
    }

        private void MovieComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ActorSubmitBtn_Click(object sender, EventArgs e)
        {
            //Need to mimic Planet class but for Actor

        }
    }
}
