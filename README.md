# aquesst-com
Two simple task

## Question 1
Write a function that given two positive integer value parameters will print out all even numbers between 2 and the highest parameter value (inclusive) which is evenly divisible by the lowest parameter value.

Examples:

- Given 17 and 4, the output will be 4, 8, 12, 16
- Given 21 and 7, the output will be 14
- Given 5 and 20, the output will be 10, 20
- Given 3 and 10, the output will be 6
- Given 2 and 2, the output will be 2

## Question 2
Write an OO class system to accommodate the following requirements. You do not need to provide an algorithm which consumes it, only the class(es) themselves. The solution does not need to be perfect, you can supplement some logic with comments as needed.

Suppose there are 3 types of vehicles: cars, motorcycles, and buses. Each type of vehicle has the following public properties:

- Make and model
- Number of wheels
- Length
- Weight
- Max number of passengers

Additionally, there are 2 places a vehicle can park: parking lot and a parking garage. Both lots and garages have a set number of spaces for each location, but each type differs in the following ways:

Lots can accommodate any type of vehicle; however, garages can only accommodate cars and motorcycles.
Garages (only) have “compact only” spaces in addition to normal spaces where only vehicles weighing less than 1,500 can park. When possible, compact spaces should be utilized before a normal space.


## Answer Quesion #1

Everything is simple here. Implementation could be found in class
```
Tasks.Question1.Implementation
```


## Answer Quesion #2

Not so simple and require additional architectural desisions about 
- how to store and retrieve data in the future.
- how easily add additional vehicle types / parking types / parking logic

All related classes and interfaces could be found in namespace
```
Tasks.Question2
```

**ParkingService** will inject parking strategies implementations.
System could be easily extended with new vehicle types (derived from **IVehicle**), 
parking types (derived from **IParkingPlace**) 
and parking rules (derived from **ICheckInOutStrategy**).