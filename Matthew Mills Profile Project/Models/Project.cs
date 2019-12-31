using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Matthew_Mills_Profile_Project.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Display(Name = "Project Name")]
        public string ProjectName { get; set; }

        public string Description { get; set; }

        [Display(Name = "Last Modified")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]
        public DateTime LastModified { get; set; }

        public string Status { get; set; }

        [Display(Name = "GitHub Link")]
        public string GitLink { get; set; }

    }
}
