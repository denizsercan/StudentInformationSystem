namespace StudentInformationSystem
{
    partial class GpaCalculator
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
            this.myListView1 = new MyControl.MyListView();
            this.Course_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Course_Desc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbListViewCombo = new System.Windows.Forms.ComboBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnSil = new System.Windows.Forms.Button();
            this.BtnRef = new System.Windows.Forms.Button();
            this.btnAvg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myListView1
            // 
            this.myListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Course_ID,
            this.Course_Desc,
            this.columnHeader1});
            this.myListView1.Location = new System.Drawing.Point(120, 62);
            this.myListView1.Name = "myListView1";
            this.myListView1.Size = new System.Drawing.Size(484, 309);
            this.myListView1.TabIndex = 0;
            this.myListView1.UseCompatibleStateImageBehavior = false;
            this.myListView1.View = System.Windows.Forms.View.Details;
            this.myListView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.myListView1_MouseUp);
            // 
            // Course_ID
            // 
            this.Course_ID.Text = "Grade";
            this.Course_ID.Width = 50;
            // 
            // Course_Desc
            // 
            this.Course_Desc.Text = "Credit";
            this.Course_Desc.Width = 200;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Course_Name";
            this.columnHeader1.Width = 50;
            // 
            // cbListViewCombo
            // 
            this.cbListViewCombo.FormattingEnabled = true;
            this.cbListViewCombo.Location = new System.Drawing.Point(131, 35);
            this.cbListViewCombo.Name = "cbListViewCombo";
            this.cbListViewCombo.Size = new System.Drawing.Size(350, 21);
            this.cbListViewCombo.TabIndex = 1;
            this.cbListViewCombo.Visible = false;
            this.cbListViewCombo.SelectedValueChanged += new System.EventHandler(this.cbListViewCombo_SelectedValueChanged);
            this.cbListViewCombo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbListViewCombo_KeyPress);
            this.cbListViewCombo.Leave += new System.EventHandler(this.cbListViewCombo_Leave);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(21, 89);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 52);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // BtnRef
            // 
            this.BtnRef.Location = new System.Drawing.Point(21, 158);
            this.BtnRef.Name = "BtnRef";
            this.BtnRef.Size = new System.Drawing.Size(75, 49);
            this.BtnRef.TabIndex = 3;
            this.BtnRef.Text = "Yenile";
            this.BtnRef.UseVisualStyleBackColor = true;
            this.BtnRef.Click += new System.EventHandler(this.BtnRef_Click);
            // 
            // btnAvg
            // 
            this.btnAvg.Location = new System.Drawing.Point(21, 227);
            this.btnAvg.Name = "btnAvg";
            this.btnAvg.Size = new System.Drawing.Size(75, 46);
            this.btnAvg.TabIndex = 4;
            this.btnAvg.Text = "Ortalama  Hesapla";
            this.btnAvg.UseVisualStyleBackColor = true;
            this.btnAvg.Click += new System.EventHandler(this.btnAvg_Click);
            // 
            // NotHesaplama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 454);
            this.Controls.Add(this.btnAvg);
            this.Controls.Add(this.BtnRef);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.cbListViewCombo);
            this.Controls.Add(this.myListView1);
            this.Name = "NotHesaplama";
            this.Text = "NotHesaplama";
            this.Load += new System.EventHandler(this.NotHesaplama_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MyControl.MyListView myListView1;
        private System.Windows.Forms.ComboBox cbListViewCombo;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColumnHeader Course_ID;
        private System.Windows.Forms.ColumnHeader Course_Desc;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button BtnRef;
        private System.Windows.Forms.Button btnAvg;
    }
}