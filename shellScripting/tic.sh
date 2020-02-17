#!/bin/bash/ -x

#random value from 0 to 8 
random(){
return $(($RANDOM%9))
}

#i have created an arr
#taken 1 in every element because later
arr=( 1 1 1 1 1 1 1 1 1 )

#display the array
display(){
echo  _____
echo  ${arr[0]} ${arr[1]} ${arr[2]}
echo  ${arr[3]} ${arr[4]} ${arr[5]}
echo  ${arr[6]} ${arr[7]} ${arr[8]}
echo  _____
}

display

#so call the randon value to put the x in that location
#computer turn
#isLocation is empty!!
ComputerTurn(){
random
var=$?
if [ "${arr[$var]}" = 1 ]
then
  arr[$var]="X"
else
 ComputerTurn
fi
}
ComputerTurn 
display


#user turn
#we have to taken the value from the user input

UserTurn(){
echo your turn enter the value from 0 to 8
read value
#isLocation is empty!!
if [ "${arr[$value]}" = 1 ]
then
 arr[$value]="O"
else 
  UserTurn
fi

}



#winner condition
winner(){

if [[ "${arr[0]}" = "X" && "${arr[1]}" = "X" && "${arr[2]}" = "X" || "${arr[3]}" = "X" && "${arr[4]}" = "X" && "${arr[5]}" = "X" || "${arr[6]}" = "X" && "${arr[7]}" = "X" && "${arr[8]}" = "X" || "${arr[0]}" = "X" && "${arr[3]}" = "X" && "${arr[6]}"="X" ||"${arr[1]}" = "X" && "${arr[4]}" = "X" && "${arr[7]}" = "X" || "${arr[2]}" = "X" && "${arr[5]}" = "X" && "${arr[8]}" = "X" || "${arr[0]}" = "X" && "${arr[4]}" = "X" && "${arr[8]}" = "X" || "${arr[6]}" = "X" && "${arr[4]}" = "X" && "${arr[2]}" = "X" ]]
then
echo computer wins
count=0
flag=1
elif [[ "${arr[0]}" = "O" && "${arr[1]}" = "O" && "${arr[2]}" = "O" || "${arr[3]}" = "O" && "${arr[4]}" = "O" && "${arr[5]}" = "O" || "${arr[6]}" = "O" && "${arr[7]}" = "O" && "${arr[8]}" = "O" || "${arr[0]}" = "O" && "${arr[3]}" = "O" && "${arr[6]}"="O" ||"${arr[1]}" = "O" && "${arr[4]}" = "O" && "${arr[7]}" = "O" || "${arr[2]}" = "O" && "${arr[5]}" = "O" && "${arr[8]}" = "O" || "${arr[0]}" = "O" && "${arr[4]}" = "O" && "${arr[8]}" = "O" || "${arr[6]}" = "O" && "${arr[4]}" = "O" && "${arr[2]}" = "O" ]]
then
echo user wins
count=0
flag=1
fi
}

count=4
flag=0

while((count>0))
do

UserTurn
winner
display
echo "........................."


if(($count!=0))
then

ComputerTurn
display
winner
fi

count=$(($count-1))
done

if(($flag==0))
then
echo draw
fi

