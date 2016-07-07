# Tyre, Wheel, Engine, Seat, Light, Person (driver and passenger), Car

class Car:
    def __init__ (self, brand, height, width, inch, color, fuel, places, sex, gender):
        self.brand = brand
        self.Tyre = Tyre(height, width)
        self.Wheel = Wheel(inch, color)
        self.Engine = Engine(fuel)
        self.Seat = Seat(places)
        self.Driver = Driver(sex)
        self.Passenger = Passenger(gender)

class Tyre:
    def __init__ (self, height, width):
        self.height = height
        self.width = width


class Wheel: 
    def __init__ (self, inch, color):
        self.inch = inch
        self.color = color


class Engine:
    def __init__ ( self, fuel):
        self.fuel = fuel


class Seat:
    def __init__ (self, places):
        self.places = places


class Driver:
    def __init__(self, sex):
        self.sex = sex


class Passenger:
    def __init__(self, gender):
        self.gender = gender

x = Car("Volkswagen", 80, 155, 13, "red", "petrol", 4, "woman", "man")

print "This is a %s" %(x.brand)
print "The Tyre is %s high and %s wide" %(x.Tyre.height, x.Tyre.width)
print "The Wheel is %s inch and has the color %s" %(x.Wheel.inch, x.Wheel.color)
print "The Engine needs %s " %(x.Engine.fuel)
print "The Car has %s seats" %(x.Seat.places)
print "The Driver is a %s" %(x.Driver.sex)
print "The passenger is a %s" %(x.Passenger.gender)
