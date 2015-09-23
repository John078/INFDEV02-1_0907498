Name = input("Hi, What's your name?")
Celsius = float(input("How much Celsius is it?"))

if -273.15 <= Celsius :
    Kelvin = (Celsius + 273.15)
    print("Okay",Name,", This is", Kelvin, "Kelvin")
else :
    print("Sorry",Name,"you have to retry")