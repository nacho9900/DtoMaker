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
    public partial class CreateDTOFRM : Form
    {
        private readonly SqlConnection conn;
        private List<string> columns = new List<string>();
        private string table;

        public CreateDTOFRM(SqlConnection conn, string table)
        {
            if (string.IsNullOrWhiteSpace(table))
            {
                throw new ArgumentException("table not selected", nameof(table));
            }

            InitializeComponent();
            this.conn = conn ?? throw new ArgumentNullException(nameof(conn));
            this.table = table;

            using (SqlCommand cmd = new SqlCommand(string.Format(@"SELECT COLUMN_NAME,DATA_TYPE
                                                    FROM INFORMATION_SCHEMA.COLUMNS
                                                    WHERE TABLE_NAME = '{0}'", table), conn))
            {
                using (IDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        columns.Add(dr[0].ToString());
                    }
                }
            }

            ColumnsCLB.Items.AddRange(columns.ToArray());
        }

        private void SelectAllBT_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < ColumnsCLB.Items.Count; i++)
            {
                ColumnsCLB.SetItemChecked(i, true);
            }

            ColumnsCLB.SelectedIndex = 0;
        }

        private void ColumnsCLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ColumnsCLB.CheckedItems.Count > 0)
            {
                CreateBT.Enabled = true;
            }
            else
            {
                CreateBT.Enabled = false;
            }
        }

        private void ClearBT_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ColumnsCLB.Items.Count; i++)
            {
                ColumnsCLB.SetItemChecked(i, false);
            }

            ColumnsCLB.SelectedIndex = 0;
        }

        private void CreateBT_Click(object sender, EventArgs e)
        {
            System.IO.File.AppendAllText(Application.StartupPath + "\\" +
                (string.IsNullOrEmpty(ClassNameTB.Text)? table : ClassNameTB.Text) + ".cs",
                "lalala");

            this.Close();
        }
    }
}
