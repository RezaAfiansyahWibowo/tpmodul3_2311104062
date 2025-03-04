using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Modul_3_KPL_REZA
{
    class KodePos
    {


        private Dictionary<string, string> kodePosTable;

        public KodePos()
        {
            // Inisialisasi tabel kode pos
            kodePosTable = new Dictionary<string, string>
            {
                {"Batumunggal", "40266"},
                {"Kujangsari", "40287"},
                {"Mengger", "40267"},
                {"Wates", "40256"},
                {"Cijaura", "40287"},
                {"Jatisari", "40286"},
                {"Margasari", "40286"},
                {"Sekejati", "40286"},
                {"Kebonwaru", "40272"},
                {"Maleer", "40274"},
                {"Samoja", "40273"}
            };
        }

        public string getKodePos(string kelurahan)
        {
            // Mengembalikan kode pos berdasarkan kelurahan
            if (kodePosTable.ContainsKey(kelurahan))
            {
                return kodePosTable[kelurahan];
            }
            else
            {
                return "Kode pos tidak ditemukan";
            }
        }
    }
}


