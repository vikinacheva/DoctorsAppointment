using DoctorsAppointment.Services;
using Microsoft.AspNetCore.Mvc;

namespace DoctorsAppointment.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly IAppointmentService _appointmentService;
        public AppointmentController(AppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }
        public IActionResult Index()
        {
            ViewBag.DoctorList = _appointmentService.GetDoctorList();
            return View();
        }
    }
}
