
int games;

Console.WriteLine("Hangi oyunu oynamak istersiniz?\nRastgele sayı bulma:1\nHesap Makinesi:2\nOrtalama Hesaplama:3");
games=Convert.ToInt32(Console.ReadLine());
int fiveGuesses = 5;

while ((games != 1) && (games != 2) && (games != 3)) //girilen değerin tanımlı olan oyunlara eşit olup olmadığını kontrol edildi

    {
    Console.WriteLine("Yanlış Değer Girdiniz");
    Console.WriteLine("Hangi oyunu oynamak istersiniz?\nRastgele sayı bulma:1\nHesap Makinesi:2\nOrtalama Hesaplama:3");
        games = Convert.ToInt32(Console.ReadLine());
    }
switch (games) // oyunlar arasında seçmek için bu yapıyı kullanıldı
{

    case 1:
        Console.WriteLine("Rastgele Sayı Bulma Oyununa Hoşgeldiniz!");
        Random random = new Random();
        int rnd=random.Next(1,100); // 1-100 arasında random sayı üretildi
        while (fiveGuesses > 0)
        {
            Console.WriteLine("Tahmininizi yazınız");
            int guessNumber = Convert.ToInt32(Console.ReadLine()); // Konsoldan girilen değer string olduğu için integera convert edildi
            if ((guessNumber < rnd))
            {
                Console.WriteLine($"Rastgele sayı {guessNumber}'dan büyüktür tekrar tahmin giriniz");
                fiveGuesses--; //Tahmin hakkını azaltmak için
                Console.WriteLine($"Kalan tahmin hakkınız: {fiveGuesses}");

            }
            else if (guessNumber > rnd)
            {
                Console.WriteLine($"Rastgele sayı {guessNumber}'dan küçüktür tekrar tahmin giriniz");
                fiveGuesses--; //Tahmin hakkını azaltmak için
                Console.WriteLine($"Kalan tahmin hakkınız: {fiveGuesses}");

            }
            else
            {
                Console.WriteLine("Tebrikler doğru tahmin! ");
                fiveGuesses = 0; // Doğru tahmin edildiği için tekrar döngüye sokmamak için oyun hakkı sıfırlandı
            } 
            if((fiveGuesses==0) &&(guessNumber != rnd))
            {
                Console.WriteLine($"Üzgünüm oyunu kaybettiniz.Sayı: {rnd}");
            }
        }
        break;
    case 2:
        Console.WriteLine("Hesap Makinesi Oyununa Hoşgeldiniz");
        Console.WriteLine("İşlem yapmak istediğiniz ilk sayıyı giriniz");
        int firstNumber=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("İşlem yapmak istediğiniz ikinci sayıyı giriniz");
        int secondNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hangi işlemi yapmak istersiniz?\nToplama için-->+\nÇıkarma için-->-\nÇarpma için-->*\nBölme için-->/ işaretlerinden birini seçiniz.");
        string operation=Console.ReadLine(); //Matematiksel işlemleri atamak için atanan değişken
        switch (operation)
        {
            case "+":
                int addition=firstNumber+secondNumber;
                Console.WriteLine($"Toplama işlemi sonucu {addition}");
                break;
            case "-":
                int subtraction=firstNumber-secondNumber;
                Console.WriteLine($"Çıkarma İşlemi sonucu {subtraction}");
                break;
            case "*":
                int multiplication=firstNumber*secondNumber;
                Console.WriteLine($"Çarpma İşlemi sonucu {multiplication}");
                break;
            case "/":
                
                if (secondNumber != 0.0) //girilen ikinci sayının 0 olup olmamasına göre işleme sokuldu.
                {
                    double division = firstNumber / secondNumber;
                    Console.WriteLine($"Bölme işlemi sonucu {division}");

                }
                else 
                { 
                    Console.WriteLine("0'a bölme işlemi yapılamaz.");
                }
                break;
                default:
                Console.WriteLine("Geçersiz işlem girdiniz");
                break ;
        }
        break;
    case 3:
        Console.WriteLine("Ortalama Hesaplama Oyununa Hoşgeldiniz!");
        Console.WriteLine("Lütfen birici ders notunuzu giriniz");
        double firstValue= Convert.ToDouble(Console.ReadLine()); 
        Console.WriteLine("Lütfen ikinci ders notunuzu giriniz");
        double secondValue = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Lütfen üçüncü ders notunuzu giriniz");
        double thirdValue = Convert.ToDouble(Console.ReadLine());
        if((firstValue >= 0 && firstValue <= 100) && (secondValue >= 0 && secondValue <= 100) && (thirdValue >= 0 && thirdValue <= 100)) //Ders notlarının 0-100 aralığında olup olmadığını kontrol eden if blogu
        {
            double averageValue = (firstValue + secondValue + thirdValue) / 3;
            Console.WriteLine($"Girdiğiniz notların ortalaması: {averageValue}");
            if (averageValue < 55)
                Console.WriteLine("Harf notunuz FF");
            else if (averageValue>=55 && averageValue < 60)
                Console.WriteLine(" Harf notunuz FD");
            else if (averageValue >= 60 && averageValue < 65)
                Console.WriteLine("Harf notunuz DD");
            else if(averageValue >= 65 && averageValue < 70)
                Console.WriteLine("Harf notunuz DC");
            else if(averageValue >= 70 && averageValue < 75)
                Console.WriteLine("Harf notunuz CC");
            else if (averageValue >= 75 && averageValue < 80)
                Console.WriteLine("Harf notunuz CB");
            else if (averageValue >= 80 && averageValue < 85)
                Console.WriteLine("Harf notunuz BB");
            else if (averageValue >= 85 && averageValue < 90)
                Console.WriteLine("Harf notunuz BA");
            else if (averageValue >= 90 && averageValue <= 100)
                Console.WriteLine("Harf notunuz AA");
        }
        else
            Console.WriteLine("Geçersiz değer girdiniz.");
        break;
    default:
        Console.WriteLine("Yanlış Değer Girdiniz");
        break;
}
