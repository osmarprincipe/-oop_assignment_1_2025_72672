# Rental Car Model (C#)

Object-Oriented Programming assignment 1, BSc in Computing, Dorset College Dublin (2025).

A console application that models a rental car and its rental life cycle, with xUnit tests for every rule.

## What it does

- `RentalCar` holds manufacturer, model, body type, registration number, daily price and borrowed status.
- The constructor validates its input: empty text fields or a price of zero or less throw an `ArgumentException`.
- `Borrow()` only succeeds when the car is available; `ReturnRentalCar()` makes it available again.
- `ChangePrice()` rejects invalid prices; `CheckPrice()` and `CheckBorrowed()` report the current state.
- `DriverRentalCar.Run()` demonstrates the class from the console.

## Project structure

```
oop-assignment-1-2025-72672/   console app (Models/RentalCar.cs, Models/DriverRentalCar.cs)
RentalCarTestUnit/             xUnit tests (RentalCarTests.cs)
```

## Run

Requires the .NET 8 SDK.

```bash
dotnet run --project oop-assignment-1-2025-72672
dotnet test
```

## Tests

12 xUnit tests cover construction, input validation, borrowing an available or already-borrowed car, returning a car and changing the price.
