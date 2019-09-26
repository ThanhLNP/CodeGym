using System;
using System.Collections.Generic;

namespace DapperORM.DAL
{
    public class GroupMeeting
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string GroupMeetingLeadName { get; set; }
        public string TeamLeadName { get; set; }
        public string Description { get; set; }
        public DateTime GroupMeetingDate { get; set; }
    }
}
