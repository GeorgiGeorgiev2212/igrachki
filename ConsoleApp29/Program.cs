Console.WriteLine("Vuvedete vuzrastta si: ");

for (int age = int.Parse(Console.ReadLine()); age <= 18;)
{
    

        if (age % 2 == 0)
        {

            Console.WriteLine("Tq shte poluchi Igrachka");

                break;
        }
            else
            {

                Console.WriteLine("Tq shte poluchi Pari");
                int sum = 0;
                 Console.WriteLine("Vuvedi parite, koito poluchavash");
                int money = int.Parse(Console.ReadLine());
                sum = age * money;
                 Console.WriteLine($"The total money by the time is:  {sum}");

                    break;
    
    
            }


}
