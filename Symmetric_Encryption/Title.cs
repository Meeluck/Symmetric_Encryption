using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Symmetric_Encryption
{
	public partial class Title : Form
	{
		public Title()
		{
			InitializeComponent();
		}


		private void Button1_Click(object sender, EventArgs e)
		{
			// переход на форму с шифрованием текста, полученного из файла
			Encrypt_Text_File fl = new Encrypt_Text_File();
			fl.Show();
			//Закрываем исходную форму
			Title cl = new Title();
			cl.Close();
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			// переход на форму для шифрования текса, введенного пользователем с клавиатуры
			Encrypt_Entered_Text fr = new Encrypt_Entered_Text();
			fr.Show();
			//Закрываем исходную форму
			Title cl = new Title();
			cl.Close();
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			Decrypt_Text_File dt = new Decrypt_Text_File();
			Title cl = new Title();
			cl.Close();
			dt.Show();

		}
	}
}
