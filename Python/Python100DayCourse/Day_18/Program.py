import random
from turtle import Turtle, Screen

# bose = Turtle()
# bose.shape("turtle")
# bose.color("blue1")
#
# bose.pensize(3)
# # Draw the rectangle
# for i in range(4):
#     bose.forward(200)
#     bose.left(90)


# sc = Screen()
# sc.exitonclick()


# import heroes
# print(heroes.gen())


# drawing dashed line
# bose= Turtle()
# for _ in range(15):
#     bose.forward(10)
#     bose.penup()
#     bose.forward(10)
#     bose.pendown()


# drawing different shapes
# bose = Turtle()
# colors = ["red", "green", "yellow", "blue", "orange", "cyan", "purple"]


# def draw_shape(num_sides):
#   angle = 360 / num_sides
#   bose.pencolor(random.choice(colors))
#   for _ in range(num_sides):
#     bose.forward(100)
#     bose.right(angle)


# for shape_sides_n in range(3,11):
#   draw_shape(shape_sides_n)


# random walking Program
bose = Turtle()
sc = Screen()
directions = [0, 90, 180, 270]
bose.pensize(1)
bose.speed("fastest")
current_heading = bose.heading()


# bose.setheading(current_heading)


def random_color():
    r = random.randint(0, 255)
    g = random.randint(0, 255)
    b = random.randint(0, 255)
    color = (r, g, b)
    return color


#
# for _ in range(200):
#     sc.colormode(255)
#     bose.pencolor(random_color())
#     bose.forward(100)
#     bose.setheading(random.choice(directions))


sc.colormode(255)

bose.speed("fastest")


def draw_spirograph(size_of_gap):
    for _ in range(int(360 / size_of_gap)):
        bose.color(random_color())
        bose.circle(100)
        bose.setheading(bose.heading() + size_of_gap)


draw_spirograph(size_of_gap=1)

sc.exitonclick()
