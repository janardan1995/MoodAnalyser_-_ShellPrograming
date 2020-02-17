#!/bin/bash/ -x
#taking two variable
headCount=0
tailCount=0
echo "enter how many times you wanna toss the coin"
read t
toss=$t

#loop is starting and its loop upto the no you have entered
while [ $toss -gt 0 ]
do
a=$(($RANDOM%2))
echo "random no is : $a"
if [ $a -eq 1 ]
then
         headCount=$(($headCount+1))
else
         tailCount=$(($tailCount+1))
fi
toss=$(($toss-1))
done

echo ".............................."
echo "tailCount=$tailCount"
echo "headCount=$headCount"

#calculate the percentage..........
x=$(($headCount * 100/t))
y=$(($tailCount * 100/t))
echo "percentage of head: $x%  and tail: $y%"
