// unset

namespace SmartBarbequeMaker.Meat
{
    public class Pork : AbstractMeat
    {
        private Pork()
        {
            Name = "pork";
        }

        public override string GetName()
        {
            return Name;
        }
    }
}