
#square
height = input("What is the height of the square?")
for x in range(height):
    for y in range(height):
        print "*"


#hallow square
rows = input("How many rows do you want?")
headrow="*"*rows
innerrow="*"+(rows-2)*" "+"*"
newline="\n"
innerpattern= (innerrow+newline)*(rows-2)
print headrow + newline + innerpattern + headrow


#driehoek maken
#start,stop,step
length = input("What is the length of the bottom line?")
bottom = length + 1
for x in range (1,bottom,1):
    print "*" * x


#pyramide maken
# aantal spaties + aantal x
length = input("What is the length of the bottom line?")
bottom = length + 1
for x in range(1,bottom):
    print ((bottom-1)-x)*" " + " ".join(["*"]*x)
 

#cirkel maken
#for the amounts 11, 5, 5, 5 it works well.
#r^2 = (x - a)^2 + (y - b)^2
print "First of all, you have to know that the width/length must be twice more than the amount of radius."
width = input("What is the width/length of the background?")
a = input("Choose x for (x,y)?")
b = input("Choose y for (x,y)?")
radius = input("What is the radius of the circle?")

map = [[" " for x in range(width)] for y in range(width)]       #een waarde x moet in de range(width) zitten, hetzelfde voor y

for y in range(width):                                          #voer uit zodra y in de waarde range
    for x in range(width):                                      #voer uit zodra x in de waarde range
        if abs((x-a)**2 + (y-b)**2)== radius**2:                #als de formule van de cirkel juist is, dan print je een *
            map[y][x] = "*"

for line in map:                    #je moet de "map" lijn voor lijn bekijken
    print " ".join(line)
