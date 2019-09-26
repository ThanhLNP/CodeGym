using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DapperORM.Models;
using DapperORM.DAL;

namespace DapperORM.Controllers
{
    public class HomeController : Controller
    {
        private readonly GroupMeetingService groupMeetingService = new GroupMeetingService();

        #region View List
        public IActionResult Index()
        {
            return View(groupMeetingService.GetGroupMeetings());
        }
        #endregion

        #region Create
        [HttpGet]
        public IActionResult AddGroupMeeting()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddGroupMeeting([Bind] GroupMeetingCreate model)
        {
            var createResult = groupMeetingService.AddGroupMeeting(new GroupMeeting()
            {
                Description = model.Description,
                GroupMeetingDate = model.GroupMeetingDate,
                GroupMeetingLeadName = model.GroupMeetingLeadName,
                ProjectName = model.ProjectName,
                TeamLeadName = model.TeamLeadName,
            });
            if (ModelState.IsValid)
            {
                if (createResult > 0)
                {
                    TempData["Success"] = "Group meeting has been created success";
                }
                else
                {
                    TempData["Error"] = "Something went wrong, please try again later";
                }
            }
            ModelState.Clear();
            return View(new GroupMeetingCreate() { GroupMeetingDate = DateTime.Now });
        }
        #endregion

        #region Edit
        [HttpGet]
        public IActionResult EditMeeting(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            GroupMeeting group = groupMeetingService.GetGroupMeetingById(id);
            if (group == null)
                return NotFound();
            return View(group);
        }

        [HttpPost]
        public IActionResult EditMeeting(int id, [Bind] GroupMeetingEdit model)
        {
            if (id != model.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                var editResult = groupMeetingService.UpdateGroupMeeting(new GroupMeeting()
                {
                    Id = model.Id,
                    Description = model.Description,
                    GroupMeetingDate = model.GroupMeetingDate,
                    GroupMeetingLeadName = model.GroupMeetingLeadName,
                    ProjectName = model.ProjectName,
                    TeamLeadName = model.TeamLeadName,
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }
        #endregion

        #region Delete
        [HttpGet]
        public IActionResult DeleteMeeting(int id)
        {
            GroupMeeting group = groupMeetingService.GetGroupMeetingById(id);
            if (group == null)
            {
                return NotFound();
            }

            return View(group);
        }
        [HttpPost]
        public IActionResult DeleteMeeting(int id, GroupMeeting groupMeeting)
        {
            if (groupMeetingService.DeleteGroupMeeting(id) > 0)
            {
                return RedirectToAction("Index");
            }
            return View(groupMeeting);
        }
        #endregion

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
