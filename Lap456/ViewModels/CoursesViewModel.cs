﻿using Lap456.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lap456.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpCommingCourses { get; set; }
        public bool ShowAction { get; set; }
       
    }
}