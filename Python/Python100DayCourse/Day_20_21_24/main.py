import time
from turtle import Screen
from snake import Snake
from food import Food
from scoreboard import Scoreboard

sc = Screen()
sc.setup(600, 600)
sc.bgcolor("black")
sc.title("My Snake Game")
sc.tracer(0)

# Creating the snake and food

snake = Snake()
food = Food()
scoreboard = Scoreboard()

# set control of snake
sc.listen()
sc.onkey(key="Up", fun=snake.up)
sc.onkey(key="Down", fun=snake.down)
sc.onkey(key="Left", fun=snake.left)
sc.onkey(key="Right", fun=snake.right)

game_is_on = True
while game_is_on:
    sc.update()
    time.sleep(.1)
    snake.move()

    #   Detect the food collision
    if snake.head.distance(food) < 15:
        food.refresh()
        snake.extent()
        scoreboard.increase_score()

    #   Detect the wall collision
    if snake.head.xcor() > 280 or snake.head.xcor() < -280 or snake.head.ycor() > 280 or snake.head.ycor() < -280:
        scoreboard.reset()
        snake.reset()
    #   Detect Collision with tail
    for segment in snake.segments[1:]:
        if snake.head.distance(segment) < 10:
            scoreboard.reset()
            snake.reset()

# segment_1 = Turtle(shape="square")
# segment_1.color("white")
# segment_2 = Turtle(shape="square")
# segment_2.color("white")
# segment_2.goto(x=-20, y=0)
# segment_3 = Turtle(shape="square")
# segment_3.color("white")
# segment_3.goto(x=-40, y=0)

sc.exitonclick()
