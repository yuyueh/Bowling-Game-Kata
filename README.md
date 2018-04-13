Bowling Game Kata
=================
> Uncle Bob's classic implemented 

[bowling-score]: http://www.wpclipart.com/recreation/sports/bowling/bowling_scoresheet_example.png "bowling score card"


## Scoring bowling

![Bowling scoreboard][bowling-score]

The game consists of 10 frames as shown above.  In each frame the player has
two opportunities to knock down 10 pins.  The score for the frame is the total
number of pins knocked down, plus bonuses for strikes and spares.

A spare is when the player knocks down all 10 pins in two tries.  The bonus for
that frame is the number of pins knocked down by the next roll.  So in frame 3
above, the score is 10 (the total number knocked down) plus a bonus of 5 (the
number of pins knocked down on the next roll.)

A strike is when the player knocks down all 10 pins on his first try.  The bonus
for that frame is the value of the next two balls rolled.

In the tenth frame a player who rolls a spare or strike is allowed to roll the extra
balls to complete the frame.  However no more than three balls can be rolled in
tenth frame.


## The requirements

* Write class "BowlingGame" that has two methods
	- *roll(pins)*
		- called each time the player rolls a ball. The argument is the number of pins knocked down.
	- *score()*
		- called only after the very end of the game. Returns total score of the game.


## Quick design session

One game  
A game has 10 frames  
A frame has one or two rolls  
The tenth frame has two or three rolls. It's different from all the other frames  
The score function must iterate through all the frames, and calculate all their scores  
The score for a spare or a strike depends on the frames successor

## 保齡球比賽

遊戲規則

1. 一場保齡球賽有10局
2. 前九局每局有兩顆球, 每局有10瓶
3. 每局共有10個球瓶
4. 每局的分數為當局擊倒瓶數加上 Bonus
5. 每局第 1 球全倒稱為 Strike
6. 每局第 2 球才全倒稱為 spare
7. 第10局如果有 strike 或 spare 就可以打第3球

Bonus:

1. 本局打 Spare, 則本局的分數等於本局分數加下一球擊倒之瓶數. ex: 本局7+3瓶, 然後下一球打 3 瓶, 則本局分數為[10+3] =13 分
2. 本局打 Strike, 則 Bonus 為本局分數加上下兩球擊倒之瓶數 ex: 本局 strike, 下兩球分別為 7, 1, 則本局分數為 (10 + 7 + 1) = 18
3. 第10局沒有 bonus

## 需求

* 開發一個 class "BowlingGame"，包含以下2個方法
	- *roll(pins)*
		- 當玩家擲球時呼叫這個方法, 傳入參數是擊倒的瓶數
	- *score()*
		- 一局結束時呼叫此方法，返回比賽總分