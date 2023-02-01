
//Console.WriteLine("Hello, World!");

using System.Threading;


//Konsolda 10 sualdan ibaret imtahan yazmaginiz teleb olunur. 
//1.  Proqramda statik olaraq 10 sual ve her sualin 3 cavabi olacaq. 
//2.  Her defe proqrami basladan zaman variantlarda olan cavablar random deyismelidir. Meselen:
//	Proqrami 1-ci defe isedusen zaman sualin cavabi 
//	a) Baki
//    b) Gence
//    c) Naxcivan
//    Proqrami 2-ci defe isedusen zaman sualin cavabi
//	a) Gence
//    b) Naxcivan
//    c) Baki
//    Proqram bu qaydada her defe cavablari qarisdirmalidir.
//3.  Butun suallar ilk defeden acilmir bir suala cavab verennen sonra o biri sual acilir.
//4.  Istifadeci suala cavab vermek ucun sadece varianti secmelidir(Sualin cavabini konsolda yazmamalidir).
//5.Duzgun cavab verilende hemen sual yasil rengde olsun, sehv cavabda qirmizi rengde.
//6.  Her duzgun suala gore user 10 xal qazanir her verdiyi cavaba gore 10 xal cixilir. Xal eger menfi olursa o zaman 0 xal gostersin yeni menfi xal olmasin. Proqramin sonunda yazilsin ki, imtahan bitmisdir siz filan qeder xal toplamisiniz. 
//7.  Proqrami yazmaq ucun siz sadece funksiya, ve arraydan istifade elemelisiniz.
// List ve ozunuzden class yaradib istifade elemek olmaz.
//Note: 
//	Random reqem istifade elemek ucun:
//	Random rand = new Random();
//int number = rand.Next(0, 99); // hansi araliqda random reqem vermesinizi istiyirsinize 0 99 u istediyiniz araliqla deyisin.
//Konsoldaki yazilarin rengini nece deyiseceyinizi bu linkden baxib oyrene bilersiniz:


//Ugurlar.

using System.Reflection.Emit;

int xal = 0;

string[] question = {"1.Azerbaycanin paytaxti haradir ?",

"2.Formula 1 tarixinde en cox qalib olmush pilot kimdir ?",

"3.Yer kuresinde en cox ehalisi olan olke hansidir ?",

"4.Shahmat harada ixtira olunub ?",

"5.Xirosima ve Naqasakiye nechenci ilde atom bombasi atilmishdir ?",

"6.Chelsea futbol klubu nechenci ilde yaranib ?",

"7.2010-cu ilde chekilmish 'Inception' filminde bash rolda kim idi ?",

"8. 2011 - 2012-ci ilde futbol uzre chempionlar liqasinin qalibi hansi komanda olub ?",

"9.Normandiya emeliyyati ne zaman olmushdur ?",

"10.Sud yolu galaktikasina en yaxin galaktika hansidir ?"

};





string[][] answers = new string[10][];

answers[0] = new string[3] { " Baki", " Sheki", " Quba" };
answers[1] = new string[3] { " Alain Prost", " Michael Schumacher", " Lewis Hamilton" };
answers[2] = new string[3] { " Rusiya", " Azerbaycan", " Chin" };
answers[3] = new string[3] { " Assuriya", " Mesopotamiya", " Hindistan" };
answers[4] = new string[3] { " 1945", " 1944", " 1946" };
answers[5] = new string[3] { " 1905", " 1907", " 1903" };
answers[6] = new string[3] { " Leonardo DiCaprio", " Vin Diesel", " Robert de Niro" };
answers[7] = new string[3] { " Bayern Munich", " Chelsea", " Real Madrid" };
answers[8] = new string[3] { " 5 avgust 1944", " 12 mart 1941", " 6 iyun 1944" };
answers[9] = new string[3] { " Saggittarrius A", " Abell 1835", " Andromeda" };



string[] correctAnswers =
{
    " Baki"," Michael Schumacher"," Chin"," Hindistan"," 1945"," 1905"," Leonardo DiCaprio"," Chelsea", " 6 iyun 1944", " Andromeda"
};


Random r = new Random();


void deleterand( ref string[] arr, int index)
{

    string[] temp = new string[arr.Length - 1];
    
    for (int i = 0; i < index; i++)
    {
        temp[i] = arr[i];
    }

    for (int i = index; i < arr.Length-1; i++)
    {
        temp[i] = arr[i+1];
    }
 
    arr = temp;
}



void correct(int i)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Correct Answer!!!");
    Thread.Sleep(1500);
    Console.ForegroundColor = ConsoleColor.White;

    xal+= 10;
    if(i == 9)
    {
        Console.WriteLine("Oyun bitti");
        Console.WriteLine($"Sizin Xaliniz {xal}");
        Thread.Sleep(1500);
    }
   
}


void False(int i)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("False Answer!!!");
    Thread.Sleep(1500);
    Console.ForegroundColor = ConsoleColor.White;

    if (xal >= 10)
    {
        xal-= 10;
    }
    
    if (i == 9)
    {
        Console.WriteLine("Oyun bitti");
        Console.WriteLine($"Sizin Xaliniz {xal}");
        Thread.Sleep(1500);
    }
  
}

for (int i = 0; i < answers.Length; i++)
{


    Console.Clear();
   
    Console.WriteLine(question[i]);
    int number = r.Next(0, answers[i].Length - 1);


    string t1 = answers[i][number];
    Console.WriteLine($"A.{t1}");
    deleterand(ref  answers[i], number);

    number = r.Next(0, answers[i].Length - 1);
   string t2 = answers[i][number];
    Console.WriteLine($"B.{t2}");
    deleterand( ref answers[i], number);

    number = r.Next(0, answers[i].Length - 1);
  string  t3 = answers[i][number];
    Console.WriteLine($"C.{t3}");
    deleterand(ref answers[i], number);
Label:
string ch = Console.ReadLine();

    if(ch == "A" || ch == "a")
    {
            if (correctAnswers[i] == t1)
                correct(i);
            else False(i);
    }
    else if(ch == "B" || ch == "b" )
    {
            if (correctAnswers[i] == t2)
                correct(i);
            else False(i); 
    }

    else if (ch == "C" || ch == "c")
    {
            if (correctAnswers[i] == t3)
                correct(i);
            else
                False(i);
    }

        else
        {
            Console.WriteLine("Bele variant yoxdur");
            Thread.Sleep(1500);
            goto Label;
        }
       



}






