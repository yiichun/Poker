using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poker
{
    public partial class frmPicTest : Form
    {
        // <summary>
        // 建構子
        // </summary>
        public frmPicTest()
        {
            InitializeComponent();
        }

        #region 自定義方法
        private Image GetImage(string name)
        {
            return Poker.Properties.Resources.ResourceManager.GetObject(name) as Image;
        }
        private Image GetImage(int num)
        {
            return GetImage($"pic{num}");
        }
        #endregion

        #region 事件處理程式
        // <summary>
        // 當按下換牌按鈕的時候 隨機產生1到52的數字
        // </summary>
        // <param name="sender></param>
        // <param name="e"></param>
        private void btnTest_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int r = random.Next(1, 53);

            //this.picTest.Image = GetImage("back");

            this.picTest.Image = GetImage(r);

            this.lblNum.Text = $"{r}";
        }

        /// <summary>
        /// 當按下 picTest 時候 將picTest的圖片換成back的圖片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picTest_Click(object sender, EventArgs e)
        {
            this.picTest.Image = GetImage("back");
        }

        #endregion
    }
}
