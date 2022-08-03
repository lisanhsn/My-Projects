import random


def main():
    new_list = [i * 10 for i in range(random.randint(50, 100), random.randint(500, 1000)) if i % 2 == 0]
    print(sorted(set(new_list)))


if __name__ == "__main__":
    main()
