using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Electronica.Manager;
using Electronica.Manager.ElectronicaDto;
using Electronica.Manager.ElectronicaProviders;

namespace Electronica_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
            {
            if (Session["Uid"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
         }
        [HttpPost]
        public ActionResult LogOut()
        {

            Session["Uid"] = null;
            Session["UserName"] = null;
            return RedirectToAction("Login");
        }
        public ActionResult Registration()
          {
          return View();
          }
        [HttpPost]
        public ActionResult Registration(ParticipantDto objMemberDto)
        {

            ParticipantManager objMemberManager = new ParticipantManager();
            bool status=objMemberManager.AddParticipant(objMemberDto);
            if (status)
               {
                return RedirectToAction("Login");
               }
            else
               {
                return Content("Error");
               }
        }

        public ActionResult Login()
        {
           return View();
        }

        [HttpPost]
        public ActionResult Login(LoginDto objloginDto)
        {
            string s = null;
            try
            {



                LoginManager objLoginManager = new LoginManager();
                ParticipantDto objReturn = new ParticipantDto();
                objReturn=objLoginManager.CheckLogin(objloginDto);
                if (objReturn.Email!=null)
                   {
                    Session["Uid"] = objReturn.UserID;
                    Session["UserName"] = objReturn.FirstName + " " + objReturn.LastName;
                    return RedirectToAction("Index");
                   }
                else
                    {
                    return Content("Invalid Username/Password");
                    }
            }
            catch (Exception ex)
            {
                s = ex.Message;
                s += ex.Source;
                s += ex.InnerException.Message;
            }
            return Content(s);
        }
        public ActionResult PastEvents()
        {
            int UserID = 1;
            EventManager em = new EventManager();
            List<ParticipantEventDto> pd = em.GetPastEvent(UserID);
            ViewBag.el = pd;
            return View();
        }

       
       // [HttpPost]
        public ActionResult Enrollment(int EventID)
        {
            //Session["eventid"] = EventID;
            if (Session["Uid"] != null)
            {
                EnrollmentDto objEnrollmentDto = new EnrollmentDto();
                objEnrollmentDto.EnrollMemberId = Convert.ToInt32( Session["Uid"]);
                objEnrollmentDto.EnrollEventId =EventID;
                EnrollmenttManager objEnroll = new EnrollmenttManager();
                objEnroll.AddEnrollment(objEnrollmentDto);
                return RedirectToAction("ShowEvent");
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
        
        public ActionResult GetEvent(string eventName)
        { 
            EventManager objEvent = new EventManager();
            EventDto objEventDto = new EventDto();
            objEventDto=objEvent.GetEvent(eventName);
            ViewBag.Name = objEventDto.EventName;
            ViewBag.StartDate= objEventDto.EventStartDate;
            ViewBag.Status=objEventDto.EventStatus;
            ViewBag.Promocode = objEventDto.PromoCode;
            return View("SearchResults");
                
        }
        public ActionResult ShowEvent()
        {
            if (Session["Uid"] != null)
            {
                EventManager objEvent = new EventManager();
            List<ParticipantEventDto> newEventList = new List<ParticipantEventDto>();
            newEventList = objEvent.DisplayEvent();
            var model = new List<ParticipantEventDto>();
            foreach (ParticipantEventDto item in newEventList)
            {
                model.Add(item);
            }
            ViewBag.listNew = model;
            return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
        
}
