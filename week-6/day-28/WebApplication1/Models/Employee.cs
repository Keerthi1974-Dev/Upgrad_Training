using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Employee
    {
        
        //public int Empno { get; set; }
        //public string Ename { get; set; }
        //public string Job { get; set; }
        //public decimal Salary { get; set; }
        //public int Deptno { get; set; }


        [Required(ErrorMessage = "Empno is required")]
        public int Empno { get; set; }

        [Required(ErrorMessage = "Employee Name is required")]
        [StringLength(15, MinimumLength = 5)]
        public string Ename { get; set; }


        public string Job { get; set; }

        [Range(10000, 100000)]
        public decimal Salary { get; set; }

        [Required(ErrorMessage = "Dept Number is required")]
        public int Deptno { get; set; }





    }
}
