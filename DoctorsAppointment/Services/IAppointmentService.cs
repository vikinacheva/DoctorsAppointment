using DoctorsAppointment.Models.ViewModels;

namespace DoctorsAppointment.Services
{
    public interface IAppointmentService
    {
        public List<DoctorVM> GetDoctorList();
        public List<PatientVM> GetPatientList();
    }
}
