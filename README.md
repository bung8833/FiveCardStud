# FiveCardStud
 
### 練習: 寫出梭哈遊戲

目前進度: 判斷牌型(同花大順、同花順、葫蘆...等等) ，大部分要用LINQ寫

#### 擴充方法: 

List<<int>> GetValueDistribution(this List<<int>> values)

回傳List中重複數字的數量分布，用來判斷撲克牌牌型

例如 values = { 1, 1, 1, 6, 6 }
則傳回 { 2, 3 }
