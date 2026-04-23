namespace Poker
{
    partial class frmPoker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpPoker = new System.Windows.Forms.GroupBox();
            this.grpButton = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnChangeCard = new System.Windows.Forms.Button();
            this.btnDealCard = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBet = new System.Windows.Forms.Button();
            this.txtBet = new System.Windows.Forms.TextBox();
            this.txtTotalMoney = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpPaytable = new System.Windows.Forms.GroupBox();
            this.lblType1 = new System.Windows.Forms.Label();
            this.lblType8 = new System.Windows.Forms.Label();
            this.lblType7 = new System.Windows.Forms.Label();
            this.lblType6 = new System.Windows.Forms.Label();
            this.lblType5 = new System.Windows.Forms.Label();
            this.lblType4 = new System.Windows.Forms.Label();
            this.lblType2 = new System.Windows.Forms.Label();
            this.lblType3 = new System.Windows.Forms.Label();
            this.lblType0 = new System.Windows.Forms.Label();
            this.grpButton.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpPaytable.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPoker
            // 
            this.grpPoker.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpPoker.Location = new System.Drawing.Point(12, 12);
            this.grpPoker.Name = "grpPoker";
            this.grpPoker.Size = new System.Drawing.Size(1224, 383);
            this.grpPoker.TabIndex = 4;
            this.grpPoker.TabStop = false;
            this.grpPoker.Text = "牌桌";
            // 
            // grpButton
            // 
            this.grpButton.Controls.Add(this.lblResult);
            this.grpButton.Controls.Add(this.btnCheck);
            this.grpButton.Controls.Add(this.btnChangeCard);
            this.grpButton.Controls.Add(this.btnDealCard);
            this.grpButton.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpButton.Location = new System.Drawing.Point(12, 613);
            this.grpButton.Name = "grpButton";
            this.grpButton.Size = new System.Drawing.Size(1224, 249);
            this.grpButton.TabIndex = 5;
            this.grpButton.TabStop = false;
            this.grpButton.Text = "功能";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(631, 91);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(536, 124);
            this.lblResult.TabIndex = 3;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(366, 91);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(226, 124);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "判斷牌型";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnChangeCard
            // 
            this.btnChangeCard.Enabled = false;
            this.btnChangeCard.Location = new System.Drawing.Point(199, 91);
            this.btnChangeCard.Name = "btnChangeCard";
            this.btnChangeCard.Size = new System.Drawing.Size(143, 124);
            this.btnChangeCard.TabIndex = 1;
            this.btnChangeCard.Text = "換牌";
            this.btnChangeCard.UseVisualStyleBackColor = true;
            this.btnChangeCard.Click += new System.EventHandler(this.btnChangeCard_Click);
            // 
            // btnDealCard
            // 
            this.btnDealCard.Location = new System.Drawing.Point(28, 91);
            this.btnDealCard.Name = "btnDealCard";
            this.btnDealCard.Size = new System.Drawing.Size(153, 124);
            this.btnDealCard.TabIndex = 0;
            this.btnDealCard.Text = "發牌";
            this.btnDealCard.UseVisualStyleBackColor = true;
            this.btnDealCard.Click += new System.EventHandler(this.btnDealCard_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBet);
            this.groupBox1.Controls.Add(this.txtBet);
            this.groupBox1.Controls.Add(this.txtTotalMoney);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(12, 422);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1224, 162);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "下注";
            // 
            // btnBet
            // 
            this.btnBet.Location = new System.Drawing.Point(1027, 71);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(140, 70);
            this.btnBet.TabIndex = 4;
            this.btnBet.Text = "押注";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // txtBet
            // 
            this.txtBet.Location = new System.Drawing.Point(773, 78);
            this.txtBet.Name = "txtBet";
            this.txtBet.Size = new System.Drawing.Size(211, 63);
            this.txtBet.TabIndex = 0;
            // 
            // txtTotalMoney
            // 
            this.txtTotalMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalMoney.Location = new System.Drawing.Point(191, 78);
            this.txtTotalMoney.Name = "txtTotalMoney";
            this.txtTotalMoney.ReadOnly = true;
            this.txtTotalMoney.Size = new System.Drawing.Size(379, 63);
            this.txtTotalMoney.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(576, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 53);
            this.label2.TabIndex = 1;
            this.label2.Text = "押注金額";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "總資金";
            // 
            // grpPaytable
            // 
            this.grpPaytable.Controls.Add(this.lblType1);
            this.grpPaytable.Controls.Add(this.lblType8);
            this.grpPaytable.Controls.Add(this.lblType7);
            this.grpPaytable.Controls.Add(this.lblType6);
            this.grpPaytable.Controls.Add(this.lblType5);
            this.grpPaytable.Controls.Add(this.lblType4);
            this.grpPaytable.Controls.Add(this.lblType2);
            this.grpPaytable.Controls.Add(this.lblType3);
            this.grpPaytable.Controls.Add(this.lblType0);
            this.grpPaytable.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpPaytable.Location = new System.Drawing.Point(1309, 12);
            this.grpPaytable.Name = "grpPaytable";
            this.grpPaytable.Size = new System.Drawing.Size(820, 850);
            this.grpPaytable.TabIndex = 6;
            this.grpPaytable.TabStop = false;
            this.grpPaytable.Text = "中獎賠率表";
            // 
            // lblType1
            // 
            this.lblType1.Location = new System.Drawing.Point(7, 184);
            this.lblType1.Name = "lblType1";
            this.lblType1.Size = new System.Drawing.Size(614, 53);
            this.lblType1.TabIndex = 8;
            this.lblType1.Text = "同花順         -     50   (倍)";
            // 
            // lblType8
            // 
            this.lblType8.Location = new System.Drawing.Point(7, 763);
            this.lblType8.Name = "lblType8";
            this.lblType8.Size = new System.Drawing.Size(614, 53);
            this.lblType8.TabIndex = 7;
            this.lblType8.Text = "一對             -     1     (倍)";
            // 
            // lblType7
            // 
            this.lblType7.Location = new System.Drawing.Point(6, 681);
            this.lblType7.Name = "lblType7";
            this.lblType7.Size = new System.Drawing.Size(614, 53);
            this.lblType7.TabIndex = 6;
            this.lblType7.Text = "兩對             -     2     (倍)";
            // 
            // lblType6
            // 
            this.lblType6.Location = new System.Drawing.Point(6, 601);
            this.lblType6.Name = "lblType6";
            this.lblType6.Size = new System.Drawing.Size(614, 53);
            this.lblType6.TabIndex = 5;
            this.lblType6.Text = "三條             -     3     (倍)";
            // 
            // lblType5
            // 
            this.lblType5.Location = new System.Drawing.Point(6, 519);
            this.lblType5.Name = "lblType5";
            this.lblType5.Size = new System.Drawing.Size(614, 53);
            this.lblType5.TabIndex = 4;
            this.lblType5.Text = "順子             -     4     (倍)";
            // 
            // lblType4
            // 
            this.lblType4.Location = new System.Drawing.Point(6, 442);
            this.lblType4.Name = "lblType4";
            this.lblType4.Size = new System.Drawing.Size(614, 53);
            this.lblType4.TabIndex = 3;
            this.lblType4.Text = "同花             -     6     (倍)";
            // 
            // lblType2
            // 
            this.lblType2.Location = new System.Drawing.Point(6, 271);
            this.lblType2.Name = "lblType2";
            this.lblType2.Size = new System.Drawing.Size(614, 53);
            this.lblType2.TabIndex = 2;
            this.lblType2.Text = "鐵支             -     25   (倍)";
            // 
            // lblType3
            // 
            this.lblType3.Location = new System.Drawing.Point(6, 356);
            this.lblType3.Name = "lblType3";
            this.lblType3.Size = new System.Drawing.Size(614, 53);
            this.lblType3.TabIndex = 1;
            this.lblType3.Text = "葫蘆             -     9     (倍)";
            // 
            // lblType0
            // 
            this.lblType0.Location = new System.Drawing.Point(6, 89);
            this.lblType0.Name = "lblType0";
            this.lblType0.Size = new System.Drawing.Size(614, 74);
            this.lblType0.TabIndex = 0;
            this.lblType0.Text = "皇家同花順 -     250 (倍)";
            // 
            // frmPoker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2268, 924);
            this.Controls.Add(this.grpPaytable);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpButton);
            this.Controls.Add(this.grpPoker);
            this.KeyPreview = true;
            this.Name = "frmPoker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "五張鋪克牌";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPoker_KeyPress);
            this.grpButton.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpPaytable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPoker;
        private System.Windows.Forms.GroupBox grpButton;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnChangeCard;
        private System.Windows.Forms.Button btnDealCard;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.TextBox txtBet;
        private System.Windows.Forms.TextBox txtTotalMoney;
        private System.Windows.Forms.GroupBox grpPaytable;
        private System.Windows.Forms.Label lblType1;
        private System.Windows.Forms.Label lblType8;
        private System.Windows.Forms.Label lblType7;
        private System.Windows.Forms.Label lblType6;
        private System.Windows.Forms.Label lblType5;
        private System.Windows.Forms.Label lblType4;
        private System.Windows.Forms.Label lblType2;
        private System.Windows.Forms.Label lblType3;
        private System.Windows.Forms.Label lblType0;
    }
}