#!/bin/bash/ -x
echo "welcoeme to coupon code"
echo "How many distinct coupon required"
read no
echo "what is the size of individual coupon"
read size
char="qwertyuioplkjhgfdsazxcvbnmZXCVBNMLKJHGFDSAQWERTYUIOP1234567890"
len=${#char}
random(){
rand=$(($RANDOM%$len))
return $rand
}
echo "distinct coupons are:"
for((i=0;i<$no;i++))
do
coupon=""
	for((j=o;j<$size;j++))
	do
	random
        xx=$?
        var=${char:$xx:1}
	coupon=$coupon$var

	done
	echo $coupon
done
