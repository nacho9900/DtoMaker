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
            for (int i = 0; i < ColumnsCLB.Items.Count; i++)
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
            string usings = "using System;" +
                Environment.NewLine + "using System.Collections.Generic;" +
                Environment.NewLine + "using System.Linq;" +
                Environment.NewLine + "using System.Text;" +
                Environment.NewLine + "using System.Threading.Tasks;" +
                Environment.NewLine;

            string classString = string.Format("{0}" +  
                Environment.NewLine + "namespace {1}" +
                Environment.NewLine + "{{" + 
                Environment.NewLine + "\tpublic class {2}" +
                Environment.NewLine + "\t{{" +
                Environment.NewLine, usings , string.IsNullOrWhiteSpace(NamespaceTB.Text) ? "NachoDTOMaker" : NamespaceTB.Text,
                string.IsNullOrWhiteSpace(ClassNameTB.Text) ? table : ClassNameTB.Text);

            using (SqlCommand cmd = new SqlCommand(string.Format(@"SELECT COLUMN_NAME,DATA_TYPE
                                                    FROM INFORMATION_SCHEMA.COLUMNS
                                                    WHERE TABLE_NAME = '{0}'", table), conn))
            {
                string type;

                using (IDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        if (ColumnsCLB.CheckedItems.Contains(dr[0].ToString()))
                        {
                            switch (dr[1].ToString())
                            {
                                case "bigint": type = "long"; break;
                                case "binary": type = "byte[]"; break;
                                case "bit": type = "bool"; break;
                                case "char": type = "string"; break;
                                case "datetime": type = "DateTime"; break;
                                case "datetime2": type = "DateTime"; break;
                                case "datetimeoffset": type = "DateTimeOffset"; break;
                                case "decimal": type = "decimal"; break;
                                case "filestream": type = "byte[]"; break;
                                case "float": type = "double"; break;
                                case "geography": type = "Microsoft.SqlServer.Types.SqlGeography"; break;
                                case "geometry": type = "Microsoft.SqlServer.Types.SqlGeometry"; break;
                                case "hierarchyid": type = "Microsoft.SqlServer.Types.SqlHierarchyId"; break;
                                case "image": type = "byte[]"; break;
                                case "int": type = "int"; break;
                                case "money": type = "decimal"; break;
                                case "nchar": type = "string"; break;
                                case "ntext": type = "string"; break;
                                case "numeric": type = "decimal"; break;
                                case "nvarchar": type = "string"; break;
                                case "real": type = "Single"; break;
                                case "rowversion": type = "byte[]"; break;
                                case "smalldatetime": type = "DateTime"; break;
                                case "smallint": type = "short"; break;
                                case "smallmoney": type = "decimal"; break;
                                case "text": type = "string"; break;
                                case "time": type = "TimeSpan"; break;
                                case "timestamp": type = "byte[]"; break;
                                case "tinyint": type = "byte"; break;
                                case "uniqueidentifier": type = "Guid"; break;
                                case "varbinary": type = "byte[]"; break;
                                case "varchar": type = "string"; break;
                                case "xml": type = "string"; break;
                                default: type = "object"; break;
                            }

                            classString += string.Format("\t\tpublic {0} {1} {{get; set; }}" + Environment.NewLine, type, dr[0].ToString());
                        }
                    }

                    classString += "\t}" + Environment.NewLine + "}";
                }
            }

            System.IO.File.AppendAllText(Application.StartupPath + "\\" +
                (string.IsNullOrEmpty(ClassNameTB.Text) ? table : ClassNameTB.Text) + ".cs",
                classString);

            this.Close();
        }
    }
}
