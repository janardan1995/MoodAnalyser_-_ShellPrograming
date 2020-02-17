#!/bin/bash/ -x
echo "welcome"
echo "enter the array to store element to whom you calculate the sum equal to zero"
echo "enter the no of element in the array"
read x
echo "enter the element one by one"
for((i=0;i<$x;i++))
do
 read arr[$(($i))]
done

echo"your all the array elements are : "
echo ${arr[@]}

len=${#arr[@]}
flag=0
for((i=0;i<len-2;i++))
do
	for((j=i+1;j<len-1;j++))
	do
		for((k=j+1;k<len;k++))
		do
		if((${arr[$i]}+${arr[$j]}+${arr[$k]}==0))
		then
		echo pairs are : $i, $j ,$k
		flag=1
		fi
               done
        done
done
 if((flag==0))
then
echo "No pairs are available to sum equal to zero"
fi
