using Assigment.Data;
using Assigment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Assigment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
 
            private readonly AssignmentDbContext _context;
            public TasksController(AssignmentDbContext context)
            {
                _context = context;
            }

            [HttpGet]
            public async Task<IEnumerable<AdminAssignment>> Get() =>

                 await _context.AdminAssignment.ToListAsync();

            [HttpGet("id")]
            public async Task<IActionResult> GetById(int id)
            {
                var Task = await _context.AdminAssignment.FindAsync(id);
                return Task == null ? NotFound() : Ok(Task);
            }
        [HttpPost]
            public async Task<IActionResult> Create(AdminAssignment AdminAssignment)
            {
                await _context.AdminAssignment.AddAsync(AdminAssignment);
                await _context.SaveChangesAsync();
                return CreatedAtAction(nameof(GetById), new { id = AdminAssignment.Id }, AdminAssignment);
            }
            [HttpPut("id")]
            public async Task<IActionResult> Update(int id, AdminAssignment AdminAssignment)
            {
                if (id != AdminAssignment.Id) return BadRequest();
                _context.Entry(AdminAssignment).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return NoContent();
            }
            [HttpDelete("id")]
            public async Task<IActionResult> Delete(int id)
            {
                var TaskTodelete = await _context.AdminAssignment.FindAsync(id);
                if (TaskTodelete == null) return NotFound();
                _context.AdminAssignment.Remove(TaskTodelete);
                await _context.SaveChangesAsync();
                return NoContent();
            }
        }
    
}