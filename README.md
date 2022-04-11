
This is my solution for Deliverable 2 for the Grand Circus Full Stack C# .NET After-Hours Bootcamp, beginning April 11, 2022.

# Deliverable2 - Buffet

## Task
Let's simulate a buffet experience! You will create a program that simulates the host of a buffet restaurant. The program will ask the user for a party size, ask for each party member’s drink order, keep track of how many times each drink was ordered, and at the end, present a bill with the accurate total price.

This is an all-you-can-eat buffet, so the price for each person is the same. (Set the buffet price to $9.99 per person.) The guests only pay extra for drinks... and this buffet only has two drinks! You can choose the two drinks and their prices. (For example, water is free, and coffee is $2.00).

You'll want to set up some variables to use throughout your program, such as number variables that keep track of how many of each drink is ordered, and how much the drinks cost. (Hint: what number data type could be used to represent money? It's not an integer...) Limit the party size to six people. If the user inputs a party size that is too large, simply provide them with a polite rejection message and end the program.

Otherwise, print out the drink options for the user. Now, set up a loop that asks each person for which drink they'd like. Keep track of how many of each drink is ordered because you'll need this number to calculate the bill.

After taking the orders, calculate the total and print out that value to the user.

Have fun with the text formatting! Feel free to add your own personal spin on the wording and prompts in the console. The example is there to guide you, but doesn't have to be exactly the same.



### Console Output Example #1
`Hi. Welcome to our Buffet. All you can eat for $9.99! We only charge extra for coffee. How many people are in your group? Please, parties of 6 or lower.`

`5`

`A table for 5! Please follow me and take a seat.`
`Let's get everyone started with some drinks. We've got water or coffee.`

`Alright, person number 1, water or coffee?`

`water`

`Water, good choice!`

`Alright, person number 2, water or coffee?`

`water`

`Water, good choice!`


`Alright, person number 3, water or coffee?`

`coffee`

`Coffee, okay!`

`Alright, person number 4, water or coffee?`

`wine`

`We don't have that. No drink for you!`


`Alright, person number 5, water or coffee?`

`coffee`

`Coffee, okay!`

`Okay, so that's 2 coffees and 2 waters. I'll be right back. Feel free to grab your food!`

`Here's your bill! Total price: $53.95`


### *Explanation of Console Output Example #1:*

5 buffets = 5 x 9.99 = 49.95

2 coffees = 2 x 2.00 = 4.00

2 waters = free

total = 53.95

### Console Output Example #2
`Hi. Welcome to our Buffet. All you can eat for $9.99! We only charge extra for coffee. How many people are in your group? Please, parties of 6 or lower.`

`8`

`Oh sorry, can only seat parties up to 6. Have a nice day.`


## Grading Criteria (10 points total): 
- 1pt: Greet the user and ask the user for a party size. Take their input. Assume valid inputs (such as the user won’t enter a string when a number is called for).
- 1pt: Convert the party size input from a string to a number and store it in a variable.
- 1pt: Limit the party size to six, and if the given party size is too large, end the program.
- 1pt: Let the user know about the drink options (You must provide two drink choices.)
- 1pt: Loop through the amount of people in the party and ask each person which drink they'd like. You can address the person with an index number if you'd like. 
- 1pt: Keep track of how many drinks are ordered for each drink option, and give feedback to the user that acknowledges their choice. (String concatenation or interpolation will help you)
- 1pt: If the user enters a drink that isn't an option, tell them about it and move on.
- 1pt: Tell the user how many of each drink have been ordered.
- 1pt: Calculate the total price correctly. Remember, each person pays the buffet price, and then pays extra for a drink.
- 1pt: Print out the total for the user to see.
