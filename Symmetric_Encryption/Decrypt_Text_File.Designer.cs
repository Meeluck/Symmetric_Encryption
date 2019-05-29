namespace Symmetric_Encryption
{
	partial class Decrypt_Text_File
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
			this.button_Decrypt = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.textbox_roadToFile = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox_DecodeKeyWord = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.textbox_roadToDecpyptFile = new System.Windows.Forms.TextBox();
			this.textbox_OutDecryptionText = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button_Decrypt
			// 
			this.button_Decrypt.Location = new System.Drawing.Point(467, 169);
			this.button_Decrypt.Name = "button_Decrypt";
			this.button_Decrypt.Size = new System.Drawing.Size(187, 84);
			this.button_Decrypt.TabIndex = 2;
			this.button_Decrypt.Text = "Дешифровка";
			this.button_Decrypt.UseVisualStyleBackColor = true;
			this.button_Decrypt.Click += new System.EventHandler(this.Button_Decrypt_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(205, 54);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(300, 17);
			this.label3.TabIndex = 6;
			this.label3.Text = "Например (C:\\Users\\dell\\Desktop\\Example.txt)";
			// 
			// textbox_roadToFile
			// 
			this.textbox_roadToFile.Location = new System.Drawing.Point(566, 55);
			this.textbox_roadToFile.Name = "textbox_roadToFile";
			this.textbox_roadToFile.Size = new System.Drawing.Size(585, 22);
			this.textbox_roadToFile.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(21, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(174, 18);
			this.label2.TabIndex = 4;
			this.label2.Text = "Укажите путь до файла";
			// 
			// textBox_DecodeKeyWord
			// 
			this.textBox_DecodeKeyWord.Location = new System.Drawing.Point(566, 110);
			this.textBox_DecodeKeyWord.Name = "textBox_DecodeKeyWord";
			this.textBox_DecodeKeyWord.Size = new System.Drawing.Size(181, 22);
			this.textBox_DecodeKeyWord.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(282, 110);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(223, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Введитю ключ дешифрования.";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.Location = new System.Drawing.Point(115, 397);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(400, 18);
			this.label9.TabIndex = 27;
			this.label9.Text = "Укажите место, куда сохранить расшифрованный файл";
			// 
			// textbox_roadToDecpyptFile
			// 
			this.textbox_roadToDecpyptFile.Location = new System.Drawing.Point(566, 394);
			this.textbox_roadToDecpyptFile.Name = "textbox_roadToDecpyptFile";
			this.textbox_roadToDecpyptFile.Size = new System.Drawing.Size(414, 22);
			this.textbox_roadToDecpyptFile.TabIndex = 26;
			// 
			// textbox_OutDecryptionText
			// 
			this.textbox_OutDecryptionText.Location = new System.Drawing.Point(566, 286);
			this.textbox_OutDecryptionText.Multiline = true;
			this.textbox_OutDecryptionText.Name = "textbox_OutDecryptionText";
			this.textbox_OutDecryptionText.Size = new System.Drawing.Size(558, 87);
			this.textbox_OutDecryptionText.TabIndex = 25;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(275, 322);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(230, 18);
			this.label6.TabIndex = 24;
			this.label6.Text = "Вывод дешифрованных данных";
			// 
			// Decrypt_Text_File
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1178, 498);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.textbox_roadToDecpyptFile);
			this.Controls.Add(this.textbox_OutDecryptionText);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textbox_roadToFile);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button_Decrypt);
			this.Controls.Add(this.textBox_DecodeKeyWord);
			this.Controls.Add(this.label1);
			this.Name = "Decrypt_Text_File";
			this.Text = "Decrypt_Text_File";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button_Decrypt;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textbox_roadToFile;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox_DecodeKeyWord;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textbox_roadToDecpyptFile;
		private System.Windows.Forms.TextBox textbox_OutDecryptionText;
		private System.Windows.Forms.Label label6;
	}
}