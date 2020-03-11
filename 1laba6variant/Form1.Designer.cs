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
            this.richTextBoxHintSimp = new System.Windows.Forms.RichTextBox();
            this.richTextBoxHintRect = new System.Windows.Forms.RichTextBox();
            this.groupBoxSimp = new System.Windows.Forms.GroupBox();
            this.groupBoxRect = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.IntPic1)).BeginInit();
            this.groupBoxSimp.SuspendLayout();
            this.groupBoxRect.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(197, 36);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 20);
            this.textBoxA.TabIndex = 0;
            this.textBoxA.Text = "0";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(197, 79);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 20);
            this.textBoxB.TabIndex = 1;
            this.textBoxB.Text = "0";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(84, 42);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(104, 13);
            this.labelA.TabIndex = 2;
            this.labelA.Text = "Введите границу а:";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(84, 85);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(104, 13);
            this.labelB.TabIndex = 3;
            this.labelB.Text = "Введите границу b:";
            // 
            // SimpBtn
            // 
            this.SimpBtn.Location = new System.Drawing.Point(0, 0);
            this.SimpBtn.Name = "SimpBtn";
            this.SimpBtn.Size = new System.Drawing.Size(117, 105);
            this.SimpBtn.TabIndex = 4;
            this.SimpBtn.Text = "Рассчитать интеграл по методу Симпсона";
            this.SimpBtn.UseVisualStyleBackColor = true;
            this.SimpBtn.Click += new System.EventHandler(this.SimpBtn_Click);
            // 
            // RectBtn
            // 
            this.RectBtn.Location = new System.Drawing.Point(0, 0);
            this.RectBtn.Name = "RectBtn";
            this.RectBtn.Size = new System.Drawing.Size(117, 98);
            this.RectBtn.TabIndex = 5;
            this.RectBtn.Text = "Рассчитать интеграл по методу средних прямоугольников";
            this.RectBtn.UseVisualStyleBackColor = true;
            this.RectBtn.Click += new System.EventHandler(this.RectBtn_Click);
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(21, 124);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(170, 13);
            this.labelN.TabIndex = 6;
            this.labelN.Text = "Введите значение n (кратное 2):";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(197, 121);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(100, 20);
            this.textBoxN.TabIndex = 7;
            this.textBoxN.Text = "0";
            this.textBoxN.TextChanged += new System.EventHandler(this.textBoxN_TextChanged);
            // 
            // IntPic1
            // 
            this.IntPic1.Image = ((System.Drawing.Image)(resources.GetObject("IntPic1.Image")));
            this.IntPic1.Location = new System.Drawing.Point(320, 60);
            this.IntPic1.Name = "IntPic1";
            this.IntPic1.Size = new System.Drawing.Size(233, 56);
            this.IntPic1.TabIndex = 8;
            this.IntPic1.TabStop = false;
            // 
            // labelSimpRes
            // 
            this.labelSimpRes.AutoSize = true;
            this.labelSimpRes.Location = new System.Drawing.Point(345, 46);
            this.labelSimpRes.Name = "labelSimpRes";
            this.labelSimpRes.Size = new System.Drawing.Size(13, 13);
            this.labelSimpRes.TabIndex = 9;
            this.labelSimpRes.Text = "0";
            // 
            // labelRectRes
            // 
            this.labelRectRes.AutoSize = true;
            this.labelRectRes.Location = new System.Drawing.Point(345, 44);
            this.labelRectRes.Name = "labelRectRes";
            this.labelRectRes.Size = new System.Drawing.Size(13, 13);
            this.labelRectRes.TabIndex = 10;
            this.labelRectRes.Text = "0";
            // 
            // labelSimpTxt
            // 
            this.labelSimpTxt.AutoSize = true;
            this.labelSimpTxt.Location = new System.Drawing.Point(123, 46);
            this.labelSimpTxt.Name = "labelSimpTxt";
            this.labelSimpTxt.Size = new System.Drawing.Size(177, 13);
            this.labelSimpTxt.TabIndex = 11;
            this.labelSimpTxt.Text = "Результат для метода Симпсона:";
            // 
            // labelRectTxt
            // 
            this.labelRectTxt.AutoSize = true;
            this.labelRectTxt.Location = new System.Drawing.Point(123, 43);
            this.labelRectTxt.Name = "labelRectTxt";
            this.labelRectTxt.Size = new System.Drawing.Size(216, 13);
            this.labelRectTxt.TabIndex = 12;
            this.labelRectTxt.Text = "Результат для метода прямоугольников:";
            // 
            // richTextBoxHintSimp
            // 
            this.richTextBoxHintSimp.Location = new System.Drawing.Point(-3, 423);
            this.richTextBoxHintSimp.Name = "richTextBoxHintSimp";
            this.richTextBoxHintSimp.Size = new System.Drawing.Size(152, 82);
            this.richTextBoxHintSimp.TabIndex = 13;
            this.richTextBoxHintSimp.Text = "Условия применения метода – N должно быть кратно 2.\nАлгебраический порядок точнос" +
    "ти метода - 4\n\n";
            this.richTextBoxHintSimp.Visible = false;
            // 
            // richTextBoxHintRect
            // 
            this.richTextBoxHintRect.Location = new System.Drawing.Point(145, 427);
            this.richTextBoxHintRect.Name = "richTextBoxHintRect";
            this.richTextBoxHintRect.Size = new System.Drawing.Size(152, 78);
            this.richTextBoxHintRect.TabIndex = 14;
            this.richTextBoxHintRect.Text = "Алгебраический порядок точности метода средних прямоугольников - 1\n\n\n";
            this.richTextBoxHintRect.Visible = false;
            // 
            // groupBoxSimp
            // 
            this.groupBoxSimp.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxSimp.Controls.Add(this.SimpBtn);
            this.groupBoxSimp.Controls.Add(this.labelSimpTxt);
            this.groupBoxSimp.Controls.Add(this.labelSimpRes);
            this.groupBoxSimp.Location = new System.Drawing.Point(72, 174);
            this.groupBoxSimp.Margin = new System.Windows.Forms.Padding(25);
            this.groupBoxSimp.Name = "groupBoxSimp";
            this.groupBoxSimp.Size = new System.Drawing.Size(481, 105);
            this.groupBoxSimp.TabIndex = 15;
            this.groupBoxSimp.TabStop = false;
            // 
            // groupBoxRect
            // 
            this.groupBoxRect.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxRect.Controls.Add(this.RectBtn);
            this.groupBoxRect.Controls.Add(this.labelRectTxt);
            this.groupBoxRect.Controls.Add(this.labelRectRes);
            this.groupBoxRect.Location = new System.Drawing.Point(72, 294);
            this.groupBoxRect.Margin = new System.Windows.Forms.Padding(12);
            this.groupBoxRect.Name = "groupBoxRect";
            this.groupBoxRect.Size = new System.Drawing.Size(481, 98);
            this.groupBoxRect.TabIndex = 16;
            this.groupBoxRect.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxRect);
            this.Controls.Add(this.richTextBoxHintRect);
            this.Controls.Add(this.groupBoxSimp);
            this.Controls.Add(this.richTextBoxHintSimp);
            this.Controls.Add(this.IntPic1);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Name = "Form1";
            this.Text = "Левочкин и Кропотов (гр. 3-46)";
            ((System.ComponentModel.ISupportInitialize)(this.IntPic1)).EndInit();
            this.groupBoxSimp.ResumeLayout(false);
            this.groupBoxSimp.PerformLayout();
            this.groupBoxRect.ResumeLayout(false);
            this.groupBoxRect.PerformLayout();
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
        private System.Windows.Forms.RichTextBox richTextBoxHintSimp;
        private System.Windows.Forms.RichTextBox richTextBoxHintRect;
        private System.Windows.Forms.GroupBox groupBoxSimp;
        private System.Windows.Forms.GroupBox groupBoxRect;
    }
}

