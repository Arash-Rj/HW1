////----------1------------
//Console.Write("Enter a sentence: ");
//string S = Console.ReadLine();
//string[] se = S.Split(" ");
//for (int i = 0; i < se.Length; i++)
//{
//    string A = se[i]; 
//     string B = A.Substring(0,1);
//    string C = B.ToUpper();
//    string D = A.Replace(A[0], C[0]);
//    Console.Write(D);
//}

////------------2---------
//Console.Write("Enter a number: ");
//int num = Convert.ToInt32(Console.ReadLine());
//for (int i = 0;i < num; i+=2)
//{
//    Console.Write(i + " ");
//}
////-----------3----------
//Console.Write("Enter a positive number: ");
//string N = (Console.ReadLine());
//for (int i = 1; i <= N.Length ; i++)
//{
//    Console.Write(N[(N.Length)-i]);
//}
//-----------4----------
/*int[] Numbers = new int[100];
bool zero=false;
int sum = 0;
int count = 0;
int p = 0;
while(!zero)
{
    Console.Write("Please enter a number: ");
    int Number = Convert.ToInt32(Console.ReadLine());
    if (Number != 0)
    {
       
        sum += Number;
        count++;
        Numbers[p] = Number;
        p++;
    }
    else
    {
        zero = true;
    }
}
Console.WriteLine(sum/count);
for(int count2=0; count2<count;count2++)
{
    Console.Write(" "+ Numbers[count2]);
}*/
//-----------5--------
Console.Write("Pick a number uo to 10: ");
int[] m = new int[10];   
int Num = Convert.ToInt32(Console.ReadLine());   
if (Num < 10 )
for(int i = 1; i < 11; i++)
    {
      
        //m[i-1] =i*Num ;
    Console.WriteLine($" {i} * {Num}= {i*Num} ");
}
//foreach (int numb in m)
//{
//    Console.WriteLine(numb);
//}