#Zorgt ervoor dat random gebruikt kan worden
import random

print("Welcome to the game Rock, Paper, Scissors! \nFirst of all, you can choose between Rock, Paper and Scissors.")

#.Lower() zorgt ervoor dat hoe de gebruiker het invult het altijd kleine letters zijn
PickPlayer1 = input("Which one do you pick?").lower()

#PickPlayer1 moet overeenkomen met de te kiezen woorden
if PickPlayer1 in ['rock', 'paper', 'scissors']:
    print("Player 1 picked", PickPlayer1)

    PickPlayer2 = random.choice(['rock', 'paper', 'scissors'])
    print("Player 2 picked",PickPlayer2)

    if (PickPlayer1=="rock") & (PickPlayer2=="paper"):
        print("Paper wraps Rock \nPlayer 2 wins!")
    elif (PickPlayer1=="rock") & (PickPlayer2=="scissors"):
        print("Rock beats scissors \nPlayer 1 wins!")
    elif (PickPlayer1=="paper") & (PickPlayer2=="scissors"):
        print("Scissors cut paper \nPlayer 2 wins!")
    elif (PickPlayer1=="paper") & (PickPlayer2=="rock"):
        print("Paper wraps Rock \nPlayer 1 wins!")
    elif (PickPlayer1=="scissors") & (PickPlayer2=="paper"):
        print("Scissors cut paper \nPlayer 1 wins!")
    elif (PickPlayer1=="scissors") & (PickPlayer2=="rock"):
        print("Rock beats scissors \nPlayer 2 wins!")
    else:
        print("You picked the same, Let's do it again!")

#als de input niet gelijk is aan choice
else:
    print("You have to choose between rock, paper or scissors \nLet's try again!")

