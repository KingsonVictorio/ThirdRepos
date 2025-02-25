using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ticketing
{
    public class TicketPrice
    {
        private int section;
        private int quantity;
        private bool discount;
        private int discountType;
        private decimal amountDue;
        private decimal mPrice;
        private decimal mdecDiscount;

        const decimal mdecBalcony = 35.5m;
        const decimal mdecGeneral = 28.75m;
        const decimal mdecBox = 62.0m;

        private int Section
        {
            get { return section; }
            set { section = value; }
        }

         private int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

         private bool Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        private int DiscountType
        {
            get { return discountType; }
            set { discountType = value; }
        }

         public decimal AmountDue
        {
            get { return amountDue; }
            set { amountDue = value; }
        }

    // Constructor for TicketPrice
    public TicketPrice(int section, int discountType, int quantity, bool discount)
    {
        Section = section;
        DiscountType= discountType;
        Quantity = quantity;
        Discount = discount;
        AmountDue = amountDue;
    }

     public void calculatePrice()
     {

         switch (section)
         {
             case 1:
                 mPrice = mdecBalcony;
                 break;
             case 2:
                 mPrice = mdecGeneral;
                 break;
             case 3:
                 mPrice = mdecBox;
                 break;
         }
         if (discount)
         {      switch(DiscountType)
                {
                    case 1:
                        mdecDiscount = 5.0m;
                        break;
                    case 2:
                        mdecDiscount = 10.0m;
                        break;
                }
                mPrice -= mdecDiscount; 
         }

         AmountDue = mPrice * quantity;

     }
    }
}
