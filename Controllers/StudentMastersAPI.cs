using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Angular2AspCoreMasterDetail.Models;

namespace Angular2AspCoreMasterDetail.Controllers
{
    [Produces("application/json")]
    [Route("api/StudentMastersAPI")]
    public class StudentMastersAPI : Controller
    {
        private readonly StudentContext _context;

        public StudentMastersAPI(StudentContext context)
        {
            _context = context;
        }

        // GET: api/values 
        // For Student Master 
        [HttpGet]
        [Route("Student")]
        public IEnumerable<StudentMasters> GetStudentMasters()
        {
            return _context.StudentMasters;

        }

        // GET: api/values 
        // For Student Detail 

        [HttpGet]
        [Route("Details")]
        public IEnumerable<StudentDetails> GetStudentDetails()
        {
            return _context.StudentDetails;

        }

        // For Student Detail with studentid to load by student ID 

        // GET api/values/5 
        [HttpGet]
        [Route("Details/{id}")]
        public IEnumerable<StudentDetails> GetStudentDetails(int id)
        {
            return _context.StudentDetails.Where(i => i.StdID == id).ToList();
        }

    }
}