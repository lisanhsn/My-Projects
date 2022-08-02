# def add(*args):
#     sum = 0
#     for i in args:
#         sum += i
#     return sum
#
#
# s = add(1, 1, 1, 1, 1, 1, 1, 1, 1)
# print(s)


# def calculate(n, **kwargs):
#     # print(kwargs)
#     n += kwargs["add"]
#     n *= kwargs["multiply"]
#     print(n)
#
#
# calculate(2, add=10, multiply=10)


class Car:
    def __init__(self, **kwargs):
        self.make = kwargs["make"]
        self.model = kwargs["model"]


car = Car(make="Nissan",model="GR-R")
# print(car.model)
print(car)