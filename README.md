# C# Console Applications
This repository showcases small C# console applications for beginners


## Context


## Table of Contents
- [C# Console Applications](#c-console-applications)
- [Context](#context)
- [Rent or Buy a Propery](#prg521---rent-or-buy-a-property)
- [City Finder](#prg521_fa2_question1---city-finder)
- [LINQ Query](#prg521_fa2_question2---linq-query)
- [Password Generator](#prg521_fa4_passwordgenerator---password-generator)
- [SalesTaxCalculator](#salestaxcalculator)


## PRG521 - (Rent or Buy a Property)
### Overview
Rent or Buy Property Application 
 
You requested assistance in using an application to help a family member determine if the amount of money they are paying is sufficient to purchase a house. The family member will use the application to input their gross monthly income (before deductions), estimated monthly tax deducted, and estimated monthly expenditures in various categories. Then they can choose between renting accommodation or buying a property. If they choose to rent, they can input the monthly rental amount. If they choose to buy a property, they must enter the purchase price, total deposit, interest rate, and number of months to repay. The Application will calculate the monthly home loan repayment for buying a property and alert the user if the repayment amount is more than a third of their gross monthly income, indicating that approval of the home loan is unlikely. The Application will also calculate the available monthly money after all specified deductions.  
- The coding standards should be internationally acceptable, and the code should include comprehensive comments explaining variable names, methods, and the logic of programming code.  
- Submit source code and a readme file with instructions for compiling and running the software:

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



## PRG521_FA2_Question1 - (City Finder)
### Overview
Write a program in LINQ and C# Sharp to find the string which starts and ends with a specific character. 
<br> Tasks to complete: 
- You are to use an array that will contain 10 South African cities – You are required to use cities provided below: 
Test data: Butterworth, Mthatha, Jagersfontein, Kroonstad, Boksburg, Soweto, Empangeni, Polokwane, Secunda, Kuruman. 
- Have a welcome message to your users that will help them know your application 
- Display all cities available 
- Prompt the user to enter a starting character for a city 
- Prompt the user to enter an ending string character for a city 
- Your output should be based on the starting and ending string character

### Demonstrating functionality
<img src="assets/images/CF1.png" alt="City Finder image 1">



## PRG521_FA2_Question2 - (LINQ Query)
### Overview
You have been provided with lines of codes. Answer the questions based on the line of codes. You are required to recreate it and add your line of code based on the questions below:

### Demonstrating functionality
Write a LINQ query that retrieves the names of all the students who have at least one grade greater than or equal to 90:

`var studentNames = courses
                .SelectMany(c => c.Students)
                .Where(s => s.Grades.Any(g => g >= 90))
                .Select(s => s.Name);`

<img src="assets/images/LINQ1.png" alt="LINQ query image 1">

<br> Write a LINQ query that calculates the average grade of all the students in each course and returns a list of anonymous objects with the course name and the average grade:

`var courseAvgGrades = courses
                .Select(c => new
                {
                    CourseName = c.Name,
                    AverageGrade = c.Students.Average(s => s.Grades.Average())
                }).ToList();`

<img src="assets/images/LINQ2.png" alt="LINQ query image 2">

<br> Write a LINQ query that retrieves the names of all the courses where all the students have at least one grade greater than or equal to 80:

`var coursesNames = courses
                .Where(c => c.Students.All(s => s.Grades.Any(g => g >= 80)))
                .Select(c => c.Name)
                .ToList();`

<img src="assets/images/LINQ3.png" alt="LINQ query image 3">

<br> Write a LINQ query that retrieves the name and age of the student with the highest average grade across all the courses:

`var topStudent = courses
                .SelectMany(c => c.Students)
                .OrderByDescending(s => s.Grades.Average())
                .First();`

<img src="assets/images/LINQ4.png" alt="LINQ query image 4">



## PRG521_FA4_PasswordGenerator - (Password Generator)
### Overview
A company has hired you to develop an application to generate passwords for their employees’ accounts. The application prompts the user to provide one single line of text with an employee’s full name in the following format “forename surname” at a time. (Please note that you are not required to validate the input, we assume that the input is well-formed.) Next, the application uses the given full name to create the corresponding item.  Note that the application should work irrespective of how the user provides the full name i.e. using upper-case letters, lower-case letters, or a combination of both upper-case and lower-case letters. You should use the full name as provided i.e. you should not modify the given full name to a different letter case. 


The password is created using the following rules:  
- The letters ‘a’, ’e’, and ‘t’ from the given full name will not be used in the password  
- Each vowel (except ‘a’ and ‘e’ which are eliminated) is going to be added twice  
- Each space is replaced by the letter ‘S’ followed by a ‘&’ and a ‘?’  
- All the other characters will remain the same as in the given full name  
- The password ends with the total number of letters eliminated (i.e. the total number of letters ‘a’, ’e’, and ‘t’ from the given full name that were not used in the password)  

### Demonstrating functionality
<img src="assets/images/PG1.png" alt="Password Generator image 1">



## SalesTaxCalculator

### Overview
Create a Windows application that calculates sales tax for a given amount. The user can enter an amount in a text box and then can enter a sales tax between 0 and 25%, in increments of 1%. When the user clicks the Submit button, the tax is calculated, and both the tax and the total are output in a label. The application should look something like the Figure below when it runs. Display your Amounts in Rands. The amount is entered in a Textbox control, but for the tax, you want to restrict the values the user can enter, so you should use a numericUpDown control. There’s a Clear button that clears the “Amount” TextBox when clicked. Implement some exception handling to ensure that the user enters a number in the TextBox. You should include the following in your program  

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
