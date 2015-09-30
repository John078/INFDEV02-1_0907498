import re

password = raw_input("Please enter your password...")

length_password = 6 <= len(password) <= 12
lowercase_password = re.search(r'[a-z]', password)
uppercase_password = re.search(r'[A-Z]', password)
numbers_password = re.search(r'[0-9]', password)


if length_password:
    if lowercase_password:
        if uppercase_password: 
            if numbers_password:
                print "You're password is strong"
            else:
                print "You're password is medium"
        else:
            print "You're password is weak"
else:
    print "You're password must be between 6 and 12 characters"
