using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checks
{
    class InputProcessor
    {
        Tally tally = new Tally();
        private string name;
        private string memo;
        private string checkAmount;

        public string getName()
        {
            return this.name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getMemo()
        {
            return this.memo;
        }
        public void setMemo(string memo)
        {
            this.memo = memo;
        }
        public string getCheckAmount()
        {
            return this.checkAmount;
        }
        public void setCheckAmount(string checkAmount)
        {
            this.checkAmount = checkAmount;
            //Tally takes an int
            tally.addTotalAmount(int.Parse(checkAmount));
        }
        public string checkAmountToString(string value)
        {
            return "Number as string";
        }
        public string getCheckNumber()
        {
            return this.tally.getCheckNumber();
        }
        public string getTotalAmount()
        {
            return this.tally.getTotalAmount();
        }
        public void newCheck()
        {
            tally.addCheckNumber();
        }
    }
}
