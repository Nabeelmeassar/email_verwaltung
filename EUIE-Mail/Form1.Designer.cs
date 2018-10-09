namespace EUIE_Mail
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.einfügen = new System.Windows.Forms.Button();
            this.txtNameStudent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatriNrStudent = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRoomNr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNameProf = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnlöschen = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // einfügen
            // 
            this.einfügen.Location = new System.Drawing.Point(46, 136);
            this.einfügen.Name = "einfügen";
            this.einfügen.Size = new System.Drawing.Size(109, 23);
            this.einfügen.TabIndex = 0;
            this.einfügen.Text = "Student einfügen";
            this.einfügen.UseVisualStyleBackColor = true;
            this.einfügen.Click += new System.EventHandler(this.einfügen_Click);
            // 
            // txtNameStudent
            // 
            this.txtNameStudent.Location = new System.Drawing.Point(82, 25);
            this.txtNameStudent.Name = "txtNameStudent";
            this.txtNameStudent.Size = new System.Drawing.Size(100, 20);
            this.txtNameStudent.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "MatriNr";
            // 
            // txtMatriNrStudent
            // 
            this.txtMatriNrStudent.Location = new System.Drawing.Point(82, 74);
            this.txtMatriNrStudent.Name = "txtMatriNrStudent";
            this.txtMatriNrStudent.Size = new System.Drawing.Size(100, 20);
            this.txtMatriNrStudent.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMatriNrStudent);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNameStudent);
            this.groupBox1.Location = new System.Drawing.Point(46, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtRoomNr);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNameProf);
            this.groupBox2.Location = new System.Drawing.Point(527, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Professor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // txtRoomNr
            // 
            this.txtRoomNr.Location = new System.Drawing.Point(82, 74);
            this.txtRoomNr.Name = "txtRoomNr";
            this.txtRoomNr.Size = new System.Drawing.Size(100, 20);
            this.txtRoomNr.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Room Nr";
            // 
            // txtNameProf
            // 
            this.txtNameProf.Location = new System.Drawing.Point(82, 25);
            this.txtNameProf.Name = "txtNameProf";
            this.txtNameProf.Size = new System.Drawing.Size(100, 20);
            this.txtNameProf.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(33, 213);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(455, 433);
            this.listBox1.TabIndex = 7;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(527, 200);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(473, 446);
            this.listBox2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(527, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Professor einfügen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnlöschen
            // 
            this.btnlöschen.Location = new System.Drawing.Point(46, 165);
            this.btnlöschen.Name = "btnlöschen";
            this.btnlöschen.Size = new System.Drawing.Size(157, 23);
            this.btnlöschen.TabIndex = 10;
            this.btnlöschen.Text = "Löschen markierte Student";
            this.btnlöschen.UseVisualStyleBackColor = true;
            this.btnlöschen.Click += new System.EventHandler(this.btnlöschen_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(527, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Löschen markierte Professor";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 684);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnlöschen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.einfügen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button einfügen;
        private System.Windows.Forms.TextBox txtNameStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatriNrStudent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRoomNr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNameProf;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnlöschen;
        private System.Windows.Forms.Button button2;
    }
}

