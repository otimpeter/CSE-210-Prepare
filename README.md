# cse210-ww-student-template
This is the starter code for students in the worldwide content version of CSE 210.

This repository contains the starter code for many different projects. They are arranged as follows:

* `sandbox` - An empty project that you can use to play around with any concepts you like.
* `csharp-prep` - Starter projects for each of the C# Prep assignments.
* `prepare` - Starter projects for each of the preparation Learning Activities.
* `prove` - Starter projects for each of the prove Developer projects.
* `final` - Starter projects for final project.

foundation 4 Abstraction 
In this program, I create a Video class with properties for the video's title, 
author, and length, as well as a list of comments.
 I also create a Comment class with properties for the commenter's name and the comment text.
The Video class has methods to add a comment, get the number of comments, 
and print out all the video information and comments. In the Main method, 
I create three videos and add comments to them, then print out all the video information using a foreach loop.


foundation 4 : Program 4: Polymorphism with Exercise Tracking
Fitness Tracker App
This program allows users to track their exercise activities at a local fitness center. It includes facilities for running, stationary bicycles, and swimming in the lap pool.

Features
Add new exercise activities with date and length in minutes
Track distance, speed, and pace for each activity
Get a summary of all activities with their details
Getting Started
Usage
When the program starts, you will be presented with a menu of options:

Add new running activity
Add new cycling activity
Add new swimming activity
Get summary of all activities
Exit

*Encapsulation with Online Ordering*
This is basic product ordering system for an online store. It uses encapsulation to protect the data and to provide controlled access to it through the public interfaces of various classes.

Classes and Responsibilities 

Order
The Order class represents an order placed by a customer. It contains a list of products and a reference to the customer who placed the order. It has the following responsibilities:

Calculate the total cost of the order (based on the prices of the products and the shipping cost)
Generate a packing label for the order (listing the product names and IDs)
Generate a shipping label for the order (listing the customer's name and address)
Product
The Product class represents a product that can be ordered by a customer. It contains the name, product ID, price, and quantity of the product. It has the following responsibilities:

Calculate the price of the product (based on the price and quantity)
Customer
The Customer class represents a customer who has placed an order. It contains the customer's name and address. It has the following responsibilities:

Check if the customer lives in the USA or not (based on the customer's address)
Address
The Address class represents the address of a customer. It contains the street address, city, state/province, and country. It has the following responsibilities:

Check if the address is in the USA or not
Generate a string representation of the address
Usage
To use this program, you can create an instance of the Order class, and add products and a customer to it. Then you can call the methods to get the packing label, shipping label, and total price of the order.
