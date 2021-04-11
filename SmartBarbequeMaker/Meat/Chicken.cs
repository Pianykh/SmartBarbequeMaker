// unset

namespace SmartBarbequeMaker.Meat
{
    public class Chicken : AbstractMeat
    {
        public Chicken()
        {
            Name = "chicken";
        }

        public override string GetName()
        {
            return Name;
        }
    }
}