#region Task_1
//Sade ve murekkeb ededleri tap;
//Console.WriteLine("Mueyyen Etmek Istediyiniz Ededi Daxil Edin:");
//int eded=Convert.ToInt32(Console.ReadLine()); //55 
//int count = 0;
//for (int i = 1; i <= eded; i++)
//{
//    if (eded%i==0)
//    {
//        count++;
//    }
//}
//if (count >2)
//{
//    Console.WriteLine("Eded murekkebdir");
//}
//else
//{
//    Console.WriteLine("Eded sadedir");
//}
#endregion
#region Task_2
//ededin faktorialin tap
//Console.WriteLine("Ededinizi Daxil Edin:");
//int eded=Convert.ToInt32(Console.ReadLine());
//int faktorial = 1;
//for (int i = 1; i <=eded; i++) //5!= 5 4 3 2 1
//{
//    faktorial *= i;
//}
//Console.WriteLine(faktorial);
#endregion
#region Task_3
//arrayin icinde nece 5 var sayi tap
int[] newarray = { 15, 20, 25, 30, 35, 40, 5, 5, 25, 35 };
int count = 0;
for (int i = 0; i < newarray.Length; i++)
{
    if (newarray[i] == 5)
    {
        count++;
    }
}
Console.WriteLine(count);
#endregion

