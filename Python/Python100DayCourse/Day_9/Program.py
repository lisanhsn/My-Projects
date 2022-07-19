# Dictionary
from re import T


my_intro = {
  "Name":"Lisan Hossain",
  "Age":17,
  "Class":12
}
my_intro["Year"] = 2022
for key  in my_intro:
  print(my_intro[key], key)


travel_log = {
  "France": {"cityvisited":["London","Paris","Dijon"], "Total_trip":12},

}
print(travel_log)