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
                double sum = 0;
                double bytime = 0;
                 Console.WriteLine("Vuvedi parite, koito poluchavash");
                double money = double.Parse(Console.ReadLine());
                sum = 18 * money;
                bytime = age * money;
                 Console.WriteLine($"The total money at the time is:  {bytime}");
                  Console.WriteLine($"The total money by 18 is:  {sum}");

                    break;
    
    
            }


}
