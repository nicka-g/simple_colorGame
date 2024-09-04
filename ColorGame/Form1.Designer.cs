namespace ColorGame
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
            button1 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            txtBxAns = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(354, 371);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "ROLL";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.LightGreen;
            pictureBox2.Location = new Point(324, 94);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(164, 171);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.PowderBlue;
            pictureBox3.Location = new Point(545, 94);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(164, 171);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Yellow;
            pictureBox1.Location = new Point(96, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 171);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // txtBxAns
            // 
            txtBxAns.Location = new Point(316, 308);
            txtBxAns.Name = "txtBxAns";
            txtBxAns.PlaceholderText = "Type your bet here: ";
            txtBxAns.Size = new Size(189, 31);
            txtBxAns.TabIndex = 8;
            txtBxAns.TextChanged += txtBxAns_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(338, 41);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 9;
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtBxAns);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            Text = "Color Game";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private TextBox txtBxAns;
        private Label label1;
    }
}
