rows = input("De zijden van de vierkant")
square = ""

for x in range(rows):
    for y in range(rows):
        if x in range(1,rows-1):
            for x in range(rows-2):
                square+= " "
        else:
            square +="*"
    square+="\n"
print square