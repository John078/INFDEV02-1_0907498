
letters = raw_input("Which letters would u like to shift?")
places = input("With how many places do you like to shift between 1 and 26?")

if places>= 1 and places<=26:       #de plaats moet binnen de 26 vallen
    translated = ""                 #je begint met een omgezette waarde van niks omdat je nog niks hebt omgezet

    for i in letters: 
        if i.isalpha():             #controleer of een willekeurige waarde wel letters zijn en geen nummers
            number = ord(i)         #zet de letters om in nummers
            number += places        #de nummer + de places wordt de nieuwe letter

            if i.isupper():                         
                if number > ord('Z'):               #nummer groter dan Z ga je terug in het alfabet dus loop je naar het begin door -26
                    number -= 26
                elif number < ord('A'):             #nummer kleiner dan A ga je terug in het alfabet dus loop je naar het einde door +26
                    number += 26
            elif i.islower():
                if number > ord('z'):
                    number -= 26
                elif number < ord('a'):
                    number += 26
            translated += chr(number)               #translated geeft de character door chr van het number
        else:
            translated += i                         #als er een andere waarde is dan blijft dit staan. Denk aan spaties of !

else:
    print "You have to choose between 1 and 26"


print translated

