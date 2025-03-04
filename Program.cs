using System;
using System.Collections.Generic;
using TP_Modul_3_KPL_REZA;

class Program
{
    static void Main(string[] args)
    {
        // Memanggil method getKodePos dari class KodePos
        KodePos kodePos = new KodePos();
        Console.WriteLine("Kode Pos Batununggal: " + kodePos.getKodePos("Batumunggal"));
        Console.WriteLine("Kode Pos Kujangsari: " + kodePos.getKodePos("Kujangsari"));
        Console.WriteLine("Kode Pos Mengger: " + kodePos.getKodePos("Mengger"));
    }
}
