import random
import os
from game_data import data
from art import logo, vs


def clear():
  os.system('clear')
print(logo)
score = 0
game_should_continue = True
account_b = random.choice(data)


def format_data(account):
    account_name = account["name"]
    account_descrip = account["description"]
    account_country = account["country"]
    return f"{account_name}, a {account_descrip}, from {account_country}"


def check_answer(guess, a_follower, b_follower):
    if a_follower > b_follower:
        return guess == "a"
    else:
        return guess != "b"


while game_should_continue:

    account_a = account_b
    account_b = random.choice(data)
    while account_a == account_b:
        account_b = random.choice(data)

    print(f"Compare A: {format_data(account_a)}")
    print(vs)
    print(f"Compare B: {format_data(account_b)}")

    guess = input("Who has more followers? type 'A' or 'B': ").lower()
    a_follower_count = account_a["follower_count"]
    b_follower_count = account_b["follower_count"]
    is_correct = check_answer(guess, a_follower_count, b_follower_count)


    clear()

    if is_correct:
        score += 1
        print(f"You'right. Current Score {score}.")
    else:
        print(f"Sorry, that's wrong. Final Score {score}")
        game_should_continue = False
