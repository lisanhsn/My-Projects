# with open("weather_data.csv") as data_file:
#     data = data_file.readlines()
#     print(data)


# import csv

#
# with open("weather_data.csv") as data_file:
#     data = csv.reader(data_file)
#     temperatures = []
#     for row in data:
#         if row[1] != "temp":
#             temperatures.append(int(row[1]))
#     print(temperatures)


# import pandas

# data = pandas.read_csv("/home/lisan/Desktop/Python100DayCourse/Day_25/weather_data.csv")
# converting to dictionary
# data_dict = data.to_dict()
# print(data_dict)

# data_list =data["temp"].to_list()
# data_list = data["temp"]
# average = sum(data_list)/ len(data_list)
# print(f"{data_list.mean()} {data_list.min()} {data_list.max()} {data_list.mode()}")

# get data in column
# print(data["condition"])
# print(data.condition)

# get data in row
# print(data[data.day == "Friday"])

# geting the highest temperatures
# print(data[data.temp == data.temp.max()])

# get in individually 
# monday = data[data.day == "Monday"]
# # print(monday.condition)
# monday_temp = int(monday.temp)
# to_fa = monday_temp * 9 / 5 + 32
# print(to_fa)


# Create a data from scratch
# data_dict = {
#     "students":["Lisan","Hossain","Shaed"],
#     "scores":[100,20,100],
# }
# data = pandas.DataFrame(data_dict)
# data.to_csv("newFileByLisan.csv")
# print("Lisan hossain")


# Working with squrell data
import pandas

data = pandas.read_csv("228 2018-Central-Park-Squirrel-Census-Squirrel-Data.csv")
grey_squ_count = len(data[data["Primary Fur Color"] == "Gray"])
cinnamon = len(data[data["Primary Fur Color"] == "Cinnamon"])
black_squ_count = len(data[data["Primary Fur Color"] == "Black"])
print(grey_squ_count)
print(cinnamon)
print(black_squ_count)

data_dict = {
    "Fur Color": ["Gray", "Cinnamon", "Black"],
    "Count":[grey_squ_count, cinnamon, black_squ_count]
}

data = pandas.DataFrame(data_dict)
print(data[data.Count == data.Count.max()])
print(data[data.Count == data.Count.max()])

data.to_csv("./Squirel_count.csv")
