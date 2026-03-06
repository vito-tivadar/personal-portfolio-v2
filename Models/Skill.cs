namespace personal_portfolio_v2.Models
{
    public class Skill
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public string Accent { get; set; }
        public byte AccentInteinsity { get; set; } = 255;
        public string AccentInteinsityHex => $"{AccentInteinsity:X2}";
        public int RowNumber { get; set; }
    }
}
