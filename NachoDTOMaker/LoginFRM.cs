using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NachoDTOMaker
{
    public partial class LoginFRM : Form
    {
        public LoginFRM()
        {
            InitializeComponent();
        }

        private void ConnectBT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ServerTB.Text) ||
                string.IsNullOrWhiteSpace(UserTB.Text) ||
                string.IsNullOrWhiteSpace(PasswordTB.Text))
            {
                ErrorLB.Text = "Debe llenar todos los campos";
            }

            string connString = string.Format(string.Format("Data Source={0};User ID={1};Password={2};",
                    ServerTB.Text, UserTB.Text, PasswordTB.Text));

            bool ok = true;

            SqlConnection conn = new SqlConnection(connString);
            
            try
            {
                conn.Open();

                SelectDatabaseFRM selectDatabaseFRM = new SelectDatabaseFRM(conn);
                selectDatabaseFRM.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                ErrorLB.Text = ex.Message;
                ok = false;
                conn.Dispose();
            }

        }

        private void LoginFRM_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
