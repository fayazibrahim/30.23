using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Hello World");
    
      int[] nums = { 18, 41, 48, 20 };
            array(nums);

        }
        static void array(int[] nums)
        {
            var sum = 0;
            for (int i=0;i<nums.Length;i++)
            {
                sum += nums[i];
            }
            Console.WriteLine(sum);
    
    
    
  }
}
