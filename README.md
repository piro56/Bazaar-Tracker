# Bazaar-Tracker
# DISCONTINUED PROJECT.
## This project was made and finished in around December of 2019.

### Purpose
This project utilizes the Hypixel API and more specifically, interacts with the Skyblock Bazaar components.
The program pulls relevant data from user input and has a few functions to give the user more insight on to what might be a good purchase.
Some useful operations are:
- cp - Goes through every item, and if you can CRAFT (create) a new item that is worth higher for a profit, it prints them out sorted from most profitable to least.
- ar - Auto refreshes the crafting profits every few seconds to see any market updates.
- cp 1,2,3,4 - Different versions of CP, some go through instant profits (buy now sell now), others go through gradual (buy later, sell later) 

### Code Quality
This code was written a while ago when I believe I did not have as firm of a grasp on programming as I do know.
Improvements that could be made on this code would be:
- Instead of hardcoding the crafting recipes and items in BazaarItems.cs, I could read from a JSON or different way of organizing data to help make the program more easily modifiable and readable.
- Move the relevant functional code into it's own utility class to help code readability
- Comment the code and it's function. 
- Theres many other slight improvements that can be made (repeating functions, better optimizations, etc.) 

## Thank you for taking the time to check out my project!
