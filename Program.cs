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

// Create an instance of the Animal class and set its properties
Animal dog = new Animal();
Animal cat = new Animal();

dog.Type = "Dog";
dog.Sound = "Woof";
cat.Type = "Cat";
cat.Sound = "Meow";


// Create an instance of the Student class and set its inherited properties
Student student1 = new Student();
student1.Name = "John";
student1.Age = 85;
student1.StudentID = "123456";


// Create an instance of the BankAccount class and perform some operations
BankAccount money = new BankAccount();
money.Deposit(1000);
money.GetBalance();

money.Withdraw(400);
money.GetBalance();

car1.PrintInfo();
car2.PrintInfo();

dog.MakeSound();
cat.MakeSound();

student1.PrintStudentInfo();

