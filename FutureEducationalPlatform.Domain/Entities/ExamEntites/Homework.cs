using FutureEducationalPlatform.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Domain.Entities.ExamEntites
{
    public class Homework : BaseModel
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
