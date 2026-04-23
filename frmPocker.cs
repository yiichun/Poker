using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Poker
{
    public partial class frmPoker : Form
    {
        #region 欄位和變數
        //畫面顯示的五張 PictureBox 陣列
        PictureBox[] pic = new PictureBox[5];

        /// <summary>
        /// 所有牌的編號 從0到51 對應到52張牌
        /// </summary>
        int[] allPoker = new int[52];
        /// <summary>
        /// 玩家手上五張牌的編號
        /// </summary>
        int[] playerPoker = new int[5];

        int totalMoney = 1000000;
        int betAmount = 0;

        Random rand = new Random();
        #endregion

        public frmPoker()
        {
            InitializeComponent();
            InitializePoker();
            //顯示初始資金
            txtTotalMoney.Text=totalMoney.ToString();  
            //預設發牌按鈕不可用 直到押注金額
            btnDealCard.Enabled=false;
            btnChangeCard.Enabled=false;
            btnCheck.Enabled=false;
        }
        #region 初始化方法
        /// <summary>
        /// 動態產生五張 PictureBox 並設定初始狀態
        /// </summary>
        private void InitializePoker()
        {
            // foreach(var item in pic)                         // 每一個pic都拿出來當一個item item是local variable var會根據pic型態去轉換成正確的型態
            for (int i = 0; i < pic.Length; i++)
            {
                pic[i] = new PictureBox();                       // pic[i]指向PictureBox()
                pic[i].Image = GetImage("back");                 // 顯示牌的背面
                //pic[i].Image = GetImage(39);
                pic[i].Name = "pic" + i;                         // 字串+int -> 把數字轉成字串 (加法是代表字串合併)
                pic[i].SizeMode = PictureBoxSizeMode.AutoSize;   // 圖片大小是自動
                pic[i].Top = 30;                                 // 指定位置 和上面的邊界差 30ps
                pic[i].Left = 10 + ((pic[i].Width + 10) * i);    // 每張牌的左邊起始位置 第一張是距離左邊10ps 後面的是距離前一張10ps(盤的寬度+10)
                pic[i].Enabled = false;                          // 預設牌桌上的牌不可點
                pic[i].Visible = false;                          // 牌面朝下
                pic[i].Visible = true;                           // 

                this.grpPoker.Controls.Add(pic[i]);              // 顯示在哪裡
                pic[i].MouseClick += new MouseEventHandler(pic_Click);
            }
        }

        ///<summary>
        ///顯示五張撲克牌到桌面上
        ///</summary>
        private void ShowCards()
        {
            for (int i = 0; i < 5; i++)
            {
                pic[i].Image = this.GetImage($"pic{playerPoker[i] + 1}");
            }
        }

        #endregion



        #region 按鈕事件處理
        /// <summary>
        /// 按下 發牌 按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnDealCard_Click(object sender, EventArgs e)
        {
            //將上一把玩的結果清除
            this.lblResult.Text = string.Empty;

            //將桌面的牌重置為牌背
            for (int i=0;i<pic.Length;i++)
            {
                pic[i].Image = GetImage("back");
            }
            //將所有牌的編號從0到51填入allpocker.length
            for(int i=0;i<allPoker.Length;i++)
            {
                allPoker[i] = i;
            }

            //洗牌
            this.Shuffle();

            //500太大 會鈍鈍的(要寫在報告裡面!!!!!)
            await Task.Delay(500);

            for (int i=0;i<playerPoker.Length;i++)
            {
                //取前52張爬的前五張
                playerPoker[i] = allPoker[i];
            }

            //測試用(同花大順)
            //playerPoker[0] = 51;
            //playerPoker[1] = 47;
            //playerPoker[2] = 43;
            //playerPoker[3] = 39;
            //playerPoker[4] = 3;

            //將對應的牌顯示在牌桌上
            this.ShowCards();

            for (int i=0;i<pic.Length;i++)
            {
                pic[i].Enabled = true;
                pic[i].Tag = "front";
            }
            //啟用換牌按鈕
            btnChangeCard.Enabled = true;
            btnCheck.Enabled = true;
            btnDealCard.Enabled = false;
        }

        /// <summary>
        /// 按下 換牌 按鈕 將52張牌打亂
        /// </summary>
        private void Shuffle()
        {
            Random rand = new Random();
            for (int i = allPoker.Length - 1; i > 0; i--)
            {
                int r = rand.Next(i + 1);
                int temp = allPoker[i];
                allPoker[i] = allPoker[r];
                allPoker[r] = temp;
            }
        }

        /// <summary>
        /// 牌桌上的牌被按下 顯示編號
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pic_Click(object sender,EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            int index=int.Parse(pic.Name.Replace("pic",""));
            int cardNum = playerPoker[index] + 1;
            //如果牌面朝下 則翻開盤面，如果牌面朝上 則換成牌背
            if(pic.Tag.ToString()=="back")
            {
                pic.Tag = "front";
                pic.Image = GetImage(cardNum);
            }
            else
            {
                pic.Tag = "back";
                pic.Image = GetImage("back");
            }
        }

        private void btnChangeCard_Click(object sender, EventArgs e)
        {
            //從allpoker陣列第五張開始發牌 前五張已經發過了
            int startIndex = 5;

            for (int i = 0; i < pic.Length; i++)
            {
                if (pic[i].Tag.ToString() == "back")
                {
                    playerPoker[i] = allPoker[startIndex];
                    startIndex++;
                    pic[i].Image = GetImage("pic" + (playerPoker[i] + 1));
                    pic[i].Tag = "front";
                }
            }
            for(int i=0;i<pic.Length;i++)
            {
                //將牌桌上的牌設為不可點擊
                pic[i].Enabled=false;
            }
            //玩家只可以換一次牌
            this.btnChangeCard.Enabled=false;

            //將判斷牌型的按鈕設成可用
            this.btnCheck.Enabled=true;
        }

        /// <summary>
        /// 當按下判斷牌型 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheck_Click(object sender, EventArgs e)
        {
            string[] colorList = { "梅花", "方塊", "愛心", "黑桃" };
            string[] pointList = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            // 計錄目前五張撲克牌的花色的陣列
            int[] pokerColor = new int[5];
            // 計錄目前五張撲克牌的點數的陣列
            int[] pokerPoint = new int[5];
            // 將每張牌的顏色和點數分別存入pokerColor和pokerPoint陣列
            for (int i = 0; i < playerPoker.Length; i++)
            {
                //計算玩家手牌的花色
                pokerColor[i] = playerPoker[i] % 4;
                //計算玩家手牌的點數
                pokerPoint[i] = playerPoker[i] / 4;
            }

            #region 測試計算出來的花色和點數是否正確
            //測試計算出來的花色和點數是否正確
            //=========================================================
            //string result = "";
            //for (int i = 0; i < playerPoker.Length; i++)
            //{
            //    //取得花色編號
            //    int iColor = pokerColor[i];
            //    //取得點數編號
            //    int iPoint = pokerPoint[i];
            //    //根據花色編號和點數編號 組合成排的名稱
            //    result += $"{colorList[iColor]}{pointList[iPoint]}";
            //}
            ////顯示玩家牌的花色和點數
            //this.lblResult.Text = result;
            //===========================================================
            #endregion

            // 統計color和point出現次數
            int[] colorCount = new int[4];
            int[] pointCount = new int[13];
            for (int i = 0; i < 5; i++)
            {
                int color = pokerColor[i];
                int point = pokerPoint[i];
                colorCount[color]++;
                pointCount[point]++;
            }
            // 排序colorCount和colorList兩個陣列一起排序 根據colorCount由小到大排序 並保持colorList的順序
            Array.Sort(colorCount, colorList);
            //this.lblResult.Text = $"{colorCount[0]},{colorList[0]}";
            Array.Reverse(colorCount);
            Array.Reverse(colorList);
            Array.Sort(pointCount, pointList);
            Array.Reverse(pointCount);
            Array.Reverse(pointList);

            // 判斷是否為同花
            bool isFlush = (colorCount[0] == 5);
            // 判斷是否為五張單張
            bool isSingle = (pointCount[0] == 1 && pointCount[1] == 1 && pointCount[2] == 1 && pointCount[3] == 1 && pointCount[4] == 1);
            // 判斷是否為差四
            bool isDiffFout = (pokerPoint.Max() - pokerPoint.Min() == 4);
            // 判斷是否為大順
            bool isRoyal = pokerPoint.Contains(0) && pokerPoint.Contains(9) && pokerPoint.Contains(10) && pokerPoint.Contains(11) && pokerPoint.Contains(12);
            // 判斷是否為同花大順
            bool isRoyalisFlush = isFlush && isRoyal;
            // 判斷是否為同花順
            bool isStraightFlush = isFlush && isSingle && isDiffFout;
            // 判斷是否為順子
            bool isStraight = isSingle && (isDiffFout || isRoyal);
            // 判斷是否為鐵支
            bool isFourOfAKind = (pointCount[0] == 4);
            // 判斷是否為葫蘆
            bool isFullHouse = (pointCount[0] == 3 && pointCount[1] == 2);
            // 判斷是否為三條
            bool isThreeOfAKind = (pointCount[0] == 3 && pointCount[1] == 1);
            // 判斷是否為兩對
            bool isTwoPair = (pointCount[0] == 2 && pointCount[1] == 2);
            // 判斷是否為一對
            bool isOnePair = (pointCount[0] == 2 && pointCount[1] == 1);

            // --- 整合結果與賠率計算 ---
            string resultText = "";
            int multiplier = 0;
            int typeIndex = -1; // 紀錄要亮哪一個賠率標籤

            if (isRoyalisFlush)
            {
                resultText = $"{colorList[0]}同花大順";
                multiplier = 250;
                typeIndex = 0; // 對應 lblType0
            }
            else if (isStraightFlush)
            {
                resultText = $"{colorList[0]}同花順";
                multiplier = 50;
                typeIndex = 1;
            }
            else if (isFourOfAKind)
            {
                resultText = $"{pointList[0]}鐵支";
                multiplier = 25;
                typeIndex = 2;
            }
            else if (isFullHouse)
            {
                resultText = $"{pointList[0]}三張{pointList[1]}兩張葫蘆";
                multiplier = 9;
                typeIndex = 3;
            }
            else if (isFlush)
            {
                resultText = $"{colorList[0]}同花";
                multiplier = 6;
                typeIndex = 4;
            }
            else if (isStraight)
            {
                resultText = "順子";
                multiplier = 4;
                typeIndex = 5;
            }
            else if (isThreeOfAKind)
            {
                resultText = $"{pointList[0]}三條";
                multiplier = 3;
                typeIndex = 6;
            }
            else if (isTwoPair)
            {
                resultText = $"{pointList[0]},{pointList[1]}兩對";
                multiplier = 2;
                typeIndex = 7;
            }
            else if (isOnePair)
            {
                resultText = $"{pointList[0]}一對";
                multiplier = 1;
                typeIndex = 8;
            }
            else
            {
                resultText = "雜牌";
                multiplier = 0;
                typeIndex = -1;
            }

            // 1. 執行亮燈 (自定義方法)
            HighlightPaytable(typeIndex);

            // 2. 計算獎金與更新介面
            int winMoney = betAmount * multiplier;
            totalMoney += winMoney;
            txtTotalMoney.Text = totalMoney.ToString();

            // 3. 顯示最後結果
            lblResult.Text = resultText + (winMoney > 0 ? $"！贏得: {winMoney}" : "。沒中獎");

            // 4. 遊戲流程控制
            btnChangeCard.Enabled = false;
            btnCheck.Enabled = false;
            btnBet.Enabled = true;     // 重新啟用下注按鈕
            txtBet.ReadOnly = false;    // 讓玩家可以改金額
            btnDealCard.Enabled = false; // 必須重新下注才能發牌

            // 破產判斷
            if (totalMoney <= 0)
            {
                MessageBox.Show("您已破產！回頭是岸。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBet.Enabled = false;
            }
        }
        private void btnBet_Click(object sender, EventArgs e)
        {
            // 1. 讀取並檢查押注金額
            if (int.TryParse(txtBet.Text, out betAmount) && betAmount > 0)
            {
                if (betAmount <= totalMoney)
                {
                    // 2. 扣除資金
                    totalMoney -= betAmount;
                    txtTotalMoney.Text = totalMoney.ToString();

                    // 3. 鎖定下注介面，啟用發牌
                    btnBet.Enabled = false;
                    txtBet.ReadOnly = true;
                    btnDealCard.Enabled = true;
                }
                else
                {
                    MessageBox.Show("資金不足！");
                }
            }
            else
            {
                MessageBox.Show("請輸入正確的押注金額！");
            }
        }

        /// <summary>
        /// 當表單被按下鍵盤時，顯示訊息框告訴使用者按下了哪一個按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPoker_KeyPress(object sender, KeyPressEventArgs e)
        {
            //只有在「換牌按鈕」或「判斷按鈕」可用時（代表已經發完牌了），才允許快捷鍵測試
            if (this.btnChangeCard.Enabled == true || this.btnCheck.Enabled == true)
            {
                //MessageBox.Show($"你按下了 {e.KeyChar} 鍵");
                switch(e.KeyChar)
                {
                    case 'q':
                        playerPoker[0] = 51;
                        playerPoker[1] = 47;
                        playerPoker[2] = 43;
                        playerPoker[3] = 39;
                        playerPoker[4] = 3;
                        break;
                    case 'w':
                        playerPoker[0] = 37;
                        playerPoker[1] = 33;
                        playerPoker[2] = 29;
                        playerPoker[3] = 25;
                        playerPoker[4] = 21;
                        break;
                    case 'e':
                        playerPoker[0] = 50;
                        playerPoker[1] = 38;
                        playerPoker[2] = 34;
                        playerPoker[3] = 22;
                        playerPoker[4] = 18;
                        break;
                    case 'r':
                        playerPoker[0] = 48;
                        playerPoker[1] = 39;
                        playerPoker[2] = 38;
                        playerPoker[3] = 37;
                        playerPoker[4] = 36;
                        break;
                    case 't':
                        playerPoker[0] = 30;
                        playerPoker[1] = 29;
                        playerPoker[2] = 6;
                        playerPoker[3] = 5;
                        playerPoker[4] = 4;
                        break;
                    case 'y':
                        playerPoker[0] = 48;
                        playerPoker[1] = 39;
                        playerPoker[2] = 15;
                        playerPoker[3] = 14;
                        playerPoker[4] = 13;
                        break;
                }
                ShowCards();
            }
        }
        #endregion

        #region 自定義方法
        /// <summary>
        /// 取得圖片資源
        /// </summary>
        /// <param name="name">string 的牌名</param>
        /// <returns></returns>
        private Image GetImage(string name)
        {
            return Properties.Resources.ResourceManager.GetObject(name) as Image;
        }
        /// <summary>
        /// 取得圖片資源
        /// </summary>
        /// <param name="name">撲克牌編號</param>
        /// <returns></returns>
        private Image GetImage(int num)
        {
            return GetImage($"pic{num}");
        }

        /// <summary>
        /// 根據中獎索引亮起對應的賠率標籤
        /// </summary>
        /// <param name="index">lblType 的編號 (0-8)，-1 表示不亮燈</param>
        private void HighlightPaytable(int index)
        {
            // 先將所有賠率標籤恢復透明背景 (假設名稱為 lblType0 到 lblType8)
            for (int i = 0; i <= 8; i++)
            {
                Control[] found = this.Controls.Find("lblType" + i, true);
                if (found.Length > 0)
                {
                    found[0].BackColor = Color.Transparent;
                    found[0].ForeColor = Color.Black; // 恢復文字顏色
                }
            }

            // 亮起中獎的那一個
            if (index >= 0)
            {
                Control[] found = this.Controls.Find("lblType" + index, true);
                if (found.Length > 0)
                {
                    found[0].BackColor = Color.Yellow; // 背景變黃
                    found[0].ForeColor = Color.Red;    // 文字變紅 (更明顯)
                }
            }
        }
    }
    #endregion
}
