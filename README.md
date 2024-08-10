# C# Console Applications
This repository showcases small C# console applications designed for beginners.


## Context
This repository contains a collection of simple yet functional C# console applications. These projects are aimed at helping beginners understand fundamental concepts in C# programming. Each application is self-contained and focuses on a specific task or problem, offering a practical way to apply C# skills. The applications demonstrate basic programming techniques such as string manipulation, LINQ queries, file handling, and mathematical calculations. Users can explore these projects to learn and practice C# in a console environment.


## Table of Contents
- [C# Console Applications](#c-console-applications)
- [Context](#context)
- [City Finder](#prg521_fa2_question1---city-finder)
- [Password Generator](#prg521_fa4_passwordgenerator---password-generator)
- [LINQ Query](#prg521_fa2_question2---linq-query)
- [Rent or Buy a Propery](#prg521---rent-or-buy-a-property)
- [SalesTaxCalculator](#salestaxcalculator)


## PRG521_FA2_Question1 - (City Finder)
### Overview
This program uses LINQ and C# to find strings that start and end with specific characters.

<br> Tasks to complete: 
- Use an array containing 10 South African cities: Butterworth, Mthatha, Jagersfontein, Kroonstad, Boksburg, Soweto, Empangeni, Polokwane, Secunda, Kuruman.
- Display a welcome message to inform users about the application.
- Show all available cities.
- Prompt the user to enter a starting character for a city.
- Prompt the user to enter an ending character for a city.
- Display the output based on the specified starting and ending characters.

### Demonstrating functionality
<img src="assets/images/CF1.png" alt="City Finder image 1">


## PRG521_FA4_PasswordGenerator - (Password Generator)
### Overview
This application generates passwords based on a user's full name. The company that hired you requires the application to:

The password is created using the following rules:  
- Exclude the letters ‘a’, ’e’, and ‘t’ from the password.
- Add each vowel (except ‘a’ and ‘e’) twice.
- Replace spaces with the string 'S&?'.
- Retain all other characters.
- End the password with the total number of excluded letters.

### Demonstrating functionality
<img src="assets/images/PG1.png" alt="Password Generator image 1">


## PRG521_FA2_Question2 - (LINQ Query)
### Overview
This section involves answering questions by writing LINQ queries.

### Demonstrating functionality
Retrieve the names of all students with at least one grade of 90 or higher:

`var studentNames = courses
                .SelectMany(c => c.Students)
                .Where(s => s.Grades.Any(g => g >= 90))
                .Select(s => s.Name);`

<img src="assets/images/LINQ1.png" alt="LINQ query image 1">

<br> Calculate the average grade of all students in each course:

`var courseAvgGrades = courses
                .Select(c => new
                {
                    CourseName = c.Name,
                    AverageGrade = c.Students.Average(s => s.Grades.Average())
                }).ToList();`

<img src="assets/images/LINQ2.png" alt="LINQ query image 2">

<br> Retrieve the names of all courses where every student has at least one grade of 80 or higher:

`var coursesNames = courses
                .Where(c => c.Students.All(s => s.Grades.Any(g => g >= 80)))
                .Select(c => c.Name)
                .ToList();`

<img src="assets/images/LINQ3.png" alt="LINQ query image 3">

<br> Retrieve the name and age of the student with the highest average grade across all courses:

`var topStudent = courses
                .SelectMany(c => c.Students)
                .OrderByDescending(s => s.Grades.Average())
                .First();`

<img src="assets/images/LINQ4.png" alt="LINQ query image 4">


## PRG521 - (Rent or Buy a Property)
### Overview
This application helps a user determine whether they should rent or buy a property. The user inputs their gross monthly income, estimated tax, and monthly expenditures. They can choose to either rent or buy a property:

- **Renting**: Input the monthly rental amount.
- **Buying**: Input the purchase price, deposit, interest rate, and repayment period. The application calculates the monthly home loan repayment and checks if it exceeds one-third of the gross monthly income.

The application includes internationally acceptable coding standards, with detailed comments explaining the code.

### Demonstrating functionality
Prompt user for gross monthly income: <br>
<img src="assets/images/RoB1.png" alt="Rent or Buy image 1">

Prompt user for estimated monthly tax deduction: <br>
<img src="assets/images/RoB2.png" alt="Rent or Buy image 2">

Prompt user for estimated monthly living expenses: <br>
a. <br> <img src="assets/images/RoB3.png" alt="Rent or Buy image 3">

b. <br> <img src="assets/images/RoB4.png" alt="Rent or Buy image 4">

Prompt user to choose between renting or buying: <br>
<img src="assets/images/RoB5.png" alt="Rent or Buy image 5">

Prompt user for monthly rental amount (if renting): <br>
<img src="assets/images/RoB6.png" alt="Rent or Buy image 6">

Prompt user for purchase price (if buying): <br>
<img src="assets/images/RoB7.png" alt="Rent or Buy image 7">

Prompt user for total deposit amount (if buying): <br>
<img src="assets/images/RoB8.png" alt="Rent or Buy image 8">

Prompt user for interest rate (if buying): <br>
<img src="assets/images/RoB9.png" alt="Rent or Buy image 9">

Prompt user for number of months for repayment: <br>
<img src="assets/images/RoB10.png" alt="Rent or Buy image 10">

Calculate available monthly funds (if renting): <br>
<img src="assets/images/RoB11.png" alt="Rent or Buy image 11">

Calculate monthly home loan repayment amount: <br>
<img src="assets/images/RoB12.png" alt="Rent or Buy image 12">

Display alert if home loan repayment > 1/3 of income: <br>
<img src="assets/images/RoB13.png" alt="Rent or Buy image 13">

Calculate available monethly funds (if buying): <br>
<img src="assets/images/RoB14.png" alt="Rent or Buy image 14">

Take Note that validation is also built in the entire application.


## SalesTaxCalculator

### Overview
This Windows application calculates sales tax for a given amount. The user enters an amount and selects a sales tax rate between 0 and 25%. The application then calculates and displays the tax and total amount. It includes exception handling to manage invalid inputs and saves both exception messages and tax calculations to text files.

### Demonstrating functionality
Exception handling should be used to prevent users from entering invalid input (text, character...) (try, catch, and finally)
<br> a. Exception handling for when a user inputs text: 
<br> <img src="assets/images/ST1.png" alt="Sales Tax image 1">

b. Exception handling for when the user inputs a character: 
<br> <img src="assets/images/ST2.png" alt="Sales Tax image 2">

All exception messages should be displayed using a message box and saved in a text file called Exceptionfile.txt
<br> a. Additional error handling for when the user does not input any value: 
<br> <img src="assets/images/ST3.png" alt="Sales Tax image 3">

b. Additional error handling for when the user inputs a negative value: 
<br> <img src="assets/images/ST4.png" alt="Sales Tax image 4">

All results should be saved in a file called TaxCalculation.txt. The result should be saved once the Submit button is pressed
<br> a. First entry: 
<br> <img src="assets/images/ST4.png" alt="Sales Tax image 5">

b. Second entry: 
<br> <img src="assets/images/ST6.png" alt="Sales Tax image 6">

c. Third entry: 
<br> <img src="assets/images/ST7.png" alt="Sales Tax image 7">

Meaning your program will have two separate text files one to record all exceptions thrown – message and the other to record all tax calculations and the date and time the operation occurred
<br> a. ExceptionFile.txt: 
<br> <img src="assets/images/ST8.png" alt="Sales Tax image 8">

b. TaxCalculation.txt: 
<br> <img src="assets/images/ST9.png" alt="Sales Tax image 9">

c. Additionally, the Clear button: 
<br> <img src="assets/images/ST10.png" alt="Sales Tax image 10">

d. The Clear button clears the Amount textbox: 
<br> <img src="assets/images/ST11.png" alt="Sales Tax image 11">
