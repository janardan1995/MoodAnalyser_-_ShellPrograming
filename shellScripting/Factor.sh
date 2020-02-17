#!/bin/bash -x
echo "enter the number to know its factor"
read no
n=$no
echo the factor of $no is:

for((x=2;x<=$n;x++))
do
 if(($n%$x==0))
then
   while(($n%$x==0))
   do
    echo $x
    n=$(($n/$x))
   done
 fi
done

