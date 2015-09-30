#import regular expression, die kijkt of strings overeenkomen
import re

password = raw_input("Please enter your password...")

#password moet aan aantal letters voldoen
#re.search zoekt naar alle '..', in password
#r'[a-z] zoekt alles tussen a en z. [^....._] geeft aan alles behalve dat.
length_password = 6 <= len(password) <= 12
lowercase_password = re.search(r'[a-z]', password)
uppercase_password = re.search(r'[A-Z]', password)
numbers_password = re.search(r'[0-9]', password)
special_password = re.search(r'[^a-zA-Z0-9_]', password)

#als alles is true dan is het password sterk.
if length_password:
    if lowercase_password:
        if uppercase_password: 
            if numbers_password:
                if special_password:
                    print "You're password is strong"
                else:
                    print "You're password is medium"
            else:
                print "You're password is weak"
        else:
            print "You're password is weak"
    else:
        print "You're password is weak"
else:
    print "You're password must be between 6 and 12 characters"
