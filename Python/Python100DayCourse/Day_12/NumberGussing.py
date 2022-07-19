from calendar import c
from random import randint

EASY_LEVEL_TURNS = 10
HARD_LEVEL_TURNS = 5


def check_answer(guess, answer, turns):
  """The guess is check against answer. Also it is tracked by number of turns"""
  if guess > answer:
    print("Your guess is too high")
    return turns - 1
  elif guess < answer:
    print("Your guess is too low")
    return turns - 1
  else:
    print(f"You got it. The answer was {answer}")


def set_difficulty():
  level = input("Choose your difficulty. Type 'easy' or 'hard': ")
  if level == "easy":
    return EASY_LEVEL_TURNS
  else:
    return HARD_LEVEL_TURNS


def game():
  print("Welcome to Number Guessing Game")
  print("I am thinking of a number between 1 to 100")
  answer = randint(1, 100)
  print(f"The answer is {answer}")

  guess = 0
  while guess != answer:
    turns = set_difficulty()
    print(f"You have {turns} attempts remaining to guess the number")
    guess = int(input("Make a guess: "))

    turns = check_answer(guess, answer, turns)
    if turns == 0:
      print("You are run out of turns")
      return
    elif guess != answer:
      print("Guess Again")

game()
