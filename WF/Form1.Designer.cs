namespace WF
{
    partial class Frm1
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
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "Ly",
            "Thi Bong",
            "23456"}, -1);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "Nguyen",
            "Van Chinh",
            "4555"}, -1);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "Tran",
            "Chanh Truc",
            "123456"}, -1);
            this.lbl1 = new System.Windows.Forms.Label();
            this.lv1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbllast = new System.Windows.Forms.Label();
            this.lblFist = new System.Windows.Forms.Label();
            this.lblphone = new System.Windows.Forms.Label();
            this.txtLN = new System.Windows.Forms.TextBox();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(2, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(50, 20);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Detail";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // lv1
            // 
            this.lv1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lv1.FullRowSelect = true;
            this.lv1.GridLines = true;
            this.lv1.HideSelection = false;
            listViewItem10.StateImageIndex = 0;
            listViewItem11.StateImageIndex = 0;
            listViewItem12.StateImageIndex = 0;
            this.lv1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem10,
            listViewItem11,
            listViewItem12});
            this.lv1.Location = new System.Drawing.Point(6, 43);
            this.lv1.Name = "lv1";
            this.lv1.Size = new System.Drawing.Size(432, 225);
            this.lv1.TabIndex = 1;
            this.lv1.UseCompatibleStateImageBehavior = false;
            this.lv1.View = System.Windows.Forms.View.Details;
            this.lv1.SelectedIndexChanged += new System.EventHandler(this.lv1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Last Name";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fist Name";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Phone";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // lbllast
            // 
            this.lbllast.AutoSize = true;
            this.lbllast.Location = new System.Drawing.Point(470, 43);
            this.lbllast.Name = "lbllast";
            this.lbllast.Size = new System.Drawing.Size(86, 20);
            this.lbllast.TabIndex = 2;
            this.lbllast.Text = "Last Name";
            // 
            // lblFist
            // 
            this.lblFist.AutoSize = true;
            this.lblFist.Location = new System.Drawing.Point(470, 111);
            this.lblFist.Name = "lblFist";
            this.lblFist.Size = new System.Drawing.Size(81, 20);
            this.lblFist.TabIndex = 3;
            this.lblFist.Text = "Fist Name";
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Location = new System.Drawing.Point(470, 172);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(55, 20);
            this.lblphone.TabIndex = 4;
            this.lblphone.Text = "Phone";
            // 
            // txtLN
            // 
            this.txtLN.Location = new System.Drawing.Point(474, 66);
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(294, 26);
            this.txtLN.TabIndex = 5;
            this.txtLN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(474, 134);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(294, 26);
            this.txtFN.TabIndex = 6;
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(474, 195);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(294, 26);
            this.txtP.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(488, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 54);
            this.button1.TabIndex = 8;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(584, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 54);
            this.button2.TabIndex = 9;
            this.button2.Text = "Xoá";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(684, 232);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 54);
            this.button3.TabIndex = 10;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.txtFN);
            this.Controls.Add(this.txtLN);
            this.Controls.Add(this.lblphone);
            this.Controls.Add(this.lblFist);
            this.Controls.Add(this.lbllast);
            this.Controls.Add(this.lv1);
            this.Controls.Add(this.lbl1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Frm1";
            this.Text = "ListView Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ListView lv1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label lbllast;
        private System.Windows.Forms.Label lblFist;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.TextBox txtLN;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

