namespace _101210_AH_SSOiBD
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polaczToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ąToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBilosc = new System.Windows.Forms.TextBox();
            this.tBnazwa = new System.Windows.Forms.TextBox();
            this.tBkubatura = new System.Windows.Forms.TextBox();
            this.tBlp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btDodaj = new System.Windows.Forms.Button();
            this.cbEdit = new System.Windows.Forms.CheckBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tBmin = new System.Windows.Forms.TextBox();
            this.btOrder = new System.Windows.Forms.Button();
            this.rBlp = new System.Windows.Forms.RadioButton();
            this.rBilosc = new System.Windows.Forms.RadioButton();
            this.rBnazwa = new System.Windows.Forms.RadioButton();
            this.informacjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.bazaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(642, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zamknijToolStripMenuItem,
            this.informacjeToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // bazaToolStripMenuItem
            // 
            this.bazaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.polaczToolStripMenuItem,
            this.ąToolStripMenuItem});
            this.bazaToolStripMenuItem.Name = "bazaToolStripMenuItem";
            this.bazaToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.bazaToolStripMenuItem.Text = "Baza";
            // 
            // polaczToolStripMenuItem
            // 
            this.polaczToolStripMenuItem.Name = "polaczToolStripMenuItem";
            this.polaczToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.polaczToolStripMenuItem.Text = "Ustawienia ";
            this.polaczToolStripMenuItem.Click += new System.EventHandler(this.polaczToolStripMenuItem_Click);
            // 
            // ąToolStripMenuItem
            // 
            this.ąToolStripMenuItem.Name = "ąToolStripMenuItem";
            this.ąToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.ąToolStripMenuItem.Text = "Wyświetl ";
            this.ąToolStripMenuItem.Click += new System.EventHandler(this.ąToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Yellow;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(235, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(183, 160);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "lp:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "nazwa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ilosc:";
            // 
            // tBilosc
            // 
            this.tBilosc.BackColor = System.Drawing.Color.Yellow;
            this.tBilosc.Location = new System.Drawing.Point(120, 103);
            this.tBilosc.Name = "tBilosc";
            this.tBilosc.Size = new System.Drawing.Size(100, 20);
            this.tBilosc.TabIndex = 7;
            // 
            // tBnazwa
            // 
            this.tBnazwa.BackColor = System.Drawing.Color.Yellow;
            this.tBnazwa.Location = new System.Drawing.Point(120, 77);
            this.tBnazwa.Name = "tBnazwa";
            this.tBnazwa.Size = new System.Drawing.Size(100, 20);
            this.tBnazwa.TabIndex = 8;
            // 
            // tBkubatura
            // 
            this.tBkubatura.BackColor = System.Drawing.Color.Yellow;
            this.tBkubatura.Location = new System.Drawing.Point(120, 129);
            this.tBkubatura.Name = "tBkubatura";
            this.tBkubatura.Size = new System.Drawing.Size(100, 20);
            this.tBkubatura.TabIndex = 9;
            // 
            // tBlp
            // 
            this.tBlp.BackColor = System.Drawing.Color.Yellow;
            this.tBlp.Location = new System.Drawing.Point(120, 51);
            this.tBlp.Name = "tBlp";
            this.tBlp.Size = new System.Drawing.Size(100, 20);
            this.tBlp.TabIndex = 10;
            this.tBlp.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "lp:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "nazwa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "ilosc:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "kubatura:";
            // 
            // btDodaj
            // 
            this.btDodaj.Location = new System.Drawing.Point(120, 155);
            this.btDodaj.Name = "btDodaj";
            this.btDodaj.Size = new System.Drawing.Size(100, 23);
            this.btDodaj.TabIndex = 15;
            this.btDodaj.Text = "Dodaj/edytuj";
            this.btDodaj.UseVisualStyleBackColor = true;
            this.btDodaj.Click += new System.EventHandler(this.btDodaj_Click);
            // 
            // cbEdit
            // 
            this.cbEdit.AutoSize = true;
            this.cbEdit.Location = new System.Drawing.Point(57, 161);
            this.cbEdit.Name = "cbEdit";
            this.cbEdit.Size = new System.Drawing.Size(57, 17);
            this.cbEdit.TabIndex = 16;
            this.cbEdit.Text = "edytuj ";
            this.cbEdit.UseVisualStyleBackColor = true;
            this.cbEdit.CheckedChanged += new System.EventHandler(this.cbEdit_CheckedChanged);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(120, 184);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(100, 23);
            this.btDelete.TabIndex = 17;
            this.btDelete.Text = "Usun";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(478, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Sortuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBnazwa);
            this.groupBox1.Controls.Add(this.rBilosc);
            this.groupBox1.Controls.Add(this.rBlp);
            this.groupBox1.Location = new System.Drawing.Point(478, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(93, 82);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sortuj według:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(443, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Produkty poniżej:";
            // 
            // tBmin
            // 
            this.tBmin.BackColor = System.Drawing.Color.Yellow;
            this.tBmin.Location = new System.Drawing.Point(527, 181);
            this.tBmin.Name = "tBmin";
            this.tBmin.Size = new System.Drawing.Size(68, 20);
            this.tBmin.TabIndex = 24;
            // 
            // btOrder
            // 
            this.btOrder.Location = new System.Drawing.Point(506, 207);
            this.btOrder.Name = "btOrder";
            this.btOrder.Size = new System.Drawing.Size(100, 23);
            this.btOrder.TabIndex = 25;
            this.btOrder.Text = "Wyświetl";
            this.btOrder.UseVisualStyleBackColor = true;
            this.btOrder.Click += new System.EventHandler(this.btOrder_Click);
            // 
            // rBlp
            // 
            this.rBlp.AutoSize = true;
            this.rBlp.Checked = true;
            this.rBlp.Location = new System.Drawing.Point(6, 19);
            this.rBlp.Name = "rBlp";
            this.rBlp.Size = new System.Drawing.Size(33, 17);
            this.rBlp.TabIndex = 0;
            this.rBlp.TabStop = true;
            this.rBlp.Text = "lp";
            this.rBlp.UseVisualStyleBackColor = true;
            // 
            // rBilosc
            // 
            this.rBilosc.AutoSize = true;
            this.rBilosc.Location = new System.Drawing.Point(6, 39);
            this.rBilosc.Name = "rBilosc";
            this.rBilosc.Size = new System.Drawing.Size(46, 17);
            this.rBilosc.TabIndex = 1;
            this.rBilosc.TabStop = true;
            this.rBilosc.Text = "ilosc";
            this.rBilosc.UseVisualStyleBackColor = true;
            // 
            // rBnazwa
            // 
            this.rBnazwa.AutoSize = true;
            this.rBnazwa.Location = new System.Drawing.Point(6, 58);
            this.rBnazwa.Name = "rBnazwa";
            this.rBnazwa.Size = new System.Drawing.Size(56, 17);
            this.rBnazwa.TabIndex = 2;
            this.rBnazwa.TabStop = true;
            this.rBnazwa.Text = "nazwa";
            this.rBnazwa.UseVisualStyleBackColor = true;
            // 
            // informacjeToolStripMenuItem
            // 
            this.informacjeToolStripMenuItem.Name = "informacjeToolStripMenuItem";
            this.informacjeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.informacjeToolStripMenuItem.Text = "Informacje";
            this.informacjeToolStripMenuItem.Click += new System.EventHandler(this.informacjeToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(642, 262);
            this.Controls.Add(this.btOrder);
            this.Controls.Add(this.tBmin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.cbEdit);
            this.Controls.Add(this.btDodaj);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBlp);
            this.Controls.Add(this.tBkubatura);
            this.Controls.Add(this.tBnazwa);
            this.Controls.Add(this.tBilosc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Baza danych";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBilosc;
        private System.Windows.Forms.TextBox tBnazwa;
        private System.Windows.Forms.TextBox tBkubatura;
        private System.Windows.Forms.TextBox tBlp;
        private System.Windows.Forms.ToolStripMenuItem bazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polaczToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btDodaj;
        private System.Windows.Forms.CheckBox cbEdit;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tBmin;
        private System.Windows.Forms.Button btOrder;
        private System.Windows.Forms.ToolStripMenuItem ąToolStripMenuItem;
        private System.Windows.Forms.RadioButton rBnazwa;
        private System.Windows.Forms.RadioButton rBilosc;
        private System.Windows.Forms.RadioButton rBlp;
        private System.Windows.Forms.ToolStripMenuItem informacjeToolStripMenuItem;
    }
}