namespace Symmetric_Encryption
{
	partial class Encrypt_Text_File
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textbox_roadToFile = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textbox_FailOpenFile = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textbox_FilePath = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textbox_OutEncryptionText = new System.Windows.Forms.TextBox();
			this.button_Encryption = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox_KeyWord = new System.Windows.Forms.TextBox();
			this.textbox_roadToExeptionFile = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(430, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(164, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "ШИФРОВАНИЕ ФАЙЛА";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 98);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(174, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Укажите путь до файла";
			// 
			// textbox_roadToFile
			// 
			this.textbox_roadToFile.Location = new System.Drawing.Point(557, 100);
			this.textbox_roadToFile.Name = "textbox_roadToFile";
			this.textbox_roadToFile.Size = new System.Drawing.Size(585, 22);
			this.textbox_roadToFile.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(205, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(300, 17);
			this.label3.TabIndex = 3;
			this.label3.Text = "Например (C:\\Users\\dell\\Desktop\\Example.txt)";
			// 
			// textbox_FailOpenFile
			// 
			this.textbox_FailOpenFile.Location = new System.Drawing.Point(557, 143);
			this.textbox_FailOpenFile.Name = "textbox_FailOpenFile";
			this.textbox_FailOpenFile.Size = new System.Drawing.Size(585, 22);
			this.textbox_FailOpenFile.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(12, 148);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(373, 17);
			this.label4.TabIndex = 5;
			this.label4.Text = "Место для вывода ошибки/ успешного указания файла";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 204);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(302, 17);
			this.label5.TabIndex = 6;
			this.label5.Text = "Теста для шифрования, считанный с файла";
			// 
			// textbox_FilePath
			// 
			this.textbox_FilePath.Location = new System.Drawing.Point(557, 173);
			this.textbox_FilePath.Multiline = true;
			this.textbox_FilePath.Name = "textbox_FilePath";
			this.textbox_FilePath.Size = new System.Drawing.Size(585, 82);
			this.textbox_FilePath.TabIndex = 7;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 401);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(215, 17);
			this.label6.TabIndex = 8;
			this.label6.Text = "Вывод зашифрованного текста";
			// 
			// textbox_OutEncryptionText
			// 
			this.textbox_OutEncryptionText.Location = new System.Drawing.Point(557, 377);
			this.textbox_OutEncryptionText.Multiline = true;
			this.textbox_OutEncryptionText.Name = "textbox_OutEncryptionText";
			this.textbox_OutEncryptionText.Size = new System.Drawing.Size(585, 106);
			this.textbox_OutEncryptionText.TabIndex = 9;
			// 
			// button_Encryption
			// 
			this.button_Encryption.Location = new System.Drawing.Point(367, 291);
			this.button_Encryption.Name = "button_Encryption";
			this.button_Encryption.Size = new System.Drawing.Size(293, 80);
			this.button_Encryption.TabIndex = 11;
			this.button_Encryption.Text = "Нажмите для шифрование текста";
			this.button_Encryption.UseVisualStyleBackColor = true;
			this.button_Encryption.Click += new System.EventHandler(this.Button_Encryption_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(12, 266);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 17);
			this.label8.TabIndex = 13;
			this.label8.Text = "Введите ключ";
			// 
			// textBox_KeyWord
			// 
			this.textBox_KeyWord.Location = new System.Drawing.Point(557, 263);
			this.textBox_KeyWord.Name = "textBox_KeyWord";
			this.textBox_KeyWord.Size = new System.Drawing.Size(307, 22);
			this.textBox_KeyWord.TabIndex = 14;
			// 
			// textbox_roadToExeptionFile
			// 
			this.textbox_roadToExeptionFile.Location = new System.Drawing.Point(557, 489);
			this.textbox_roadToExeptionFile.Name = "textbox_roadToExeptionFile";
			this.textbox_roadToExeptionFile.Size = new System.Drawing.Size(414, 22);
			this.textbox_roadToExeptionFile.TabIndex = 15;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.Location = new System.Drawing.Point(12, 492);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(369, 17);
			this.label9.TabIndex = 16;
			this.label9.Text = "Укажите место, куда сохранить зашифрованный файл";
			// 
			// Encrypt_Text_File
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1158, 556);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.textbox_roadToExeptionFile);
			this.Controls.Add(this.textBox_KeyWord);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.button_Encryption);
			this.Controls.Add(this.textbox_OutEncryptionText);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textbox_FilePath);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textbox_FailOpenFile);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textbox_roadToFile);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Encrypt_Text_File";
			this.Text = "Encrypt_Text_File";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textbox_roadToFile;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textbox_FailOpenFile;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textbox_FilePath;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textbox_OutEncryptionText;
		private System.Windows.Forms.Button button_Encryption;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox_KeyWord;
		private System.Windows.Forms.TextBox textbox_roadToExeptionFile;
		private System.Windows.Forms.Label label9;
	}
}