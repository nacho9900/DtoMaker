namespace NachoDTOMaker
{
    partial class SelectDatabaseFRM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.DatabasesCBX = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TablesCBX = new System.Windows.Forms.ComboBox();
            this.FilterTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NextBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select database";
            // 
            // DatabasesCBX
            // 
            this.DatabasesCBX.FormattingEnabled = true;
            this.DatabasesCBX.Location = new System.Drawing.Point(13, 37);
            this.DatabasesCBX.Name = "DatabasesCBX";
            this.DatabasesCBX.Size = new System.Drawing.Size(436, 28);
            this.DatabasesCBX.TabIndex = 1;
            this.DatabasesCBX.SelectedIndexChanged += new System.EventHandler(this.DatabasesCBX_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select table";
            // 
            // TablesCBX
            // 
            this.TablesCBX.Enabled = false;
            this.TablesCBX.FormattingEnabled = true;
            this.TablesCBX.Location = new System.Drawing.Point(12, 95);
            this.TablesCBX.Name = "TablesCBX";
            this.TablesCBX.Size = new System.Drawing.Size(259, 28);
            this.TablesCBX.TabIndex = 3;
            // 
            // FilterTB
            // 
            this.FilterTB.Enabled = false;
            this.FilterTB.Location = new System.Drawing.Point(278, 97);
            this.FilterTB.Name = "FilterTB";
            this.FilterTB.Size = new System.Drawing.Size(171, 26);
            this.FilterTB.TabIndex = 4;
            this.FilterTB.TextChanged += new System.EventHandler(this.FilterTB_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Filter";
            // 
            // NextBT
            // 
            this.NextBT.Enabled = false;
            this.NextBT.Location = new System.Drawing.Point(17, 141);
            this.NextBT.Name = "NextBT";
            this.NextBT.Size = new System.Drawing.Size(432, 30);
            this.NextBT.TabIndex = 6;
            this.NextBT.Text = "Next >";
            this.NextBT.UseVisualStyleBackColor = true;
            this.NextBT.Click += new System.EventHandler(this.NextBT_Click);
            // 
            // SelectDatabaseFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 183);
            this.Controls.Add(this.NextBT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FilterTB);
            this.Controls.Add(this.TablesCBX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DatabasesCBX);
            this.Controls.Add(this.label1);
            this.Name = "SelectDatabaseFRM";
            this.Text = "Select Database";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectDatabaseFRM_FormClosing);
            this.Shown += new System.EventHandler(this.SelectDatabaseFRM_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DatabasesCBX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TablesCBX;
        private System.Windows.Forms.TextBox FilterTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button NextBT;
    }
}