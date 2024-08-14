
namespace Practice1
{
    class MultiProgram : BMICalculator
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please choose an option: ");
            Console.WriteLine("(1) BMI Calculator");
            var option = int.Parse(Console.ReadLine());

            switch (option){
                case 1:
                    bmiCalculator();

                    break;
                case 2:

                    break; 
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:

                    break;
                default:
                    break;
                }
        }
    }
}

