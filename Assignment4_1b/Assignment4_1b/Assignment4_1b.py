Name = raw_input("Hi, What's your name?")   
Celsius = input("How much Celsius is it?")  

if -273.15 <= Celsius:         #because this is the absolute-0 point Kelvin.
    Kelvin = (Celsius + 273.15)         #this is the formula for Kelvin to Celsius.
    print "Okay",Name,", This is", Kelvin, "Kelvin"
else:
    print "Sorry",Name,", you have to retry"