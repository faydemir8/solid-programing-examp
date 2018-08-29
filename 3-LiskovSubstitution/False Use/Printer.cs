using System;
using System.Collections.Generic;
using System.Text;

namespace _3_LiskovSubstitution.False_Use
{
    abstract class BasePrinter
    {
        public abstract void Print(string value);
        public abstract void Scan(string value);
    }

    class HpPrinter : BasePrinter
    {
        public override void Print(string value)
        {
            //işlemler falan 
        }

        public override void Scan(string value)
        {
            throw new NotImplementedException();
        }
    }

    class CanonPrinter : BasePrinter
    {
        public override void Print(string value)
        {
            //işlemler falan 
        }

        public override void Scan(string value)
        {
            //işlemler falan 
        }
    }

    class Printer
    {
        readonly BasePrinter _canonPrinter = new CanonPrinter();
        readonly BasePrinter _hpPrinter = new HpPrinter();

        public void Print(string value)
        {
            //canon için herhangi bir sorun yok  
            _canonPrinter.Print(value);
            _canonPrinter.Scan(value);


            //hp de ise Scan özelliği olmadığından NotImplementedException hatası alacağız 
            _hpPrinter.Print(value);
            _hpPrinter.Scan(value);
        }
       
    }

}
