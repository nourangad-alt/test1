namespace WinFormsApp4
{
    partial class Form4
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            clrbtn = new Button();
            label7 = new Label();
            teamsPanel = new Guna.UI2.WinForms.Guna2Panel();
            labelteam = new Label();
            label3 = new Label();
            coachPanel = new Guna.UI2.WinForms.Guna2Panel();
            labelcoach = new Label();
            label2 = new Label();
            playrsPanel = new Guna.UI2.WinForms.Guna2Panel();
            labelplayer = new Label();
            label1 = new Label();
            panel1 = new Panel();
            showcoachbtn = new Button();
            addcoachbtn = new Button();
            pictureBox1 = new PictureBox();
            addteambtn = new Button();
            showplayerbtn = new Button();
            Addplayerbtn = new Button();
            showteambtn = new Button();
            dataGridView1 = new DataGridView();
            delbtn = new Button();
            teamsPanel.SuspendLayout();
            coachPanel.SuspendLayout();
            playrsPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // clrbtn
            // 
            clrbtn.Anchor = AnchorStyles.Bottom;
            clrbtn.AutoEllipsis = true;
            clrbtn.BackColor = Color.Transparent;
            clrbtn.FlatAppearance.BorderSize = 0;
            clrbtn.FlatAppearance.MouseDownBackColor = Color.Silver;
            clrbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            clrbtn.FlatStyle = FlatStyle.Flat;
            clrbtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            clrbtn.ForeColor = Color.FromArgb(6, 30, 41);
            clrbtn.ImageAlign = ContentAlignment.MiddleLeft;
            clrbtn.Location = new Point(270, 462);
            clrbtn.Name = "clrbtn";
            clrbtn.Size = new Size(86, 32);
            clrbtn.TabIndex = 17;
            clrbtn.Text = "clear";
            clrbtn.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(16, 30, 41);
            label7.Location = new Point(270, 9);
            label7.Name = "label7";
            label7.Size = new Size(118, 30);
            label7.TabIndex = 16;
            label7.Text = "Dashboard";
            // 
            // teamsPanel
            // 
            teamsPanel.BorderRadius = 15;
            teamsPanel.Controls.Add(labelteam);
            teamsPanel.Controls.Add(label3);
            teamsPanel.CustomizableEdges = customizableEdges1;
            teamsPanel.FillColor = Color.White;
            teamsPanel.ForeColor = Color.FromArgb(16, 30, 41);
            teamsPanel.Location = new Point(469, 61);
            teamsPanel.Name = "teamsPanel";
            teamsPanel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            teamsPanel.Size = new Size(160, 94);
            teamsPanel.TabIndex = 15;
            // 
            // labelteam
            // 
            labelteam.AutoSize = true;
            labelteam.BackColor = Color.Transparent;
            labelteam.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelteam.ForeColor = Color.FromArgb(16, 30, 41);
            labelteam.Location = new Point(59, 34);
            labelteam.Name = "labelteam";
            labelteam.Size = new Size(42, 32);
            labelteam.TabIndex = 2;
            labelteam.Text = "10";
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
            // 
            // coachPanel
            // 
            coachPanel.BorderRadius = 15;
            coachPanel.Controls.Add(labelcoach);
            coachPanel.Controls.Add(label2);
            coachPanel.CustomizableEdges = customizableEdges3;
            coachPanel.FillColor = Color.White;
            coachPanel.ForeColor = Color.FromArgb(16, 30, 41);
            coachPanel.Location = new Point(653, 61);
            coachPanel.Name = "coachPanel";
            coachPanel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            coachPanel.Size = new Size(160, 94);
            coachPanel.TabIndex = 14;
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
            // playrsPanel
            // 
            playrsPanel.BorderRadius = 15;
            playrsPanel.Controls.Add(labelplayer);
            playrsPanel.Controls.Add(label1);
            playrsPanel.CustomizableEdges = customizableEdges5;
            playrsPanel.FillColor = Color.White;
            playrsPanel.ForeColor = Color.FromArgb(16, 30, 41);
            playrsPanel.Location = new Point(270, 61);
            playrsPanel.Name = "playrsPanel";
            playrsPanel.ShadowDecoration.CustomizableEdges = customizableEdges6;
            playrsPanel.Size = new Size(160, 94);
            playrsPanel.TabIndex = 13;
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 30, 41);
            panel1.Controls.Add(showcoachbtn);
            panel1.Controls.Add(addcoachbtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(addteambtn);
            panel1.Controls.Add(showplayerbtn);
            panel1.Controls.Add(Addplayerbtn);
            panel1.Controls.Add(showteambtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 545);
            panel1.TabIndex = 11;
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
            pictureBox1.Location = new Point(0, -19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 155);
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
            // 
            // Addplayerbtn
            // 
            Addplayerbtn.AutoEllipsis = true;
            Addplayerbtn.BackColor = Color.Transparent;
            Addplayerbtn.FlatAppearance.BorderSize = 0;
            Addplayerbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(18, 20, 41);
            Addplayerbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(18, 40, 50);
            Addplayerbtn.FlatStyle = FlatStyle.Flat;
            Addplayerbtn.Font = new Font("Candara", 11.25F);
            Addplayerbtn.ForeColor = Color.WhiteSmoke;
            Addplayerbtn.Image = (Image)resources.GetObject("Addplayerbtn.Image");
            Addplayerbtn.ImageAlign = ContentAlignment.MiddleLeft;
            Addplayerbtn.Location = new Point(21, 142);
            Addplayerbtn.Name = "Addplayerbtn";
            Addplayerbtn.Size = new Size(165, 48);
            Addplayerbtn.TabIndex = 5;
            Addplayerbtn.Text = "Add player";
            Addplayerbtn.UseVisualStyleBackColor = false;
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
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(270, 182);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(543, 274);
            dataGridView1.TabIndex = 12;
            // 
            // delbtn
            // 
            delbtn.Anchor = AnchorStyles.Bottom;
            delbtn.BackColor = Color.FromArgb(16, 30, 41);
            delbtn.FlatStyle = FlatStyle.Flat;
            delbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delbtn.ForeColor = Color.White;
            delbtn.Location = new Point(690, 463);
            delbtn.Name = "delbtn";
            delbtn.Size = new Size(123, 35);
            delbtn.TabIndex = 18;
            delbtn.Text = "Delete";
            delbtn.UseVisualStyleBackColor = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 545);
            Controls.Add(delbtn);
            Controls.Add(clrbtn);
            Controls.Add(label7);
            Controls.Add(teamsPanel);
            Controls.Add(coachPanel);
            Controls.Add(playrsPanel);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            teamsPanel.ResumeLayout(false);
            teamsPanel.PerformLayout();
            coachPanel.ResumeLayout(false);
            coachPanel.PerformLayout();
            playrsPanel.ResumeLayout(false);
            playrsPanel.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button clrbtn;
        private Label label7;
        private Guna.UI2.WinForms.Guna2Panel teamsPanel;
        private Label labelteam;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Panel coachPanel;
        private Label labelcoach;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Panel playrsPanel;
        private Label labelplayer;
        private Label label1;
        private Panel panel1;
        private Button showcoachbtn;
        private Button addcoachbtn;
        private PictureBox pictureBox1;
        private Button addteambtn;
        private Button showplayerbtn;
        private Button Addplayerbtn;
        private Button showteambtn;
        private DataGridView dataGridView1;
        private Button delbtn;
    }
}