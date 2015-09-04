using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checks
{
    class InputProcessor
    {
        // String arrays for Words used in the conversion function
        private String[] ones = {"Zero","One","Two","Three","Four",
            "Five","Six","Seven","Eight","Nine","Ten",
            "Eleven","Twelve","Thirteen","Fourteen","Fifteen",
            "Sixteen","Seventeen","Eighteen","Nineteen"};
        private String[] tens = {"","","Twenty","Thirty","Forty","Fifty",
            "Sixty","Seventy","Eighty","Ninety"};

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
            tally.addTotalAmount(double.Parse(checkAmount));
        }
        public string checkAmountToString(string value)
        {
            return convert(double.Parse(checkAmount));
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
        // Recursive Function
        public String convert(double i) {
            if (i < 1) return " and " + i + "/100";
            if (i < 20) return ones[(int)i];
            if (i < 100) return tens[(int)i / 10] + ((i % 10 > 0) ? " " + convert(i % 10) : "");
            if (i < 1000) return ones[(int)i / 100] + " Hundred" + ((i % 100 > 0) ? " and " + convert(i % 100) : "");
            if (i < 1000000) return convert(i / 1000) + " Thousand " + ((i % 1000 > 0) ? " " + convert(i % 1000) : "");
            return convert(i / 1000000) + " Million " + ((i % 1000000 > 0) ? " " + convert(i % 1000000) : "");
        }
    }
}
