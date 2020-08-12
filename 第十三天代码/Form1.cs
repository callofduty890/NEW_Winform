using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 第十三天代码
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //关闭之前嵌入的窗体
        private void CloseForm()
        {
            foreach (Control item in this.panel1.Controls)
            {
                if (item is Form)
                {
                    Form objControl = (Form)item;
                    objControl.Close();
                }
            }
        }
        
        private void OpenForm(Form objForm)
        {
            //擦除之前新打开的窗体
            CloseForm();
            objForm.TopLevel = false;//关闭顶级窗体
            objForm.FormBorderStyle = FormBorderStyle.None;//去除图像边框
            objForm.Parent = this.panel1;//指定容器
            objForm.Dock = DockStyle.Fill;//填充满容器
            objForm.Show();//显示新的窗体
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            //
            OpenForm(fr2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            //
            OpenForm(fr3);
        }
    }
}
