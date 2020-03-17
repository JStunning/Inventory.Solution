# Inventory

#### _Track Inventory, 3/17/2020_

#### By _**Jack Dunning**_

## Description

_This is an app that can add a Collection to the Collection list and add a Item to that specific Collection. It can hold atleast one Collection and take multiple Items, hopefully._

## Setup/Installation Requirements

* _Download .NET from here: https://dotnet.microsoft.com/download/dotnet-core/current_
* _Download .NET script in the Terminal with this command { dotnet tool install -g dotnet-script }_
* _Git clone Or download the zip file from gihub { https://github.com/JackStunning/VendorTracker.Solution }_
* _In the Terminal run this command { dotnet build }_
* _In the Terminal run this command { dotnet run }_

## Specs

  * _Spec:_ When user opens localhost:5000.
      * _Input:_ user opens web app
      * _Output:_ homepage should open "Welcome to a Stunning Vendor Tracker web app!" and also give you some options "View Vendors" and "Add a new Vendor"

  * _Spec:_ if user clicks "Add new Vendor".
      * _Input:_ clicks "Add new Vendor"
      * _Output:_ should route user to Vendor form

  * _Spec:_ if user enters a vendor name and clicks the add button.
      * _Input:_ user enters "Bob's Burgers" and clicks add
      * _Output:_ should route user to Vendor List with the vendor added

  * _Spec:_ if user clicks a vendor name it should show an empty orders list, a Order Total of $0 a link to add a new order and a button clear all orders.
      * _Input:_ user clicks "Bob's Burgers"
      * _Output:_ should route user to a empty Vendor Orders List, a Order Total of $0 a link to add a new order and a button clear all orders

  * _Spec:_ if user clicks "Add a new Order"
      * _Input:_ user clicks "Add a new Order"
      * _Output:_ should route user to a heading "Add Order to Bob's Burgers", empty form with "Order title", "Order Description", "Order Date" and "Add" button 

  * _Spec:_ if user clicks "Add" with the form complete
      * _Input:_ user clicks "Add" "Order title: Buns" "Order Description: I want to purchase some buns, thanks." "Order Date: 3/13/20"
      * _Output:_ should route user back to the orders list with Buns now added and the Orders Total Updated to "Orders Total: $5"

  * _Spec:_ if user clicks "Buns" in the Vendors Orders List
      * _Input:_ user clicks "Buns" 
      * _Output:_ should route user to page that has Vendor name, Order name, Order description, Order date, the price and links back to Order list and Vendor list

## Known Bugs

_No known bugs_

## Support and contact details

_Email: JackStunning9001@gmail.com_

## Technologies Used

_C#, .NET, MSTest, Html, Bootstrap_

### License

*Copyright (c)

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN*

Copyright (c) 2020 **_Jack Dunning_**
