namespace Lab_1.Models
{
    public class StudentVm
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public override string ToString()
        {
            return $"{LastName} {FirstName}";
        }
    }
}
