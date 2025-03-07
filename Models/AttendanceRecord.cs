namespace AttendanceApp.Models
{
    public class AttendanceRecord
    {
        public int AttendanceRecordId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime CheckInTime { get; set; }
        public DateTime? CheckOutTime { get; set; }

        public Employee? Employee { get; set; }
    }
}
