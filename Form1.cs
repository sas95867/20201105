using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20201105
{
    public partial class Form1 : Form
    {
        CarApi api = null;

        public Form1()
        {
            InitializeComponent();
        }
        #region 生命週期
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        #endregion

        #region 事件
        /// <summary>
        /// 按下按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGo_Click(object sender, EventArgs e)
        {
            //檢查輸入是否空白
            if(string.IsNullOrWhiteSpace(tbPlate.Text))
            {
                MessageBox.Show("輸入車牌", "錯啦淦!");
                    return;
            }
            //送資料
            api = new CarApi();
            List<Image> imgList = api.Getplate(tbPlate.Text);
            //根據結果顯示圖
            if (imgList !=null && imgList.Count>=4)
            {
                pic1.Image = imgList[3];
            }


        }
        #endregion
    }
}
