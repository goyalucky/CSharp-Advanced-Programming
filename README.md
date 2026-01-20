# csharp-advance-programming
This repository contains advanced C# practice programs focused on **Lambda expressions, LINQ, Regular Expressions, Exception handling (including custom exceptions), and unit testing with NUnit**, helping build clean, efficient, and reliable applications through hands-on problem solving.

---

## 🛠 Tech Stack
- **Language:** C#
- **Framework:** .NET
- **Tools:** Visual Studio Code
- **Version Control:** Git & GitHub

---

## ✨ Features
- Structured **branch-wise learning approach** for advanced C# topics  
- Hands-on practice with **Lambda expressions, LINQ, Regex, Exceptions, and NUnit**
- Strong focus on **clean code, reusability, and performance**
- Real-world oriented **problem statements and use cases**
- Emphasis on **functional programming concepts and error handling**
- Designed to improve **code quality, testing, and debugging skills**

---

## 📂 Branch Structure

### 🔹 `lambda-LINQ` branch
This branch focuses on **Lambda Expressions and LINQ in C#**, emphasizing how functional-style programming simplifies data filtering, sorting, grouping, and aggregation.  
The problems are designed to strengthen understanding of **lambda syntax**, **LINQ query methods**, and **custom sorting logic**, including cases **with and without LINQ**.

---

### 📝 Practice Problems

- **Employee Filtering Using Lambda**
  
  Filter a collection of employees using a lambda expression to find those who:
  - Joined in the last six months
  - Belong to a specific department

- **Sort Strings by Length Using LINQ + Lambda**
  
  Use a lambda expression with LINQ’s `OrderBy()` method to sort a list of strings by their length in ascending order and print the result.

- **Group Products by Category Using LINQ**
  
  Group a list of products by category and calculate the **average price** for each category using LINQ grouping and aggregation.

- **Sort Strings by Length Using Lambda (Without LINQ)**
  
  Sort a `List<string>` by string length using a lambda expression with the `Sort()` method (no LINQ allowed).

- **Student Sorting Without LINQ**
  
  Create a `Student` class with:
  - RollNo  
  - Name  
  - Marks  

  **Tasks:**
  - Store students in a `List<Student>`
  - Sort students:
    - By **Marks (descending)**
    - If marks are equal, by **Name (ascending)**
  - Print the sorted list  
  - Use **`IComparer<Student>` or a lambda expression** (LINQ not allowed)

---

### 🎯 Learning Outcomes
- Master **lambda expressions** in real scenarios
- Apply **LINQ for filtering, sorting, grouping, and aggregation**
- Understand **custom sorting using lambda and IComparer**
- Learn when and how to **avoid LINQ** and rely on core collection methods
- Improve **functional and declarative programming skills in C#**

---

### 🔹 `regex` branch
This branch focuses on **Regular Expressions (Regex) in C#**, combined with **OOP concepts and Custom Exception handling**.  
The problems cover **validation**, **data extraction**, and **real-world input handling** scenarios without relying on LINQ where specified.

---

### 📝 Practice Problems

- User Registration System  
  Create a user registration system using OOP, Regex, and custom exceptions. Validate phone number, email, and password using regular expressions. Throw a custom exception if validation fails and store only valid users.

- Valid Phone and Email Extraction  
  Given a list of strings containing mixed content, extract all valid email addresses and valid Indian phone numbers using Regex. Store them in separate lists and display the results. Do not use LINQ.

- Username Validation  
  Validate a username using Regex with rules such as starting with a letter, allowing only letters, digits, and underscores, and enforcing a specific length range.

- License Plate Number Validation  
  Validate a license plate number using Regex where the format consists of uppercase letters followed by digits.

- Hex Color Code Validation  
  Validate hexadecimal color codes using Regex based on standard hex color rules.

- Extract Email Addresses from Text  
  Extract all valid email addresses from a given block of text using Regex.

- Extract Capitalized Words  
  Extract all words that start with an uppercase letter from a given sentence using Regex.

- Credit Card Number Validation  
  Validate credit card numbers using Regex by identifying supported card formats based on starting digits and length.

- Extract Programming Language Names  
  Extract programming language names from a given text using Regex.

- Extract Currency Values  
  Extract currency values from text using Regex.

- Social Security Number (SSN) Validation  
  Validate a Social Security Number using Regex based on its standard format.

---

### 🎯 Learning Outcomes
- Master **Regex pattern writing and matching**
- Perform **input validation** using Regex
- Combine **OOP, Regex, and Custom Exceptions**
- Extract structured data from unstructured text
- Build **robust and secure input-handling logic** in C#

---

## 👤 Author
**Lucky Goyal**  
B.Tech CSE (Artificial Intelligence and Machine Learning)  