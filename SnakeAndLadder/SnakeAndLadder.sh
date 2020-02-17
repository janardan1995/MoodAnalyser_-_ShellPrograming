  
#!/bin/bash/ -x
echo WECOME TO SNAKE AND LADDER
echo single player playeing the game and his starting position is 0

#random function for randomly generated number
#.............................................................................................................>
random(){
 x=$(($(($RANDOM%6))+1))
return $x
}
#>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

Ladder(){
# VARIBLE IS USED FOR STORING THE PARAMETER
Count=$1

# random function calling for rolling die
random
a=$?
echo die value is : $a

#enter into the case
   case $a in
     1) Count=$(($Count+1))
	return $Count
        ;;

     2) if (($Count==99))
	then
        return $Count
	else
	Count=$(($Count+2))
        return $Count
	fi
        ;;

     3) if [ $Count -eq 99 ] || [ $Count -eq 98 ]
	then
	return $Count
	else
	Count=$(($Count+3))
        return $Count
	fi
        ;;

     4) if [ $Count -eq 99 ] || [ $Count -eq 98 ] || [ $Count -eq 97 ]
	then
	return
	else
	Count=$(($Count+4))
        return $Count
	fi
        ;;

      5)if [ $Count -eq 99 ] || [ $Count -eq 98 ] || [ $Count -eq 97 ] || [ $Count -eq 96 ]
	then
	return $Count
	else
	Count=$(($Count+5))
        return $Count
	fi
        ;;

      6)if [ $Count -eq 99 ] || [ $Count -eq 98 ] || [ $Count -eq 97 ] || [ $Count -eq 96 ] || [ $Count -eq 95 ]
	then
	return $Count
	else
	Count=$(($Count+6))
        return $Count
	fi
        ;;

      *) echo error
   esac
}
#----------------------------------------------------------------------------------------

#snake function..........................

Snake(){
Count=$1
# random function calling for rolling die
random
a=$?
echo die value is : $a
#echo enter into the case
   case $a in
     1) if [ $Count -eq 0 ]
	then
	return $Count
	else
	Count=$(($Count-1))
        return $Count
	fi
        ;;

     2) if [ $Count -eq 1 ] || [ $Count -eq 0 ]
	then
        return $Count
	else
	Count=$(($Count-2))
        return $Count
	fi
        ;;

     3) if [ $Count -eq 1 ] || [ $Count -eq 2 ] || [ $Count -eq 0 ]
	then
	return $Count
	else
	Count=$(($Count-3))
        return $Count
	fi
        ;;

     4) if [ $Count -eq 1 ] || [ $Count -eq 2 ] || [ $Count -eq 3 ] || [ $Count -eq 0 ]
	then
        return $Count
	else
	Count=$(($Count-4))
        return $Count
	fi
        ;;

      5)if [ $Count -eq 1 ] || [ $Count -eq 2 ] || [ $Count -eq 3 ] || [ $Count -eq 3 ] || [ $Count -eq 0 ]
	then
	return $Count
	else
	Count=$(($Count-5))
        return $Count
	fi
        ;;

      6)if [ $Count -eq 1 ] || [ $Count -eq 2 ] || [ $Count -eq 3 ] || [ $Count -eq 3 ] || [ $Count -eq 5 ] || [ $Count -eq 0 ]
	then
	return $Count
	else
	Count=$(($Count-6))
        return $Count
	fi
        ;;

     *) echo error
   esac

}

#first user method.......................................
userTurn(){

#this random no is for Checking the option of play no play and ladder and snake

move=$(($RANDOM%3+1))
echo option check for user 1 is :$move

#cash of ching option is start from here
  case $move in
    1) echo "position : $PositionOf1stUser"
       ;;

    2) Ladder $PositionOf1stUser
       PositionOf1stUser=$?
       echo "position : $PositionOf1stUser"
       ;;

    3) Snake $PositionOf1stUser
       PositionOf1stUser=$?
       echo "position : $PositionOf1stUser"
       ;;

    *)echo error
  esac
  count=$(($count+1))

}

#user 2 function..........................................

userTurn2(){
move=$(($RANDOM%3+1))
echo option for 2nd user is : $move

#case is starting for here
  case $move in
   1) echo "position : $PositionOf2ndUser"
      ;;

   2) Ladder $PositionOf2ndUser
      PositionOf2ndUser=$?
      echo "position : $PositionOf2ndUser"
      ;;

   3) Snake $PositionOf2ndUser
      PositionOf2ndUser=$?
      echo "position : $PositionOf2ndUser"
      ;;

    *)echo error
  esac
  count2=$(($count2+1))

}

# win methos.............................................................
  win(){

    if [ $PositionOf2ndUser -eq 100 ] || [ $PositionOf1stUser -eq 100 ]
    then
    echo result_________________________________________________________
    echo
    echo User one score : $PositionOf1stUser 
    echo User two score : $PositionOf2ndUser 
    
        if(($PositionOf2ndUser==100))
        then
        echo user 2 wins
        fi

        if(($PositionOf1stUser==100))
        then
        echo user 1 wins
        fi

       exit 
    fi
}

#my main function from where program is starting...................................................
#this count variable is for no of total time die was played
count=0
count2=0
PositionOf1stUser=0
PositionOf2ndUser=0
loop=1
while(($loop!=0))
do
echo -----------
echo user 1 turn
echo -----------
#calling the user 1 method
    userTurn
#is user 1 is win?
    win

echo ------------
echo user 2 turn
echo ------------
#calling user 2 method
    userTurn2
#is user 2 win?
    win
echo
done
#echo total number of times the dice was played by user 1 to win the game is : $count
#echo total number of times the dice was played by user 1 to win the game is : $count2


