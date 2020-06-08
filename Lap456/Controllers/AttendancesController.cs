using _dbContext;
using Lap456.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Lap456.Controllers
{
    [Authorize]
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _dbContext;

        public object AttendeeId { get; private set; }
        public int CourseId { get; private set; }

        public AttendancesController()
        {
            _dbContext = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Attend([FromBody] int courseId)
        {
            CourseId = courseId,
            AttendeeId = User.Identity.GetUserId()
        };
        _dbContext.Attendances.Add(Attendances);
        _dbContext.SaveChanges();
    }
}
