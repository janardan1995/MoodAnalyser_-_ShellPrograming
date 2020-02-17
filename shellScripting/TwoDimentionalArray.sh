#!/bin/bash/ -x
echo "welcome you to 2D array of the shellscripting"
echo "enter the no of rows"
read r
echo "enter the no of columns"
read c
echo "now insert the element one by one"
#array nested for loop
for((i=0;i<$r;i++))
do
  for((j=0;j<$c;j++))
  do
   read arr[$(($i))$(($j))]
  done
done

#its a shortcut method to displat an array
echo "horizontal display"
echo ${arr[@]}

# Traditional method
echo vertical display
for((x=0;x<$r;x++))
do
  for((z=0;z<$c;z++))
  do
   echo "${arr[$(($x))$(($z))]}"
  done
done
