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
    public partial class SelectDatabaseFRM : Form
    {
        private readonly SqlConnection conn;
        private List<string> databases = new List<string>();
        private string selectedDb;
        private List<string> tables = new List<string>();
        private List<string> tablesFiltered = new List<string>();

        private bool first = true;


        public SelectDatabaseFRM(SqlConnection conn)
        {
            this.conn = conn ?? throw new ArgumentNullException(nameof(conn));

            InitializeComponent();
        }

        private void CreateBT_Click(object sender, EventArgs e)
        {
            
        }

        private void SelectDatabaseFRM_Shown(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases;", conn))
            {
                using (IDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        databases.Add(dr[0].ToString());
                    }
                }
            }

            DatabasesCBX.DataSource = databases;
        }

        private void DatabasesCBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!first)
            {
                ComboBox cb = sender as ComboBox;
                selectedDb = cb.SelectedValue.ToString();
                TablesCBX.Enabled = true;
                FilterTB.Enabled = true;
                tables.Clear();

                using (SqlCommand cmd = new SqlCommand("SELECT name from sys.tables;", conn))
                {
                    conn.ChangeDatabase(selectedDb);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            tables.Add(dr[0].ToString());
                        }
                    }
                }

                if (tables.Count > 0)
                {
                    NextBT.Enabled = true;
                }

                TablesCBX.DataSource = tables;
            }
            else
            {
                first = false;
            }
        }

        private void FilterTB_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;

            tablesFiltered = tables.Where(x => x.ToUpper().Contains(tb.Text.ToUpper())).ToList();

            if (tablesFiltered.Count == 0)
            {
                NextBT.Enabled = false;
                TablesCBX.Enabled = false;
            }
            else
            {
                NextBT.Enabled = true;
                TablesCBX.Enabled = true;
                TablesCBX.DataSource = tablesFiltered;
            }
        }

        private void NextBT_Click(object sender, EventArgs e)
        {
            CreateDTOFRM createDTOFRM = new CreateDTOFRM(conn, TablesCBX.SelectedValue.ToString());
            createDTOFRM.Activated += new EventHandler(createDTOFRM_Activated);
            createDTOFRM.FormClosed += new FormClosedEventHandler(createDTOFRM_FormClosed);
            createDTOFRM.Show();
        }

        private void createDTOFRM_Activated(object sender, EventArgs e)
        {
            this.Enabled = false; 
        }

        private void createDTOFRM_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true; // Closes Form1 and remove this time from Memory
        }

        private void SelectDatabaseFRM_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
            Application.Exit();
        }
    }
}
