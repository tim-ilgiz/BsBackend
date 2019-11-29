using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bsbackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace bsbackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly ApiDbContext _context;
        public BlogController(ApiDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public object Get()
        {
            return _context.Blogs.Select(c => new Blog
            {
                Id = c.Id,
                Name = c.Name
            }).ToList();
        }

        [HttpPost]
        [ProducesResponseType(typeof(Blog), 200)]
        [Produces("application/json")]
        public object Post([FromBody] Blog blog)
        {
            _context.Blogs.Add(blog);
            _context.SaveChanges();
            return Ok();
        }
    }
}
