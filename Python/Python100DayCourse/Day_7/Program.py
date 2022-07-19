import random
from hangman_art import logo, stages
from hangman_words import word_list




lives = 6

chosen_word = random.choice(word_list)
word_len = len(chosen_word)
print(chosen_word)

end_of_game = False
display =[]
for _ in range(word_len):
  display += "_"
print(logo)
while not end_of_game:
  guess = input("Guess a letter: ").lower()
  print("\x1B[2J")
  if guess in display:
    print(f"You already guessed {guess}")
    

  # print(display)
  for position in range(word_len):
    letter = chosen_word[position]
    if letter == guess:
      display[position] = letter


  print(" ".join(display))
  
  if guess not in chosen_word:
    print(f"The {guess} is not the word. You lose a life")
    lives = lives - 1
    if lives == 0:
      print("You Lose")
      end_of_game = True
    

  if "_" not in display:
    end_of_game = True
    print("You win!!")


  print(stages[lives])