print("Welcome to trip bill calculator")
bill = float(input("What was the bill for your trip: "))
tip = int(input("How mush would you give tip(10, 12, 15): "))
people = int(input("How many people you split the trip cost: "))
bill_with_tip = tip / 100 * bill + bill
you_need_Pay = bill_with_tip / people
print(you_need_Pay)