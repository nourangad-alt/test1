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
            panel1 = new Panel();
            button2 = new Button();
            button3 = new Button();
            button1 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button4);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 450);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLightLight;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Cambria", 9.75F);
            button2.ForeColor = SystemColors.ControlDark;
            button2.Location = new Point(-82, 334);
            button2.Name = "button2";
            button2.Size = new Size(342, 60);
            button2.TabIndex = 2;
            button2.Text = "show coaches";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLightLight;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Cambria", 9.75F);
            button3.ForeColor = SystemColors.ControlDark;
            button3.Location = new Point(-82, 202);
            button3.Name = "button3";
            button3.Size = new Size(342, 60);
            button3.TabIndex = 3;
            button3.Text = "show players ";
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cambria", 9.75F);
            button1.ForeColor = SystemColors.ControlDark;
            button1.Location = new Point(-82, 268);
            button1.Name = "button1";
            button1.Size = new Size(342, 60);
            button1.TabIndex = 1;
            button1.Text = "show teams ";
            button1.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonHighlight;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Cambria", 9.75F);
            button4.ForeColor = SystemColors.ControlDark;
            button4.Location = new Point(0, 133);
            button4.Name = "button4";
            button4.Size = new Size(342, 60);
            button4.TabIndex = 4;
            button4.Text = "add player";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(216, -3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(587, 450);
            dataGridView1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(221, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Location = new Point(0, 133);
            panel2.Name = "panel2";
            panel2.Size = new Size(13, 60);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientActiveCaption;
            panel3.Location = new Point(0, 202);
            panel3.Name = "panel3";
            panel3.Size = new Size(13, 60);
            panel3.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.GradientActiveCaption;
            panel4.Location = new Point(0, 268);
            panel4.Name = "panel4";
            panel4.Size = new Size(13, 60);
            panel4.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.GradientActiveCaption;
            panel5.Location = new Point(0, 334);
            panel5.Name = "panel5";
            panel5.Size = new Size(13, 60);
            panel5.TabIndex = 7;
            panel5.Paint += panel5_Paint;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Form3";
            Text = "Form3";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
    }
}