from turtle import Screen, Turtle
from ball import Ball

sc = Screen()
sc.bgcolor("black")
sc.setup(width=800, height=600)
sc.title("Pong Game by Lisan")
sc.tracer(0)

paddle = Turtle(shape="square")
paddle.color("white")
paddle.shapesize(stretch_wid=5, stretch_len=1)
paddle.penup()
paddle.goto(350, 0)


def go_up():
    new_y = paddle.ycor() + 20
    paddle.goto(paddle.xcor(), new_y)


def go_down():
    new_y = paddle.ycor() - 20
    paddle.goto(paddle.xcor(), new_y)


sc.listen()
sc.onkey(go_up, "Up")
sc.onkey(go_down, "Down")


game_is_on = True
while game_is_on:
    sc.update()

sc.exitonclick()
