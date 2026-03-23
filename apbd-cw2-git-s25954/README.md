Just run the Program.cs.

- Cohesion is achieved in most of the classes of this task. Every class only performs tasks dedicated to it.
EquipmentService is responsible for interaction with all the equipment.
RentalService is responsible for creating/returning and interacting with rentals.
- Coupling is achieved by the use of inheritance in main classes like User, Rental and Equipment.
Every other class (except Program) one way or another is dependent on those 3 classes.
- User - defines users, like Student, Employee inside the system.
- Equipment - describes all rented equipment.
- Rental - implementation of rentals
- EquipmentService and RentalService contain all the business logic and interaction with classes.
- Program - runs and tests the entire system.

Entity defining classes use inheritance in this solution because it helps to easily achieve above-mentioned goals, specifically cohesion and coupling.
Equipment and Rental have their own corresponding Service classes to keep the code more clean and cohesive, as well as to define clear lines and responsibilities between classes.

