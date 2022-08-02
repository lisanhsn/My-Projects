# # Reduce Indentation erroe
# class User:
#     pass
#
#
# user_1 = User()

# Constructor
class User:
    def __init__(self, user_id, user_name):
        self.user_id = user_id
        self.user_name = user_name
        self.follower = 0
        self.following = 0

    def follow(self, user):
        user.follower += 1
        self.following += 1


user_1 = User("001", "Lisan Hossain")
user_2 = User("002", "Shaed")
user_1.follow(user_2)

print(user_1.follower)
print(user_1.following)
print(user_2.follower)
print(user_2.following)

# print(user_1.user_name)
# print(user_1.user_id)
# print(user_2.user_name)
# print(user_2.user_id)
