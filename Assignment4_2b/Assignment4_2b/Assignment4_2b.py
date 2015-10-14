#SINGLEPLAYER

#Zorgt ervoor dat random gebruikt kan worden
import random

print "Welcome to the game Rock, Paper, Scissors, Lizard, Spock! \nFirst of all, you can choose between Rock, Paper, Scissors, Lizard or Spock."

#.Lower() zorgt ervoor dat hoe de gebruiker het invult het altijd kleine letters zijn
PickPlayer1 = raw_input("Which one do you pick?").lower()

#PickPlayer1 moet overeenkomen met de te kiezen woorden
if PickPlayer1 in ['rock', 'paper', 'scissors', 'lizard', 'spock']:
    print "Player 1 picked", PickPlayer1

    PickPlayer2 = random.choice(['rock', 'paper', 'scissors', 'lizard', 'spock']) #Player 2 is een random keuze uit de 5 keuzes door Random.choice
    print "Player 2 picked", PickPlayer2

    if PickPlayer1==PickPlayer2:
        print "You picked the same, Let's do it again!"

    elif PickPlayer1=="rock":
        if PickPlayer2=="paper":
            print "Paper covers Rock \nPlayer 2 wins!"
        elif PickPlayer2=="scissors":
            print "Rock crushes Scissors \nPlayer 1 wins!"
        elif PickPlayer2=="spock":
            print "Spock vaporizes Rock \nPlayer 2 wins!"
        elif PickPlayer2=="lizard":
            print "Rock crushes Lizard \nPlayer 1 wins!"

    elif PickPlayer1=="paper":
        if PickPlayer2=="scissors":
            print "Scissors cuts paper \nPlayer 2 wins!"
        elif PickPlayer2=="rock":
            print "Paper covers Rock \nPlayer 1 wins!"
        elif PickPlayer2=="lizard":
            print "Lizard eats Paper \nPlayer 2 wins!"
        elif PickPlayer2=="spock":
            print "Paper disproves Spock \nPlayer 1 wins!"

    elif PickPlayer1=="scissors":
        if PickPlayer2=="paper":
            print "Scissors cuts Paper \nPlayer 1 wins!"
        elif PickPlayer2=="rock":
            print "Rock crushes Scissors \nPlayer 2 wins!"
        elif PickPlayer2=="lizard":
            print "Scissors decapitates Lizard \nPlayer 1 wins!"
        elif PickPlayer2=="spock":
            print "Spock smashes Scissors \nPlayer 2 wins!"

    elif PickPlayer1=="lizard":
        if PickPlayer2=="paper":
            print "Lizard eats Paper \nPlayer 1 wins!"
        elif PickPlayer2=="rock":
            print "Rock crushes Lizard \nPlayer 2 wins!"
        elif PickPlayer2=="scissors":
            print "Scissors decapitates Lizard \nPlayer 2 wins!"
        elif PickPlayer2=="spock":
            print "Lizard poisons Spock \nPlayer 1 wins!"

    elif PickPlayer1=="spock":
        if PickPlayer2=="paper":
              print "Paper disproves Spock \nPlayer 1 wins!"
        elif PickPlayer2=="rock":
            print "Spock vaporizes Rock \nPlayer 1 wins!"
        elif PickPlayer2=="scissors":
            print "Spock smashes Scissors \nPlayer 1 wins!"
        elif PickPlayer2=="lizard":
            print "Lizard poisons Spock \nPlayer 2 wins!"


#als de input niet gelijk is aan choice
else:
    print "You have to choose between Rock, Paper, Scissors, Lizard or Spock \nLet's try again!"

