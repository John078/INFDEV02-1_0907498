
letters = raw_input("Which letters would u like to shift?")
places = input("With how many places do you like to shift between 1 and 26?")

if places>= 1 and places<=26:
    translated = ""
    don
    for i in letters: 
        if i.isalpha():
            number = ord(i)
            number += places

            if i.isupper():
                if number > ord('Z'):
                    number -= 26
                elif number < ord('A'):
                    number += 26
            elif i.islower():
                if number > ord('z'):
                    number -= 26
                elif number < ord('a'):
                    number += 26
            translated += chr(number)
        else:
            translated += i

else:
    print "You have to choose between 1 and 26"


print translated

