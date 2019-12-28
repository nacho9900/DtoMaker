namespace NachoDTOMaker
{
    partial class CreateDTOFRM
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
            this.ColumnsCLB = new System.Windows.Forms.CheckedListBox();
            this.CancelBT = new System.Windows.Forms.Button();
            this.CreateBT = new System.Windows.Forms.Button();
            this.SelectAllBT = new System.Windows.Forms.Button();
            this.ClearBT = new System.Windows.Forms.Button();
            this.ClassNameTB = new System.Windows.Forms.TextBox();
            this.NamespaceTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ColumnsCLB
            // 
            this.ColumnsCLB.CheckOnClick = true;
            this.ColumnsCLB.FormattingEnabled = true;
            this.ColumnsCLB.Location = new System.Drawing.Point(13, 114);
            this.ColumnsCLB.MultiColumn = true;
            this.ColumnsCLB.Name = "ColumnsCLB";
            this.ColumnsCLB.Size = new System.Drawing.Size(776, 349);
            this.ColumnsCLB.TabIndex = 0;
            this.ColumnsCLB.SelectedIndexChanged += new System.EventHandler(this.ColumnsCLB_SelectedIndexChanged);
            // 
            // CancelBT
            // 
            this.CancelBT.Location = new System.Drawing.Point(12, 469);
            this.CancelBT.Name = "CancelBT";
            this.CancelBT.Size = new System.Drawing.Size(376, 30);
            this.CancelBT.TabIndex = 2;
            this.CancelBT.Text = "Cancel";
            this.CancelBT.UseVisualStyleBackColor = true;
            // 
            // CreateBT
            // 
            this.CreateBT.Enabled = false;
            this.CreateBT.Location = new System.Drawing.Point(394, 469);
            this.CreateBT.Name = "CreateBT";
            this.CreateBT.Size = new System.Drawing.Size(393, 30);
            this.CreateBT.TabIndex = 3;
            this.CreateBT.Text = "Create";
            this.CreateBT.UseVisualStyleBackColor = true;
            this.CreateBT.Click += new System.EventHandler(this.CreateBT_Click);
            // 
            // SelectAllBT
            // 
            this.SelectAllBT.Location = new System.Drawing.Point(411, 78);
            this.SelectAllBT.Name = "SelectAllBT";
            this.SelectAllBT.Size = new System.Drawing.Size(376, 30);
            this.SelectAllBT.TabIndex = 4;
            this.SelectAllBT.Text = "Select All";
            this.SelectAllBT.UseVisualStyleBackColor = true;
            this.SelectAllBT.Click += new System.EventHandler(this.SelectAllBT_Click);
            // 
            // ClearBT
            // 
            this.ClearBT.Location = new System.Drawing.Point(13, 78);
            this.ClearBT.Name = "ClearBT";
            this.ClearBT.Size = new System.Drawing.Size(376, 30);
            this.ClearBT.TabIndex = 5;
            this.ClearBT.Text = "Clear All";
            this.ClearBT.UseVisualStyleBackColor = true;
            this.ClearBT.Click += new System.EventHandler(this.ClearBT_Click);
            // 
            // ClassNameTB
            // 
            this.ClassNameTB.Location = new System.Drawing.Point(13, 46);
            this.ClassNameTB.Name = "ClassNameTB";
            this.ClassNameTB.Size = new System.Drawing.Size(376, 26);
            this.ClassNameTB.TabIndex = 6;
            // 
            // NamespaceTB
            // 
            this.NamespaceTB.Location = new System.Drawing.Point(411, 46);
            this.NamespaceTB.Name = "NamespaceTB";
            this.NamespaceTB.Size = new System.Drawing.Size(376, 26);
            this.NamespaceTB.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Class name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Namespace";
            // 
            // CreateDTOFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NamespaceTB);
            this.Controls.Add(this.ClassNameTB);
            this.Controls.Add(this.ClearBT);
            this.Controls.Add(this.SelectAllBT);
            this.Controls.Add(this.CreateBT);
            this.Controls.Add(this.CancelBT);
            this.Controls.Add(this.ColumnsCLB);
            this.Name = "CreateDTOFRM";
            this.Text = "CreateDTOFRM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ColumnsCLB;
        private System.Windows.Forms.Button CancelBT;
        private System.Windows.Forms.Button CreateBT;
        private System.Windows.Forms.Button SelectAllBT;
        private System.Windows.Forms.Button ClearBT;
        private System.Windows.Forms.TextBox ClassNameTB;
        private System.Windows.Forms.TextBox NamespaceTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}