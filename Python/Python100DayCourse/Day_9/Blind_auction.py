from cmath import log
from art import logo
print(logo)

bids ={}
bidding_finished = False
def findind_highest_bidder(bidder_recors):
  highest_bid = 0
  for bidder in bidder_recors:
    bid_amount = bidder_recors[bidder]
    if bid_amount > highest_bid:
      highest_bid = bid_amount
      winner = bidder
  print(f"The winner of Bid id {winner} => {bidder_recors[bidder]}")

while not bidding_finished:
  name = input("What is your name: ")
  price = int(input ("What is price you going to bid: $"))
  bids[name] = price
  should_contine= input ("Are there any bidders. Type 'yes' or 'no'.")
  if should_contine == "no":
    bidding_finished = True
    findind_highest_bidder(bids)


