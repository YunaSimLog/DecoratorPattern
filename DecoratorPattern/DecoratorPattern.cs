using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class Beverage
    {
        protected string m_strDescription = string.Empty;

        public virtual string GetDescription()
        {
            return m_strDescription;
        }

        public abstract int GetCost();
    }

    public class Espresso : Beverage
    {
        public Espresso()
        {
            m_strDescription = "에스프레소";
        }

        public override int GetCost()
        {
            return 4000;
        }
    }

    public abstract class Decorator : Beverage
    {
        public abstract override string GetDescription();
    }

    public class Milk : Beverage
    {
        Beverage m_CurBeverage;

        public Milk(Beverage CurBeverage)
        {
            m_CurBeverage = CurBeverage;
        }

        public override int GetCost()
        {
            return m_CurBeverage.GetCost() + 1000;
        }

        public override string GetDescription()
        {
            string strCurDescription = m_CurBeverage.GetDescription();
            return strCurDescription + " + 우유";
        }
    }

    public class SoyMilk : Beverage
    {
        Beverage m_CurBeverage;

        public SoyMilk(Beverage CurBeverage)
        {
            m_CurBeverage = CurBeverage;
        }

        public override int GetCost()
        {
            return m_CurBeverage.GetCost() + 1200;
        }

        public override string GetDescription()
        {
            string strCurDescription = m_CurBeverage.GetDescription();
            return strCurDescription + " + 두유";
        }
    }

    public class Mocha : Decorator
    {
        private Beverage m_CurBeverage;

        public Mocha(Beverage CurBeverage)
        {
            m_CurBeverage = CurBeverage;
        }

        public override int GetCost()
        {
            return m_CurBeverage.GetCost() + 1500;
        }

        public override string GetDescription()
        {
            string strCurDescription = m_CurBeverage.GetDescription();
            return strCurDescription + " + 모카";
        }
    }

    public class Cinnamon : Decorator
    {
        Beverage m_CurBeverage;

        public Cinnamon(Beverage _CurBeverage)
        {
            m_CurBeverage = _CurBeverage;
        }

        public override int GetCost()
        {
            return m_CurBeverage.GetCost() + 500;
        }

        public override string GetDescription()
        {
            string strCurDescription = m_CurBeverage.GetDescription();
            return strCurDescription + " + 시나몬";
        }
    }
}
