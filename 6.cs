using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Hello World");
    
    
    
            Console.WriteLine("ilk ededi daxil et");
            string input1 = Console.ReadLine();
            var number1 = Convert.ToInt32(input1);

            Console.WriteLine("ikinci ededi daxil et");
            string input2 = Console.ReadLine();
            var number2 = Convert.ToInt32(input2);

            Console.WriteLine("ucuncu ededi daxil et");
            string input3 = Console.ReadLine();
            var number3 = Convert.ToInt32(input3);


            if (number1 > number2 && number1 > number3)
            {
                Console.WriteLine($"En boyuk eded {number1}");
            }

            else if (number2 > number1 && number2 > number3)
            {

                Console.WriteLine($"En boyuk eded {number2}");
            }

            else if (number3 > number2 && number3 > number1)
            {
                Console.WriteLine($"En boyuk eded {number3}");
            }

            else
            {
                Console.WriteLine("boyuk eded yoxdur");
            }
    
    
    
    
    
    
    
  }
}
