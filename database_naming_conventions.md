# Database Naming Conventions

In order to maintain the clear view of the structure of database, we'll stablish some conventions to keep in mind when write something in database.

## Fields

The fields inside the tables will follow the structure in lowercase. Probably sometimes you'll need to join two words (like a compost word) and in this case, you can use the underscore (_) character to divide the names. Some examples:

name  				(single word)
customer_id 		(two words)
payment_date		(two words)		... and so on.

## Table and View names
This objects always will represented with the Camel Case, followed with the plural in the last word. Examples:

Activities
Customers
CustomerActivities

## Procedures (whether necessary)
We are going to use the Entity Framework and perhaps, some objects will not be necessary in the solution, and one of them is Stored Procedures. Therefore whether necessary, you can follow the pattern, starting with the prefix "PR" and the words in uppercase, like below:

PR_GET_CUSTOMERS
PR_DO_SOME_OPERATION

`IMPORTANT NOTE: for performance reasons, never use the prefix SP_ in the procedures.`