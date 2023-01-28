using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using zad10.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace zad10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private MainDbContext _context;

        public StudentsController(MainDbContext context)
        {
            _context = context;
        }


        // GET: api/<StudentsController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
           var context = new MainDbContext();
            var stutent = context.Students
                            .Select(s => new
                            {
                                Imie = s.Imie,
                                Nazwisko = s.Nazwisko,
                                NrIndeksu = s.NrIndeksu,
                                RokStudiow = s.RokStudiow,
                                Studia = s.Studia

                            }
                            );
            return Ok(stutent);
        }

       // GET api/<StudentsController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSpecific(int id)
        {
            var context = new MainDbContext();
            var stutent = from s in context.Students
                          where s.IdStudent.Equals(id)
                          join st in context.Studias on s.IdStudia equals st.IdStudia
                          
                          select new
                          {

                              Imie = s.Imie,
                              Nazwisko = s.Nazwisko,
                              NrIndeksu = s.NrIndeksu,
                              RokStudiow = s.RokStudiow,
                              StudiaNazwa = st.Nazwa,
                              StudiaTryb = st.Tryb

                          };
                       
  
            return Ok(stutent);
        }

        //// POST api/<StudentsController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<StudentsController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<StudentsController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
