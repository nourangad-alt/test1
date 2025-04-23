namespace WinFormsApp2
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            comboBoxTID = new ComboBox();
            pictureBox1 = new PictureBox();
            showPlayerBtn = new Button();
            showTeamsBtn = new Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            ClearBtn = new Button();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            CirclePictureBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            label4 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CirclePictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 30, 41);
            panel1.Controls.Add(comboBoxTID);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(showPlayerBtn);
            panel1.Controls.Add(showTeamsBtn);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(202, 450);
            panel1.TabIndex = 0;
            // 
            // comboBoxTID
            // 
            comboBoxTID.FormattingEnabled = true;
            comboBoxTID.Location = new Point(26, 177);
            comboBoxTID.Name = "comboBoxTID";
            comboBoxTID.Size = new Size(143, 23);
            comboBoxTID.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-33, 256);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(276, 207);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // showPlayerBtn
            // 
            showPlayerBtn.AutoEllipsis = true;
            showPlayerBtn.BackColor = Color.Transparent;
            showPlayerBtn.FlatAppearance.BorderSize = 0;
            showPlayerBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(18, 20, 41);
            showPlayerBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(18, 40, 50);
            showPlayerBtn.FlatStyle = FlatStyle.Flat;
            showPlayerBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            showPlayerBtn.ForeColor = Color.WhiteSmoke;
            showPlayerBtn.Image = (Image)resources.GetObject("showPlayerBtn.Image");
            showPlayerBtn.ImageAlign = ContentAlignment.MiddleLeft;
            showPlayerBtn.Location = new Point(9, 79);
            showPlayerBtn.Name = "showPlayerBtn";
            showPlayerBtn.Size = new Size(174, 48);
            showPlayerBtn.TabIndex = 8;
            showPlayerBtn.Text = "Players";
            showPlayerBtn.UseVisualStyleBackColor = false;
            // 
            // showTeamsBtn
            // 
            showTeamsBtn.AutoEllipsis = true;
            showTeamsBtn.BackColor = Color.Transparent;
            showTeamsBtn.FlatAppearance.BorderSize = 0;
            showTeamsBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(18, 20, 41);
            showTeamsBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(18, 40, 50);
            showTeamsBtn.FlatStyle = FlatStyle.Flat;
            showTeamsBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            showTeamsBtn.ForeColor = Color.WhiteSmoke;
            showTeamsBtn.Image = (Image)resources.GetObject("showTeamsBtn.Image");
            showTeamsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            showTeamsBtn.Location = new Point(12, 25);
            showTeamsBtn.Name = "showTeamsBtn";
            showTeamsBtn.Size = new Size(174, 48);
            showTeamsBtn.TabIndex = 7;
            showTeamsBtn.Text = "Teams";
            showTeamsBtn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(26, 140);
            label2.Name = "label2";
            label2.Size = new Size(143, 21);
            label2.TabIndex = 4;
            label2.Text = "Search by Team ID";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.ControlLightLight;
            dataGridView1.Location = new Point(227, 117);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(546, 250);
            dataGridView1.TabIndex = 1;
            // 
            // ClearBtn
            // 
            ClearBtn.Anchor = AnchorStyles.Bottom;
            ClearBtn.AutoEllipsis = true;
            ClearBtn.BackColor = Color.Transparent;
            ClearBtn.FlatAppearance.BorderSize = 0;
            ClearBtn.FlatAppearance.MouseDownBackColor = Color.Silver;
            ClearBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            ClearBtn.FlatStyle = FlatStyle.Flat;
            ClearBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            ClearBtn.ForeColor = Color.FromArgb(6, 30, 41);
            ClearBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ClearBtn.Location = new Point(237, 385);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(86, 32);
            ClearBtn.TabIndex = 11;
            ClearBtn.Text = "clear";
            ClearBtn.UseVisualStyleBackColor = false;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.Controls.Add(CirclePictureBox);
            guna2Panel1.Controls.Add(label4);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.CustomizableEdges = customizableEdges5;
            guna2Panel1.FillColor = Color.White;
            guna2Panel1.ForeColor = Color.FromArgb(16, 30, 41);
            guna2Panel1.Location = new Point(227, 17);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel1.Size = new Size(390, 94);
            guna2Panel1.TabIndex = 12;
            // 
            // CirclePictureBox
            // 
            CirclePictureBox.BackColor = Color.Transparent;
            CirclePictureBox.Image = (Image)resources.GetObject("CirclePictureBox.Image");
            CirclePictureBox.ImageRotate = 0F;
            CirclePictureBox.Location = new Point(22, 8);
            CirclePictureBox.Name = "CirclePictureBox";
            CirclePictureBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            CirclePictureBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            CirclePictureBox.Size = new Size(64, 64);
            CirclePictureBox.TabIndex = 3;
            CirclePictureBox.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(16, 30, 41);
            label4.Location = new Point(92, 8);
            label4.Name = "label4";
            label4.Size = new Size(174, 32);
            label4.TabIndex = 1;
            label4.Text = "Welcom Back!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(101, 40);
            label1.Name = "label1";
            label1.Size = new Size(123, 17);
            label1.TabIndex = 0;
            label1.Text = "Hi Coach Ahmed...";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(guna2Panel1);
            Controls.Add(ClearBtn);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CirclePictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label2;
        private Button showPlayerBtn;
        private Button showTeamsBtn;
        private Button ClearBtn;
        private PictureBox pictureBox1;
        private ComboBox comboBoxTID;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox CirclePictureBox;
        private Label label4;
        private Label label1;
    }
}