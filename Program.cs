//5. ZADATAK
////string? input = Console.ReadLine();
////if (!string.IsNullOrEmpty(input))
////{
////    string toPrint = "";
////    for ( int i = input.Length -1; i >= 0; i--)
////    {
////        toPrint += input[i];
////    }
////    Console.WriteLine(toPrint);
////}

//7. ZADATAK
//var input = Console.ReadLine();

//List<char> vowels = new List<char>()
//{
//    'a', 'e', 'i', 'o', 'u',
//    'A','E', 'I', 'O', 'U'
//};

//int count = 0;

//if (!string.IsNullOrEmpty(input))
//{
//    for (int i = 0; i < input.Length; i++)
//    {
//        char c = input[i];
//        if (vowels.Contains(c))
//        {
//            count++;
//        }
//    }
//}
//Console.WriteLine("Input contains " + count + " vowels.");

//4.ZADATAK
//Random random = new Random();
//int genNum = random.Next(0, 101);
//int input;

//while (true)
//{
//    if (int.TryParse(Console.ReadLine(), out input))
//    {
//        if (input < genNum)
//        {
//            Console.WriteLine("Prenisko, pokusajte ponovo.");
//        }
//        else if (input > genNum)
//        {
//            Console.WriteLine("Previsoko, pokusajte ponovo.");
//        }
//        else
//        {
//            Console.WriteLine("Bravo, broj je pogoden!");
//            break;
//        }
//    }
//}

//8. ZADATAK
//string path = @"E:\repos\PredavanjeCetiri\predavanjeCetiri\zadaca.txt";
//if (!File.Exists(path))
//{
//    using (StreamWriter steamwriter = File.CreateText(path))
//    {
//        steamwriter.WriteLine("My .txt file content");
//    }
//}
//using (StreamReader steamreader = File.OpenText(path))
//{
//    string s;
//    while ((s = steamreader.ReadLine()) != null)
//    {
//        Console.WriteLine(s);
//    }
//}
    
