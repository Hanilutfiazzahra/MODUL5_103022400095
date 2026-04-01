// See https://aka.ms/new-console-template for more information
using MODUL5_103022400095;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("MODUL 5 KONTRUKSI PERANGKAT LUNAK");

        PemrosesanData data = new PemrosesanData();
        data.DapatkanNilaiTerpesar(10, 30, 22);

        SimpleDataBase<int> db = new SimpleDataBase<int>();
        db.AddData(12);
        db.AddData(34);
        db.AddData(56);
        db.printData();

    }
}
using MODUL5_103022400095;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("MODUL 5 KONTRUKSI PERANGKAT LUNAK");

        SimpleDataBase<int> db = new SimpleDataBase<int>();
        db.AddData(12);
        db.AddData(34);
        db.AddData(56);
        db.printData();

    }


}
