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
            this.CancelSimp = new System.Windows.Forms.Button();
            this.lblSimpTime = new System.Windows.Forms.Label();
            this.lblSimpTimeText = new System.Windows.Forms.Label();
            this.groupBoxRect = new System.Windows.Forms.GroupBox();
            this.CancelRect = new System.Windows.Forms.Button();
            this.lblRectTimeTxt = new System.Windows.Forms.Label();
            this.lblRectTimeRes = new System.Windows.Forms.Label();
            this.gBParSimp = new System.Windows.Forms.GroupBox();
            this.CancelParSimp = new System.Windows.Forms.Button();
            this.lblParSimpRes = new System.Windows.Forms.Label();
            this.lblParSimpTime = new System.Windows.Forms.Label();
            this.lblParSimpTimeTxt = new System.Windows.Forms.Label();
            this.lblParSimpTxt = new System.Windows.Forms.Label();
            this.btnParSimp = new System.Windows.Forms.Button();
            this.gbParRect = new System.Windows.Forms.GroupBox();
            this.CancelParRect = new System.Windows.Forms.Button();
            this.lblParRectTimeRes = new System.Windows.Forms.Label();
            this.lblParRectTimeTxt = new System.Windows.Forms.Label();
            this.lblParRectRes = new System.Windows.Forms.Label();
            this.lblParRectTxt = new System.Windows.Forms.Label();
            this.btnParRect = new System.Windows.Forms.Button();
            this.pb = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.IntPic1)).BeginInit();
            this.groupBoxSimp.SuspendLayout();
            this.groupBoxRect.SuspendLayout();
            this.gBParSimp.SuspendLayout();
            this.gbParRect.SuspendLayout();
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
            // 
            // IntPic1
            // 
            this.IntPic1.Image = ((System.Drawing.Image)(resources.GetObject("IntPic1.Image")));
            this.IntPic1.Location = new System.Drawing.Point(384, 36);
            this.IntPic1.Name = "IntPic1";
            this.IntPic1.Size = new System.Drawing.Size(233, 56);
            this.IntPic1.TabIndex = 8;
            this.IntPic1.TabStop = false;
            // 
            // labelSimpRes
            // 
            this.labelSimpRes.AutoSize = true;
            this.labelSimpRes.Location = new System.Drawing.Point(191, 46);
            this.labelSimpRes.Name = "labelSimpRes";
            this.labelSimpRes.Size = new System.Drawing.Size(13, 13);
            this.labelSimpRes.TabIndex = 9;
            this.labelSimpRes.Text = "0";
            // 
            // labelRectRes
            // 
            this.labelRectRes.AutoSize = true;
            this.labelRectRes.Location = new System.Drawing.Point(191, 43);
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
            this.labelSimpTxt.Size = new System.Drawing.Size(62, 13);
            this.labelSimpTxt.TabIndex = 11;
            this.labelSimpTxt.Text = "Результат:";
            // 
            // labelRectTxt
            // 
            this.labelRectTxt.AutoSize = true;
            this.labelRectTxt.Location = new System.Drawing.Point(123, 43);
            this.labelRectTxt.Name = "labelRectTxt";
            this.labelRectTxt.Size = new System.Drawing.Size(62, 13);
            this.labelRectTxt.TabIndex = 12;
            this.labelRectTxt.Text = "Результат:";
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
            this.groupBoxSimp.Controls.Add(this.CancelSimp);
            this.groupBoxSimp.Controls.Add(this.lblSimpTime);
            this.groupBoxSimp.Controls.Add(this.lblSimpTimeText);
            this.groupBoxSimp.Controls.Add(this.SimpBtn);
            this.groupBoxSimp.Controls.Add(this.labelSimpTxt);
            this.groupBoxSimp.Controls.Add(this.labelSimpRes);
            this.groupBoxSimp.Location = new System.Drawing.Point(34, 169);
            this.groupBoxSimp.Margin = new System.Windows.Forms.Padding(25);
            this.groupBoxSimp.Name = "groupBoxSimp";
            this.groupBoxSimp.Size = new System.Drawing.Size(383, 105);
            this.groupBoxSimp.TabIndex = 15;
            this.groupBoxSimp.TabStop = false;
            // 
            // CancelSimp
            // 
            this.CancelSimp.Location = new System.Drawing.Point(123, 7);
            this.CancelSimp.Name = "CancelSimp";
            this.CancelSimp.Size = new System.Drawing.Size(75, 23);
            this.CancelSimp.TabIndex = 23;
            this.CancelSimp.Text = "Отмена";
            this.CancelSimp.UseVisualStyleBackColor = true;
            this.CancelSimp.Click += new System.EventHandler(this.CancelSimp_Click);
            // 
            // lblSimpTime
            // 
            this.lblSimpTime.AutoSize = true;
            this.lblSimpTime.Location = new System.Drawing.Point(191, 70);
            this.lblSimpTime.Name = "lblSimpTime";
            this.lblSimpTime.Size = new System.Drawing.Size(13, 13);
            this.lblSimpTime.TabIndex = 17;
            this.lblSimpTime.Text = "0";
            // 
            // lblSimpTimeText
            // 
            this.lblSimpTimeText.AutoSize = true;
            this.lblSimpTimeText.Location = new System.Drawing.Point(123, 70);
            this.lblSimpTimeText.Name = "lblSimpTimeText";
            this.lblSimpTimeText.Size = new System.Drawing.Size(43, 13);
            this.lblSimpTimeText.TabIndex = 17;
            this.lblSimpTimeText.Text = "Время:";
            // 
            // groupBoxRect
            // 
            this.groupBoxRect.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxRect.Controls.Add(this.CancelRect);
            this.groupBoxRect.Controls.Add(this.lblRectTimeTxt);
            this.groupBoxRect.Controls.Add(this.lblRectTimeRes);
            this.groupBoxRect.Controls.Add(this.RectBtn);
            this.groupBoxRect.Controls.Add(this.labelRectTxt);
            this.groupBoxRect.Controls.Add(this.labelRectRes);
            this.groupBoxRect.Location = new System.Drawing.Point(34, 289);
            this.groupBoxRect.Margin = new System.Windows.Forms.Padding(12);
            this.groupBoxRect.Name = "groupBoxRect";
            this.groupBoxRect.Size = new System.Drawing.Size(383, 98);
            this.groupBoxRect.TabIndex = 16;
            this.groupBoxRect.TabStop = false;
            // 
            // CancelRect
            // 
            this.CancelRect.Location = new System.Drawing.Point(126, 13);
            this.CancelRect.Name = "CancelRect";
            this.CancelRect.Size = new System.Drawing.Size(75, 23);
            this.CancelRect.TabIndex = 24;
            this.CancelRect.Text = "Отмена";
            this.CancelRect.UseVisualStyleBackColor = true;
            this.CancelRect.Click += new System.EventHandler(this.CancelRect_Click);
            // 
            // lblRectTimeTxt
            // 
            this.lblRectTimeTxt.AutoSize = true;
            this.lblRectTimeTxt.Location = new System.Drawing.Point(123, 66);
            this.lblRectTimeTxt.Name = "lblRectTimeTxt";
            this.lblRectTimeTxt.Size = new System.Drawing.Size(43, 13);
            this.lblRectTimeTxt.TabIndex = 20;
            this.lblRectTimeTxt.Text = "Время:";
            // 
            // lblRectTimeRes
            // 
            this.lblRectTimeRes.AutoSize = true;
            this.lblRectTimeRes.Location = new System.Drawing.Point(191, 66);
            this.lblRectTimeRes.Name = "lblRectTimeRes";
            this.lblRectTimeRes.Size = new System.Drawing.Size(13, 13);
            this.lblRectTimeRes.TabIndex = 20;
            this.lblRectTimeRes.Text = "0";
            // 
            // gBParSimp
            // 
            this.gBParSimp.BackColor = System.Drawing.SystemColors.Window;
            this.gBParSimp.Controls.Add(this.CancelParSimp);
            this.gBParSimp.Controls.Add(this.lblParSimpRes);
            this.gBParSimp.Controls.Add(this.lblParSimpTime);
            this.gBParSimp.Controls.Add(this.lblParSimpTimeTxt);
            this.gBParSimp.Controls.Add(this.lblParSimpTxt);
            this.gBParSimp.Controls.Add(this.btnParSimp);
            this.gBParSimp.Location = new System.Drawing.Point(445, 169);
            this.gBParSimp.Name = "gBParSimp";
            this.gBParSimp.Size = new System.Drawing.Size(327, 100);
            this.gBParSimp.TabIndex = 17;
            this.gBParSimp.TabStop = false;
            // 
            // CancelParSimp
            // 
            this.CancelParSimp.Location = new System.Drawing.Point(123, 7);
            this.CancelParSimp.Name = "CancelParSimp";
            this.CancelParSimp.Size = new System.Drawing.Size(75, 23);
            this.CancelParSimp.TabIndex = 25;
            this.CancelParSimp.Text = "Отмена";
            this.CancelParSimp.UseVisualStyleBackColor = true;
            this.CancelParSimp.Click += new System.EventHandler(this.CancelParSimp_Click);
            // 
            // lblParSimpRes
            // 
            this.lblParSimpRes.AutoSize = true;
            this.lblParSimpRes.Location = new System.Drawing.Point(197, 46);
            this.lblParSimpRes.Name = "lblParSimpRes";
            this.lblParSimpRes.Size = new System.Drawing.Size(13, 13);
            this.lblParSimpRes.TabIndex = 17;
            this.lblParSimpRes.Text = "0";
            // 
            // lblParSimpTime
            // 
            this.lblParSimpTime.AutoSize = true;
            this.lblParSimpTime.Location = new System.Drawing.Point(197, 70);
            this.lblParSimpTime.Name = "lblParSimpTime";
            this.lblParSimpTime.Size = new System.Drawing.Size(13, 13);
            this.lblParSimpTime.TabIndex = 16;
            this.lblParSimpTime.Text = "0";
            // 
            // lblParSimpTimeTxt
            // 
            this.lblParSimpTimeTxt.AutoSize = true;
            this.lblParSimpTimeTxt.Location = new System.Drawing.Point(129, 70);
            this.lblParSimpTimeTxt.Name = "lblParSimpTimeTxt";
            this.lblParSimpTimeTxt.Size = new System.Drawing.Size(43, 13);
            this.lblParSimpTimeTxt.TabIndex = 15;
            this.lblParSimpTimeTxt.Text = "Время:";
            // 
            // lblParSimpTxt
            // 
            this.lblParSimpTxt.AutoSize = true;
            this.lblParSimpTxt.Location = new System.Drawing.Point(129, 46);
            this.lblParSimpTxt.Name = "lblParSimpTxt";
            this.lblParSimpTxt.Size = new System.Drawing.Size(62, 13);
            this.lblParSimpTxt.TabIndex = 14;
            this.lblParSimpTxt.Text = "Результат:";
            // 
            // btnParSimp
            // 
            this.btnParSimp.Location = new System.Drawing.Point(0, 0);
            this.btnParSimp.Name = "btnParSimp";
            this.btnParSimp.Size = new System.Drawing.Size(117, 105);
            this.btnParSimp.TabIndex = 12;
            this.btnParSimp.Text = "Параллельно рассчитать интеграл по методу Симпсона";
            this.btnParSimp.UseVisualStyleBackColor = true;
            this.btnParSimp.Click += new System.EventHandler(this.btnParSimp_Click);
            // 
            // gbParRect
            // 
            this.gbParRect.BackColor = System.Drawing.SystemColors.Window;
            this.gbParRect.Controls.Add(this.CancelParRect);
            this.gbParRect.Controls.Add(this.lblParRectTimeRes);
            this.gbParRect.Controls.Add(this.lblParRectTimeTxt);
            this.gbParRect.Controls.Add(this.lblParRectRes);
            this.gbParRect.Controls.Add(this.lblParRectTxt);
            this.gbParRect.Controls.Add(this.btnParRect);
            this.gbParRect.Location = new System.Drawing.Point(445, 289);
            this.gbParRect.Name = "gbParRect";
            this.gbParRect.Size = new System.Drawing.Size(327, 100);
            this.gbParRect.TabIndex = 18;
            this.gbParRect.TabStop = false;
            // 
            // CancelParRect
            // 
            this.CancelParRect.Location = new System.Drawing.Point(123, 13);
            this.CancelParRect.Name = "CancelParRect";
            this.CancelParRect.Size = new System.Drawing.Size(75, 23);
            this.CancelParRect.TabIndex = 26;
            this.CancelParRect.Text = "Отмена";
            this.CancelParRect.UseVisualStyleBackColor = true;
            this.CancelParRect.Click += new System.EventHandler(this.CancelParRect_Click);
            // 
            // lblParRectTimeRes
            // 
            this.lblParRectTimeRes.AutoSize = true;
            this.lblParRectTimeRes.Location = new System.Drawing.Point(208, 66);
            this.lblParRectTimeRes.Name = "lblParRectTimeRes";
            this.lblParRectTimeRes.Size = new System.Drawing.Size(13, 13);
            this.lblParRectTimeRes.TabIndex = 19;
            this.lblParRectTimeRes.Text = "0";
            // 
            // lblParRectTimeTxt
            // 
            this.lblParRectTimeTxt.AutoSize = true;
            this.lblParRectTimeTxt.Location = new System.Drawing.Point(129, 66);
            this.lblParRectTimeTxt.Name = "lblParRectTimeTxt";
            this.lblParRectTimeTxt.Size = new System.Drawing.Size(43, 13);
            this.lblParRectTimeTxt.TabIndex = 18;
            this.lblParRectTimeTxt.Text = "Время:";
            // 
            // lblParRectRes
            // 
            this.lblParRectRes.AutoSize = true;
            this.lblParRectRes.Location = new System.Drawing.Point(208, 44);
            this.lblParRectRes.Name = "lblParRectRes";
            this.lblParRectRes.Size = new System.Drawing.Size(13, 13);
            this.lblParRectRes.TabIndex = 13;
            this.lblParRectRes.Text = "0";
            // 
            // lblParRectTxt
            // 
            this.lblParRectTxt.AutoSize = true;
            this.lblParRectTxt.Location = new System.Drawing.Point(129, 44);
            this.lblParRectTxt.Name = "lblParRectTxt";
            this.lblParRectTxt.Size = new System.Drawing.Size(62, 13);
            this.lblParRectTxt.TabIndex = 13;
            this.lblParRectTxt.Text = "Результат:";
            // 
            // btnParRect
            // 
            this.btnParRect.Location = new System.Drawing.Point(0, 0);
            this.btnParRect.Name = "btnParRect";
            this.btnParRect.Size = new System.Drawing.Size(117, 98);
            this.btnParRect.TabIndex = 13;
            this.btnParRect.Text = "Параллельно рассчитать интеграл по методу средних прямоугольников";
            this.btnParRect.UseVisualStyleBackColor = true;
            this.btnParRect.Click += new System.EventHandler(this.btnParRect_Click);
            // 
            // pb
            // 
            this.pb.BackColor = System.Drawing.SystemColors.Window;
            this.pb.Location = new System.Drawing.Point(331, 114);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(383, 23);
            this.pb.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.gbParRect);
            this.Controls.Add(this.gBParSimp);
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
            this.gBParSimp.ResumeLayout(false);
            this.gBParSimp.PerformLayout();
            this.gbParRect.ResumeLayout(false);
            this.gbParRect.PerformLayout();
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
        private System.Windows.Forms.GroupBox gBParSimp;
        private System.Windows.Forms.Label lblParSimpTxt;
        private System.Windows.Forms.Button btnParSimp;
        private System.Windows.Forms.GroupBox gbParRect;
        private System.Windows.Forms.Label lblParRectRes;
        private System.Windows.Forms.Label lblParRectTxt;
        private System.Windows.Forms.Button btnParRect;
        private System.Windows.Forms.Label lblParSimpTime;
        private System.Windows.Forms.Label lblParSimpTimeTxt;
        private System.Windows.Forms.Label lblSimpTime;
        private System.Windows.Forms.Label lblSimpTimeText;
        private System.Windows.Forms.Label lblParSimpRes;
        private System.Windows.Forms.Label lblRectTimeTxt;
        private System.Windows.Forms.Label lblRectTimeRes;
        private System.Windows.Forms.Label lblParRectTimeRes;
        private System.Windows.Forms.Label lblParRectTimeTxt;
        private System.Windows.Forms.Button CancelSimp;
        private System.Windows.Forms.Button CancelRect;
        private System.Windows.Forms.Button CancelParSimp;
        private System.Windows.Forms.Button CancelParRect;
        private System.Windows.Forms.ProgressBar pb;
    }
}

