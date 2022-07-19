# Calculator



from tkinter import W
from wsgiref.simple_server import sys_version


def add(n1, n2):
  return n1 + n2

def subtrat(n1, n2):
  return n1 - n2

def multiply(n1, n2):
  return n1 * n2

def divide(n1, n2):
  return n1 / n2


operations = {
  "+":add,
  "-":subtrat,
  "*":multiply,
  "/":divide
}


def calculator():
  num1 = float(input("Enter the first number: "))
  for symbol in operations:
    print(symbol)
  should_continue = True
  while should_continue:
    operation_symbol = input("Pick a operator from above: ")
    num2 = float(input("Enter the next: "))
    operation_function = operations[operation_symbol]
    answer = operation_function(num1, num2)
    print(f"{num1} {operation_symbol} {num2} = {answer}")
    if input(f"type 'y' to continue Calculation  with {answer}or type 'n' to break out") =='y':
      num1 = answer
    else:
      should_continue = False 
      calculator()

calculator()