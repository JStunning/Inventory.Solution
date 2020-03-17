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
      * _Output:_ homepage should open "Welcome to the Inventory Sheet!" and also give you a link "See Inventory"

  * _Spec:_ if user clicks "See inventory".
      * _Input:_ clicks "See inventory"
      * _Output:_ should route user to empty inventory list

  * _Spec:_ if user is on empty list page and clicks "Add new collection" link
      * _Input:_ user clicks add
      * _Output:_ should route user to "Add a new Collection" page with a small form

  * _Spec:_ if user is on "Add a new Collection" page and fills out form name and description and clicks "Add new Collection"
      * _Input:_ user fills out form and click "Add new Collection" button
      * _Output:_ should route user to a Inventory list with their collection now there

  * _Spec:_ if user clicks a collection name in the inventory list
      * _Input:_ user clicks "{Collection Name}"
      * _Output:_ should route user to "Collection Details" page with the Name and Description in which they have entered. Also has link back to Collection List and has a "Delete Collection" link

  * _Spec:_ if user clicks "Delete Collection"
      * _Input:_ user clicks "Delete Collection"
      * _Output:_ should route user to "Delete?" page, it shows the name of the collection, a delete button and a "Back to List" link

  * _Spec:_ if user clicks "Delete" button on "Delete?" page
      * _Input:_ user clicks "Delete" 
      * _Output:_ should route user back to the "Inventory" page with the collection now removed

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
