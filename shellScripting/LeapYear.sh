#!/bin/bash/ -x
echo "enter the year to know leap year"
read y
year=$y
a=$(($y%4))
b=$(($y%400))
c=$(($y%100))

if [ $year -ge 1582 -a $year -le 9999 ]
then
 if [ $a -eq 0 -a $c -ne 0 -o $b -eq 0  ]
  then
     echo "leap year"
  else
     echo "it's not a leap year"
 fi
else
echo "you have entered an invalid year"
fi
