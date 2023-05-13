## Object-Oriented Programming (OOP)

Object-Oriented Programming (OOP) is a programming paradigm that organizes code and data into objects, allowing developers to model real-world entities and relationships. OOP provides a set of principles and techniques for designing and structuring code in a more modular and reusable manner. Let's explore the key concepts of OOP:

### Terminology Associated with OOP

- **Objects:** Objects are the fundamental building blocks of OOP. They represent individual instances of a class and encapsulate data (properties/attributes) and behavior (methods) related to a specific entity or concept.

- **Properties/Attributes:** Properties or attributes are the characteristics or data associated with an object. They define the state of an object and can be accessed and manipulated through methods.

- **Methods:** Methods define the behavior or actions that an object can perform. They encapsulate the logic and operations that can be executed on an object's data.

- **Classes:** Classes are the blueprint or template for creating objects. They define the structure, behavior, and initial state of objects belonging to that class. Objects are created from classes using the process called instantiation.

- **Inheritance:** Inheritance is a mechanism that allows classes to inherit properties and methods from other classes. It promotes code reuse and enables the creation of a hierarchy of classes, where subclasses inherit characteristics from their parent class or superclass.

- **Polymorphism:** Polymorphism allows objects of different classes to be treated as objects of a common superclass. It enables objects to exhibit different behaviors based on their specific class implementation, providing flexibility and extensibility in the code.

- **Containment (Aggregation):** Containment, also known as aggregation, is a relationship between objects where one object contains or owns another object. It represents a "has-a" relationship, where an object can be composed of other objects as its parts or components.

- **Encapsulation:** Encapsulation is a principle that combines data and methods into a single unit called a class. It hides the internal details of an object and provides a public interface (getters and setters) to access and manipulate the object's state, ensuring data integrity and promoting modular design.

- **Getters and Setters:** Getters and setters are methods used to access (get) and modify (set) the values of an object's properties. They provide controlled access to the object's data, allowing validation and maintaining the object's integrity.

- **Instances:** Instances are objects created from a class using the process of instantiation. Each instance has its own unique state and can independently execute the methods defined in the class.

### Solving Problems with OOP

To solve a problem using OOP, it involves designing appropriate classes that represent the entities, their properties, and behaviors related to the problem domain. Here's a general approach to designing classes in OOP:

1. Identify the main entities or objects relevant to the problem domain.

2. Define the properties (attributes) that describe the state of each object.

3. Identify the behaviors (methods) that objects can perform.

4. Determine the relationships between objects, including inheritance and containment.

5. Implement the classes with appropriate attributes and methods based on the identified requirements.

6. Create instances of the classes to represent individual objects and interact with them through method calls.

By following this approach, you can effectively model and solve problems using OOP concepts.

The concepts of OOP, such as objects, properties/attributes, methods, classes, inheritance, polymorphism, containment, encapsulation, getters, setters, and instances, provide a powerful framework for designing modular, reusable, and maintainable code. Understanding and
applying these concepts can greatly enhance the structure and organization of your code. Let's see an example to demonstrate the use of OOP concepts, including containment:

```python
# Class definition
class Car:
    def __init__(self, make, model, year):
        self.make = make
        self.model = model
        self.year = year

    def get_details(self):
        return f"Make: {self.make}, Model: {self.model}, Year: {self.year}"


class Garage:
    def __init__(self, name):
        self.name = name
        self.cars = []

    def add_car(self, car):
        self.cars.append(car)

    def get_all_car_details(self):
        details = []
        for car in self.cars:
            details.append(car.get_details())
        return details


# Creating instances
car1 = Car("Toyota", "Camry", 2021)
car2 = Car("Honda", "Civic", 2022)

garage = Garage("My Garage")
garage.add_car(car1)
garage.add_car(car2)

# Accessing car details from the garage
car_details = garage.get_all_car_details()
for detail in car_details:
    print(detail)
```

In the above example, we have two classes: `Car` and `Garage`. The `Car` class represents a car object with properties like `make`, `model`, and `year`. It also has a method `get_details()` to retrieve the details of the car.

The `Garage` class represents a garage object that contains multiple cars. It has a property `cars` that is a list to store the cars. It also has methods `add_car()` to add a car to the garage and `get_all_car_details()` to retrieve the details of all the cars in the garage.

We create instances of the `Car` class, representing two cars, and an instance of the `Garage` class called `garage`. We add the cars to the garage using the `add_car()` method.

Then, we retrieve the details of all the cars in the garage using the `get_all_car_details()` method, and iterate over them to print the details.

This example demonstrates containment or aggregation, where the `Garage` object contains or owns multiple `Car` objects. The garage can manage and interact with the cars as its components.

By utilizing OOP concepts like classes, objects, properties, methods, and containment, you can design and implement more organized and modular code that represents real-world scenarios effectively.

Understanding and utilizing OOP concepts empower you to create robust, maintainable, and reusable code, enabling you to solve complex problems with clarity and efficiency.
