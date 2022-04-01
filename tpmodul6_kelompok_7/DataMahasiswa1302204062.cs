using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace tpmodul6_kelompok_7
{
    public class DataMahasiswa1302204062
    {
        public string Depan { get; set; }
        public string Belakang { get; set; }
        public int NIM { get; set; }
        public string Fakultas { get; set; }

        public DataMahasiswa1302204062() { }

        public DataMahasiswa1302204062(string depan, string belakang, int nim, string fakultas)
        {
            this.Depan = depan;
            this.Belakang = belakang;
            this.NIM = nim;
            this.Fakultas = fakultas;
        }
        public void ReadJSON()
        {
            String jsonString = File.ReadAllText("/Users/Faza/praktikum_kpl/tpmodul6_kelompok_7/tpmodul6_kelompok_7/tp6_1_1302204062.json");

            DataMahasiswa1302204062 Mhs = JsonSerializer.Deserialize<DataMahasiswa1302204062>(jsonString);

            Console.WriteLine("Nama " + Mhs.Depan + " " + Mhs.Belakang + " dengan nim " + Mhs.NIM + " dari fakultas " + Mhs.Fakultas);
        }
    }
}
