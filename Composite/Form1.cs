namespace Composite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string FileName { get; set; }
        private string FoldeName { get; set; }
        private float FileSize { get; set; }
        private float FolderSize { get; set; }

        private void btn_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                if (btn.Name == "btn_SelectFile")
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        FileSize = new FileInfo(openFileDialog.FileName).Length;
                        FileName = new FileInfo(openFileDialog.FileName).FullName;
                        lbl_FileName.Text = FileName;
                        lbl_FileSize.Text = $"{(FileSize * 0.0009765625)} KB";
                    }
                }
                else if (btn.Name == "btn_SelectFolder")
                {
                    FolderBrowserDialog dialog = new FolderBrowserDialog();
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        FoldeName = new FileInfo(dialog.SelectedPath).FullName;
                        FolderSize = GetDirectorySize(dialog.SelectedPath);
                        lbl_FolderPath.Text = FoldeName.ToString();
                        lbl_FolderSize.Text = $"{(FolderSize * 0.0009765625)} KB";
                    }
                }
            }

        }

        static long GetDirectorySize(string p)
        {
            string[] a = Directory.GetFiles(p, "*.*");
            long b = 0;
            foreach (string name in a)
            {
                FileInfo info = new FileInfo(name);
                b += info.Length;
            }
            return b;
        }
    }
}