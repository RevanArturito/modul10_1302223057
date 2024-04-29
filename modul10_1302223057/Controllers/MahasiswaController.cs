using Microsoft.AspNetCore.Mvc;

namespace modul10_1302223057.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MahasiswaController
    {
        // inisialisasi data mahasiswa berupa anggota kelompok
        private static List<Mahasiswa> mahasiswa = new List<Mahasiswa>()
        {
            new Mahasiswa("Cokorda Arturito Revan Putra Diarta", "1302223057", new List<String> {"PBO", "KPL", "BASDAT"} , 2022),
            new Mahasiswa("Rd. M. Faisal Ramadhan Junaidi", "1302220093", new List<String> {"PBO", "KPL", "BASDAT"}, 2022),
            new Mahasiswa("Farrel Haykal Giffari", "1302220064", new List<String> {"PBO", "KPL", "BASDAT"}, 2022),
        };

        // menggunakan IEnumerable untuk menampilkan seluruh data list Mahasiswa
        [HttpGet(Name = "GetMahasiswa")]
        public IEnumerable<Mahasiswa> Get() 
        { 
            return mahasiswa; 
        }

        // menggunakan post untuk menambah data mahasiwa pada list
        [HttpPost]
        public void post([FromBody] Mahasiswa ListMahasiswa) 
        {
            mahasiswa.Add(ListMahasiswa);
        }

        // menampilkan data mahasiswa berdasarkan id(index) yang diinput
        [HttpGet("{id}")]
        public Mahasiswa Get(int  id)
        {
            return mahasiswa[id];
        }

        // menggunakan delete untuk menghapus data list berdasarkan id
        [HttpDelete]
        public void delete(int id)
        {
            mahasiswa.RemoveAt(id);
        }

    }
}
