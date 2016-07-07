import pygame
import time
import random

pygame.init()

display_width = 800
display_height = 600

black = (0,0,0)
white = (255,255,255)
red = (255,0,0)
green = (0,255,0)

car_width = 105
car_height = 63

gameDisplay = pygame.display.set_mode((display_width,display_height))    #the resolution of the window
pygame.display.set_caption('Moving the car')    #the title of the window
clock = pygame.time.Clock()

carImg = pygame.image.load('car.png')

def things(thingx, thingy, thingw, thingh, color):
    pygame.draw.rect(gameDisplay, color, [thingx, thingy, thingw, thingh])

def car(x,y):
    gameDisplay.blit(carImg,(x,y)) #zorgt ervoor dat er altijd een achtergrond is voor het plaatje

def text_objects(text, font):
    textSurface = font.render(text, True, black)
    return textSurface, textSurface.get_rect()

def message_display(text):
    largeText = pygame.font.Font('freesansbold.ttf',50)
    TextSurf, TextRect = text_objects(text, largeText)
    TextRect.center = ((display_width/2),(display_height/2))
    gameDisplay.blit(TextSurf, TextRect)

    pygame.display.update()

    time.sleep(2)   #2 seconden lang de message

    game_loop()     #start alles opnieuw op en wordt gereset

def crash():
    message_display('You hit the wall')

def game_loop():
    x = (display_width * 0.4)
    y = (display_height * 0.8)

    x_change = 0
    y_change = 0

    thing_startx = random.randrange(0, display_width)
    thing_starty = -600
    thing_speed = 7
    thing_width = 100
    thing_height = 100

    gameExit = False

    while not gameExit:
        for event in pygame.event.get():     #elk event dat er is wordt in een list gezet om het te gebruiken.
            if event.type == pygame.QUIT:
                pygame.quit()
                quit()

            if event.type == pygame.KEYDOWN:
                if event.key == pygame.K_LEFT:
                    x_change = -5
                elif event.key == pygame.K_RIGHT:
                    x_change = 5
                elif event.key == pygame.K_UP:
                    y_change = -5
                elif event.key == pygame.K_DOWN:
                    y_change = 5

            if event.type == pygame.KEYUP:
                if event.key == pygame.K_LEFT or event.key == pygame.K_RIGHT:
                    x_change = 0
                elif event.key == pygame.K_DOWN or event.key == pygame.K_UP:
                    y_change = 0

        x +=x_change            #verplaatst de afbeelding horizontaal met 0+ x_change
        y +=y_change            #verplaatst de afbeelding verticaal met 0+ y_change

        gameDisplay.fill(white)

        things(thing_startx, thing_starty, thing_width, thing_height, black)
        thing_starty += thing_speed
        car(x,y)

        if x > display_width - car_width or x < 0:
            crash()
        elif y > display_height - car_height or y < 0:
            crash()

        if thing_starty > display_height:
            thing_starty = 0 - thing_height
            thing_startx = random.randrange(0,display_width)

        if y < thing_starty+thing_height:
            print('y crossover')

            if x > thing_startx and x < thing_startx + thing_width or x+car_width > thing_startx and x + car_width < thing_startx+thing_width:
                print('x crossover')
                crash()

        pygame.display.update() #.update zorgt dat hij de parameter specifiek blijft updaten, .flip blijft alles updaten.
        clock.tick(60)      #How fast its move through the loop (FPS)


game_loop()
pygame.quit()
quit()
