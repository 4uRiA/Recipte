namespace Recipte
{
    partial class Cheese_sticks
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
            label3 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(296, 27);
            label1.TabIndex = 0;
            label1.Text = "Домашние сырные палочки";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cheesestick;
            pictureBox1.Location = new Point(14, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(407, 299);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(440, 61);
            label2.Name = "label2";
            label2.Size = new Size(621, 69);
            label2.TabIndex = 2;
            label2.Text = "Простой, но очень вкусный рецепт домашних сырных палочек.\r\nПальчики оближешь! Минимум продуктов и максимум удовольствия,\r\nа с приготовлением справится даже ребёнок.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(14, 434);
            label3.Name = "label3";
            label3.Size = new Size(311, 115);
            label3.TabIndex = 3;
            label3.Text = "Продукты:\r\n*Сыр твердый - 300 г\r\n*Яйцо - 1 шт.\r\n*Мука - 30 г (1 ст. ложка с горкой)\r\n*Мысло растительное - 70 мл";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.cheeseStick1;
            pictureBox2.Location = new Point(446, 133);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(633, 478);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // Cheese_sticks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1106, 627);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Cheese_sticks";
            Text = "Сырные палочки";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox2;
    }
}