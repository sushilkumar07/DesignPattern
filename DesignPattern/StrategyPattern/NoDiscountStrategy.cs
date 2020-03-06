namespace StrategyPattern
{
    public class NoDiscountStrategy : baseStrategy //base for discount logic (interface)
    {
        //int IStrategy.GetFinalBill(int BillAmount)
        //{
        //    // 
        //    return BillAmount;
        //}
        public override int abstractGetFinalBill(int BillAmount)
        {
            return (int)(BillAmount);// - (BillAmount * 0.5));
        }
        /*
        * we can replace the thing with interface / vice versa we can use  
        */
    }
}
