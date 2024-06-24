

namespace FutureEducationalPlatform.Application.DTOS.CenterCourseTimeDtos
{
    public record AddCenterCourseTimeDto : BaseCenterCourseTimeDto
    {
        public AddCenterCourseTimeDto(Guid CenterId, Guid CourseId, DayOfWeek LectureDay, TimeOnly LectureTime) : base(CenterId, CourseId, LectureDay, LectureTime)
        {
        }
    }
}
