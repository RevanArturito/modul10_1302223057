namespace modul10_1302223057
{
    // deklarasi class mahasiswa
    public class Mahasiswa
    {
        // menambahakan atribut nama
        public String Name {  get; set; }
        // menambahkan atribut nim
        public String Nim {  get; set; }
        // menambahkan atribut berupa list matkul yang diambil
        public List<String> Course { get; set; }
        // menambahkan atribut tahun
        public int Year { get; set; }

        // constructor class Mahasiswa
        public Mahasiswa(string name, string nim, List<string> course, int year)
        {
            this.Name = name;
            this.Nim = nim;
            this.Course = course;
            this.Year = year;
        }
    }
}
