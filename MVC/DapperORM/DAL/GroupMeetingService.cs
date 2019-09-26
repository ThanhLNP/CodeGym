using Dapper;
using DapperORM.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DapperORM.DAL
{
    public class GroupMeetingService : BaseService
    {
        public GroupMeetingService() : base()
        {

        }

        public IEnumerable<GroupMeetingView> GetGroupMeetings()
        {
            List<GroupMeetingView> groupMeetingsList = new List<GroupMeetingView>();

            using (IDbConnection con = new SqlConnection(strConnectionString))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                groupMeetingsList = con.Query<GroupMeetingView>("GetGroupMeetingDetails").ToList();
            }

            return groupMeetingsList;
        }

        public GroupMeeting GetGroupMeetingById(int? id)
        {
            GroupMeeting groupMeeting = new GroupMeeting();
            if (id == null)
                return groupMeeting;

            using (IDbConnection con = new SqlConnection(strConnectionString))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                DynamicParameters parameter = new DynamicParameters();
                parameter.Add("@Id", id);
                groupMeeting = con.Query<GroupMeeting>("GetGroupMeetingByID", parameter, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }

            return groupMeeting;
        }

        public int AddGroupMeeting(GroupMeeting groupMeeting)
        {
            int rowAffected = 0;
            using (IDbConnection con = new SqlConnection(strConnectionString))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ProjectName", groupMeeting.ProjectName);
                parameters.Add("@GroupMeetingLeadName", groupMeeting.GroupMeetingLeadName);
                parameters.Add("@TeamLeadName", groupMeeting.TeamLeadName);
                parameters.Add("@Description", groupMeeting.Description);
                parameters.Add("@GroupMeetingDate", groupMeeting.GroupMeetingDate);

                rowAffected = con.Execute("InsertGroupMeeting", parameters, commandType: CommandType.StoredProcedure);
            }

            return rowAffected;
        }

        public int UpdateGroupMeeting(GroupMeeting groupMeeting)
        {
            int rowAffected = 0;

            using (IDbConnection con = new SqlConnection(strConnectionString))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", groupMeeting.Id);
                parameters.Add("@ProjectName", groupMeeting.ProjectName);
                parameters.Add("@GroupMeetingLeadName", groupMeeting.GroupMeetingLeadName);
                parameters.Add("@TeamLeadName", groupMeeting.TeamLeadName);
                parameters.Add("@Description", groupMeeting.Description);
                parameters.Add("@GroupMeetingDate", groupMeeting.GroupMeetingDate);
                rowAffected = con.Execute("UpdateGroupMeeting", parameters, commandType: CommandType.StoredProcedure);
            }

            return rowAffected;
        }

        public int DeleteGroupMeeting(int id)
        {
            int rowAffected = 0;
            using (IDbConnection con = new SqlConnection(strConnectionString))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", id);
                rowAffected = con.Execute("DeleteGroupMeeting", parameters, commandType: CommandType.StoredProcedure);

            }

            return rowAffected;
        }
    }
}
