'''

#square
height = input("What is the height of the square?")
square = ""
for x in range(height):
    for y in range(height):
        square += "*"
    square += "\n"      
print square



#hallow sqaure
rows = input("How many rows do you want?")
square = ("")                      #The printing string

for a in range(rows):              #The first row 
    square += ("*")                  
square += ("\n")                     
for b in range(rows-2):            #Prints the middle lines rows-2 times
    square += ("*")      
    for c in range(rows-2):        #Prints the middle of the line of the rows-2 times.
        square += (" ")
    square += ("*")
    square += ("\n")
for d in range(rows):              #The last row
    square += ("*")                
square += ("\n")                   
        
print square



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
length = input("How many rows do you want?")
pyramide = ""
for i in range(length):                   #length +1 zorgt ervoor dat het nummer wat de gebruiker intypt ook echt het einde is.
    for b in range(length-i):           #deze loop zorgt ervoor dat er spaties tussen de getallen komen, wat steeds afneemt met 1.
        pyramide +=  " "            
    for b in range((2*i)+1):                  #je pakt nu de range van 1 tot 2, 1 tot 4, 1 tot 6, etc
        pyramide += "*"
    pyramide += "\n"
print pyramide
'''


#cirkel maken
#r^2 = (x - a)^2 + (y - b)^2
radius = input("What is the radius of the circle?")
if radius > 1:
    width = 4*radius                                                #4*radius is always safe to have enough space outside the cirkel.
    a, b = 2*radius, 2*radius                                       #het startpunt is in the middle of the background. This is 4/2 so 2*radius.

    map = [[" " for x in range(width)] for y in range(width)]       #een waarde x moet in de range(width) zitten, hetzelfde voor y

    for y in range(width):                                          #voer uit zodra y in de waarde range
        for x in range(width):                                      #voer uit zodra x in de waarde range
            if (x-a)**2 + (y-b)**2 - radius**2 < radius:            #de formule van een cirkel moet kleiner zijn dan de radius om alles binnen de lijnen te printen.
                map[y][x] = "*"

 
    for line in map:                    #hij bekijkt elke lijst apart in de map
        print " ".join(line)            #join(line), elke list wordt in een string gezet en dat wordt gescheiden door " "

else:
    print "You're radius is too low for a circle"
    '''