# Exercise 1:
# numbers = [1, 1, 2, 3, 5, 8, 13, 21, 34, 55]
# squared_numbers = [n * n for n in numbers]
# result = [n for n in numbers if n % 2 == 0]
# print(squared_numbers)
# print(result)


# Exercise 2:
import random
from turtle import st

# list_1 = [1, 2, 3, 4, 5, 5, 6, 7, 7, 8, 9, 10, 11]
# list_2 = [11, 2, 3, 4, 5, 6, 7, 7, 8, 9, 11, 10]
#
# result = [n for n in list_1 if n in list_2]
# print(result)

# Exercise 3:

# names = ["Lisan", "Hossain", "Shaed", "Abu", "Raian"]
#
# student_scores = {student:random.randint(0,100) for student in names}
#
# passed_student = {student:score for (student, score) in student_scores.items() if score >= 60}
#
# print(student_scores)
# print(passed_student)


# Exercise 4:

# sentence = "What is the Airspeed Velocity of an Unladen Swallow"
# sen_2 = sentence.split(" ")
#
# result = {word: len(word) for word in sen_2}
# reuslt_in_farenheit = {day: temp * 9/5 + 32 for (day, temp) in result.items()}
#
# print(result)
# print(reuslt_in_farenheit)


# Iterate through pandas dataframe

import pandas
student_dict = {
    "student": ["Lisan", "Hossain", "Shaed"],
    "score": [100, 99, 98]
}

student_data_frame = pandas.DataFrame(student_dict)
print(student_data_frame)
for (index, row) in student_data_frame.iterrows():
    print(row.student)