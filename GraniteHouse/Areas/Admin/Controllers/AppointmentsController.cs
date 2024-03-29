﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using GraniteHouse.Data;
using GraniteHouse.Models;
using GraniteHouse.Models.ViewModel;
using GraniteHouse.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GraniteHouse.Areas.Admin.Controllers
{
    [Authorize(Roles = SD.SuperAdminUser+","+SD.AdminUser)]
    [Area("Admin")]
    public class AppointmentsController : Controller
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public AppointmentViewModel AppointmentVM { get; set; }
        public AppointmentsController(ApplicationDbContext db)
        {
            _db = db;

            AppointmentVM = new AppointmentViewModel()
            {
                Appointments = new List<Appointments>()
            };
        }

        public async Task<IActionResult> Index(string searchName,string searchEmail,string searchDate,string searchPhone)
        {
            ClaimsPrincipal currentUser = this.User;
            var ClaimsIdentity = (ClaimsIdentity)this.User.Identity;
            var claim = ClaimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            AppointmentViewModel appointmentVM = new AppointmentViewModel()
            {
                Appointments = new List<Appointments>()
            };
            appointmentVM.Appointments = _db.Appointments.Include(x => x.SalesPerson).ToList();


            if (User.IsInRole(SD.AdminUser))
            {
                appointmentVM.Appointments = appointmentVM.Appointments.Where(x => x.SalesPersonId == claim.Value).ToList();
            }
            if(searchName!=null)
            {
                appointmentVM.Appointments = appointmentVM.Appointments.Where(a => a.CustomerName.ToLower().Contains(searchName.ToLower())).ToList();
            }
            if (searchEmail != null)
            {
                appointmentVM.Appointments = appointmentVM.Appointments.Where(a => a.CustomerEmail.ToLower().Contains(searchEmail.ToLower())).ToList();
            }
            if (searchPhone != null)
            {
                appointmentVM.Appointments = appointmentVM.Appointments.Where(a => a.CustomerPhoneNumber.ToLower().Contains(searchPhone.ToLower())).ToList();
            }
            if (searchDate != null)
            {
                try
                {
                    var appDate = Convert.ToDateTime(searchDate);
                    appointmentVM.Appointments = appointmentVM.Appointments.Where(a => a.AppointmentDate.ToShortDateString().Equals(appDate.ToShortDateString())).ToList();
                }
                catch (Exception)
                {

                }
            }
            return View(appointmentVM);
        }
    }
}