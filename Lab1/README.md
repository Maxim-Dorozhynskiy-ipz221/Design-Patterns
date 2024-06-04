##*Inventory Management System - Programming Principles Demonstration*
This repository contains an implementation of an inventory management system that demonstrates the application of various programming principles. The code adheres to best practices and showcases the practical implementation of these principles to enhance code quality, maintainability, and extensibility.

*###1. Don't Repeat Yourself (DRY)*

The DRY principle emphasizes minimizing code duplication by avoiding redundant logic and data. This is evident in the code:

Consistent naming conventions: Variable and function names are consistent throughout the code, improving readability and reducing confusion. (See Program.cs, Product.cs, etc.)

Separation of concerns: Each class has a well-defined responsibility, reducing duplication and promoting modularity. (e.g., Product for product data, Warehouse for product management)

Reuse of functions: Functions like SaveProductsToFile and LoadProductsFromFile are reused for different product saving and loading scenarios. (Warehouse.cs, Program.cs)

*Example:*
Consistent naming: The [Product class](https://github.com/Maxim-Dorozhynskiy-ipz221/Design-Patterns/blob/main/Lab1/Product.cs) consistently uses id, name, and unitPrice for its properties.

*###2. Keep It Simple, Stupid (KISS)*

The KISS principle advocates for simplicity and avoiding unnecessary complexity. The code adheres to KISS in several aspects:

Straightforward design: The class structure and code flow are easy to follow, making it understandable for developers of varying experience levels.

Minimalistic implementation: The code avoids unnecessary complexity and focuses on the core functionality of the inventory management system.

Understandable comments: Comments throughout the code clarify the purpose of sections and functions, enhancing readability.

*Example:*

Straightforward design: The [Warehouse class](https://github.com/Maxim-Dorozhynskiy-ipz221/Design-Patterns/blob/main/Lab1/Warehouse.cs) has a clear responsibility: managing a collection of products.
###3. SOLID Principles

SOLID is an acronym for five software design principles that promote code maintainability and extensibility:

*###3.1 Single Responsibility Principle (SRP)*

Each class should have a single reason to change. Your code adheres to SRP by having well-defined classes with specific responsibilities (e.g., Product for product data, Warehouse for product management).

*Example:*

SRP in Product class: The [Product class](https://github.com/Maxim-Dorozhynskiy-ipz221/Design-Patterns/blob/main/Lab1/Product.cs) solely focuses on representing product data and its properties. 

*###3.2 Open/Closed Principle (OCP)*

Classes should be open for extension but closed for modification. Your code demonstrates OCP by using interfaces (IProduct, IWarehouse, IReporting) to define contracts that can be extended with new implementations without modifying existing classes.

*Example:*

OCP with interfaces: The [IProduct interface](https://github.com/Maxim-Dorozhynskiy-ipz221/Design-Patterns/blob/main/Lab1/Interfaces/IProduct.cs) allows for new product implementations without modifying existing classes. 

*###3.3 Liskov Substitution Principle (LSP)*

Subtypes should be substitutable for their base types. Your code seems to follow LSP, as the classes (e.g., Product) appear to behave consistently with their parent interfaces (IProduct).

*Example:*

LSP in Product class: The [Product class](https://github.com/Maxim-Dorozhynskiy-ipz221/Design-Patterns/blob/main/Lab1/Product.cs) adheres to the IProduct interface's methods and properties. 

*###3.4 Interface Segregation Principle (ISP)*

Many client-specific interfaces are better than one general interface. Your code implements ISP by defining separate interfaces (IProduct, IWarehouse, IReporting) for specific functionalities, reducing coupling and promoting better client-specific implementations.

*Example:*

ISP with interfaces: The [IWarehouse interface](https://github.com/Maxim-Dorozhynskiy-ipz221/Design-Patterns/blob/main/Lab1/Interfaces/IWarehouse.cs) provides specific methods for warehouse management.

*###3.5 Dependency Inversion Principle (DIP)*

Depend on abstractions, not on concretions. Your code follows DIP by using interfaces (IProduct, IWarehouse, IReporting) to define dependencies rather than concrete classes. (See Program.cs, Reporting.cs, etc.)

*Example:*

DIP with interfaces: The [Reporting class](https://github.com/Maxim-Dorozhynskiy-ipz221/Design-Patterns/blob/main/Lab1/Reporting.cs) depends on the IProduct interface, allowing different product implementations to be used. 
Additional Considerations

*Code Readability*: The code employs meaningful variable names, proper indentation, and comments to enhance readability and maintainability.

*Error Handling*: Basic error handling is implemented to detect and report errors during program execution.

###*Conclusion*

This inventory management system demonstrates the application of various programming principles to achieve code quality, maintainability, and extensibility. By adhering to these principles, the code becomes easier to understand, modify, and extend, making it a more robust and sustainable software solution.
