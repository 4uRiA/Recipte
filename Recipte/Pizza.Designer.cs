namespace Recipte
{
    partial class Пицца
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Пицца));
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(294, 23);
            label1.TabIndex = 0;
            label1.Text = "Пицца на сковороде за 10 минут";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(295, 58);
            label2.Name = "label2";
            label2.Size = new Size(704, 273);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pizaa_home;
            pictureBox1.Location = new Point(17, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(254, 189);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9.75F);
            label3.Location = new Point(17, 310);
            label3.Name = "label3";
            label3.Size = new Size(162, 120);
            label3.TabIndex = 3;
            label3.Text = "Пошаговый рецепт\r\n\r\n1.\r\nЧтобы приготовить жидкое\r\nтесто для   пиццы,   хорошо\r\nперемешайте   с   помощью\r\nвенчика      яйца,    майонез\r\nмуку     и    немного   соли.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9.75F);
            label4.Location = new Point(185, 340);
            label4.Name = "label4";
            label4.Size = new Size(218, 90);
            label4.TabIndex = 4;
            label4.Text = "2.\r\nВылейте тесто в сковороду\r\n(с     антипригарным     покрытием),\r\nв  которой  будет  готовиться пицца.\r\nКетчуп    аккуратно    распределите\r\nего       по       поверхности     теста.       ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9.75F);
            label5.Location = new Point(399, 340);
            label5.Name = "label5";
            label5.Size = new Size(166, 90);
            label5.TabIndex = 5;
            label5.Text = "3.\r\nОвощи и колбасу нарежьте\r\nнебольшими кусочками или\r\nкружочками (кому как\r\nнравится) и в произвольном\r\nпорядке разложите на тесто.\r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 9.75F);
            label6.Location = new Point(573, 340);
            label6.Name = "label6";
            label6.Size = new Size(114, 60);
            label6.TabIndex = 6;
            label6.Text = "4.\r\nСверху, не скупясь,\r\n присыпьте все\r\n тертым сыром.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 9.75F);
            label7.Location = new Point(696, 340);
            label7.Name = "label7";
            label7.Size = new Size(133, 135);
            label7.TabIndex = 7;
            label7.Text = "5.\r\nПоставьте сковороду с\r\n\"ленивой\" пиццей на\r\nмедленный огонь и \r\nнакройте крышкой.\r\nВыпекается пицца на\r\n сковороде примерно \r\n10 минут (проверяйте \r\nготовность теста).";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 9.75F);
            label8.Location = new Point(845, 345);
            label8.Name = "label8";
            label8.Size = new Size(153, 75);
            label8.TabIndex = 8;
            label8.Text = "6.\r\nВкусная и ароматная \r\nдомашняя пицца на\r\n сковороде готова!\r\nВсем приятного аппетита!";
            // 
            // Пицца
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1034, 579);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Пицца";
            Text = "Pizza";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}