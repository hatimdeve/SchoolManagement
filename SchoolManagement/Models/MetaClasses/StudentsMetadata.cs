using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace SchoolManagement.Models
{
    public class StudentsMetadata
    { 
        [StringLength(50)]
        [Display(Name ="last name")]
        public string LastName { get; set; }
        [StringLength(50)]
        [Display(Name = "first name")]
        public string FirstName { get; set; }
        [Display(Name = "date of enrillment ")]
        public Nullable<System.DateTime> EnrollmentDate { get; set; }
        [StringLength(50)]
        [Display(Name = "middle name")]
        public string MiddleName { get; set; }
    }
    [MetadataType(typeof(StudentsMetadata))]
    public partial class Student
    {

    }
}