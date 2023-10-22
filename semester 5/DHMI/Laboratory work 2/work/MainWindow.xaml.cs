using Microsoft.Win32;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows;
using System.Windows.Input;
using Path = System.IO.Path;

namespace work
{
    public partial class MainWindow : Window
    {
        MD5 md5 = MD5.Create();
        string HashMd5 = "";
        string LastFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public MainWindow()
        {
            InitializeComponent();
        }
        private void DropFile(object sender, DragEventArgs e) => SelectFile(_DropFile(e));
        private void DropFileMd5(object sender, DragEventArgs e) => SelectFileMd5(_DropFile(e));
        private void SelectFile(object sender, MouseButtonEventArgs e) => SelectFile(_SelectFile(null));
        private void SelectFileMd5(object sender, MouseButtonEventArgs e) => SelectFileMd5(_SelectFile("Hash Files (*.md5)|*.md5|All Files (*.*)|*.*"));
        private string? _DropFile(DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if(files.Length > 0)
                {
                    return files[0];
                }
            }
            return null;
        }
        private string? _SelectFile(string? Filter)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if(Filter != null)
            {
                dialog.Filter = Filter;
            }
            dialog.InitialDirectory = LastFolder;
            if (dialog.ShowDialog() == true)
            {
                string? lastFolder = Path.GetDirectoryName(dialog.FileName);
                if(lastFolder != null)
                {
                    LastFolder = lastFolder;
                }
                return dialog.FileName;
            }
            return null;
        }
        private void SelectFile(string? src)
        {
            if(src != null)
            {
                try
                {
                    HashMd5 = BitConverter.ToString(md5.ComputeHash(File.ReadAllBytes(src))).Replace("-", "").ToLower();
                    LabelFileSrc.Content = "Файл: " + src;
                    LabelFileMd5.Content = "Хэш файла: " + HashMd5;
                    BuutonOpenMd5.Visibility = Visibility.Visible;
                    BuutonSaveMd5.Visibility = Visibility.Visible;
                }
                catch
                {
                    ClearFile(null, null);
                    MessageBox.Show("При чтении файла, произошла ошибка", "Ошибка");
                }
            }
        }
        private void SelectFileMd5(string? src)
        {
            if (src != null)
            {
                try
                {
                    StreamReader reader = new System.IO.StreamReader(src);
                    string text = reader.ReadToEnd();
                    reader.Close();
                    LabelFile2Src.Content = "Файл с хэшем: " + src;
                    LabelFile2Md5.Content = "Хэш в выбранном файле: " + text;
                    if (HashMd5 == text)
                    {
                        LabelResult.Content = "Хэш из файла, равен хэшу открытого файла";
                    }
                    else
                    {
                        LabelResult.Content = "Хэш из файла, не равен хэшу открытого файла";
                    }
                }
                catch
                {
                    LabelFile2Md5.Content = "";
                    LabelFile2Src.Content = "";
                    LabelResult.Content = "";
                    MessageBox.Show("При чтении файла, произошла ошибка", "Ошибка");
                }
            }
        }
        private void ClearFile(object? sender, MouseButtonEventArgs? e)
        {
            BuutonOpenMd5.Visibility = Visibility.Hidden;
            BuutonSaveMd5.Visibility = Visibility.Hidden;
            LabelFileMd5.Content = "";
            LabelResult.Content = "";
            LabelFile2Md5.Content = "";
            LabelFile2Src.Content = "";
            LabelFileSrc.Content = "Файл не выбран";
        }
        private void SaveFile(object sender, MouseButtonEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Hash Files (*.md5)|*.md5|All Files (*.*)|*.*";
            dialog.InitialDirectory = LastFolder;
            if (dialog.ShowDialog() == true)
            {
                string? lastFolder = Path.GetDirectoryName(dialog.FileName);
                if (lastFolder != null)
                {
                    LastFolder = lastFolder;
                }
                string filePath = dialog.FileName;
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.Write(HashMd5);
                }
            }
        }
    }
}
