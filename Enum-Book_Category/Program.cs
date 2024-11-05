class Program
{
    enum KitapKategori
    {
        BilimKurgu = 0,
        DunyaKlasikleri = 1,
        Psikoloji = 2
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen Bir Kategori Giriniz \n0 - BilimKurgu\n1 - DunyaKlasikleri\n2 - Psikoloji \nYa Kategori İsimini Ya Da Kategori Numarasını Girerek İstediğiniz Reyon Hakkında Bilgi Alabilirsiniz.\nLütfen Giriniz : ");
        string kategoriGiris = Console.ReadLine();
        Console.Clear();
        Thread.Sleep(1000);
        Console.WriteLine("Reyon Hakkında Bilgi Yükleniyor...");
        Thread.Sleep(1000);
        Console.Clear();
        try
        {
            KitapKategori kategori = (KitapKategori)Enum.Parse(typeof(KitapKategori), kategoriGiris);
            switch (kategori)
            {
                case KitapKategori.BilimKurgu:
                    Console.WriteLine("Bilim Kurgu Kategorisindeki Kitaplar A Reyonunda Yer Almaktadır.");
                    break;
                case KitapKategori.DunyaKlasikleri:
                    Console.WriteLine("Dünya Klasikleri Kategorisindeki Kitaplar B Reyonunda Yer Almaktadır.");
                    break;
                case KitapKategori.Psikoloji:
                    Console.WriteLine("Psikoloji Kategorisindeki Kitaplar C Reyonunda Yer Almaktadır.");
                    break;
                default:
                    Console.WriteLine("Yanlış Bir Tuşlama Yaptınız! Lütfen 0-3 Arası Bir Seçim Yapınız!");
                    break;
            }
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Geçersiz Kategori Girişi Yaptınız. Lütfen Doğru Bir Kategori Giriniz.");
        }
    }
}
