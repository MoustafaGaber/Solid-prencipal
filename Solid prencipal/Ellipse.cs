namespace Solid_prencipal
{
    public class Ellipse
    {
        public double Rx { get; set; }
        public double Ry { get; set; }

        public bool IsCircle => Rx == Ry;

        public virtual void SetRx(double value)
        {
            if (IsCircle)
            {
                Ry = value;
            }

            Rx = value;
        }

        public void SetRy(double value)
        {
            if (IsCircle)
            {
                Ry = Rx;
            }

            Ry = value;
        }
    }

}




