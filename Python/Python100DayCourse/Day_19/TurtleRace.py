import random
from turtle import Screen, Turtle

sc = Screen()

sc.setup(500, 400)
user_bet = sc.textinput(title="Have you bet", prompt="Which turtle will win the race? Enter a color: ")
print(user_bet)
colors = ["red", "blue", "green", "yellow", "purple", "orange"]
y_position = [-70, -40, -10, 20, 50, 80]
all_turtles = []

for index in range(0, 6):
  new_turtle = Turtle(shape="turtle")
  new_turtle.color(colors[index])
  new_turtle.penup()
  new_turtle.goto(x=-230, y=y_position[index])
  all_turtles.append(new_turtle)

if user_bet:
  is_race_on = True

while is_race_on:
  for turtle in all_turtles:
    if turtle.xcor() > 230:
      is_race_on = False
      winning_color = turtle.pencolor()
      if winning_color == user_bet:
        print(f"You're winner.The color winner is {winning_color}")
        break
      else:
        print(f"You've lose.The color winner is {winning_color}")
        break
    random_distance = random.randint(0, 10)
    turtle.forward(random_distance)

sc.exitonclick()
