//using System;
//using System.Collections.Generic;
//using TP_Modul_3_KPL_REZA;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Memanggil method getKodePos dari class KodePos
//        KodePos kodePos = new KodePos();
//        Console.WriteLine("Kode Pos Batununggal: " + kodePos.getKodePos("Batumunggal"));
//        Console.WriteLine("Kode Pos Kujangsari: " + kodePos.getKodePos("Kujangsari"));
//        Console.WriteLine("Kode Pos Mengger: " + kodePos.getKodePos("Mengger"));
//    }
//}

using System;
using TP_Modul_3_KPL_REZA;

namespace tpmodul3_NIM
{
    class Program
    {
        static void Main(string[] args)
        {
            // Memanggil method getKodePos dari class KodePos
            KodePos kodePos = new KodePos();
            Console.WriteLine("Kode Pos Batununggal: " + kodePos.getKodePos("Batumunggal"));
            Console.WriteLine("Kode Pos Kujangsari: " + kodePos.getKodePos("Kujangsari"));
            Console.WriteLine("Kode Pos Mengger: " + kodePos.getKodePos("Mengger"));

            // Mensimulasikan perubahan state pada DoorMachine
            DoorMachine door = new DoorMachine();
            door.KunciPintu(); // State awal: Terkunci
            door.BukaPintu();  // State berubah: Terbuka
            door.KunciPintu(); // State berubah: Terkunci
        }
    }
}
    