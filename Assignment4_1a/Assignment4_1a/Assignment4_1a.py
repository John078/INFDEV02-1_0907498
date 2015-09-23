#Van Fahrenheit naar Celsius
#F = C *1.8 + 32

Name = input("Hi, What's your name?")
Fahrenheit = float(input("How much Fahrenheit is it?"))
if 33 < Fahrenheit :
 print("Okay",Name,"Let's convert",Fahrenheit,"degrees Fahrenheit")
 Celsius = (Fahrenheit - 32)/1.8
 print(Fahrenheit,"Fahrenheit is",round(Celsius,2), "degrees Celsius")
else : 
    print("This is not a correct value, try again")