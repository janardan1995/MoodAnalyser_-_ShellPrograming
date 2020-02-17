#!/bin/bash/
echo enter the x axis
read x
echo enter the y axis
read y
sum=$(($(($x*$x))+$(($y*$y))))
dis=$(echo "$sum" | awk '{print sqrt($1)}')
echo "distane between them is :$dis"
