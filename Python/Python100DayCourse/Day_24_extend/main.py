# file = open("myText.txt") another of doing
# with open("myText.txt") as f:  # was just for reading
#     content = f.read()
#     print(content)

# with open("myText.txt", mode="w") as f: # is for writing
#     f.write("New text by Lisan")

with open("/home/lisan/Desktop/Lisan.txt", mode="a") as f: # is for appending
    f.write("\nNew text by Lisan.")
