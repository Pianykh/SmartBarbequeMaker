﻿// unset

namespace SmartBarbequeMaker.Meat
{
    public class Beef : AbstractMeat
    {
        public Beef()
        {
            Name = "beef";
        }

        public override string GetName()
        {
            return Name;
        }
    }
}