letter = raw_input("Type a letter: ")

print letter
number = input("Type a number to shift in the alfabet: ")
print "You want to shift the letter", letter,"with",number,"places"

for i in letter:
    print ord(i)



'''
shift = (check+number)
if shift <= 26:
    print shift
    result = alfabet[shift]
    print "The new letter is now",result
else:
    print "The alphabet has only 26 characters"

'''
