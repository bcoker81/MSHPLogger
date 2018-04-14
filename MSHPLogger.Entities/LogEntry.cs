using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSHPLogger.Entities
{
    public class LogEntry
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(4, ErrorMessage ="App Code can be no longer than 4 characters.")]
        public string AppCode { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Error Class can be no longer than 100 characters.")]
        public string ErrorClass { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Platform can be no longer than 20 characters.")]
        public string Platform { get; set; }

        [Required]
        public string ExceptionCode { get; set; }

        [Required]
        [StringLength(150, ErrorMessage = "User Name can be no longer than 150 characters.")]
        public string UserName { get; set; }

        [Required]
        public DateTime TransactionDate { get; set; }
    }
}
