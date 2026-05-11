using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.DAL
{
    public class ParticipantDAL
    {
        public static List<User> GetParticipants(int appId)
        {
            using (var db = DataContextFactory.CreateContext())
            {
                var q = db.Participants.Where(p => p.AppointmentId == appId).Select(p => p.User);
                return q.ToList();
            }
        }

        public static User GetParticipant(int appId, int userId)
        {
            using (var db = DataContextFactory.CreateContext())
            {
                var q = db.Participants.Where(p => p.AppointmentId == appId && p.UserId == userId).Select(p => p.User);
                return q.FirstOrDefault();
            }
        }

        public static bool AddParticipant(Participant participant)
        {
            using (var db = DataContextFactory.CreateContext())
            {
                try
                {
                    db.Participants.InsertOnSubmit(participant);
                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    db.SubmitChanges();
                }
                return true;
            }
        }

        public static bool DeleteParticipant(int appId, int userId)
        {
            using (var db = DataContextFactory.CreateContext())
            {
                try
                {
                    var q = db.Participants.Where(p => p.AppointmentId == appId && p.UserId == userId).FirstOrDefault();
                    if (q != null)
                    {
                        db.Participants.DeleteOnSubmit(q);
                    }
                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    db.SubmitChanges();
                }
                return true;
            }
        }
    }
}
