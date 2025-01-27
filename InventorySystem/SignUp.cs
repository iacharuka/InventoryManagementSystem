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
using System.Security.Cryptography;

namespace InventorySystemCsharp
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (bunifuMetroTextbox1.Text!=""&&bunifuMetroTextbox2.Text!=""&& bunifuMetroTextbox3.Text!="" && bunifuMetroTextbox4.Text!="" && bunifuMetroTextbox5.Text!="" && bunifuMetroTextbox6.Text!="")
            {
                if (bunifuMetroTextbox5.Text == bunifuMetroTextbox6.Text)
                {
                   
                }
                else
                {
                    MessageBox.Show("Passwords doesn't match");
                }
            }
            else
                MessageBox.Show("Fill all fields");
            

            
        }
        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
