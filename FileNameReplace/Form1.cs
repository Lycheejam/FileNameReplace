using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FileNameReplace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void folder_btn_Click(object sender, EventArgs e)
        {
            //FolderBrowserDialogクラスのインスタンスを作成
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            //上部に表示する説明テキストを指定する
            fbd.Description = "フォルダを指定してください。";
            //ルートフォルダを指定する
            //デフォルトでDesktop
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            //最初に選択するフォルダを指定する
            //RootFolder以下にあるフォルダである必要がある
            fbd.SelectedPath = @"C:\Windows";
            //ユーザーが新しいフォルダを作成できるようにする
            //デフォルトでTrue
            fbd.ShowNewFolderButton = true;

            //ダイアログを表示する
            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                //選択されたフォルダを表示する
                textBox1.Text = fbd.SelectedPath;
            }
        }

        private void act_btn_Click(object sender, EventArgs e)
        {
            //ワイルドカード"*"は、すべてのファイルを意味する
            string[] files = Directory.GetFiles(
                textBox1.Text, "*", SearchOption.AllDirectories);

            var lists = new List<FileList>();
            var regex = new Regex(@"正規表現");
            foreach (var file in files)
            {
                var match = regex.Match(Path.GetFileName(file));
                if (match.Success)
                {
                    lists.Add(new FileList
                    {
                        FullPath = Path.GetDirectoryName(file)
                        , FileName = Path.GetFileName(file)
                        , AfterName = Path.GetFileName(file).Replace("str", "")
                    });
                }
            }

            
                foreach (var item in lists)
                {
                    File.Move(item.FullPath + "\\" + item.FileName,
                              item.FullPath + "\\" + item.AfterName);
                }
            

            //ネットで調べたら出てきた
            //var bs = new BindingSource(lists, string.Empty);
            //dgv.DataSource = bs;

            dgv.DataSource = lists;
        }
    }
    class FileList
    {
        public string FullPath { get; set; }
        public string FileName { get; set; }
        public string AfterName { get; set; }
    }
}
