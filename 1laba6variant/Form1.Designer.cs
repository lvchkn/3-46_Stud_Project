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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.SimpBtn = new System.Windows.Forms.Button();
            this.RectBtn = new System.Windows.Forms.Button();
            this.labelN = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.IntPic1 = new System.Windows.Forms.PictureBox();
            this.labelSimpRes = new System.Windows.Forms.Label();
            this.labelRectRes = new System.Windows.Forms.Label();
            this.labelSimpTxt = new System.Windows.Forms.Label();
            this.labelRectTxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IntPic1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(278, 63);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 20);
            this.textBoxA.TabIndex = 0;
            this.textBoxA.Text = "0";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(278, 106);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 20);
            this.textBoxB.TabIndex = 1;
            this.textBoxB.Text = "0";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(165, 69);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(104, 13);
            this.labelA.TabIndex = 2;
            this.labelA.Text = "Введите границу а:";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(165, 112);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(104, 13);
            this.labelB.TabIndex = 3;
            this.labelB.Text = "Введите границу b:";
            // 
            // SimpBtn
            // 
            this.SimpBtn.Location = new System.Drawing.Point(407, 107);
            this.SimpBtn.Name = "SimpBtn";
            this.SimpBtn.Size = new System.Drawing.Size(117, 82);
            this.SimpBtn.TabIndex = 4;
            this.SimpBtn.Text = "Рассчитать интеграл по методу Симпсона";
            this.SimpBtn.UseVisualStyleBackColor = true;
            this.SimpBtn.Click += new System.EventHandler(this.SimpBtn_Click);
            // 
            // RectBtn
            // 
            this.RectBtn.Location = new System.Drawing.Point(530, 107);
            this.RectBtn.Name = "RectBtn";
            this.RectBtn.Size = new System.Drawing.Size(111, 82);
            this.RectBtn.TabIndex = 5;
            this.RectBtn.Text = "Рассчитать интеграл по методу средних прямоугольников";
            this.RectBtn.UseVisualStyleBackColor = true;
            this.RectBtn.Click += new System.EventHandler(this.RectBtn_Click);
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(102, 151);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(170, 13);
            this.labelN.TabIndex = 6;
            this.labelN.Text = "Введите значение n (кратное 2):";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(278, 148);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(100, 20);
            this.textBoxN.TabIndex = 7;
            this.textBoxN.Text = "0";
            // 
            // IntPic1
            // 
            this.IntPic1.Image = ((System.Drawing.Image)(resources.GetObject("IntPic1.Image")));
            this.IntPic1.Location = new System.Drawing.Point(407, 44);
            this.IntPic1.Name = "IntPic1";
            this.IntPic1.Size = new System.Drawing.Size(234, 57);
            this.IntPic1.TabIndex = 8;
            this.IntPic1.TabStop = false;
            // 
            // labelSimpRes
            // 
            this.labelSimpRes.AutoSize = true;
            this.labelSimpRes.Location = new System.Drawing.Point(626, 215);
            this.labelSimpRes.Name = "labelSimpRes";
            this.labelSimpRes.Size = new System.Drawing.Size(13, 13);
            this.labelSimpRes.TabIndex = 9;
            this.labelSimpRes.Text = "0";
            // 
            // labelRectRes
            // 
            this.labelRectRes.AutoSize = true;
            this.labelRectRes.Location = new System.Drawing.Point(626, 243);
            this.labelRectRes.Name = "labelRectRes";
            this.labelRectRes.Size = new System.Drawing.Size(13, 13);
            this.labelRectRes.TabIndex = 10;
            this.labelRectRes.Text = "0";
            // 
            // labelSimpTxt
            // 
            this.labelSimpTxt.AutoSize = true;
            this.labelSimpTxt.Location = new System.Drawing.Point(404, 215);
            this.labelSimpTxt.Name = "labelSimpTxt";
            this.labelSimpTxt.Size = new System.Drawing.Size(177, 13);
            this.labelSimpTxt.TabIndex = 11;
            this.labelSimpTxt.Text = "Результат для метода Симпсона:";
            // 
            // labelRectTxt
            // 
            this.labelRectTxt.AutoSize = true;
            this.labelRectTxt.Location = new System.Drawing.Point(404, 243);
            this.labelRectTxt.Name = "labelRectTxt";
            this.labelRectTxt.Size = new System.Drawing.Size(216, 13);
            this.labelRectTxt.TabIndex = 12;
            this.labelRectTxt.Text = "Результат для метода прямоугольников:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelRectTxt);
            this.Controls.Add(this.labelSimpTxt);
            this.Controls.Add(this.labelRectRes);
            this.Controls.Add(this.labelSimpRes);
            this.Controls.Add(this.IntPic1);
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
            ((System.ComponentModel.ISupportInitialize)(this.IntPic1)).EndInit();
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
        private System.Windows.Forms.PictureBox IntPic1;
        private System.Windows.Forms.Label labelSimpRes;
        private System.Windows.Forms.Label labelRectRes;
        private System.Windows.Forms.Label labelSimpTxt;
        private System.Windows.Forms.Label labelRectTxt;
    }
}

