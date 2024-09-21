namespace Recipte
{
    partial class Potato_village
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
            label1.Location = new Point(16, 13);
            label1.Name = "label1";
            label1.Size = new Size(270, 27);
            label1.TabIndex = 0;
            label1.Text = "Картошка по-деревенски";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.potvilage;
            pictureBox1.Location = new Point(659, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(435, 320);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(659, 355);
            label2.Name = "label2";
            label2.Size = new Size(314, 184);
            label2.TabIndex = 2;
            label2.Text = "Продукты:\r\n*Картофель - 1 кг\r\n*Паприка молотая - 2 ч. л.\r\n*Куркума - 0,5 ч. л.\r\n*Чеснок гранулированный - 2 ч. л.\r\n*Масло растительное - 1-2 ст. л.\r\n*Перец черный молотый\r\n*Соль";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.potVilage1;
            pictureBox2.Location = new Point(16, 56);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(351, 570);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.potVilage2;
            pictureBox3.Location = new Point(373, 56);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(273, 571);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // Potato_village
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1117, 638);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Potato_village";
            Text = "Картошка по-деревенски";
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