// unset

namespace SmartBarbequeMaker.Meat
{
    public class Chicken : AbstractMeat
    {
        private Chicken()
        {
            Name = "chicken";
        }

        public override string GetName()
        {
            return Name;
        }
    }
}