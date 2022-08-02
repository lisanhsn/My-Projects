import random
import turtle as tt

bose = tt.Turtle()
bose.penup()
bose.hideturtle()
tt.colormode(255)
rgb_color = [(238, 236, 234), (230, 226, 228), (34, 108, 167), (223, 229, 235), (227, 233, 230), (245, 77, 36),
             (112, 163, 211), (153, 57, 85), (219, 156,
                                              94), (201, 60, 27), (24, 133, 55), (246, 204, 84),
             (190, 151, 47), (225, 119, 152), (46, 53,
                                               121), (221, 68, 97), (113, 199, 156), (147, 37, 30),
             (253, 202, 0), (91, 113, 192), (74, 40, 32), (248,
                                                           153, 143), (111, 41, 49), (155, 212, 203),
             (53, 174, 163), (38, 31, 67), (154, 210, 219), (43, 33, 45), (35, 55, 46), (99, 93, 2)]

bose.setheading(225)
bose.forward(300)
bose.setheading(0)
bose.speed("fastest")

number_of_dots = 101

for dot_count in range(1, number_of_dots):
    bose.dot(20, random.choice(rgb_color))
    bose.forward(50)
    if dot_count % 10 == 0:
        bose.setheading(90)
        bose.forward(50)
        bose.setheading(180)
        bose.forward(500)
        bose.setheading(0)

sc = tt.Screen()
sc.exitonclick()
