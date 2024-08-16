
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
                Console.WriteLine("(4) Student AVG Calculator");
                Console.WriteLine("(5) Dates Calculator");
                Console.WriteLine("(6) Text Calculator");
                Console.WriteLine("(7) File Names Sorter");
                Console.WriteLine("(8) Exit");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        bmiCalculator();

                        break;
                    case 2:
                        bookObject();

                        break;
                    case 3:
                        atmMachine();

                        break;
                    case 4:
                        studentAVGCalc();

                        break;
                    case 5:
                        compareDates();

                        break;
                    case 6:
                        countTextFields();
                        break;
                    case 7:
                        fileSorter.sortFile();

                        break;
                    default:
                        break;
                } 
            } while (option != 8);

            static void compareDates()
            {
                Console.WriteLine("Enter the First Date (MM/DD/YYYY): ");
                DateTime date1 = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Second Date (MM/DD/YYYY): ");
                DateTime date2 = DateTime.Parse(Console.ReadLine());

                var differenceDays = (date1 - date2).TotalDays;
                Console.WriteLine("There are {0} days between ({1}) and ({2})\n",
                    differenceDays < 0 ? differenceDays * -1 : differenceDays,
                    date1.ToString("dd/MM/yyyy"), date2.ToString("dd/MM/yyyy"));
            }

            static void bookObject()
            {
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
            }

            static void atmMachine()
            {
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
                } while (bankOperation != 4);
            }

            static void countTextFields()
            {
                Console.WriteLine("Enter a block of text (Press Enter twice to finish input): ");
                textCounter txtCounter = new textCounter();
                txtCounter.readLines();
                txtCounter.countText();

                Console.WriteLine("Text entered:");
                Console.WriteLine(txtCounter.inputText + "\n");
                Console.WriteLine("Your text contained: {0} Paragraphs, {1} Sentences, {2} Words\n",
                    txtCounter.numParagraphs, txtCounter.numSentences, txtCounter.numWords);
            }
        }

        private static void studentAVGCalc()
        {
            Console.WriteLine("How many students do you have?: ");
            var numStudents = int.Parse(Console.ReadLine());
            StudentGrades grades = new StudentGrades();

            for (int i = 1; i <= numStudents; i++)
            {
                Console.WriteLine("Enter the student's {0} Score:", i);
                float studentScore = float.Parse(Console.ReadLine());
                grades.addGrade(studentScore);
            }

            grades.calculateAvg();
            Console.WriteLine("Student's Grades:");
            grades.displayGrades();
        }
    }
}

