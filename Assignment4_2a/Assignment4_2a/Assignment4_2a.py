﻿#Zorgt ervoor dat random gebruikt kan worden
import random

print("Welcome to the game Rock, Paper, Scissors! \nFirst of all, you can choose between Rock, Paper and Scissors.")

#.Lower() zorgt ervoor dat hoe de gebruiker het invult het altijd kleine letters zijn
PickPlayer1 = input("Player 1, Which one do you pick?").lower()
PickPlayer2 = input("Player 2, Which one do you pick?").lower()


A =  PickPlayer1 in ['rock', 'paper', 'scissors']
B =  PickPlayer2 in ['rock', 'paper', 'scissors']

#de input moet gelijk zijn aan rock paper of scissors
#als de input niet gelijk is aan de keuze
if A and B:
    print("Player 1 picked", PickPlayer1)
    print("Player 2 picked", PickPlayer2)
else:
    print("You have to choose between rock, paper or scissors \nLet's try again!")


#PickPlayer1=Pickplayer2 geeft foutmelding. Anders is het goed en wint er iemand.
if PickPlayer1==PickPlayer2:
    print("You picked the same, Let's do it again!")
elif (PickPlayer1=="rock") & (PickPlayer2=="paper"):
        print("Paper covers Rock \nPlayer 2 wins!")   
elif (PickPlayer1=="rock") & (PickPlayer2=="scissors"):
        print("Rock crushes scissors \nPlayer 1 wins!")
elif (PickPlayer1=="paper") & (PickPlayer2=="scissors"):
        print("Scissors cuts paper \nPlayer 2 wins!")
elif (PickPlayer1=="paper") & (PickPlayer2=="rock"):
        print("Paper covers Rock \nPlayer 1 wins!")
elif (PickPlayer1=="scissors") & (PickPlayer2=="paper"):
        print("Scissors cuts paper \nPlayer 1 wins!")
elif (PickPlayer1=="scissors") & (PickPlayer2=="rock"):
        print("Rock crushes scissors \nPlayer 2 wins!")
else:
   ()