namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            for (int j = 50; j <70; j++)
                 
            {
                int result = 1;
                for(int i = 2; i <=j;i++)
                {
                    while (i % 2 == 0)
                    {
                        result = i / 2;
                        Console.WriteLine(result);


                       if (i % 2 == 1)
                        {
                            result = ((i * 3) + 1) / 2;
                            Console.WriteLine(result);
                        }
                    }
                        break;
                   
                }
               


            }
        }
    }
}