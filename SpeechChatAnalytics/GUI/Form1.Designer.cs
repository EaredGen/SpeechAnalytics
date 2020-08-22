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
        /// <param Name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
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
            this.progressBarWriting = new System.Windows.Forms.ProgressBar();
            this.richTextBoxAllThemes = new System.Windows.Forms.RichTextBox();
            this.richTextBoxSelectedThemes = new System.Windows.Forms.RichTextBox();
            this.checkBoxAllowChangeThemes = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonChooseReadingDirection = new System.Windows.Forms.Button();
            this.buttonSaveThemes = new System.Windows.Forms.Button();
            this.labelWritingProgress = new System.Windows.Forms.Label();
            this.progressBarAnalyze = new System.Windows.Forms.ProgressBar();
            this.labelAnalyzeProgress = new System.Windows.Forms.Label();
            this.progressBarReading = new System.Windows.Forms.ProgressBar();
            this.labelReadingProgress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRead
            // 
            this.buttonRead.Enabled = false;
            this.buttonRead.Location = new System.Drawing.Point(16, 435);
            this.buttonRead.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(100, 28);
            this.buttonRead.TabIndex = 0;
            this.buttonRead.Text = "Выгрузить";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // textBoxDirectionForReading
            // 
            this.textBoxDirectionForReading.Location = new System.Drawing.Point(124, 391);
            this.textBoxDirectionForReading.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDirectionForReading.Name = "textBoxDirectionForReading";
            this.textBoxDirectionForReading.Size = new System.Drawing.Size(279, 22);
            this.textBoxDirectionForReading.TabIndex = 1;
            this.textBoxDirectionForReading.Text = "Выберите файл с выгрузкой по чатам";
            // 
            // progressBarWriting
            // 
            this.progressBarWriting.Location = new System.Drawing.Point(16, 726);
            this.progressBarWriting.Margin = new System.Windows.Forms.Padding(4);
            this.progressBarWriting.Name = "progressBarWriting";
            this.progressBarWriting.Size = new System.Drawing.Size(388, 23);
            this.progressBarWriting.TabIndex = 4;
            // 
            // richTextBoxAllThemes
            // 
            this.richTextBoxAllThemes.Location = new System.Drawing.Point(431, 351);
            this.richTextBoxAllThemes.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxAllThemes.Name = "richTextBoxAllThemes";
            this.richTextBoxAllThemes.ReadOnly = true;
            this.richTextBoxAllThemes.Size = new System.Drawing.Size(347, 403);
            this.richTextBoxAllThemes.TabIndex = 5;
            this.richTextBoxAllThemes.Text = "";
            // 
            // richTextBoxSelectedThemes
            // 
            this.richTextBoxSelectedThemes.Location = new System.Drawing.Point(431, 49);
            this.richTextBoxSelectedThemes.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxSelectedThemes.Name = "richTextBoxSelectedThemes";
            this.richTextBoxSelectedThemes.Size = new System.Drawing.Size(347, 248);
            this.richTextBoxSelectedThemes.TabIndex = 6;
            this.richTextBoxSelectedThemes.Text = "";
            // 
            // checkBoxAllowChangeThemes
            // 
            this.checkBoxAllowChangeThemes.AutoSize = true;
            this.checkBoxAllowChangeThemes.Location = new System.Drawing.Point(431, 322);
            this.checkBoxAllowChangeThemes.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxAllowChangeThemes.Name = "checkBoxAllowChangeThemes";
            this.checkBoxAllowChangeThemes.Size = new System.Drawing.Size(216, 21);
            this.checkBoxAllowChangeThemes.TabIndex = 7;
            this.checkBoxAllowChangeThemes.Text = "Разрешить редактирование";
            this.checkBoxAllowChangeThemes.UseVisualStyleBackColor = true;
            this.checkBoxAllowChangeThemes.Click += new System.EventHandler(this.checkBoxAllowChangeThemes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Актуальные тематики для поиска";
            // 
            // buttonChooseReadingDirection
            // 
            this.buttonChooseReadingDirection.Location = new System.Drawing.Point(16, 388);
            this.buttonChooseReadingDirection.Margin = new System.Windows.Forms.Padding(4);
            this.buttonChooseReadingDirection.Name = "buttonChooseReadingDirection";
            this.buttonChooseReadingDirection.Size = new System.Drawing.Size(100, 28);
            this.buttonChooseReadingDirection.TabIndex = 9;
            this.buttonChooseReadingDirection.Text = "Выбрать";
            this.buttonChooseReadingDirection.UseVisualStyleBackColor = true;
            this.buttonChooseReadingDirection.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonChooseDirection_MouseClick);
            // 
            // buttonSaveThemes
            // 
            this.buttonSaveThemes.Location = new System.Drawing.Point(663, 318);
            this.buttonSaveThemes.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveThemes.Name = "buttonSaveThemes";
            this.buttonSaveThemes.Size = new System.Drawing.Size(100, 28);
            this.buttonSaveThemes.TabIndex = 11;
            this.buttonSaveThemes.Text = "Сохранить";
            this.buttonSaveThemes.UseVisualStyleBackColor = true;
            this.buttonSaveThemes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonSaveThemes_MouseClick);
            // 
            // labelWritingProgress
            // 
            this.labelWritingProgress.AutoSize = true;
            this.labelWritingProgress.Location = new System.Drawing.Point(16, 700);
            this.labelWritingProgress.Name = "labelWritingProgress";
            this.labelWritingProgress.Size = new System.Drawing.Size(119, 17);
            this.labelWritingProgress.TabIndex = 12;
            this.labelWritingProgress.Text = "Прогресс записи";
            // 
            // progressBarAnalyze
            // 
            this.progressBarAnalyze.Location = new System.Drawing.Point(16, 661);
            this.progressBarAnalyze.Name = "progressBarAnalyze";
            this.progressBarAnalyze.Size = new System.Drawing.Size(388, 23);
            this.progressBarAnalyze.TabIndex = 13;
            // 
            // labelAnalyzeProgress
            // 
            this.labelAnalyzeProgress.AutoSize = true;
            this.labelAnalyzeProgress.Location = new System.Drawing.Point(16, 635);
            this.labelAnalyzeProgress.Name = "labelAnalyzeProgress";
            this.labelAnalyzeProgress.Size = new System.Drawing.Size(128, 17);
            this.labelAnalyzeProgress.TabIndex = 14;
            this.labelAnalyzeProgress.Text = "Прогресс анализа";
            // 
            // progressBarReading
            // 
            this.progressBarReading.Location = new System.Drawing.Point(16, 601);
            this.progressBarReading.Name = "progressBarReading";
            this.progressBarReading.Size = new System.Drawing.Size(388, 23);
            this.progressBarReading.TabIndex = 15;
            // 
            // labelReadingProgress
            // 
            this.labelReadingProgress.AutoSize = true;
            this.labelReadingProgress.Location = new System.Drawing.Point(16, 575);
            this.labelReadingProgress.Name = "labelReadingProgress";
            this.labelReadingProgress.Size = new System.Drawing.Size(120, 17);
            this.labelReadingProgress.TabIndex = 16;
            this.labelReadingProgress.Text = "Прогресс чтения";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 769);
            this.Controls.Add(this.labelReadingProgress);
            this.Controls.Add(this.progressBarReading);
            this.Controls.Add(this.labelAnalyzeProgress);
            this.Controls.Add(this.progressBarAnalyze);
            this.Controls.Add(this.labelWritingProgress);
            this.Controls.Add(this.buttonSaveThemes);
            this.Controls.Add(this.buttonChooseReadingDirection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxAllowChangeThemes);
            this.Controls.Add(this.richTextBoxSelectedThemes);
            this.Controls.Add(this.richTextBoxAllThemes);
            this.Controls.Add(this.progressBarWriting);
            this.Controls.Add(this.textBoxDirectionForReading);
            this.Controls.Add(this.buttonRead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Speech analytics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.TextBox textBoxDirectionForReading;
        private System.Windows.Forms.ProgressBar progressBarWriting;
        private System.Windows.Forms.RichTextBox richTextBoxAllThemes;
        private System.Windows.Forms.RichTextBox richTextBoxSelectedThemes;
        private System.Windows.Forms.CheckBox checkBoxAllowChangeThemes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonChooseReadingDirection;
        private System.Windows.Forms.Button buttonSaveThemes;
        private System.Windows.Forms.Label labelWritingProgress;
        private System.Windows.Forms.ProgressBar progressBarAnalyze;
        private System.Windows.Forms.Label labelAnalyzeProgress;
        private System.Windows.Forms.ProgressBar progressBarReading;
        private System.Windows.Forms.Label labelReadingProgress;
    }
}

