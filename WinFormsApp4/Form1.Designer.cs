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
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(412, 1);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(213, 182);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(522, 198);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(522, 381);
            textBox2.Margin = new Padding(4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(256, 28);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(522, 324);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(256, 27);
            textBox3.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(522, 435);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(256, 27);
            comboBox1.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(885, 1);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(172, 133);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.MenuHighlight;
            button1.Location = new Point(917, 155);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(96, 29);
            button1.TabIndex = 7;
            button1.Text = "add photo ";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Font = new Font("Tahoma", 12F);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(412, 198);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 65);
            label1.TabIndex = 8;
            label1.Text = "full name";
            // 
            // label2
            // 
            label2.Font = new Font("Tahoma", 12F);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(398, 263);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(127, 45);
            label2.TabIndex = 9;
            label2.Text = "date of birth";
            // 
            // label3
            // 
            label3.Font = new Font("Tahoma", 12F);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(398, 327);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(117, 54);
            label3.TabIndex = 10;
            label3.Text = "phone number ";
            // 
            // label4
            // 
            label4.Font = new Font("Tahoma", 12F);
            label4.ForeColor = SystemColors.MenuHighlight;
            label4.Location = new Point(395, 381);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(120, 67);
            label4.TabIndex = 11;
            label4.Text = "medical history";
            // 
            // label5
            // 
            label5.Font = new Font("Tahoma", 12F);
            label5.ForeColor = SystemColors.MenuHighlight;
            label5.Location = new Point(395, 435);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(120, 54);
            label5.TabIndex = 12;
            label5.Text = "team id";
            label5.Click += label5_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(522, 257);
            dateTimePicker1.Margin = new Padding(4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(256, 27);
            dateTimePicker1.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 605);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Font = new Font("Tahoma", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePicker1;
    }
}
