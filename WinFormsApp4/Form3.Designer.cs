namespace WinFormsApp4
{
    partial class Form3
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
            panel2 = new Panel();
            textBoxTAGE = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            clearbtn = new Button();
            label6 = new Label();
            textBoxtCoach = new TextBox();
            subTbtn = new Button();
            textBoxTname = new TextBox();
            label3 = new Label();
            comboBoxTID = new ComboBox();
            label1 = new Label();
            label5 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(textBoxTAGE);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(clearbtn);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBoxtCoach);
            panel2.Controls.Add(subTbtn);
            panel2.Controls.Add(textBoxTname);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(comboBoxTID);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(60, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(720, 531);
            panel2.TabIndex = 26;
            // 
            // textBoxTAGE
            // 
            textBoxTAGE.Location = new Point(205, 211);
            textBoxTAGE.Name = "textBoxTAGE";
            textBoxTAGE.Size = new Size(300, 23);
            textBoxTAGE.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.ForeColor = Color.FromArgb(16, 30, 41);
            label2.Location = new Point(123, 211);
            label2.Name = "label2";
            label2.Size = new Size(66, 17);
            label2.TabIndex = 25;
            label2.Text = "Team Age";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Location = new Point(28, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 1);
            panel1.TabIndex = 17;
            // 
            // clearbtn
            // 
            clearbtn.AutoEllipsis = true;
            clearbtn.BackColor = Color.Transparent;
            clearbtn.FlatAppearance.BorderSize = 0;
            clearbtn.FlatAppearance.MouseDownBackColor = Color.Silver;
            clearbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            clearbtn.FlatStyle = FlatStyle.Flat;
            clearbtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            clearbtn.ForeColor = Color.FromArgb(6, 30, 41);
            clearbtn.ImageAlign = ContentAlignment.MiddleLeft;
            clearbtn.Location = new Point(233, 426);
            clearbtn.Name = "clearbtn";
            clearbtn.Size = new Size(86, 32);
            clearbtn.TabIndex = 24;
            clearbtn.Text = "clear";
            clearbtn.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(16, 30, 41);
            label6.Location = new Point(282, 44);
            label6.Name = "label6";
            label6.Size = new Size(170, 21);
            label6.TabIndex = 14;
            label6.Text = "TEAM REGISTRATION";
            // 
            // textBoxtCoach
            // 
            textBoxtCoach.Location = new Point(205, 168);
            textBoxtCoach.Name = "textBoxtCoach";
            textBoxtCoach.Size = new Size(300, 23);
            textBoxtCoach.TabIndex = 20;
            // 
            // subTbtn
            // 
            subTbtn.BackColor = Color.FromArgb(16, 30, 41);
            subTbtn.FlatStyle = FlatStyle.Flat;
            subTbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subTbtn.ForeColor = Color.White;
            subTbtn.Location = new Point(410, 427);
            subTbtn.Name = "subTbtn";
            subTbtn.Size = new Size(123, 35);
            subTbtn.TabIndex = 16;
            subTbtn.Text = "Submit Team";
            subTbtn.UseVisualStyleBackColor = false;
            // 
            // textBoxTname
            // 
            textBoxTname.Location = new Point(205, 118);
            textBoxTname.Name = "textBoxTname";
            textBoxTname.Size = new Size(300, 23);
            textBoxTname.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.ForeColor = Color.FromArgb(16, 30, 41);
            label3.Location = new Point(110, 169);
            label3.Name = "label3";
            label3.Size = new Size(79, 17);
            label3.TabIndex = 10;
            label3.Text = "Team Coach";
            // 
            // comboBoxTID
            // 
            comboBoxTID.FormattingEnabled = true;
            comboBoxTID.Location = new Point(205, 253);
            comboBoxTID.Name = "comboBoxTID";
            comboBoxTID.Size = new Size(300, 23);
            comboBoxTID.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.ForeColor = Color.FromArgb(16, 30, 41);
            label1.Location = new Point(111, 119);
            label1.Name = "label1";
            label1.Size = new Size(78, 17);
            label1.TabIndex = 8;
            label1.Text = "Team Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.ForeColor = Color.FromArgb(16, 30, 41);
            label5.Location = new Point(134, 259);
            label5.Name = "label5";
            label5.Size = new Size(55, 17);
            label5.TabIndex = 12;
            label5.Text = "Team ID";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 577);
            Controls.Add(panel2);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Button clearbtn;
        private Label label6;
        private TextBox textBoxtCoach;
        private Button subTbtn;
        private TextBox textBoxTname;
        private Label label3;
        private ComboBox comboBoxTID;
        private Label label1;
        private Label label5;
        private TextBox textBoxTAGE;
        private Label label2;
    }
}