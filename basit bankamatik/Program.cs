
class Program
{
    static void Main(string[] args)
    {
        int bakiye, gelenp, gidenp;
        bakiye = 1000;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Lütfen bir seçenek seçin");//seçilmek üzere switch case yapısından önce listeyi kullanıcının önüne açar
            Console.WriteLine("1-Bakiye Görüntüle");
            Console.WriteLine("2-Para Yatır");
            Console.WriteLine("3-Para Çek");
            Console.WriteLine("4-Çıkış");
            var key= Console.ReadKey(true);//kullanıcının basmasını bekler
            switch (key.Key) 
            {
                case ConsoleKey.D1:
                    Console.WriteLine("Bakiye:"+bakiye);//kullanıcıya bakiyesini gösterir
                    break;
                case ConsoleKey.D2://bakiyeye para eklemek için kullanılır
                    Console.WriteLine("Para Yatırma Seçildi");//seçilen işlemi kullanıcıya iletir
                    Console.WriteLine("Lütfen Yatırılacak Miktarı Giriniz");
                    if (int.TryParse(Console.ReadLine(), out gelenp) && gelenp > 0) //girilen değerin 0 dan büyük olup olmadığını kontrol eder
                    { 
                        bakiye +=gelenp;//girilen değer istenen şekilde ise o değere eşdeğer miktar bakiyeye eklenir
                        Console.WriteLine("Güncel Bakiyeniz:"+bakiye);
                    }
                    else//girilen miktarın geçerli olmadığı hakkında kullanıcıyı uyarır
                    {
                        Console.WriteLine("Lütfen Geçerli Bir Miktar Giriniz");
                    }
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("Para Çekme Seçildi");
                    if (int.TryParse(Console.ReadLine(), out gidenp) && gidenp > 0)
                    {
                        if (gidenp > bakiye)//bakiyeyi kontrol eder çekilmek istenen miktar bakiyeden fazlaysa kullanıcıyı uyarır
                        {
                            Console.WriteLine("Bakiyeniz Yetersiz");
                        }
                        else//çekilmek istenen değer bakiyeden fazla değil ise çekilen değer bakiyeden çıkarılır ve güncel bakiye ekrana yazdırılır
                        {
                            bakiye -= gidenp;
                            Console.WriteLine("Güncel Bakiyeniz:" + bakiye);
                        }
                    }
                    else 
                    {
                        Console.WriteLine("Lütfen Geçerli Bir Miktar Giriniz");
                    }
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("Çıkış Yapılıyor...");
                    return;//programdan çıkış yapmamızı sağlar
                default:
                    Console.WriteLine("Geçersiz Seçim");//yanlış bir tuşlama yapar isek bizi uyarır
                    break;
            }
            Console.WriteLine("Devam Etmek İçin Bir Tuşa Basın");
            Console.ReadKey();
        }
    }
}