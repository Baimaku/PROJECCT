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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LOGIN_FORM_PRESENTATION
{
    public partial class Voting : Form
    {
        public Voting()
            {
            InitializeComponent();

            
 
            voteBox.SelectedIndexChanged += voteBox_SelectedIndexChanged; 
            }

        private void VINCE_Click(object sender, EventArgs e)
        {

        }

        private void closeButt_Click(object sender, EventArgs e)
        {
            

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void voteBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            switch ( voteBox.SelectedItem.ToString() )
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
                }
             
            }

      

        private void VOTEBTN_Click(object sender, EventArgs e)
        {
            try
                {
                string conn = "datasource=localhost;database=login;port=3306;SSLMode=none;username=root;password=; ";
                string query = "insert into votersdata (president ,votecount) values('"+voteBox.SelectedItem.ToString()+"','"+"1"+"')";
                MySqlConnection connection = new MySqlConnection(conn);
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader;
                try
                    {
                    connection.Open();
                    reader = command.ExecuteReader();
                    connection.Close();
                    CustomMessageBox customMessage = new CustomMessageBox("Voted");
                    customMessage.ShowDialog();
                    _7_Voting v7 = new _7_Voting();
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

        private void Voting_Load(object sender, EventArgs e)
        {
        /*KUYS MARK LAGAY KA LANG NENTO OR GAWA KA PA NANG IBANG FORM KUNG PAPANO YUNG BOTOHAN GAYAHIN MO LANG TOH*/
        //SIGE BOSS BASTA KANTUTIN MUNA KITA
            voteBox.Items.Add("OFFICIAL 1");
            voteBox.Items.Add("OFFICIAL 2");
            voteBox.Items.Add("OFFICIAL 3");
            }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void IAN_Click(object sender, EventArgs e)
        {

        }

        private void MARK_Click(object sender, EventArgs e)
        {

        }

        private void JAKE_Click(object sender, EventArgs e)
        {

        }

        private void IMOT_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e)
        {
            
        }
    }
}
