using System.ComponentModel.DataAnnotations;

namespace TP2_Triangulo__FI13005258_.Models
{
    public class TriangleModel
    {
        [Required, Range(0.0001, double.MaxValue, ErrorMessage = "Lado a debe ser mayor que cero.")]
        public double A { get; set; }

        [Required, Range(0.0001, double.MaxValue, ErrorMessage = "Lado b debe ser mayor que cero.")]
        public double B { get; set; }

        [Required, Range(0.0001, double.MaxValue, ErrorMessage = "Lado c debe ser mayor que cero.")]
        public double C { get; set; }

        public double Perimeter { get; set; }
        public double SemiPerimeter { get; set; }
        public double Area { get; set; }
        public string TriangleType { get; set; }
        public double Alpha { get; set; }
        public double Beta { get; set; }
        public double Gamma { get; set; }
    }
}
