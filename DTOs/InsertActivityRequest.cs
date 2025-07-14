namespace PS_1_Backend.DTOs
{
    public class InsertActivityRequest
    {
        public string Source_of_Verification { get; set; } = string.Empty;
        public int Denominator { get; set; }
        public int Numerator { get; set; }
        public string CHO_Name { get; set; } = string.Empty;
    }
}
