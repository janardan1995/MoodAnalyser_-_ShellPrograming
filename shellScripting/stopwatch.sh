#!/bin/bash/ -x
echo "stopwatch simulation"

echo "start the timer by pressing enter"
read
H=$(date '+%H')
M=$(date '+%M')
S=$(date '+%S')
echo "start timer is : $H:$M:$S"
echo "stop the timer by pressing enter key"
read
h=$(date '+%H')
m=$(date '+%M')
s=$(date '+%S')
echo "stop timmer is :$h:$m:$s"
a=$(($h-$H))
b=$(($m-$M))
c=$(($s-$S))
echo "total time by timmer is"
echo $a:$b:$c
