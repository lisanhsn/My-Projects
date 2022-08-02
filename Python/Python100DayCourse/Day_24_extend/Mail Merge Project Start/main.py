PLACEHOLDER = "[name]"
with open("./Input/Names/invited_names.txt") as name_files:
    names = name_files.readlines()
    print(names)

with open("./Input/Letters/starting_letter.txt") as letter_file:
    letter_content = letter_file.read()
    for name in names:
        striped_name = name.strip()
        new_letter = letter_content.replace(PLACEHOLDER, striped_name)
        with open(f"./Output/ReadyToSend/letter_for_{striped_name}", mode="w") as completed_letter:
            completed_letter.write(new_letter)
