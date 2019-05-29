namespace Symmetric_Encryption
{
	partial class Title
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
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(206, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(213, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Выберите способ шифрования";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(94, 105);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(149, 76);
			this.button1.TabIndex = 1;
			this.button1.Text = "Шифрование данных из текстового файла";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(363, 105);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(149, 76);
			this.button2.TabIndex = 2;
			this.button2.Text = "Шифрование текста, введенным пользователем";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(236, 225);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(149, 88);
			this.button3.TabIndex = 3;
			this.button3.Text = "Расшифровка данных с файла";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3_Click);
			// 
			// Title
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(644, 343);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Name = "Title";
			this.Text = "Алгоритм шифрования DES";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
	}
}

