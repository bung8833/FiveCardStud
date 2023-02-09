# FiveCardStud
 
### 練習: 寫出梭哈遊戲

目前進度: 用LINQ寫判斷牌型(同花大順、同花順、葫蘆...等等)

#### 擴充方法: 

List<<t>int</t>> GetValueDistribution(this List<<t>int</t>> values)

回傳 List 中重複數字的數量分布，用來判斷撲克牌牌型

例如 values = { 1, 1, 2, 6, 6 }
則回傳 { 1, 2, 2 }

values = { 5, 5, 5, 13, 13 }
則回傳 { 2, 3 }
