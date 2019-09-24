namespace Solid_prencipal
{
    public class Circle : Ellipse
    {
        public override void SetRx(double value)
        {
            base.SetRx(value);
            Ry = value;
        }
    }
}




