using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Threading;

namespace Viewer
{
    public partial class ViewerForm : Form
    {
        private string Path;
        private DispatcherTimer timer;

        public ViewerForm()
        {
            InitializeComponent();

            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(btNext_Click);
            timer.Interval = new TimeSpan(0, 0, 1);
        }
        
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            using (var dialog = new System.Windows.Forms.FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    pictureBoxImg.Image = null;
                    Path = dialog.SelectedPath;
                    textBox1.Text = Path;
                    try
                    {
                        LoadImages(Path);
                    }
                    catch(Exception ex) { MessageBox.Show(ex.Message); }
                }
            }
            IsEnabled(true);
        }

        private void LoadImages(string path)
        {
            string[] files = Directory.GetFiles(Path);

            ClearResurses();

            for (int i=0; i<files.Length; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = files[i].Remove(0, files[i].LastIndexOf('\\') + 1);
                lvi.Tag = i;              
                listView1.Items.Add(lvi);

                imageList1.Images.Add(Image.FromFile(files[i]));

                lvi.ImageIndex = i;
            }
        }

        private void ClearResurses()
        {
            listView1.Clear();
            imageList1.Images.Clear();
        }

        private void IsEnabled(bool e)
        {
            btBack.Enabled = e;
            btNext.Enabled = e;
            btTimer.Enabled = e;
            timerMenuItem.Enabled = e;
        }

        private void timer_Tick(object sender2, EventArgs e)
        {
            if (timer.IsEnabled)
            {
                timer.Stop();
                btTimer.Text = "Timer on";
                btBack.Enabled = true;
                btNext.Enabled = true;
            }
            else
            {
                timer.Start();
                btTimer.Text = "Timer off";
                btBack.Enabled = false;
                btNext.Enabled = false;
            }          
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (sender is ListView)
            {
                pictureBoxImg.Image = Image.FromFile(Path + "\\" + listView1.SelectedItems[0].Text);
            }
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                listView1.Items[0].Selected = true;
                pictureBoxImg.Image = Image.FromFile(Path + "\\" + listView1.SelectedItems[0].Text);
                return;
            }

            int count;
            count = int.Parse(listView1.SelectedItems[0].Tag.ToString());
            if (listView1.Items[count].Index > listView1.Items.Count-2)
            {
                return;
            }
                
            else
            {
                listView1.Items[count + 1].Selected = true;
                listView1.Items[count].Selected = false;

                pictureBoxImg.Image = Image.FromFile(Path + "\\" + listView1.Items[count + 1].Text);
            }            
        }
        private void btBack_Click(object sender, EventArgs e)
        {
            int count;
            if (listView1.SelectedItems.Count == 0)
            {
                count = listView1.Items.Count - 1;
                listView1.Items[count].Selected = true;
                pictureBoxImg.Image = Image.FromFile(Path + "\\" + listView1.SelectedItems[0].Text);
                return;
            }

            count = int.Parse(listView1.SelectedItems[0].Tag.ToString());
            if (listView1.Items[count].Index < 1)
            {
                return;
            }

            else
            {
                listView1.Items[count - 1].Selected = true;
                listView1.Items[count].Selected = false;

                pictureBoxImg.Image = Image.FromFile(Path + "\\" + listView1.Items[count - 1].Text);
            }

        }

        private void pictureBoxImg_Click(object sender, EventArgs e)
        {
            if (pictureBoxImg.Image != null)
            {
                pictureBoxImg.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBoxImg.Refresh();
            }
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Приветствую Вас программе Viewer!\n Для начала работы выберите пункт в меню \"Открыть папку с изображениями\" или нажмите кнопку \"Open folder\" (элемент textbox не активен - он лишь отображает выбранный путь).\n" +
                "После этого разблокируются кнопки \"Back\", \"Next\" и \"Timer\". Последняя является кнопкой старта (\"Timer on\") и отключения (\"Timer off\").\n" +
                "Выбрать любую фотографию можно нажатием на неё мышью в списке - она отобразится в панели справа. Кроме этого, выбранное изображение можно вращать на 90 градусов нажатием на него в правой панели.\n" +
                "При разворачивании окна изображение так же масштабируется. Так же можно перетянуть мышкой правую панель влево на их стыке для увеличения размеров правой.\nСпасибо за использование программы.\n";
            MessageBox.Show(message);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
