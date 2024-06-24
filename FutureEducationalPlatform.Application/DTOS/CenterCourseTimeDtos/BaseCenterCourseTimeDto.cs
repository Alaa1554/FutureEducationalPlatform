using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.DTOS.CenterCourseTimeDtos
{
    public record BaseCenterCourseTimeDto
    (
        Guid CenterId,
        Guid CourseId,
        DayOfWeek LectureDay,
        TimeOnly LectureTime
    );
}
