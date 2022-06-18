# Finances 

Finances is a poc for learning how to implement a class with its components. 
 
## Installation

You may install this project by cloning this repository from GitHub 

## Usage

### Case description 

#### Part1
Your user wants to manage his finances. There is a wallet that belongs to a person and we would like to 
have information about how much money is in the wallet. For simplicity, we assume that the amount of 
money is always an integer. 
The user should be able to get some information about the wallet (e.g. by clicking a button). Additionally, 
the user should be able to modify the date of the wallet, for example the owner of wallet.    

#### Part 2
This app was supposed to be about two objects of type Wallet. The left side of the window is already 
about one of the wallets. On the right side we should have the same for another wallet. Make sure you 
have on the right side the same as for myWallet on the left side. 

#### Part3 
Now about the ignored controls on the right side of the screenshot above. Add these controls in the 
middle of Form1 between the panels for the two wallets. In the textbox, the user can specify how much 
money should be transferred from one wallet to another wallet. 
Clicking the button with text “>>” should transfer the specified amount of money from myWallet to 
anotherWallet, if allowed. 
The transfer of money is allowed if: 
* The amount of money to transfer is not negative, and 
* There is enough money in the wallet (so amount of money to transfer <= amount of money in the 
wallet it comes from). 

Clicking the button with text “<<” should transfer the specified amount of money from anotherWallet to 
myWallet, if allowed. 
