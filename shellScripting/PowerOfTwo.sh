#!bin/bash/ -x
echo "power of two table"
echo "enter the no upto which you wanna print table of power 2"
read x

#program logic is starting from here
for((i=0;i<=$x;i++))
do
y=$((2**$i))
echo "2 power $i : $y"
done
