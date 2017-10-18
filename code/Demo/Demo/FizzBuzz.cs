namespace Demo
{
    public class FizzBuzz
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public string Parse(int i)
        {
            //var unused = 1;

            if (i % 3 == 0 && i % 5 == 0)
            {
                return "FizzBuzz";
            }

            if (i % 3 == 0)
            {
                return "Fizz";
            }

            if (i % 5 == 0)
            {
                return "Buzz";
            }

            return i.ToString();
        }
    }
}