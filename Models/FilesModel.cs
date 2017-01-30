﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace streaming_inż.Models
{
    public class FileUpload
    {   
        [Required]
        public string Title { get; set; }
        [Required]
        public HttpPostedFileBase Avatar { get; set; }
        
        public HttpPostedFileBase Song { get; set; }
    }

    public class UserSongs
    {
        public string UserName { get; set; }

        public string Title { get; set; }

        public string UploadTime { get; set; }

        public string avatarPath { get; set; }
    }
}