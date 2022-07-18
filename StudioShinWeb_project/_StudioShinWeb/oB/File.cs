using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _jta_MVC_WP.oB {


  public class BufferedSingleFileUploadDb {
    [Required]
    [Display(Name = "File")]
    public IFormFile FormFile { get; set; }
  }
}
