using System;
using System.Collections.Generic;
namespace commerce.Request
{
    public class CreateTestDataRequest
    {
        public void Create(int CustomerQuantity, int BasketQuantity)
        {
            Console.WriteLine("Müşteri adedi:" + CustomerQuantity + " " + "Sepet adedi:" + BasketQuantity);
        }
    }
}
