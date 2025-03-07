namespace AttendanceApp.Models
{
    public class AttendanceRecord
    {
        public int AttendanceRecordId { get; set; } // Primary key
        public int EmployeeId { get; set; }
        public DateTime CheckInTime { get; set; }
        public DateTime? CheckOutTime { get; set; }

        // Relasi ke Employee (opsional, jika ingin navigasi)
        public Employee? Employee { get; set; }
    }
}
