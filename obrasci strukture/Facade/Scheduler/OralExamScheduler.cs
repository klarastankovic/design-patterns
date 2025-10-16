using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Scheduler
{
    public class OralExamScheduler
    {
        LabExcercisesService labService = new LabExcercisesService();
        AttendanceService attendanceService = new AttendanceService();
        WrittenExamService writtenExamService = new WrittenExamService();
        public bool IsEligibleForOralExam(String id)
        {
            return this.labService.HasEnoughPoints(id) &&
                this.attendanceService.HasAttendedEnoughClasses(id) &&
                this.writtenExamService.PassedWrittenExam(id);
        }
    }
}
