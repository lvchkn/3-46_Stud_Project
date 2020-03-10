namespace _1laba6variant
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.SimpBtn = new System.Windows.Forms.Button();
            this.RectBtn = new System.Windows.Forms.Button();
            this.labelN = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelSIMPoutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(174, 81);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 20);
            this.textBoxA.TabIndex = 0;
            this.textBoxA.Text = "0";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(174, 124);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 20);
            this.textBoxB.TabIndex = 1;
            this.textBoxB.Text = "0";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(16, 84);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(104, 13);
            this.labelA.TabIndex = 2;
            this.labelA.Text = "Введите границу а:";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(16, 127);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(104, 13);
            this.labelB.TabIndex = 3;
            this.labelB.Text = "Введите границу b:";
            // 
            // SimpBtn
            // 
            this.SimpBtn.Location = new System.Drawing.Point(330, 50);
            this.SimpBtn.Name = "SimpBtn";
            this.SimpBtn.Size = new System.Drawing.Size(129, 57);
            this.SimpBtn.TabIndex = 4;
            this.SimpBtn.Text = "Рассчитать интеграл по методу Симпсона";
            this.SimpBtn.UseVisualStyleBackColor = true;
            this.SimpBtn.Click += new System.EventHandler(this.SimpBtn_Click);
            // 
            // RectBtn
            // 
            this.RectBtn.Location = new System.Drawing.Point(330, 127);
            this.RectBtn.Name = "RectBtn";
            this.RectBtn.Size = new System.Drawing.Size(129, 71);
            this.RectBtn.TabIndex = 5;
            this.RectBtn.Text = "Рассчитать интеграл по методу средних прямоугольников";
            this.RectBtn.UseVisualStyleBackColor = true;
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(12, 166);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(111, 13);
            this.labelN.TabIndex = 6;
            this.labelN.Text = "Введите значение n:";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(174, 166);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(100, 20);
            this.textBoxN.TabIndex = 7;
            this.textBoxN.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(637, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // labelSIMPoutput
            // 
            this.labelSIMPoutput.AutoSize = true;
            this.labelSIMPoutput.Location = new System.Drawing.Point(82, 227);
            this.labelSIMPoutput.Name = "labelSIMPoutput";
            this.labelSIMPoutput.Size = new System.Drawing.Size(13, 13);
            this.labelSIMPoutput.TabIndex = 9;
            this.labelSIMPoutput.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSIMPoutput);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.RectBtn);
            this.Controls.Add(this.SimpBtn);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Name = "Form1";
            this.Text = "Левочкин и Кропотов (гр. 3-46)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Button SimpBtn;
        private System.Windows.Forms.Button RectBtn;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelSIMPoutput;
    }
}

