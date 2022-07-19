import math
import sys
import os
from datetime import date
from datetime import datetime
from prettytable import PrettyTable
####Time and Date###
today = date.today()
now = datetime.now()
current_time = now.strftime("%H:%M:%S")
total_time = str(today)+'\n'+str(current_time)
###################
table = PrettyTable(['Subject', 'English', 'Math', 'Science'])
table.add_row(['Code', 'sub11', 'sub22', 'sub33'])
skill_table = PrettyTable(['Skills', 'English', 'Math', 'Science'])
skill_table.add_row(['Code', 'ski11', 'ski22', 'ski33'])
note_table = PrettyTable(["CLI LSN EDUCATION SOFTWARE 🇧🇩\nYou can choose one subject at a time and you have to re-enter into the program"])
print(note_table)
print(table)
print('')
print("Extra option for skills")
print(skill_table)
print('')

#################ASK USER TO CHOOSE Subject#################
ask_subject = input("Enter a correct code for your starting:\n➥")
ask_name_for_ID = input("Enter your name:\n➥")
ask_age_for_ID = input("Enter your age:\n➥")
ask_schl_for_ID = input("Enter your school name:\n➥")
print('')


#######################Math__SUBJECT##########################
if ask_subject == "sub11":
    ID_table = PrettyTable(["Student ID"])
    sub11_table = PrettyTable(['Name', 'Age', 'School', 'Time'])
    sub11_table.add_row([ask_name_for_ID, ask_age_for_ID, ask_schl_for_ID, total_time])
    print(ID_table)
    print(sub11_table)
    print("Enter in Math QUIZ ✅")
else:
    print("Incorrect Code For Subjects and Skills")
    ask_subject = input("Enter a correct code for your starting:\n➥")