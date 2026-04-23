專案簡介：

一個基於 C# WinForms 開發的撲克牌博弈遊戲，完整實作了隨機洗牌、牌型判定邏輯、下注賠率系統與自動化 UI 回饋機制。

🎮 遊戲操作說明

本遊戲模擬經典的五門撲克，請依照以下步驟進行遊戲：

1. 初始準備
•	起始資金：遊戲開始時，玩家擁有 1,000,000 元。
•	狀態確認：初始狀態下，所有功能按鈕（發牌、換牌、判斷）皆為禁用，需先完成下注。
 <img width="865" height="388" alt="image" src="https://github.com/user-attachments/assets/44c36e21-6a5d-43bf-85a7-97ce2138bc73" />

2. 下注
•	在 「押注金額」 文字框中輸入你想投注的金額。
•	點擊 「押注」 按鈕。
o	防呆機制：若金額超過現有資金、負數或輸入非法字元，系統將跳出警告彈窗，且無法開始遊戲。
 <img width="669" height="303" alt="image" src="https://github.com/user-attachments/assets/386e3ce0-5d62-40a1-a03d-76e2ef8e426e" />

o	押注成功後，金額會從總資金扣除，並啟用發牌功能。
 <img width="695" height="311" alt="image" src="https://github.com/user-attachments/assets/7ef7c4a2-4b94-48da-8e44-a56a910f409e" />

3. 發牌與留牌
•	點擊 「發牌」 按鈕，系統會執行非同步洗牌動畫延遲並翻開五張撲克牌。
 <img width="705" height="317" alt="image" src="https://github.com/user-attachments/assets/515bba8f-61bf-4e17-9394-e0357abd071f" />

•	選擇保留牌：用滑鼠左鍵點擊你想要「換掉」的牌。
o	牌面翻回背面（顯示牌背）：代表這張牌不要，稍後會更換。
o	牌面維持正面（顯示點數）：代表這張牌保留。
 <img width="652" height="296" alt="image" src="https://github.com/user-attachments/assets/4ea0f2e4-eb4c-4e6f-86d2-538ed13274f6" />

4. 換牌
•	決定好要更換的牌後，點擊 「換牌」 按鈕。
•	系統會將牌背狀態的卡片替換成新的牌，並將所有牌鎖定，準備進入判定階段。
o	註：每局遊戲僅有一次換牌機會。
 <img width="731" height="327" alt="image" src="https://github.com/user-attachments/assets/20034852-2958-44d1-a4fe-65bc0a446317" />

5. 牌型判定與結算 (Check & Result)
•	點擊 「判斷牌型」 按鈕，系統會自動分析點數與花色。
•	動態回饋：右側「賠率表」會根據判定結果（如：三條、順子等）自動以 黃底紅字 亮起對應標籤。
•	獎金更新：系統自動計算「押注 × 賠率」並即時更新至總資金與結果顯示區。
 <img width="674" height="304" alt="image" src="https://github.com/user-attachments/assets/29b824b8-17b7-446a-a8b1-dbf7593a0dee" />

•	結算完成後，需重新執行「步驟 2」開始新的一局。
6. 破產機制
•	若總資金歸零且無法支付下注金額，系統將跳出破產提示，並關閉投注功能。
 <img width="858" height="388" alt="image" src="https://github.com/user-attachments/assets/4a14d0e0-07c7-4bd8-85f5-c8610e65b136" />

牌型與賠率說明
 <img width="784" height="617" alt="image" src="https://github.com/user-attachments/assets/916794e8-eab7-4e53-a325-49d277428599" />

🛠 開發者測試模式 
為了方便快速驗證各種中獎牌型與賠率判定邏輯，本程式內建測試快捷鍵。在 「發牌後」且「判斷前」，按下鍵盤對應按鍵可直接變更手牌：
•	Q：切換為 同花大順
•	W：切換為 同花順
•	E：切換為 鐵支
•	R：切換為 順子
•	T：切換為 兩對
•	Y：切換為 一對
註：此功能僅供測試使用，正式遊玩請透過「換牌」功能進行遊戲。
