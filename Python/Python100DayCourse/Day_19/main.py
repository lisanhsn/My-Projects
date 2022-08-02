from hashlib import new
from turtle import Screen, Turtle

bose = Turtle()
sc = Screen()

def move_forward():
    bose.forward(100)

def move_backward():
    bose.backward(100)

def turn_left():
    new_heading = bose.heading() + 10
    bose.setheading(new_heading)

def turn_right():
    new_heading = bose.heading() - 10
    bose.setheading(new_heading)


def clear():
  bose.clear()
  bose.penup()
  bose.home()
  bose.pendown() 


sc.listen()
sc.onkey(key="w", fun=move_forward)
sc.onkey(key="s", fun=move_backward)
sc.onkey(key="a", fun=turn_left)
sc.onkey(key="d", fun=turn_right)
sc.onkey(key="c", fun=clear)
sc.exitonclick()