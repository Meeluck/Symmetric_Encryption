using System;
using System.Windows.Forms;
using Main_Functionality;
using System.Diagnostics;
using System.IO;
namespace Symmetric_Encryption
{
	public partial class Encrypt_Entered_Text : Form
	{
		public Encrypt_Entered_Text()
		{
			InitializeComponent();
		}

		private void ButtonEncryptionText_Click(object sender, EventArgs e)
		{
			if (textBoxEnterKeyWord.Text.Length>0)
			{
				string s = textBoxTextForEncryption.Text; //строка с полученными данными для дальнейшего шифрования
				if (s=="")
				{
					MessageBox.Show("Введите данные, которые хотите зашифровать");
					return;
				}
				string key = textBoxEnterKeyWord.Text; // строка с ключом

				//запись полученных данных в файл
				string roadToWriteFile = @"";
				try
				{
					roadToWriteFile = roadToWriteFile + textbox_roadToFile.Text;
					StreamWriter sw = new StreamWriter(roadToWriteFile,false);
					sw.WriteLine(s);
					sw.Close();
					textbox_FailOpenFile.Text = "Данные записаны в файл";
				}
				catch(UnauthorizedAccessException)
				{
					textbox_FailOpenFile.Text = "Некорректно указано место сохранения и название файла";
					return;
				}
				catch (DirectoryNotFoundException)
				{
					textbox_FailOpenFile.Text = "Некорректно указано место сохранения и название файла";
					return;
				}
				catch (ArgumentException)
				{
					textbox_FailOpenFile.Text= "Пустое имя пути не допускается.";
					return;
				}
				// Проверяем длину считанного текста на кратность 128 (для последующего разбиения на блоки шифрования)
				// Если не кратно, до добавляем символы до кратной 128 длине
				s = Function.StringToRightLength(s);
				// Переводим текст в бинарный вид и разбиваем текст на блоки по 128 бит
				Function.CutStringIntoBlocks(s);
				
				// Приводим пароль к необходимому для шифрования виду
				key = Function.CorrectKeyWord(key, 4);
				key = Function.StringToBinaryFormat(key);

				//блок шифрования
				for (int i = 0; i < Function.quantityOfRounds; i++)
				{
					for (int j = 0; j < Function.Blocks.Length; j++)
						// раунд шифрования DES
						Function.Blocks[j] = Function.EncodeDES_One_Round(Function.Blocks[j], key);
					//Вычисление ключа для следующего раунда шифрования
					key = Function.KeyToNextRound(key);
				}
				//запись зашифрованных данных в файл
				string ResultEncryption = "";
				for (int i = 0; i < Function.Blocks.Length; i++)
					ResultEncryption += Function.Blocks[i];
				textboxOutEncryptionText.Text = ResultEncryption;
				string roadToExeptionFile = @"";
				try
				{
					roadToExeptionFile = roadToExeptionFile + textbox_roadToExeptionFile.Text;
					StreamWriter swout = new StreamWriter(roadToExeptionFile,false);
					swout.WriteLine(ResultEncryption);
					swout.Close();
					Process.Start(roadToExeptionFile);
				}
				catch(UnauthorizedAccessException)
				{
					MessageBox.Show("Некорректно указано место сохранения и название файла");
					return;
				}
				catch (DirectoryNotFoundException)
				{
					MessageBox.Show("Некорректно указано место сохранения и название файла");
					return;
				}
				catch(ArgumentException)
				{
					MessageBox.Show("Пустое имя пути не допускается.");
					return;
				}
				Process.Start(roadToWriteFile);
				Process.Start(roadToExeptionFile);
			}
			else
			{
				MessageBox.Show("Введите ключевое слово");
			}
		}

	}
}
