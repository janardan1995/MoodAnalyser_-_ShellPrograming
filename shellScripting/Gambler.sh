#!/bin/bash -x

#you have playing with initially stack ie money
echo enter the stack
read stack

#set a goal to win the bet
echo enter the goal
read goal

#how may games do you want to play
echo enter the no of time you wanna play
read play

#loop starting ..........................
for((i=1;i<=$play;i++))
do
money=$stack
bit=0

while(($money!=$goal && $money!=0))
do

#randomly bet
a=$(($RANDOM%2))
bit=$(($bit+1))
if(($a==0))
then
money=$(($money-1))
else
money=$(($money+1))
fi
done

echo no of bets are : $bit
if(($money==0))
then
 echo you are broke 
loss=$(($loss+1))
else
echo you win
win=$(($win+1))
fi
done
echo "..................."
echo "$win times win"
echo "$loss times loss"

winper=$(($(($win*100))/$play))
lossper=$(($(($loss*100))/$play))

echo "win percentage : $winper%"
echo "loss percentage : $lossper%"
