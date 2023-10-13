using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_ClassWork_7{

        internal class Money
        {
            public string name_ { get; set; } = "Abstract currency";
            public long integer_ { set; get; } = 1;
            int _cents;
            Money() { }
        //public Money(string name, double money_double): this(name, (int)money_double, (100*(int)(money_double - Convert.ToDouble((int)(money_double))))) {}
        public Money(string name, double money_double) : this(name, (int)money_double, ((int)(money_double*100))%100) { }
        public Money(string name, long integer, int cents)
            {
                name_ = name;
                integer_ = integer + cents / 100;
                _cents = cents % 100;
            }
            public int cents_
            {
                get { return _cents; }
                set
                {
                    _cents = value % 100;
                    integer_ += value / 100;
                }
            }
            public void COUT()
            {
                Console.Write(integer_ + (double)(_cents) / 100 + " " + name_);

            }
            public override string ToString()
            {
                //return (Math.Round((integer_ + (double)(_cents) / 100), 2) + " " + name_).ToString().PadLeft(4);
                return (Math.Round((integer_ + (double)(_cents) / 100), 2) + " " + name_);
            }
            static public Money operator +(Money a, Money b)
            {
                if (a.name_ != b.name_) throw new ArgumentException("Cannot operate: different currencies");
                return new Money(a.name_, a.integer_ + b.integer_, a._cents + b._cents);
            }
        double Absolute()
        {
            return ((double)(integer_) + (double)(cents_)/100);
}

        static public Money operator -(Money a, Money b)
        {
            if (a.name_ != b.name_) throw new ArgumentException("Cannot operate: different currencies");

            if (a.Absolute() - b.Absolute() < 0) throw new Exception("Bankrote");

            return new Money(a.name_, (a.Absolute() - b.Absolute()));
        }
        static public Money operator /(Money a, int denum)
        {
            return new Money(a.name_, a.Absolute()/denum);
        }
        static public Money operator /(int denum, Money a)
        {
            return new Money(a.name_, a.Absolute() / denum);
        }

        static public Money operator *(Money a, int num)
        {
            return new Money(a.name_, a.Absolute() * num);
        }
        static public Money operator *(int num, Money a)
        {
            return new Money(a.name_, a.Absolute() * num);
        }

        static public Money operator ++(Money a)
        {
            return new Money(a.name_, a.integer_, ++a._cents);
        }
        static public Money operator --(Money a)
        {
            if (a.Absolute() - 0.01 < 0) throw new Exception("Bankrote");
            return new Money(a.name_, (a.Absolute()-0.01) );
        }

        public static bool operator <(Money a, Money b)
        {
            if (a.name_ != b.name_) throw new ArgumentException("Cannot operate: different currencies");
            return a.Absolute() < b.Absolute();
        }
        public static bool operator >(Money a, Money b)
        {
            if (a.name_ != b.name_) throw new ArgumentException("Cannot operate: different currencies");
            return a.Absolute() > b.Absolute();
        }

        public static bool operator ==(Money a, Money b)
        {
            if (a.name_ != b.name_) throw new ArgumentException("Cannot operate: different currencies");
            return a.Absolute() == b.Absolute();
        }
        public static bool operator !=(Money a, Money b)
        {
            if (a.name_ != b.name_) throw new ArgumentException("Cannot operate: different currencies");
            return a.Absolute() != b.Absolute();
        }

    }
    }
