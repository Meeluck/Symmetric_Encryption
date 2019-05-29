using System;
using System.Windows.Forms;
using System.IO;
using Main_Functionality;
using System.Diagnostics;
namespace Symmetric_Encryption
{
	public partial class Decrypt_Text_File : Form
	{
		public Decrypt_Text_File()
		{
			InitializeComponent();
		}

		private void Button_Decrypt_Click(object sender, EventArgs e)
		{
			if (textBox_DecodeKeyWord.Text.Length > 0)
			{
				string s = "";
				string roadToEncriptFile = @"";
				try
				{
					roadToEncriptFile = roadToEncriptFile + textbox_roadToFile.Text;
					StreamReader sr = new StreamReader(roadToEncriptFile);
					while (!sr.EndOfStream)
					{
						s += sr.ReadLine();
					}
					sr.Close();
				}
				catch (UnauthorizedAccessException)
				{
					MessageBox.Show("Неккорректно указан путь до файла, который необходимо дешифровать");
					return;
				}
				catch (FileNotFoundException)
				{
					MessageBox.Show("Данный файл не найдет");
					return;
				}

				Function.CutBinaryStringIntoBlocks(s); // полученные данные делим на равные блоки

				string key = textBox_DecodeKeyWord.Text;
				
				key = Function.CorrectKeyWord(key, 4);
				key = Function.StringToBinaryFormat(key); // приводим ключ к бинарному виду

				// приводим ключ к нужному для дешифровки виду
				for (int i = 0; i < Function.quantityOfRounds; i++)
					key = Function.KeyToNextRound(key);
				//получаем первый ключ для дешифроки
				key = Function.KeyToPrevRound(key);

				for (int i=0; i < Function.quantityOfRounds; i++)
				{
					for (int j = 0; j < Function.Blocks.Length; j++)
						Function.Blocks[j] = Function.DecodeDES_One_Round(Function.Blocks[j], key);
					key = Function.KeyToPrevRound(key);
				}

				string result = "";
				for (int i = 0; i < Function.Blocks.Length; i++)
					result += Function.Blocks[i];
				textbox_OutDecryptionText.Text = Function.StringFromBinaryToNormalFormat(result);

				string roadToDecryptFile = @"";
				try
				{
					roadToDecryptFile = roadToDecryptFile + textbox_roadToDecpyptFile.Text;
					StreamWriter sw = new StreamWriter(roadToDecryptFile,true);
					sw.WriteLine(Function.StringFromBinaryToNormalFormat(result));
					sw.Close();
				}
				catch(UnauthorizedAccessException)
				{
					MessageBox.Show("Неккорректно указан путь до файла, в который необходимо записать дешифрованные данные");
					return;
				}
				catch(ArgumentException)
				{
					MessageBox.Show("Неуказан место, куда сохранить дешифрованные данные");
					return;
				}
				Process.Start(roadToEncriptFile);
				Process.Start(roadToDecryptFile);
			}
			else
			{
				MessageBox.Show("Введите ключ");
			}
		}
	}
}
