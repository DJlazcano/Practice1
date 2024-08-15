﻿
namespace Practice1
{
    class MultiProgram : BMICalculator
    {
        public static void Main(string[] args)
        {
            var option = -1;
            do
            {
                Console.WriteLine("Please choose an option: ");
                Console.WriteLine("(1) BMI Calculator");
                Console.WriteLine("(2) Book Class");
                Console.WriteLine("(3) ATM Machine");
                Console.WriteLine("(4) Exit");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        bmiCalculator();

                        break;
                    case 2:
                        List<Book> books = new List<Book>();

                        Book book1 = new Book("Moby-Dick", "Herman Melville", "123987");
                        Book book2 = new Book("The Lord of the Rings", "John Ronald", "569032");
                        Book book3 = new Book("The Lord of the Rings", "Jhonny Wonka", "569032");

                        book1.bookDetails();

                        books.Add(book1);
                        books.Add(book2);
                        books.Add(book3);
                        Console.WriteLine("List of books:");
                        books.ForEach(p => p.bookDetails());

                        Console.WriteLine("After Removing 1 element:");
                        books.RemoveAt(0);
                        books.ForEach(p => p.bookDetails());

                        Console.WriteLine("\nSingle book from list:");
                        Console.WriteLine(books[1]);

                        Console.WriteLine("\nCompare two books by ISBN: ");
                        Console.WriteLine("Book1 isbn({0}) equals book2 isbn({1})?: {2}\n", books[0].getIsbn(),
                            books[1].getIsbn(),
                            books[0].Equals(books[1]));

                        break;
                    case 3:
                        AtmMachine machine = new AtmMachine();
                        var bankOperation = -1;
                        do
                        {
                            Console.WriteLine("Please choose an operation: ");
                            Console.WriteLine("(1) Check Balance");
                            Console.WriteLine("(2) Deposit Money");
                            Console.WriteLine("(3) Withdraw Money");
                            Console.WriteLine("(4) Exit");
                            bankOperation = int.Parse(Console.ReadLine());

                            switch (bankOperation)
                            {
                                case 1:
                                    machine.checkBalance();
                                    break;
                                case 2:
                                    Console.WriteLine("Please enter the amount to Deposit: ");
                                    var depositAmount = double.Parse(Console.ReadLine());
                                    machine.depositMoney(depositAmount);

                                    break;
                                case 3:
                                    Console.WriteLine("Please enter the amount to Deposit: ");
                                    var withdrawAmount = double.Parse(Console.ReadLine());
                                    machine.withdrawMoney(withdrawAmount);

                                    break;
                                default:
                                    break;
                            } 
                        } while (bankOperation!=4);

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:

                        break;
                    case 7:

                        break;
                    default:
                        break;
                } 
            } while (option != 4);
        }
    }
}

