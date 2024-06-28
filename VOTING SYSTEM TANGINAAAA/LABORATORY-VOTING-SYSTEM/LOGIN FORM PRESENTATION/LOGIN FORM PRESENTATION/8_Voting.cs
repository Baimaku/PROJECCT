using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIN_FORM_PRESENTATION
{
    public partial class _8_Voting : Form
    {
        public _8_Voting()
        {
            InitializeComponent();

            voteBox.SelectedIndexChanged += voteBox_SelectedIndexChanged;

        }

        private void _8_Voting_Load(object sender, EventArgs e)
        {
            voteBox.Items.Add("OFFICIAL 1");
            voteBox.Items.Add("OFFICIAL 2");
            voteBox.Items.Add("OFFICIAL 3");
            voteBox.Items.Add("OFFICIAL 4");
            voteBox.Items.Add("OFFICIAL 5");

        }

        private void voteBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (voteBox.SelectedItem.ToString())
            {
                case "OFFICIAL 1":
                    CD1.BringToFront();
                    break;
                case "OFFICIAL 2":
                    CD2.BringToFront();
                    break;
                case "OFFICIAL 3":
                    CD3.BringToFront();
                    break;
                case "OFFICIAL 4":
                    CD4.BringToFront();
                    break;
                case "OFFICIAL 5":
                    CD5.BringToFront();
                    break;

            }

        }

        private void VOTEBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string conn = "datasource=localhost;database=login;port=3306;SSLMode=none;username=root;password=; ";
                string query = "insert into votersdata (secretary ,votecount) values('" + voteBox.SelectedItem.ToString() + "','" + "1" + "')";
                MySqlConnection connection = new MySqlConnection(conn);
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader;
                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    connection.Close();
                    CustomMessageBox customMessage = new CustomMessageBox("Thanks For Voting!");
                    customMessage.ShowDialog();
                    Login_Form v7 = new Login_Form();
                    v7.Show();
                    this.Hide();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
