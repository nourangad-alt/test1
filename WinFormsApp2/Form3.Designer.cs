namespace WinFormsApp2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            showcoachbtn = new Button();
            addcoachbtn = new Button();
            pictureBox1 = new PictureBox();
            addteambtn = new Button();
            showplayerbtn = new Button();
            addplayerbtn = new Button();
            showteambtn = new Button();
            dataGridView1 = new DataGridView();
            playerPanel = new Guna.UI2.WinForms.Guna2Panel();
            labelplayer = new Label();
            label1 = new Label();
            coachPanel = new Guna.UI2.WinForms.Guna2Panel();
            labelcoach = new Label();
            label2 = new Label();
            teamPanel = new Guna.UI2.WinForms.Guna2Panel();
            labelteams = new Label();
            label3 = new Label();
            label7 = new Label();
            clearbtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            playerPanel.SuspendLayout();
            coachPanel.SuspendLayout();
            teamPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 30, 41);
            panel1.Controls.Add(showcoachbtn);
            panel1.Controls.Add(addcoachbtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(addteambtn);
            panel1.Controls.Add(showplayerbtn);
            panel1.Controls.Add(addplayerbtn);
            panel1.Controls.Add(showteambtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 522);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // showcoachbtn
            // 
            showcoachbtn.AutoEllipsis = true;
            showcoachbtn.BackColor = Color.Transparent;
            showcoachbtn.FlatAppearance.BorderSize = 0;
            showcoachbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(18, 20, 41);
            showcoachbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(18, 40, 50);
            showcoachbtn.FlatStyle = FlatStyle.Flat;
            showcoachbtn.Font = new Font("Candara", 11.25F);
            showcoachbtn.ForeColor = Color.WhiteSmoke;
            showcoachbtn.Image = (Image)resources.GetObject("showcoachbtn.Image");
            showcoachbtn.ImageAlign = ContentAlignment.MiddleLeft;
            showcoachbtn.Location = new Point(21, 434);
            showcoachbtn.Name = "showcoachbtn";
            showcoachbtn.Size = new Size(165, 48);
            showcoachbtn.TabIndex = 9;
            showcoachbtn.Text = "Coaches";
            showcoachbtn.UseVisualStyleBackColor = false;
            // 
            // addcoachbtn
            // 
            addcoachbtn.AutoEllipsis = true;
            addcoachbtn.BackColor = Color.Transparent;
            addcoachbtn.FlatAppearance.BorderSize = 0;
            addcoachbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(18, 20, 41);
            addcoachbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(18, 40, 50);
            addcoachbtn.FlatStyle = FlatStyle.Flat;
            addcoachbtn.Font = new Font("Candara", 11.25F);
            addcoachbtn.ForeColor = Color.WhiteSmoke;
            addcoachbtn.Image = (Image)resources.GetObject("addcoachbtn.Image");
            addcoachbtn.ImageAlign = ContentAlignment.MiddleLeft;
            addcoachbtn.Location = new Point(21, 375);
            addcoachbtn.Name = "addcoachbtn";
            addcoachbtn.Size = new Size(165, 48);
            addcoachbtn.TabIndex = 8;
            addcoachbtn.Text = "Add Coache";
            addcoachbtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, -9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 164);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // addteambtn
            // 
            addteambtn.AutoEllipsis = true;
            addteambtn.BackColor = Color.Transparent;
            addteambtn.FlatAppearance.BorderSize = 0;
            addteambtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(18, 20, 41);
            addteambtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(18, 40, 50);
            addteambtn.FlatStyle = FlatStyle.Flat;
            addteambtn.Font = new Font("Candara", 11.25F);
            addteambtn.ForeColor = Color.WhiteSmoke;
            addteambtn.Image = (Image)resources.GetObject("addteambtn.Image");
            addteambtn.ImageAlign = ContentAlignment.MiddleLeft;
            addteambtn.Location = new Point(21, 255);
            addteambtn.Name = "addteambtn";
            addteambtn.Size = new Size(165, 48);
            addteambtn.TabIndex = 7;
            addteambtn.Text = "Add Team";
            addteambtn.UseVisualStyleBackColor = false;
            // 
            // showplayerbtn
            // 
            showplayerbtn.AutoEllipsis = true;
            showplayerbtn.BackColor = Color.Transparent;
            showplayerbtn.FlatAppearance.BorderSize = 0;
            showplayerbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(18, 20, 41);
            showplayerbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(18, 40, 50);
            showplayerbtn.FlatStyle = FlatStyle.Flat;
            showplayerbtn.Font = new Font("Candara", 11.25F);
            showplayerbtn.ForeColor = Color.WhiteSmoke;
            showplayerbtn.Image = (Image)resources.GetObject("showplayerbtn.Image");
            showplayerbtn.ImageAlign = ContentAlignment.MiddleLeft;
            showplayerbtn.Location = new Point(21, 198);
            showplayerbtn.Name = "showplayerbtn";
            showplayerbtn.Size = new Size(165, 48);
            showplayerbtn.TabIndex = 6;
            showplayerbtn.Text = "Players";
            showplayerbtn.UseVisualStyleBackColor = false;
            showplayerbtn.Click += button2_Click;
            // 
            // addplayerbtn
            // 
            addplayerbtn.AutoEllipsis = true;
            addplayerbtn.BackColor = Color.Transparent;
            addplayerbtn.FlatAppearance.BorderSize = 0;
            addplayerbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(18, 20, 41);
            addplayerbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(18, 40, 50);
            addplayerbtn.FlatStyle = FlatStyle.Flat;
            addplayerbtn.Font = new Font("Candara", 11.25F);
            addplayerbtn.ForeColor = Color.WhiteSmoke;
            addplayerbtn.Image = (Image)resources.GetObject("addplayerbtn.Image");
            addplayerbtn.ImageAlign = ContentAlignment.MiddleLeft;
            addplayerbtn.Location = new Point(21, 142);
            addplayerbtn.Name = "addplayerbtn";
            addplayerbtn.Size = new Size(165, 48);
            addplayerbtn.TabIndex = 5;
            addplayerbtn.Text = "Add player";
            addplayerbtn.UseVisualStyleBackColor = false;
            // 
            // showteambtn
            // 
            showteambtn.AutoEllipsis = true;
            showteambtn.BackColor = Color.Transparent;
            showteambtn.FlatAppearance.BorderSize = 0;
            showteambtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(18, 20, 41);
            showteambtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(18, 40, 50);
            showteambtn.FlatStyle = FlatStyle.Flat;
            showteambtn.Font = new Font("Candara", 11.25F);
            showteambtn.ForeColor = Color.WhiteSmoke;
            showteambtn.Image = (Image)resources.GetObject("showteambtn.Image");
            showteambtn.ImageAlign = ContentAlignment.MiddleLeft;
            showteambtn.Location = new Point(21, 314);
            showteambtn.Name = "showteambtn";
            showteambtn.Size = new Size(165, 48);
            showteambtn.TabIndex = 4;
            showteambtn.Text = "Teams";
            showteambtn.UseVisualStyleBackColor = false;
            showteambtn.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(243, 182);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(543, 274);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // playerPanel
            // 
            playerPanel.BorderRadius = 15;
            playerPanel.Controls.Add(labelplayer);
            playerPanel.Controls.Add(label1);
            playerPanel.CustomizableEdges = customizableEdges7;
            playerPanel.FillColor = Color.White;
            playerPanel.ForeColor = Color.FromArgb(16, 30, 41);
            playerPanel.Location = new Point(243, 61);
            playerPanel.Name = "playerPanel";
            playerPanel.ShadowDecoration.CustomizableEdges = customizableEdges8;
            playerPanel.Size = new Size(160, 94);
            playerPanel.TabIndex = 2;
            // 
            // labelplayer
            // 
            labelplayer.AutoSize = true;
            labelplayer.BackColor = Color.Transparent;
            labelplayer.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelplayer.ForeColor = Color.FromArgb(16, 30, 41);
            labelplayer.Location = new Point(49, 33);
            labelplayer.Name = "labelplayer";
            labelplayer.Size = new Size(56, 32);
            labelplayer.TabIndex = 1;
            labelplayer.Text = "145";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(47, 13);
            label1.Name = "label1";
            label1.Size = new Size(61, 17);
            label1.TabIndex = 0;
            label1.Text = "PLAYERS";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // coachPanel
            // 
            coachPanel.BorderRadius = 15;
            coachPanel.Controls.Add(labelcoach);
            coachPanel.Controls.Add(label2);
            coachPanel.CustomizableEdges = customizableEdges9;
            coachPanel.FillColor = Color.White;
            coachPanel.ForeColor = Color.FromArgb(16, 30, 41);
            coachPanel.Location = new Point(626, 61);
            coachPanel.Name = "coachPanel";
            coachPanel.ShadowDecoration.CustomizableEdges = customizableEdges10;
            coachPanel.Size = new Size(160, 94);
            coachPanel.TabIndex = 3;
            // 
            // labelcoach
            // 
            labelcoach.AutoSize = true;
            labelcoach.BackColor = Color.Transparent;
            labelcoach.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelcoach.ForeColor = Color.FromArgb(16, 30, 41);
            labelcoach.Location = new Point(59, 36);
            labelcoach.Name = "labelcoach";
            labelcoach.Size = new Size(42, 32);
            labelcoach.TabIndex = 2;
            labelcoach.Text = "11";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(46, 13);
            label2.Name = "label2";
            label2.Size = new Size(67, 17);
            label2.TabIndex = 0;
            label2.Text = "COACHES";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // teamPanel
            // 
            teamPanel.BorderRadius = 15;
            teamPanel.Controls.Add(labelteams);
            teamPanel.Controls.Add(label3);
            teamPanel.CustomizableEdges = customizableEdges11;
            teamPanel.FillColor = Color.White;
            teamPanel.ForeColor = Color.FromArgb(16, 30, 41);
            teamPanel.Location = new Point(442, 61);
            teamPanel.Name = "teamPanel";
            teamPanel.ShadowDecoration.CustomizableEdges = customizableEdges12;
            teamPanel.Size = new Size(160, 94);
            teamPanel.TabIndex = 4;
            // 
            // labelteams
            // 
            labelteams.AutoSize = true;
            labelteams.BackColor = Color.Transparent;
            labelteams.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelteams.ForeColor = Color.FromArgb(16, 30, 41);
            labelteams.Location = new Point(59, 34);
            labelteams.Name = "labelteams";
            labelteams.Size = new Size(42, 32);
            labelteams.TabIndex = 2;
            labelteams.Text = "10";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(54, 13);
            label3.Name = "label3";
            label3.Size = new Size(51, 17);
            label3.TabIndex = 0;
            label3.Text = "TEAMS";
            label3.TextAlign = ContentAlignment.TopCenter;
            label3.Click += label3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(16, 30, 41);
            label7.Location = new Point(243, 9);
            label7.Name = "label7";
            label7.Size = new Size(118, 30);
            label7.TabIndex = 5;
            label7.Text = "Dashboard";
            // 
            // clearbtn
            // 
            clearbtn.Anchor = AnchorStyles.Bottom;
            clearbtn.AutoEllipsis = true;
            clearbtn.BackColor = Color.Transparent;
            clearbtn.FlatAppearance.BorderSize = 0;
            clearbtn.FlatAppearance.MouseDownBackColor = Color.Silver;
            clearbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            clearbtn.FlatStyle = FlatStyle.Flat;
            clearbtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            clearbtn.ForeColor = Color.FromArgb(6, 30, 41);
            clearbtn.ImageAlign = ContentAlignment.MiddleLeft;
            clearbtn.Location = new Point(243, 462);
            clearbtn.Name = "clearbtn";
            clearbtn.Size = new Size(86, 32);
            clearbtn.TabIndex = 10;
            clearbtn.Text = "clear";
            clearbtn.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(812, 522);
            Controls.Add(clearbtn);
            Controls.Add(label7);
            Controls.Add(teamPanel);
            Controls.Add(coachPanel);
            Controls.Add(playerPanel);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            ForeColor = Color.FromArgb(16, 30, 41);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            playerPanel.ResumeLayout(false);
            playerPanel.PerformLayout();
            coachPanel.ResumeLayout(false);
            coachPanel.PerformLayout();
            teamPanel.ResumeLayout(false);
            teamPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button showteambtn;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Button addteambtn;
        private Button showplayerbtn;
        private Button addplayerbtn;
        private Button showcoachbtn;
        private Button addcoachbtn;
        private Guna.UI2.WinForms.Guna2Panel playerPanel;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Panel coachPanel;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Panel teamPanel;
        private Label label3;
        private Label labelplayer;
        private Label labelcoach;
        private Label labelteams;
        private Label label7;
        private Button clearbtn;
    }
}