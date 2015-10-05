'''
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
#r^2 = (x - a)^2 + (y - b)^2
width = input("What is the width/length of the circle?")
a = input("What is the Centrepoint x?")
b = input("What is the Centrepoint y?")
radius = input("What is the radius of the circle?")
E = radius**0.5

map = [[" " for x in range(width)] for y in range(width)]

for y in range(width):
    for x in range(width):
        if abs((x-a)**2 + (y-b)**2 - radius**2) < E**2 :
            map[y][x] = "*"

for line in map:
    print " ".join(line)

'''
