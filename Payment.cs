namespace inventoryItemApplication
{
    internal class Payment
    {
        public int amount;
        public bool paid;
        public int paymentId;
        public int paymenttotalAmount;
        public string  paymentInventoryName; 
        public string date;

        public Payment()
        {
            this.amount = 0;
            this.paid = false;
        }

        public bool PaymentSuccess(int  amount)
        {
            
            return true;
        }

        public void paymentSuccesful()
        {

            

        }

        public  void  updatepayment()
        {
            
        }

        public  void deletePayment()
        {
            
        }

    }
}