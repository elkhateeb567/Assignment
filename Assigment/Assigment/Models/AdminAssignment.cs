using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Assigment.Models
{
    public class AdminAssignment
    {
        [Key]
       
        public int Id { get; set; }
        [Required]
        public string Task { get; set; }
        [Required]
        public string Description { get; set; }
        public int EmployeeId { get; set; }
        public TaskType TaskType { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Completed { get; set; }
    }
    public enum TaskType
    {
        Low, urgent
    }
}

