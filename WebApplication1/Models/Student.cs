using System.ComponentModel.DataAnnotations;
using WebApplication1.CustomAttribute;

namespace WebApplication1.Models
{
    public class Student
    {
        public int Id { get; set; }

        [CustomValidationMSG(textstr:"",ErrorMessage ="")]
        public string Name { get; set; }
    }
}