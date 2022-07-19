n  = int(input("Enter a number: "))

def primeChecker(number):
  is_prime = True
  for i in range(2, number):
    if number % i == 0:
      is_prime = False
  if is_prime:
    print("The number is a prime.")
  else:
    print("The number is not a prime.")
primeChecker(n)
      