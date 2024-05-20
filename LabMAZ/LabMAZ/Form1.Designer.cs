
namespace LabMAZ
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
            this.ComboVariantShifr = new System.Windows.Forms.ComboBox();
            this.TextDecodir = new System.Windows.Forms.TextBox();
            this.TextCodir = new System.Windows.Forms.TextBox();
            this.LabelText = new System.Windows.Forms.Label();
            this.LabelVariantShifr = new System.Windows.Forms.Label();
            this.LabelTextDecodirov = new System.Windows.Forms.Label();
            this.LabelTextCodirov = new System.Windows.Forms.Label();
            this.BtnZacodirov = new System.Windows.Forms.Button();
            this.BtnDecodirov = new System.Windows.Forms.Button();
            this.TextSlovar = new System.Windows.Forms.TextBox();
            this.LabelSlovar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComboVariantShifr
            // 
            this.ComboVariantShifr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ComboVariantShifr.FormattingEnabled = true;
            this.ComboVariantShifr.Items.AddRange(new object[] {
            "хафмен",
            "Фано Шеннон",
            "арифметическое",
            "БВТ и РЛЕ",
            "ЛЗ77",
            "хемминг",
            "лин код 5,2"});
            this.ComboVariantShifr.Location = new System.Drawing.Point(23, 75);
            this.ComboVariantShifr.Name = "ComboVariantShifr";
            this.ComboVariantShifr.Size = new System.Drawing.Size(260, 24);
            this.ComboVariantShifr.TabIndex = 2;
            // 
            // TextDecodir
            // 
            this.TextDecodir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.TextDecodir.Location = new System.Drawing.Point(333, 75);
            this.TextDecodir.Multiline = true;
            this.TextDecodir.Name = "TextDecodir";
            this.TextDecodir.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextDecodir.Size = new System.Drawing.Size(349, 345);
            this.TextDecodir.TabIndex = 3;
            // 
            // TextCodir
            // 
            this.TextCodir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.TextCodir.Location = new System.Drawing.Point(765, 75);
            this.TextCodir.Multiline = true;
            this.TextCodir.Name = "TextCodir";
            this.TextCodir.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextCodir.Size = new System.Drawing.Size(349, 345);
            this.TextCodir.TabIndex = 4;
            // 
            // LabelText
            // 
            this.LabelText.AutoSize = true;
            this.LabelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.LabelText.Location = new System.Drawing.Point(700, 232);
            this.LabelText.Name = "LabelText";
            this.LabelText.Size = new System.Drawing.Size(46, 31);
            this.LabelText.TabIndex = 7;
            this.LabelText.Text = "<>";
            // 
            // LabelVariantShifr
            // 
            this.LabelVariantShifr.AutoSize = true;
            this.LabelVariantShifr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LabelVariantShifr.Location = new System.Drawing.Point(28, 33);
            this.LabelVariantShifr.Name = "LabelVariantShifr";
            this.LabelVariantShifr.Size = new System.Drawing.Size(245, 20);
            this.LabelVariantShifr.TabIndex = 8;
            this.LabelVariantShifr.Text = "Выберите способ шифрования";
            // 
            // LabelTextDecodirov
            // 
            this.LabelTextDecodirov.AutoSize = true;
            this.LabelTextDecodirov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LabelTextDecodirov.Location = new System.Drawing.Point(339, 33);
            this.LabelTextDecodirov.Name = "LabelTextDecodirov";
            this.LabelTextDecodirov.Size = new System.Drawing.Size(194, 20);
            this.LabelTextDecodirov.TabIndex = 9;
            this.LabelTextDecodirov.Text = "Расшифрованный текст";
            // 
            // LabelTextCodirov
            // 
            this.LabelTextCodirov.AutoSize = true;
            this.LabelTextCodirov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LabelTextCodirov.Location = new System.Drawing.Point(771, 33);
            this.LabelTextCodirov.Name = "LabelTextCodirov";
            this.LabelTextCodirov.Size = new System.Drawing.Size(187, 20);
            this.LabelTextCodirov.TabIndex = 10;
            this.LabelTextCodirov.Text = "Зашифрованный текст";
            // 
            // BtnZacodirov
            // 
            this.BtnZacodirov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnZacodirov.Location = new System.Drawing.Point(32, 269);
            this.BtnZacodirov.Name = "BtnZacodirov";
            this.BtnZacodirov.Size = new System.Drawing.Size(143, 57);
            this.BtnZacodirov.TabIndex = 11;
            this.BtnZacodirov.Text = "Сжать";
            this.BtnZacodirov.UseVisualStyleBackColor = true;
            this.BtnZacodirov.Click += new System.EventHandler(this.BtnZacodirov_Click);
            // 
            // BtnDecodirov
            // 
            this.BtnDecodirov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnDecodirov.Location = new System.Drawing.Point(140, 348);
            this.BtnDecodirov.Name = "BtnDecodirov";
            this.BtnDecodirov.Size = new System.Drawing.Size(143, 57);
            this.BtnDecodirov.TabIndex = 12;
            this.BtnDecodirov.Text = "Расшифровать";
            this.BtnDecodirov.UseVisualStyleBackColor = true;
            this.BtnDecodirov.Click += new System.EventHandler(this.BtnDecodirov_Click);
            // 
            // TextSlovar
            // 
            this.TextSlovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.TextSlovar.Location = new System.Drawing.Point(1129, 75);
            this.TextSlovar.Multiline = true;
            this.TextSlovar.Name = "TextSlovar";
            this.TextSlovar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextSlovar.Size = new System.Drawing.Size(280, 345);
            this.TextSlovar.TabIndex = 13;
            // 
            // LabelSlovar
            // 
            this.LabelSlovar.AutoSize = true;
            this.LabelSlovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LabelSlovar.Location = new System.Drawing.Point(1137, 33);
            this.LabelSlovar.Name = "LabelSlovar";
            this.LabelSlovar.Size = new System.Drawing.Size(75, 20);
            this.LabelSlovar.TabIndex = 14;
            this.LabelSlovar.Text = "Словарь";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 450);
            this.Controls.Add(this.LabelSlovar);
            this.Controls.Add(this.TextSlovar);
            this.Controls.Add(this.BtnDecodirov);
            this.Controls.Add(this.BtnZacodirov);
            this.Controls.Add(this.LabelTextCodirov);
            this.Controls.Add(this.LabelTextDecodirov);
            this.Controls.Add(this.LabelVariantShifr);
            this.Controls.Add(this.LabelText);
            this.Controls.Add(this.TextCodir);
            this.Controls.Add(this.TextDecodir);
            this.Controls.Add(this.ComboVariantShifr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ComboVariantShifr;
        private System.Windows.Forms.TextBox TextDecodir;
        private System.Windows.Forms.TextBox TextCodir;
        private System.Windows.Forms.Label LabelText;
        private System.Windows.Forms.Label LabelVariantShifr;
        private System.Windows.Forms.Label LabelTextDecodirov;
        private System.Windows.Forms.Label LabelTextCodirov;
        private System.Windows.Forms.Button BtnZacodirov;
        private System.Windows.Forms.Button BtnDecodirov;
        private System.Windows.Forms.TextBox TextSlovar;
        private System.Windows.Forms.Label LabelSlovar;
    }
}

