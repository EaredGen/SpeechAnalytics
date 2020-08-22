namespace SpeechChatAnalytics
{
    partial class MainForm
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
            this.buttonRead = new System.Windows.Forms.Button();
            this.textBoxDirectionForReading = new System.Windows.Forms.TextBox();
            this.textBoxDirectionForWritting = new System.Windows.Forms.TextBox();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.richTextBoxAllThemes = new System.Windows.Forms.RichTextBox();
            this.richTextBoxSelectedThemes = new System.Windows.Forms.RichTextBox();
            this.checkBoxAllowChangeThemes = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonChooseReadingDirection = new System.Windows.Forms.Button();
            this.buttonChooseWrittingDirection = new System.Windows.Forms.Button();
            this.buttonSaveThemes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRead
            // 
            this.buttonRead.Enabled = false;
            this.buttonRead.Location = new System.Drawing.Point(12, 421);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(75, 23);
            this.buttonRead.TabIndex = 0;
            this.buttonRead.Text = "Выгрузить";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonRead_MouseClick);
            // 
            // textBoxDirectionForReading
            // 
            this.textBoxDirectionForReading.Location = new System.Drawing.Point(93, 395);
            this.textBoxDirectionForReading.Name = "textBoxDirectionForReading";
            this.textBoxDirectionForReading.Size = new System.Drawing.Size(210, 20);
            this.textBoxDirectionForReading.TabIndex = 1;
            this.textBoxDirectionForReading.Text = "Выберите файл с выгрузкой по чатам";
            // 
            // textBoxDirectionForWritting
            // 
            this.textBoxDirectionForWritting.Location = new System.Drawing.Point(94, 498);
            this.textBoxDirectionForWritting.Name = "textBoxDirectionForWritting";
            this.textBoxDirectionForWritting.Size = new System.Drawing.Size(209, 20);
            this.textBoxDirectionForWritting.TabIndex = 2;
            this.textBoxDirectionForWritting.Text = "Выберите пустой Excel для записи";
            // 
            // buttonWrite
            // 
            this.buttonWrite.Enabled = false;
            this.buttonWrite.Location = new System.Drawing.Point(13, 527);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(75, 23);
            this.buttonWrite.TabIndex = 3;
            this.buttonWrite.Text = "Записать";
            this.buttonWrite.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 590);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(291, 23);
            this.progressBar.TabIndex = 4;
            // 
            // richTextBoxAllThemes
            // 
            this.richTextBoxAllThemes.Location = new System.Drawing.Point(323, 285);
            this.richTextBoxAllThemes.Name = "richTextBoxAllThemes";
            this.richTextBoxAllThemes.ReadOnly = true;
            this.richTextBoxAllThemes.Size = new System.Drawing.Size(261, 328);
            this.richTextBoxAllThemes.TabIndex = 5;
            this.richTextBoxAllThemes.Text = "";
            // 
            // richTextBoxSelectedThemes
            // 
            this.richTextBoxSelectedThemes.Location = new System.Drawing.Point(323, 40);
            this.richTextBoxSelectedThemes.Name = "richTextBoxSelectedThemes";
            this.richTextBoxSelectedThemes.Size = new System.Drawing.Size(261, 202);
            this.richTextBoxSelectedThemes.TabIndex = 6;
            this.richTextBoxSelectedThemes.Text = "";
            // 
            // checkBoxAllowChangeThemes
            // 
            this.checkBoxAllowChangeThemes.AutoSize = true;
            this.checkBoxAllowChangeThemes.Location = new System.Drawing.Point(323, 262);
            this.checkBoxAllowChangeThemes.Name = "checkBoxAllowChangeThemes";
            this.checkBoxAllowChangeThemes.Size = new System.Drawing.Size(168, 17);
            this.checkBoxAllowChangeThemes.TabIndex = 7;
            this.checkBoxAllowChangeThemes.Text = "Разрешить редактирование";
            this.checkBoxAllowChangeThemes.UseVisualStyleBackColor = true;
            this.checkBoxAllowChangeThemes.Click += new System.EventHandler(this.checkBoxAllowChangeThemes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Актуальные тематики для поиска";
            // 
            // buttonChooseReadingDirection
            // 
            this.buttonChooseReadingDirection.Location = new System.Drawing.Point(12, 392);
            this.buttonChooseReadingDirection.Name = "buttonChooseReadingDirection";
            this.buttonChooseReadingDirection.Size = new System.Drawing.Size(75, 23);
            this.buttonChooseReadingDirection.TabIndex = 9;
            this.buttonChooseReadingDirection.Text = "Выбрать";
            this.buttonChooseReadingDirection.UseVisualStyleBackColor = true;
            this.buttonChooseReadingDirection.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonChooseDirection_MouseClick);
            // 
            // buttonChooseWrittingDirection
            // 
            this.buttonChooseWrittingDirection.Location = new System.Drawing.Point(13, 498);
            this.buttonChooseWrittingDirection.Name = "buttonChooseWrittingDirection";
            this.buttonChooseWrittingDirection.Size = new System.Drawing.Size(75, 23);
            this.buttonChooseWrittingDirection.TabIndex = 10;
            this.buttonChooseWrittingDirection.Text = "Выбрать";
            this.buttonChooseWrittingDirection.UseVisualStyleBackColor = true;
            this.buttonChooseWrittingDirection.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonChooseDirection_MouseClick);
            // 
            // buttonSaveThemes
            // 
            this.buttonSaveThemes.Location = new System.Drawing.Point(497, 258);
            this.buttonSaveThemes.Name = "buttonSaveThemes";
            this.buttonSaveThemes.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveThemes.TabIndex = 11;
            this.buttonSaveThemes.Text = "Сохранить";
            this.buttonSaveThemes.UseVisualStyleBackColor = true;
            this.buttonSaveThemes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonSaveThemes_MouseClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 625);
            this.Controls.Add(this.buttonSaveThemes);
            this.Controls.Add(this.buttonChooseWrittingDirection);
            this.Controls.Add(this.buttonChooseReadingDirection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxAllowChangeThemes);
            this.Controls.Add(this.richTextBoxSelectedThemes);
            this.Controls.Add(this.richTextBoxAllThemes);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.buttonWrite);
            this.Controls.Add(this.textBoxDirectionForWritting);
            this.Controls.Add(this.textBoxDirectionForReading);
            this.Controls.Add(this.buttonRead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Speech analytics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRead;
        public System.Windows.Forms.TextBox textBoxDirectionForReading;
        private System.Windows.Forms.TextBox textBoxDirectionForWritting;
        private System.Windows.Forms.Button buttonWrite;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.RichTextBox richTextBoxAllThemes;
        public System.Windows.Forms.RichTextBox richTextBoxSelectedThemes;
        private System.Windows.Forms.CheckBox checkBoxAllowChangeThemes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonChooseReadingDirection;
        private System.Windows.Forms.Button buttonChooseWrittingDirection;
        private System.Windows.Forms.Button buttonSaveThemes;
    }
}

