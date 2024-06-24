using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.DTOS.CenterCourseTimeDtos
{
    public record UpdateCenterCourseTimeDto : BaseCenterCourseTimeDto
    {
        public UpdateCenterCourseTimeDto(Guid CenterId, Guid CourseId, DayOfWeek LectureDay, TimeOnly LectureTime) : base(CenterId, CourseId, LectureDay, LectureTime)
        {
        }
    }
}
