#!/bin/bash -x
echo "enter the no upto which you wanna print hermonic no."
read  no
a=0
sum=0
for((i=1;i<=no;i++))
do
a=$(echo "$a" "$i" |awk '{print $1+(1/$2) }')
echo $a
done
echo "finally............."
echo Harmonic upto $n number is : $a
