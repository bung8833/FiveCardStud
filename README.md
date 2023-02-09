# FiveCardStud
 
練習: 寫出梭哈遊戲

目前進度: 判斷牌型(同花大順、同花順、葫蘆...等等) ，大部分要用LINQ寫


用擴充方法判斷一手牌中有多少數字重複的牌
List<<int>> GetValueDistribution(this List<int> values)
例如 values = { 1, 1, 1, 6, 6 }
則傳回 { 2, 3 }