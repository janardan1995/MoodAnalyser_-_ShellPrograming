#!/bin?bash/ -x
echo "welcom to windchill programs"
echo enter velocity of wind v
read v
echo enter the temperature t
read t

if((v>3 && v<120 && t<50))
then
w=$(echo "35.74" "0.6215" "0.4275" "35.75" "0.16" "$t" "$v" | awk '{print $1+$2*$6+(($3*$6-$4)*($7**$5))}')
else
echo invalid formula
fi
echo "result : $w"
