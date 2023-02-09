# FiveCardStud
 
## 練習: 寫出梭哈遊戲

目前進度: 用LINQ寫判斷牌型(同花大順、同花順、葫蘆...等等)

#### 擴充方法: List<<t>int</t>> GetValueAppearances( this List<<t>int</t>> values )

回傳List中每種數字的出現次數，用來判斷撲克牌牌型

例如:

values = { 5, 6, 5, 6, 13 } 

則回傳 { 1, 2, 2 }

values = { 5, 4, 13, 13, 13 } 

則回傳 { 1, 1, 3 }
