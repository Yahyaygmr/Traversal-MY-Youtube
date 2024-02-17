using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TraversalApiProject.DAL.Context;
using TraversalApiProject.DAL.Entities;

namespace TraversalApiProject.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class VisitorController : ControllerBase
    {
        [HttpGet]
        public ActionResult VisitorList()
        {
            using (var context = new VisitorContext())
            {
                var values = context.Visitors.ToList();

                return Ok(values);
            }

        }
        [HttpPost]
        public IActionResult VisitorAdd(Visitor visitor)
        {
            using (var context = new VisitorContext())
            {
                context.Visitors.Add(visitor);
                context.SaveChanges();
                return Ok();
            }
        }
        [HttpGet("{id}")]
        public IActionResult VisitorGetById(int id)
        {
            using (var context = new VisitorContext())
            {
                var value = context.Visitors.Find(id);
                if (value == null)
                    return NotFound();

                return Ok(value);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult VisitorDelete(int id)
        {
            using (var context = new VisitorContext())
            {
                var value = context.Visitors.Find(id);
                if (value == null)
                    return NotFound();
                context.Visitors.Remove(value);
                context.SaveChanges();

                return Ok();
            }
        }
        [HttpPut]
        public IActionResult VisitorUpdate(Visitor visitor)
        {
            using (var context = new VisitorContext())
            {
                var value = context.Visitors.Find(visitor.VisitorId);
                if (value == null)
                    return NotFound();
                
                value.Name = visitor.Name;
                value.Surname   = visitor.Surname;
                value.City = visitor.City;
                value.Country = visitor.Country;
                value.Mail = visitor.Mail;
                context.Visitors.Update(value);
                context.SaveChanges ();
                return Ok();
            }
        }
    }
}
