namespace MandelbrotSet
{
    struct ComplexNumber
    {
        public double Re { get; }
        public double Im { get; }
        public double Normal => Re * Re + Im * Im;

        public ComplexNumber(double re, double im)
        {
            this.Re = re;
            this.Im = im;
        }

        public static ComplexNumber operator +(ComplexNumber x, ComplexNumber y)
        {
            return new ComplexNumber(x.Re + y.Re, x.Im + y.Im);
        }

        public static ComplexNumber operator *(ComplexNumber x, ComplexNumber y)
        {
            return new ComplexNumber(
                re: x.Re * y.Re - x.Im * y.Im,
                im: x.Re * y.Im + x.Im * y.Re);
        }
    }
}
