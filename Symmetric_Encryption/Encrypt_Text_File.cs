using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Main_Functionality;

namespace Symmetric_Encryption
{
	public partial class Encrypt_Text_File : Form
	{
		public Encrypt_Text_File()
		{
			InitializeComponent();
		}
		private void Button_Encryption_Click(object sender, EventArgs e)
		{
			if(textBox_KeyWord.Text.Length>0)
			{
				string s = ""; //строка с полученными данными для дальнейшего шифрования
				string key = textBox_KeyWord.Text; // строка с ключом
				//обработка ошибки, если файл не найден
				try
				{
					// обрабатываем получение адресса файла
					string roadToFile = @"";// переменная для указания путь до файла, который необходимо зашифровать
					string road = textbox_roadToFile.Text;
					roadToFile = roadToFile + road;//полный путь до файла
					StreamReader rd = new StreamReader(roadToFile);
					// Запись данных из файла в переменную-строку
					while (!rd.EndOfStream)
					{
						s += rd.ReadLine();
					}
					rd.Close(); // закрываем файл, откуда считываем информацию
					textbox_FailOpenFile.Text = "Файл успешно считан";
				}
				catch (FileNotFoundException)
				{
					textbox_FailOpenFile.Text = "Ошибка открытия файла. Проверьте, правильно ли вы указали путь";
					textbox_roadToFile.Text = "";
				return;
				}
				catch (ArgumentException)
				{
					textbox_FailOpenFile.Text = "Пустое имя пути не допускается.";
					return;
				}

				//вывод считанных данных
				textbox_FilePath.Text = s; 
				// Проверяем длину считанного текста на кратность 128 (для последующего разбиения на блоки шифрования)
				// Если не кратно, до добавляем символы до кратной 128 длине
				s = Function.StringToRightLength(s);
				
				//Разбиваем текста на блоки по 128 бит
				Function.CutStringIntoBlocks(s);
				key = Function.CorrectKeyWord(key,4);
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

				string ResultEncryption = "";
				for (int i = 0; i < Function.Blocks.Length; i++)
					ResultEncryption += Function.Blocks[i];
				//вывод зашифрованных данных на экран
				textbox_OutEncryptionText.Text = ResultEncryption;
				//запись зашифрованных данных в файл
				try
				{
					string roadToExeptionFile = @"";
					roadToExeptionFile = roadToExeptionFile + textbox_roadToExeptionFile.Text;
					StreamWriter sw = new StreamWriter(roadToExeptionFile, true);
					sw.WriteLine(ResultEncryption);
					sw.Close();
					Process.Start(roadToExeptionFile);
				}
				catch(DirectoryNotFoundException)
				{
					MessageBox.Show("Некоректно указано место сохранения и название файла");
					return;
				}
				catch (ArgumentException)
				{
					MessageBox.Show("Пустое имя пути не допускается.");
					return;
				}
			}
			else
			{
				MessageBox.Show("Введите ключевое слово");
			}
		}

	}
}
