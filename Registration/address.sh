#!/bin/bash/ -x
echo "welcome to address registration"
echo "adding name to the registration book" >> test1.txt
echo ..................................... >> test1.txt
echo

#first name and lastname method
name(){
read fn
if [[ "$fn" != "${fn%[[:space:]]*}" ]]
then
echo "you have entered invalid name"
echo "re-entered your name"
name
else
 var=$(echo "$fn" | awk '/^[A-Z]{1}[a-z]{2,}$/{print $0}' )
 if [ -z $var ]
 then
 echo "you have entered invalid name"
 echo "re-entered your name"
 name
 else
 echo "valid name"
echo $fn
echo "$fn" >> test1.txt
 fi
fi
}

#mobile verification
mobile(){
read mo
var=$(echo "$mo" | awk '/^[7-9]{1}[0-9]{9}/{print $0}')
echo "$var"
if [ -z $var ]
then
echo "invalid try again"
echo enter mobile no.
mobile
else
echo "valid mobile number"
echo "$mo" >> test1.txt
fi
}

#emailId verification
email(){
read em
v=$(echo "$em" | awk '/^([A-Za-z0-9]+)@([a-zA-Z]+)\.([a-zA-Z]{2,4})$/{print $0}' )
if [ -z $v ]
then
echo invalid try again
email
else
echo valid email
echo $em >> test1.txt
fi
}

#password generation
password(){
echo "enter the password"
read password
len="${#password}"
if [ $len -ge 8 ]
then
    echo "$password" | grep -q [0-9]
     if [ $? -eq 0 ]
     then
           echo "$password" | grep -q [A-Z]
                if [ $? -eq 0 ]
                then
                    echo "$password" | grep -q [a-z]
                      if [ $? -eq 0 ]
                      then
                         echo "$password" | grep -q "[@#$%^&*]"
                           if [ $? -eq 0 ]
                           then
                              echo "strong password"
		              echo $password >> test1.txt
                           else
                               echo "special character is not included"
password
                            fi
                      else
                          echo "weak password include lower case char"
password
                      fi
                 else
                 echo "weak password include capital char"
password
                 fi
            else
       echo "please include the numbers in password it is weak password"
password

            fi
else
    echo "password lenght should be greater than or equal 8 hence weak password"
password
fi
}

#Main registration.........................
employ_address(){

#enter first name
echo "enter the firstName (first letter should capital and should min length 3)"
name

#enter lastName
echo "enter the lastName (first letter should capital)"
name

#enter mobileNo
echo "enter your 10 digit mobile no."
mobile

#email varification
echo "enter your valid emilId(eg. abc123@abc123.abc)"
email

#password verification
password
}

employ_address

echo >> test1.txt
