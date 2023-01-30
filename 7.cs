using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Hello World");
    
    
    
      Console.WriteLine("Yazi daxil edin");
            string input = Console.ReadLine();

            string reverseInput = "";

            for(int i = input.Length-1; i>=0; i--)
            {
                reverseInput += input[i];
            }


            Console.WriteLine(reverseInput);
  }
}
