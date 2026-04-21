namespace OpenKey
{
    partial class fMain
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
            this.pSide = new System.Windows.Forms.Panel();
            this.btnOpenEncryptedFile = new System.Windows.Forms.Button();
            this.lEilerValue = new System.Windows.Forms.Label();
            this.lEilerTitle = new System.Windows.Forms.Label();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnOpenSourceFile = new System.Windows.Forms.Button();
            this.btnDecryption = new System.Windows.Forms.Button();
            this.lYValue = new System.Windows.Forms.Label();
            this.lYTitle = new System.Windows.Forms.Label();
            this.btnEncryption = new System.Windows.Forms.Button();
            this.lXTitle = new System.Windows.Forms.Label();
            this.tbKC = new System.Windows.Forms.TextBox();
            this.lGTitle = new System.Windows.Forms.Label();
            this.btnAcceptP = new System.Windows.Forms.Button();
            this.lPTitle = new System.Windows.Forms.Label();
            this.tbP = new System.Windows.Forms.TextBox();
            this.tbOpenedFile = new System.Windows.Forms.TextBox();
            this.lOpenedFile = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.lResult = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tbQ = new System.Windows.Forms.TextBox();
            this.pSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // pSide
            // 
            this.pSide.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pSide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pSide.Controls.Add(this.tbQ);
            this.pSide.Controls.Add(this.btnOpenEncryptedFile);
            this.pSide.Controls.Add(this.lEilerValue);
            this.pSide.Controls.Add(this.lEilerTitle);
            this.pSide.Controls.Add(this.btnSaveFile);
            this.pSide.Controls.Add(this.btnOpenSourceFile);
            this.pSide.Controls.Add(this.btnDecryption);
            this.pSide.Controls.Add(this.lYValue);
            this.pSide.Controls.Add(this.lYTitle);
            this.pSide.Controls.Add(this.btnEncryption);
            this.pSide.Controls.Add(this.lXTitle);
            this.pSide.Controls.Add(this.tbKC);
            this.pSide.Controls.Add(this.lGTitle);
            this.pSide.Controls.Add(this.btnAcceptP);
            this.pSide.Controls.Add(this.lPTitle);
            this.pSide.Controls.Add(this.tbP);
            this.pSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pSide.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pSide.Location = new System.Drawing.Point(0, 0);
            this.pSide.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pSide.Name = "pSide";
            this.pSide.Size = new System.Drawing.Size(306, 554);
            this.pSide.TabIndex = 0;
            // 
            // btnOpenEncryptedFile
            // 
            this.btnOpenEncryptedFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenEncryptedFile.Location = new System.Drawing.Point(145, 343);
            this.btnOpenEncryptedFile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnOpenEncryptedFile.Name = "btnOpenEncryptedFile";
            this.btnOpenEncryptedFile.Size = new System.Drawing.Size(152, 72);
            this.btnOpenEncryptedFile.TabIndex = 18;
            this.btnOpenEncryptedFile.Text = "Открыть зашифрованный файл";
            this.btnOpenEncryptedFile.UseVisualStyleBackColor = true;
            this.btnOpenEncryptedFile.Click += new System.EventHandler(this.btnOpenEncryptedFile_Click);
            // 
            // lEilerValue
            // 
            this.lEilerValue.AutoSize = true;
            this.lEilerValue.Location = new System.Drawing.Point(254, 296);
            this.lEilerValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lEilerValue.Name = "lEilerValue";
            this.lEilerValue.Size = new System.Drawing.Size(22, 21);
            this.lEilerValue.TabIndex = 16;
            this.lEilerValue.Text = "\"\"";
            // 
            // lEilerTitle
            // 
            this.lEilerTitle.AutoSize = true;
            this.lEilerTitle.Location = new System.Drawing.Point(8, 296);
            this.lEilerTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lEilerTitle.Name = "lEilerTitle";
            this.lEilerTitle.Size = new System.Drawing.Size(206, 21);
            this.lEilerTitle.TabIndex = 15;
            this.lEilerTitle.Text = "Значение функции Эйлера:";
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveFile.Location = new System.Drawing.Point(10, 426);
            this.btnSaveFile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(287, 29);
            this.btnSaveFile.TabIndex = 14;
            this.btnSaveFile.Text = "Сохранить";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnOpenSourceFile
            // 
            this.btnOpenSourceFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenSourceFile.Location = new System.Drawing.Point(9, 343);
            this.btnOpenSourceFile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnOpenSourceFile.Name = "btnOpenSourceFile";
            this.btnOpenSourceFile.Size = new System.Drawing.Size(131, 72);
            this.btnOpenSourceFile.TabIndex = 13;
            this.btnOpenSourceFile.Text = "Открыть исходный файл";
            this.btnOpenSourceFile.UseVisualStyleBackColor = true;
            this.btnOpenSourceFile.Click += new System.EventHandler(this.btnOpenSourceFile_Click);
            // 
            // btnDecryption
            // 
            this.btnDecryption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecryption.Enabled = false;
            this.btnDecryption.Location = new System.Drawing.Point(145, 480);
            this.btnDecryption.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDecryption.Name = "btnDecryption";
            this.btnDecryption.Size = new System.Drawing.Size(152, 40);
            this.btnDecryption.TabIndex = 12;
            this.btnDecryption.Text = "Дешифровать";
            this.btnDecryption.UseVisualStyleBackColor = true;
            this.btnDecryption.Click += new System.EventHandler(this.btnDecryption_Click);
            // 
            // lYValue
            // 
            this.lYValue.AutoSize = true;
            this.lYValue.Location = new System.Drawing.Point(254, 256);
            this.lYValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lYValue.Name = "lYValue";
            this.lYValue.Size = new System.Drawing.Size(22, 21);
            this.lYValue.TabIndex = 11;
            this.lYValue.Text = "\"\"";
            // 
            // lYTitle
            // 
            this.lYTitle.AutoSize = true;
            this.lYTitle.Location = new System.Drawing.Point(8, 256);
            this.lYTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lYTitle.Name = "lYTitle";
            this.lYTitle.Size = new System.Drawing.Size(106, 21);
            this.lYTitle.TabIndex = 10;
            this.lYTitle.Text = "Значение KO:";
            // 
            // btnEncryption
            // 
            this.btnEncryption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncryption.Enabled = false;
            this.btnEncryption.Location = new System.Drawing.Point(7, 480);
            this.btnEncryption.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEncryption.Name = "btnEncryption";
            this.btnEncryption.Size = new System.Drawing.Size(134, 40);
            this.btnEncryption.TabIndex = 9;
            this.btnEncryption.Text = "Зашифровать";
            this.btnEncryption.UseVisualStyleBackColor = true;
            this.btnEncryption.Click += new System.EventHandler(this.btnEncryption_Click);
            // 
            // lXTitle
            // 
            this.lXTitle.AutoSize = true;
            this.lXTitle.Location = new System.Drawing.Point(4, 137);
            this.lXTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lXTitle.Name = "lXTitle";
            this.lXTitle.Size = new System.Drawing.Size(187, 21);
            this.lXTitle.TabIndex = 5;
            this.lXTitle.Text = "Укажите компоненту KC:";
            // 
            // tbKC
            // 
            this.tbKC.Location = new System.Drawing.Point(7, 161);
            this.tbKC.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbKC.Name = "tbKC";
            this.tbKC.Size = new System.Drawing.Size(287, 29);
            this.tbKC.TabIndex = 4;
            // 
            // lGTitle
            // 
            this.lGTitle.AutoSize = true;
            this.lGTitle.Location = new System.Drawing.Point(5, 70);
            this.lGTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lGTitle.Name = "lGTitle";
            this.lGTitle.Size = new System.Drawing.Size(190, 21);
            this.lGTitle.TabIndex = 3;
            this.lGTitle.Text = "Выберите компоненту Q:";
            // 
            // btnAcceptP
            // 
            this.btnAcceptP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcceptP.Location = new System.Drawing.Point(7, 210);
            this.btnAcceptP.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAcceptP.Name = "btnAcceptP";
            this.btnAcceptP.Size = new System.Drawing.Size(287, 29);
            this.btnAcceptP.TabIndex = 1;
            this.btnAcceptP.Text = "Подтвердить";
            this.btnAcceptP.UseVisualStyleBackColor = true;
            this.btnAcceptP.Click += new System.EventHandler(this.btnAcceptP_Click);
            // 
            // lPTitle
            // 
            this.lPTitle.AutoSize = true;
            this.lPTitle.Location = new System.Drawing.Point(5, 12);
            this.lPTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lPTitle.Name = "lPTitle";
            this.lPTitle.Size = new System.Drawing.Size(114, 21);
            this.lPTitle.TabIndex = 1;
            this.lPTitle.Text = "Компонента P:";
            // 
            // tbP
            // 
            this.tbP.Location = new System.Drawing.Point(8, 38);
            this.tbP.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbP.Name = "tbP";
            this.tbP.Size = new System.Drawing.Size(287, 29);
            this.tbP.TabIndex = 0;
            // 
            // tbOpenedFile
            // 
            this.tbOpenedFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOpenedFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOpenedFile.Location = new System.Drawing.Point(310, 25);
            this.tbOpenedFile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbOpenedFile.Multiline = true;
            this.tbOpenedFile.Name = "tbOpenedFile";
            this.tbOpenedFile.ReadOnly = true;
            this.tbOpenedFile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOpenedFile.Size = new System.Drawing.Size(447, 228);
            this.tbOpenedFile.TabIndex = 1;
            // 
            // lOpenedFile
            // 
            this.lOpenedFile.AutoSize = true;
            this.lOpenedFile.BackColor = System.Drawing.Color.White;
            this.lOpenedFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOpenedFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lOpenedFile.Location = new System.Drawing.Point(310, -1);
            this.lOpenedFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lOpenedFile.Name = "lOpenedFile";
            this.lOpenedFile.Size = new System.Drawing.Size(260, 21);
            this.lOpenedFile.TabIndex = 16;
            this.lOpenedFile.Text = "Содержимое открытого файла:";
            // 
            // tbResult
            // 
            this.tbResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResult.Location = new System.Drawing.Point(311, 294);
            this.tbResult.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResult.Size = new System.Drawing.Size(447, 249);
            this.tbResult.TabIndex = 17;
            // 
            // lResult
            // 
            this.lResult.AutoSize = true;
            this.lResult.BackColor = System.Drawing.Color.White;
            this.lResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lResult.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lResult.Location = new System.Drawing.Point(310, 271);
            this.lResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(90, 21);
            this.lResult.TabIndex = 18;
            this.lResult.Text = "Результат:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "save";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "save";
            // 
            // tbQ
            // 
            this.tbQ.Location = new System.Drawing.Point(7, 94);
            this.tbQ.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbQ.Name = "tbQ";
            this.tbQ.Size = new System.Drawing.Size(287, 29);
            this.tbQ.TabIndex = 19;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(765, 554);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.lOpenedFile);
            this.Controls.Add(this.tbOpenedFile);
            this.Controls.Add(this.pSide);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Шифрование с открытым кючом";
            this.pSide.ResumeLayout(false);
            this.pSide.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pSide;
        private System.Windows.Forms.Button btnAcceptP;
        private System.Windows.Forms.Label lPTitle;
        private System.Windows.Forms.TextBox tbP;
        private System.Windows.Forms.Label lXTitle;
        private System.Windows.Forms.TextBox tbKC;
        private System.Windows.Forms.Label lGTitle;
        private System.Windows.Forms.Button btnEncryption;
        private System.Windows.Forms.Label lYTitle;
        private System.Windows.Forms.Label lYValue;
        private System.Windows.Forms.Button btnDecryption;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnOpenSourceFile;
        private System.Windows.Forms.Label lEilerValue;
        private System.Windows.Forms.Label lEilerTitle;
        private System.Windows.Forms.TextBox tbOpenedFile;
        private System.Windows.Forms.Label lOpenedFile;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label lResult;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btnOpenEncryptedFile;
        private System.Windows.Forms.TextBox tbQ;
    }
}

