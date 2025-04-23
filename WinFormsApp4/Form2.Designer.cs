namespace WinFormsApp4
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            clearbtn = new Button();
            label11 = new Label();
            textBoxCPnum = new TextBox();
            pictureBoxCOACH = new PictureBox();
            label9 = new Label();
            textBoxCLname = new TextBox();
            panel1 = new Panel();
            subCoachbtn = new Button();
            addCPhotobtn = new Button();
            label6 = new Label();
            textBoxCNID = new TextBox();
            label3 = new Label();
            comboBoxTID = new ComboBox();
            label5 = new Label();
            label1 = new Label();
            textBoxCFname = new TextBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCOACH).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
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
            clearbtn.Location = new Point(99, 448);
            clearbtn.Name = "clearbtn";
            clearbtn.Size = new Size(86, 32);
            clearbtn.TabIndex = 24;
            clearbtn.Text = "clear";
            clearbtn.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F);
            label11.ForeColor = Color.FromArgb(16, 30, 41);
            label11.Location = new Point(117, 232);
            label11.Name = "label11";
            label11.Size = new Size(109, 17);
            label11.TabIndex = 23;
            label11.Text = "National Number";
            // 
            // textBoxCPnum
            // 
            textBoxCPnum.Location = new Point(233, 185);
            textBoxCPnum.Name = "textBoxCPnum";
            textBoxCPnum.Size = new Size(300, 23);
            textBoxCPnum.TabIndex = 20;
            // 
            // pictureBoxCOACH
            // 
            pictureBoxCOACH.Image = (Image)resources.GetObject("pictureBoxCOACH.Image");
            pictureBoxCOACH.Location = new Point(570, 99);
            pictureBoxCOACH.Name = "pictureBoxCOACH";
            pictureBoxCOACH.Size = new Size(128, 128);
            pictureBoxCOACH.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCOACH.TabIndex = 0;
            pictureBoxCOACH.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F);
            label9.ForeColor = Color.FromArgb(16, 30, 41);
            label9.Location = new Point(157, 145);
            label9.Name = "label9";
            label9.Size = new Size(70, 17);
            label9.TabIndex = 19;
            label9.Text = "Last Name";
            // 
            // textBoxCLname
            // 
            textBoxCLname.Location = new Point(233, 140);
            textBoxCLname.Name = "textBoxCLname";
            textBoxCLname.Size = new Size(300, 23);
            textBoxCLname.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Location = new Point(28, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 1);
            panel1.TabIndex = 17;
            // 
            // subCoachbtn
            // 
            subCoachbtn.BackColor = Color.FromArgb(16, 30, 41);
            subCoachbtn.FlatStyle = FlatStyle.Flat;
            subCoachbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subCoachbtn.ForeColor = Color.White;
            subCoachbtn.Location = new Point(233, 445);
            subCoachbtn.Name = "subCoachbtn";
            subCoachbtn.Size = new Size(123, 35);
            subCoachbtn.TabIndex = 16;
            subCoachbtn.Text = "Submit Coach";
            subCoachbtn.UseVisualStyleBackColor = false;
            // 
            // addCPhotobtn
            // 
            addCPhotobtn.BackColor = Color.WhiteSmoke;
            addCPhotobtn.FlatStyle = FlatStyle.Flat;
            addCPhotobtn.ForeColor = Color.FromArgb(16, 30, 41);
            addCPhotobtn.Location = new Point(402, 446);
            addCPhotobtn.Name = "addCPhotobtn";
            addCPhotobtn.Size = new Size(131, 32);
            addCPhotobtn.TabIndex = 7;
            addCPhotobtn.Text = "Add Photo ";
            addCPhotobtn.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(16, 30, 41);
            label6.Location = new Point(282, 44);
            label6.Name = "label6";
            label6.Size = new Size(181, 21);
            label6.TabIndex = 14;
            label6.Text = "COACH REGISTRATION";
            // 
            // textBoxCNID
            // 
            textBoxCNID.Location = new Point(233, 228);
            textBoxCNID.Name = "textBoxCNID";
            textBoxCNID.Size = new Size(300, 23);
            textBoxCNID.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.ForeColor = Color.FromArgb(16, 30, 41);
            label3.Location = new Point(130, 190);
            label3.Name = "label3";
            label3.Size = new Size(100, 17);
            label3.TabIndex = 10;
            label3.Text = "Phone Number ";
            // 
            // comboBoxTID
            // 
            comboBoxTID.FormattingEnabled = true;
            comboBoxTID.Location = new Point(233, 272);
            comboBoxTID.Name = "comboBoxTID";
            comboBoxTID.Size = new Size(300, 23);
            comboBoxTID.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.ForeColor = Color.FromArgb(16, 30, 41);
            label5.Location = new Point(171, 272);
            label5.Name = "label5";
            label5.Size = new Size(55, 17);
            label5.TabIndex = 12;
            label5.Text = "Team ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.ForeColor = Color.FromArgb(16, 30, 41);
            label1.Location = new Point(156, 99);
            label1.Name = "label1";
            label1.Size = new Size(71, 17);
            label1.TabIndex = 8;
            label1.Text = "First Name";
            // 
            // textBoxCFname
            // 
            textBoxCFname.Location = new Point(233, 99);
            textBoxCFname.Name = "textBoxCFname";
            textBoxCFname.Size = new Size(300, 23);
            textBoxCFname.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(clearbtn);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(addCPhotobtn);
            panel2.Controls.Add(textBoxCNID);
            panel2.Controls.Add(textBoxCPnum);
            panel2.Controls.Add(subCoachbtn);
            panel2.Controls.Add(textBoxCFname);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBoxCOACH);
            panel2.Controls.Add(comboBoxTID);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBoxCLname);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(50, 38);
            panel2.Name = "panel2";
            panel2.Size = new Size(720, 531);
            panel2.TabIndex = 25;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 600);
            Controls.Add(panel2);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBoxCOACH).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button clearbtn;
        private Label label11;
        private TextBox textBoxCPnum;
        private PictureBox pictureBoxCOACH;
        private Label label9;
        private TextBox textBoxCLname;
        private Panel panel1;
        private Button subCoachbtn;
        private Button addCPhotobtn;
        private Label label6;
        private TextBox textBoxCNID;
        private Label label3;
        private ComboBox comboBoxTID;
        private Label label5;
        private Label label1;
        private TextBox textBoxCFname;
        private Panel panel2;
    }
}