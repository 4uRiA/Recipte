namespace Recipte
{
    partial class Potato
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(14, 9);
            label1.Name = "label1";
            label1.Size = new Size(255, 27);
            label1.TabIndex = 0;
            label1.Text = "Картофельные драники";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.draniki;
            pictureBox1.Location = new Point(14, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(298, 226);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(14, 280);
            label2.Name = "label2";
            label2.Size = new Size(306, 138);
            label2.TabIndex = 2;
            label2.Text = "Продукты (на 3 порции):\r\n*Картофель - 11 шт.\r\n*Яйца - 2 шт.\r\n*Соль - по вкусу\r\n*Перец молотый - по вкусу\r\n*Масло растительное - для жарки";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.draniki1;
            pictureBox2.Location = new Point(351, 40);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(349, 553);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.draniki2;
            pictureBox3.Location = new Point(714, 41);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(324, 553);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // Potato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1077, 606);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Potato";
            Text = "Картофельные драники";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}