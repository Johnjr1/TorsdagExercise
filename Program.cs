using TorsdagExercise;

// Create instances of the Car class and set their properties
Car car1 = new Car();
Car car2 = new Car();


// Set properties for car1
car1.Brand = "Volvo";
car1.Model = "XC90";
car1.Year = 2024;

// Set properties for car2
car2.Brand = "Mercedes";
car2.Model = "C63 AMG";
car2.Year = 2025;

BankAccount money = new BankAccount();
money.Deposit(1000);
money.GetBalance();

money.Withdraw(400);
money.GetBalance();

car1.PrintInfo();
car2.PrintInfo();

