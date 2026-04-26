using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.DTO
{
    public class CreateReminder
    {
        public int RmdTimeId { get; set; }
        public int AppointmentId { get; set; }
    }
}
