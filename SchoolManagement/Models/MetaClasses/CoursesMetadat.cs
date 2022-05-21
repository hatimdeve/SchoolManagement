using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.Models
{
    public class CoursesMetadat
    { 
        [StringLength(50)]
        public string Title { get; set; }
        [Range(1,10)]
        public int Credits { get; set; }
    }
    [MetadataType(typeof(CoursesMetadat))]
    public partial class Course
    {

    }
}