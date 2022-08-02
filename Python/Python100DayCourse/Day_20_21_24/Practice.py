class Animal:
    def __init__(self):
        self.num_eyes = 2

    def breathe(self):
        print("Inhale, exhale")


class Fish(Animal):
    def __init__(self):
        super().__init__()

    def swim(self):
        print("Swing in water")

    def breathe(self):
        # super().breathe()
        print("In under water")


an_animal = Animal()
a_fish = Fish()
print(an_animal.breathe())
print(a_fish.breathe())
print(a_fish.num_eyes)
print(an_animal.num_eyes)
