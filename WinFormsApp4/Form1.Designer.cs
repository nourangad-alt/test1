namespace WinFormsApp4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            playerpic = new PictureBox();
            textBoxFname = new TextBox();
            textBoxMH = new TextBox();
            textBoxNID = new TextBox();
            comboBoxTID = new ComboBox();
            photoPbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dateTimePickerP = new DateTimePicker();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            clearPRbtn = new Button();
            textBoxPPnum = new TextBox();
            label11 = new Label();
            textBoxPnum = new TextBox();
            label10 = new Label();
            label9 = new Label();
            textBoxLname = new TextBox();
            panel1 = new Panel();
            submitPbtn = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)playerpic).BeginInit();
            guna2GradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // playerpic
            // 
            playerpic.Image = (Image)resources.GetObject("playerpic.Image");
            playerpic.Location = new Point(556, 95);
            playerpic.Name = "playerpic";
            playerpic.Size = new Size(128, 128);
            playerpic.SizeMode = PictureBoxSizeMode.StretchImage;
            playerpic.TabIndex = 0;
            playerpic.TabStop = false;
            // 
            // textBoxFname
            // 
            textBoxFname.Location = new Point(228, 95);
            textBoxFname.Name = "textBoxFname";
            textBoxFname.Size = new Size(300, 23);
            textBoxFname.TabIndex = 1;
            textBoxFname.TextChanged += textBox1_TextChanged;
            // 
            // textBoxMH
            // 
            textBoxMH.Location = new Point(228, 375);
            textBoxMH.Name = "textBoxMH";
            textBoxMH.Size = new Size(300, 23);
            textBoxMH.TabIndex = 2;
            // 
            // textBoxNID
            // 
            textBoxNID.Location = new Point(228, 275);
            textBoxNID.Name = "textBoxNID";
            textBoxNID.Size = new Size(300, 23);
            textBoxNID.TabIndex = 3;
            // 
            // comboBoxTID
            // 
            comboBoxTID.FormattingEnabled = true;
            comboBoxTID.Location = new Point(228, 422);
            comboBoxTID.Name = "comboBoxTID";
            comboBoxTID.Size = new Size(300, 23);
            comboBoxTID.TabIndex = 4;
            // 
            // photoPbtn
            // 
            photoPbtn.Anchor = AnchorStyles.Bottom;
            photoPbtn.BackColor = Color.WhiteSmoke;
            photoPbtn.FlatStyle = FlatStyle.Flat;
            photoPbtn.ForeColor = Color.FromArgb(16, 30, 41);
            photoPbtn.Location = new Point(397, 485);
            photoPbtn.Name = "photoPbtn";
            photoPbtn.Size = new Size(131, 32);
            photoPbtn.TabIndex = 7;
            photoPbtn.Text = "Add Photo ";
            photoPbtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.ForeColor = Color.FromArgb(16, 30, 41);
            label1.Location = new Point(137, 96);
            label1.Name = "label1";
            label1.Size = new Size(71, 17);
            label1.TabIndex = 8;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.ForeColor = Color.FromArgb(16, 30, 41);
            label2.Location = new Point(126, 331);
            label2.Name = "label2";
            label2.Size = new Size(83, 17);
            label2.TabIndex = 9;
            label2.Text = "Date Of Birth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.ForeColor = Color.FromArgb(16, 30, 41);
            label3.Location = new Point(111, 187);
            label3.Name = "label3";
            label3.Size = new Size(100, 17);
            label3.TabIndex = 10;
            label3.Text = "Phone Number ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.ForeColor = Color.FromArgb(16, 30, 41);
            label4.Location = new Point(111, 381);
            label4.Name = "label4";
            label4.Size = new Size(99, 17);
            label4.TabIndex = 11;
            label4.Text = "Medical History";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.ForeColor = Color.FromArgb(16, 30, 41);
            label5.Location = new Point(155, 423);
            label5.Name = "label5";
            label5.Size = new Size(55, 17);
            label5.TabIndex = 12;
            label5.Text = "Team ID";
            label5.Click += label5_Click;
            // 
            // dateTimePickerP
            // 
            dateTimePickerP.Location = new Point(228, 325);
            dateTimePickerP.Name = "dateTimePickerP";
            dateTimePickerP.Size = new Size(300, 23);
            dateTimePickerP.TabIndex = 13;
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            guna2GradientPanel1.BackColor = Color.White;
            guna2GradientPanel1.BorderColor = Color.Transparent;
            guna2GradientPanel1.BorderRadius = 15;
            guna2GradientPanel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            guna2GradientPanel1.Controls.Add(clearPRbtn);
            guna2GradientPanel1.Controls.Add(textBoxPPnum);
            guna2GradientPanel1.Controls.Add(label11);
            guna2GradientPanel1.Controls.Add(textBoxPnum);
            guna2GradientPanel1.Controls.Add(playerpic);
            guna2GradientPanel1.Controls.Add(label10);
            guna2GradientPanel1.Controls.Add(label9);
            guna2GradientPanel1.Controls.Add(textBoxLname);
            guna2GradientPanel1.Controls.Add(panel1);
            guna2GradientPanel1.Controls.Add(submitPbtn);
            guna2GradientPanel1.Controls.Add(photoPbtn);
            guna2GradientPanel1.Controls.Add(label6);
            guna2GradientPanel1.Controls.Add(textBoxNID);
            guna2GradientPanel1.Controls.Add(dateTimePickerP);
            guna2GradientPanel1.Controls.Add(label3);
            guna2GradientPanel1.Controls.Add(comboBoxTID);
            guna2GradientPanel1.Controls.Add(label5);
            guna2GradientPanel1.Controls.Add(textBoxMH);
            guna2GradientPanel1.Controls.Add(label1);
            guna2GradientPanel1.Controls.Add(label2);
            guna2GradientPanel1.Controls.Add(textBoxFname);
            guna2GradientPanel1.Controls.Add(label4);
            guna2GradientPanel1.CustomizableEdges = customizableEdges1;
            guna2GradientPanel1.FillColor = Color.White;
            guna2GradientPanel1.Location = new Point(55, 42);
            guna2GradientPanel1.Margin = new Padding(2);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.Padding = new Padding(20);
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2GradientPanel1.Size = new Size(720, 531);
            guna2GradientPanel1.TabIndex = 15;
            guna2GradientPanel1.Paint += guna2GradientPanel1_Paint;
            // 
            // clearPRbtn
            // 
            clearPRbtn.Anchor = AnchorStyles.Bottom;
            clearPRbtn.AutoEllipsis = true;
            clearPRbtn.BackColor = Color.Transparent;
            clearPRbtn.FlatAppearance.BorderSize = 0;
            clearPRbtn.FlatAppearance.MouseDownBackColor = Color.Silver;
            clearPRbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            clearPRbtn.FlatStyle = FlatStyle.Flat;
            clearPRbtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            clearPRbtn.ForeColor = Color.FromArgb(6, 30, 41);
            clearPRbtn.ImageAlign = ContentAlignment.MiddleLeft;
            clearPRbtn.Location = new Point(101, 483);
            clearPRbtn.Name = "clearPRbtn";
            clearPRbtn.Size = new Size(86, 32);
            clearPRbtn.TabIndex = 24;
            clearPRbtn.Text = "clear";
            clearPRbtn.UseVisualStyleBackColor = false;
            // 
            // textBoxPPnum
            // 
            textBoxPPnum.Location = new Point(228, 226);
            textBoxPPnum.Name = "textBoxPPnum";
            textBoxPPnum.Size = new Size(300, 23);
            textBoxPPnum.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F);
            label11.ForeColor = Color.FromArgb(16, 30, 41);
            label11.Location = new Point(99, 281);
            label11.Name = "label11";
            label11.Size = new Size(109, 17);
            label11.TabIndex = 23;
            label11.Text = "National Number";
            // 
            // textBoxPnum
            // 
            textBoxPnum.Location = new Point(228, 181);
            textBoxPnum.Name = "textBoxPnum";
            textBoxPnum.Size = new Size(300, 23);
            textBoxPnum.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F);
            label10.ForeColor = Color.FromArgb(16, 30, 41);
            label10.Location = new Point(67, 232);
            label10.Name = "label10";
            label10.Size = new Size(145, 17);
            label10.TabIndex = 21;
            label10.Text = " Parent Phone Number ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F);
            label9.ForeColor = Color.FromArgb(16, 30, 41);
            label9.Location = new Point(138, 142);
            label9.Name = "label9";
            label9.Size = new Size(70, 17);
            label9.TabIndex = 19;
            label9.Text = "Last Name";
            // 
            // textBoxLname
            // 
            textBoxLname.Location = new Point(228, 136);
            textBoxLname.Name = "textBoxLname";
            textBoxLname.Size = new Size(300, 23);
            textBoxLname.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Location = new Point(23, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 1);
            panel1.TabIndex = 17;
            // 
            // submitPbtn
            // 
            submitPbtn.Anchor = AnchorStyles.Bottom;
            submitPbtn.BackColor = Color.FromArgb(16, 30, 41);
            submitPbtn.FlatStyle = FlatStyle.Flat;
            submitPbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submitPbtn.ForeColor = Color.White;
            submitPbtn.Location = new Point(228, 484);
            submitPbtn.Name = "submitPbtn";
            submitPbtn.Size = new Size(123, 35);
            submitPbtn.TabIndex = 16;
            submitPbtn.Text = "Submit Player";
            submitPbtn.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(16, 30, 41);
            label6.Location = new Point(257, 20);
            label6.Name = "label6";
            label6.Size = new Size(183, 21);
            label6.TabIndex = 14;
            label6.Text = "PLAYER REGISTRATION";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(820, 600);
            Controls.Add(guna2GradientPanel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Player Registration";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)playerpic).EndInit();
            guna2GradientPanel1.ResumeLayout(false);
            guna2GradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox playerpic;
        private TextBox textBoxFname;
        private TextBox textBoxMH;
        private TextBox textBoxNID;
        private ComboBox comboBoxTID;
        private Button photoPbtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePickerP;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Label label6;
        private Button submitPbtn;
        private Panel panel1;
        private TextBox textBoxPnum;
        private Label label10;
        private Label label9;
        private TextBox textBoxLname;
        private TextBox textBoxPPnum;
        private Label label11;
        private Button clearPRbtn;
    }
}
