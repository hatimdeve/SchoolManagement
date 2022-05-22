using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace SchoolManagement.Models
{
    public class EnrollmentsMetadata
    {
        [Display(Name ="student grade")]
        public Nullable<decimal> Grade { get; set; }
        [Display(Name = "course")]
        public int CourseID { get; set; }
        [Display(Name = "student ")]
        public int StudentID { get; set; }
        [Display(Name = "lecturer")]
        public Nullable<int> LecturerID { get; set; }
        [Display(Name = "course")]
        public  Course Course { get; set; }
        [Display(Name = "student ")]
        public  Student Student { get; set; }
        [Display(Name = "lecturer")]
        public  Lecturer Lecturer { get; set; }
       
    }
    [MetadataType(typeof(EnrollmentsMetadata))]
    public partial class Enrollments { }
}