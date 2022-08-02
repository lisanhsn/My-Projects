# from turtle import Turtle
# from turtle import  Screen
# bose = Turtle()
# bose.shape("turtle")
# bose.color("red","green")
# bose.forward(100)
#
# my_screen = Screen()
# my_screen.exitonclick()


#example
from prettytable import  PrettyTable
table = PrettyTable()
table.add_column("Pokemon Name",["Pikacu","squitle","Mangarsour"])
table.add_column("Type",["Electric" ,"Plants","water"])
table.align = "l"
print(table)
