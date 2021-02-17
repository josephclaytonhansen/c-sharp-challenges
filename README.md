# C# Challenges
## Introductory Challenges
All of these challenges can be done fairly simply in a console app. There are 15 introductory challenges, covering the basics of C#, and they're all simple terminal read/terminal write programs. The mid-level challenges will start to use file input/output as well. These challenges are designed to be companion exercises to https://www.youtube.com/watch?v=GhQdlIFylQ8, FreeCodeCamp's excellent C# tutorial. You can do all of these challenges with the material in the video... more or less. You may also need information regarding random numbers (https://stackoverflow.com/questions/2706500/how-do-i-generate-a-random-int-number for an overview, https://docs.microsoft.com/en-us/dotnet/api/system.random?view=net-5.0 for documentation) and lists (https://www.c-sharpcorner.com/article/c-sharp-list/ has excellent information in a readable format.)

This repository also contains solutions I've written for these challenges. Note that they are not optimized, but are meant to be readable and understandable. I would encourage you not to copy and paste the solutions. Having them open as reference may help you figure something tricky out, but copying and pasting from them will not. Whenever possible, use your knowledge, intuition, and trial and error before looking at the solutions. 

*1: Using Console read and write*
### Challenge 1
Get a hot dog order from the user: give them three options to enter a topping, then print “Here is your hot dog. It has: (toppings).”

**BONUS**: Put “and” before the last topping and put a period at the end of the toppings.

*2-4: Using Math methods and basic operations*
### Challenge 2
Get a number from the user and use it to print that many significant digits of pi (i.e., user says “3”, print “3.141”)
<details>
  <summary>Hint</summary>
  
HINT: Pi ~= 355/113
</details>

### Challenge 3
Get two numbers from the user: significant digits, and radius in inches. Print the area of the circle in square feet, with correct significant digits. Print the diameter and circumference in feet with correct digits.
<details>
  <summary>Hint</summary>
  
HINT: 1 foot = 12 inches. 1 square foot = 12 * 12 square inches 
</details>

### Challenge 4
Get a number from the user and tell them if it’s even or odd
<details>
  <summary>Hint</summary>
  
HINT: Don’t forget about the modulo operator
</details>

*5-7: Using string operations, if, and arrays/lists*
### Challenge 5
Get two strings from the user and print “They are the same!” if they are the same, or “They are not the same!” if they are not.

**BONUS**: Match despite capitalization

### Challenge 6
Print pricing information about a hot dog with six topping options: ketchup, mustard, onions, cream cheese, mushrooms, and jalapenos. The hot dog should have a base price, and toppings should add to it. For each topping, ask the user if they want it (yes or no). Print their hot dog with toppings (comma separated) and the price. 

**BONUS**: Put “and” before the last topping and put a period at the end of the toppings.

**DOUBLE BONUS**: Include sales tax (6%) in the price. 

<details>
  <summary>Hint</summary>
  
HINT: This may be easier with a list. See https://www.c-sharpcorner.com/article/c-sharp-list/
</details>

### Challenge 7
Get three numbers from the user. If two of them are the same, print “Two of them are the same.” If they are all the same, print “All of them are the same.” Otherwise, print “None of them are the same.”

*8-12: Card challenges! Using global variables and random numbers*
### Challenge 8
Get three cards from the user formatted as “10 of Hearts” or “H10”. (i.e., Ace of Clubs would be CA.) Tell them if they have a pair.

### Challenge 9
Deal 5 random cards to the user from a deck, and print those cards. 
<details>
  <summary>Hint</summary>
  
Use global variables to keep track of which cards are in play. Look at the solution for an example.
</details>

### Challenge 10
Deal 5 random cards to the user from a deck, and print those cards. Tell them if they have a:
- straight flush
- 4-of-a-kind
- full house
- flush
- straight
- 3-of-a-kind
- two pairs
- a pair

### Challenge 11
Deal 5 cards to three users (user1, user2, and user3), without repeating any. Print the probability of the next card for a number, an ace, or a face card.

### Challenge 12
Build a functional game of Crazy 8 between you and the computer, using a standard deck. 

*13-14: Intepreting input correctly*
### Challenge 13
Get an email address from the user and validate it. Print the validation status and the domain.

### Challenge 14
Build and print a basic fast food menu with prices. Take an order from the user. After each item, ask the user if they'd like anything else. Once their order is complete, print out their order and see if they want changes. If they do, allow them to add or remove items until satisfied. Once they're finally satisfied, charge them their total + sales tax (6%). 

**BONUS**: Choose an item that's out of stock. Let the user know if they pick it. It should never be added to an order.
<details>
  <summary>Hint</summary>
  
HINT: If you've done challenge #6, you've done at least half of this already. Don't be afraid to re-use code! 
</details>

*This challenge uses everything these challenges have covered so far (even math operations, if you do the bonus) and concludes this challenge set.*
### Challenge 15
Build a game of Rock, Paper, Scissors. Give the option to play again. Keep a running score.

**BONUS**: You can use this for rudimentary "machine learning." Store the results of each game, and use the past results to weight the next decision. Choose randomly- but if the random choice is the worst of the three (so far), choose again. 
