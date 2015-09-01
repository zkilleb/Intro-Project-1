namespace Checks
{
    class Tally
    {
        private int checkNumber = 3001;
        private int totalAmount = 0;

        public string getCheckNumber()
        {
            return (this.checkNumber).ToString();
        }
        public string getTotalAmount()
        {
            return (this.totalAmount).ToString();
        }
        public void addCheckNumber()
        {
            this.checkNumber++;
        }
        public void addTotalAmount(int amount)
        {
            this.totalAmount += amount;
        }
    }
}
