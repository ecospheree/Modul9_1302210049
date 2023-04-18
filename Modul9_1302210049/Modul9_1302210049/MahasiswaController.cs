using Microsoft.AspNetCore.Mvc;
using Modul9_1302210049;

namespace Modul9_1302210049
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController
    {
        private static List<Mahasiswa> mahasiswa = new List<Mahasiswa>()
        {
            new Mahasiswa("Nabiel Prayoga Budiana", "1302210049", new List<string> { "KPL", "BASDAT" }, 2021),
            new Mahasiswa("Walid Hanif Ataullah", "1302213120", new List<string> { "KPL", "BASDAT" }, 2021),
            new Mahasiswa("Muhammad Raffa Zuhayr", "1302210068", new List<string> { "KPL", "BASDAT" }, 2021),
            new Mahasiswa("Muhammad Yaasin Rafi", "1302210055", new List<string> { "KPL", "BASDAT" }, 2021),
            new Mahasiswa("Sylvana Rheina Kharmeliawaty", "1302210017", new List<string> { "KPL", "BASDAT" }, 2021)
        };
        //membuat get di controller
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswa;
        }

        //menambahkan object 
        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            mahasiswa.Add(value);
        }

        //get sesuia index
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mahasiswa[id];
        }

        //untuk mengahapus index
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            mahasiswa.RemoveAt(id);
        }
    }
}



            
