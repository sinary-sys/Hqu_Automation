using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace ktvsystem
{
    public partial class musicplayer : Form
    {
        public musicplayer()
        {
            InitializeComponent();
        }
        List<string> listsongs = new List<string>();   //用来存储音乐文件的全路径
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        SoundPlayer sp = new SoundPlayer();
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = listsongs[listBox1.SelectedIndex];
            sp.Play();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex; //获得当前选中歌曲的索引
            index++;

            if (index == listBox1.Items.Count)
            {
                index = 0;
            }
            listBox1.SelectedIndex = index; //将改变后的索引重新赋值给我当前选中项的索引
            sp.SoundLocation = listsongs[index];
            sp.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex; //获得当前选中歌曲的索引
            index--;

            if (index < 0)
            {
                index = listBox1.Items.Count - 1;
            }
            listBox1.SelectedIndex = index; //将改变后的索引重新赋值给我当前选中项的索引
            sp.SoundLocation = listsongs[index];
            sp.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择音乐文件";      //打开对话框的标题
            ofd.InitialDirectory = @"F:\music";    //设置打开对话框的初始设置目录
            ofd.Multiselect = true; //设置多选
            ofd.Filter = @"音乐文件|*.mp3||*.wav|所有文件|*.*";    //设置文件格式筛选
            ofd.ShowDialog();   //显示打开对话框
            string[] pa_th = ofd.FileNames;       //获得在文件夹中选择的所有文件的全路径
            for (int i = 0; i < pa_th.Length; i++)
            {
                listBox1.Items.Add(Path.GetFileName(pa_th[i]));  //将音乐文件的文件名加载到listBox中
                listsongs.Add(pa_th[i]);    //将音乐文件的全路径存储到泛型集合中
            }
        }
    }
}
