
'''
#square
height = input("What is the height of the square?")
square = ""
for x in range(height):
    for y in range(height):
        square += "*"
    square += "\n"      
print square


#hallow square
rows = input("How many rows do you want?")
headrow="*"*rows
innerrow="*"+(rows-2)*" "+"*"
newline="\n"
innerpattern= (innerrow+newline)*(rows-2)
hallowsquare = headrow + newline + innerpattern + headrow
print hallowsquare


#triangle
#start,stop,step
length = input("What is the length of the bottom line?")
bottom = length + 1
triangle = ""
for x in range (1,bottom,1):
    triangle += "*"
    print triangle
'''

#pyramide maken
# aantal spaties + aantal x
length = input("What is the length of the bottom line?")
bottom = length + 1

for i in range(1,bottom):                   #length +1 zorgt ervoor dat het nummer wat de gebruiker intypt ook echt het einde is.
    for a in range(1,length-i+1):           #je pakt nu de range van 1 tot een getal dat steeds afneemt dus van 1 tot 6, 1 tot 5, 1 tot 4, etc.
        print ' ',
    for b in range(1,2*i):                  #je pakt nu de range van 1 tot 2, 1 tot 4, 1 tot 6, etc
        print '*',
    print 

'''

#cirkel maken
#r^2 = (x - a)^2 + (y - b)^2
radius = input("What is the radius of the circle?")
width = 4*radius                                                #4*radius is always safe to have enough space outside the cirkel.
a, b = 2*radius, 2*radius                                       #het startpunt is in the middle of the background. This is 4/2 so 2*radius.

map = [[" " for x in range(width)] for y in range(width)]       #een waarde x moet in de range(width) zitten, hetzelfde voor y

for y in range(width):                                          #voer uit zodra y in de waarde range
    for x in range(width):                                      #voer uit zodra x in de waarde range
        if (x-a)**2 + (y-b)**2 - radius**2 < radius:            #de formule van een cirkel moet kleiner zijn dan de radius om alles binnen de lijnen te printen.
              map[y][x] = "*"

 
for line in map:                    #je moet de "map" lijn voor lijn bekijken en een " " ertussen printen zonder deze regels wordt er niks laten zien.
    print " ".join(line)

'''
