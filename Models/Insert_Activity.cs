namespace PS_1_Backend.Models
{
    public class Insert_Activity
    {
        public int Id { get; set; } // Primary key
        public string CHO_Name { get; set; } = string.Empty;

        public string Source_of_Verification { get; set; } = string.Empty;

        public int Denominator { get; set; }

        public int Numerator { get; set; }

        public double Work_Percentage { get; set; }
    }
}
