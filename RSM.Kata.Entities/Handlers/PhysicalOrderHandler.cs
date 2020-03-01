using System;
using System.Collections.Generic;
using System.Text;
using Data.Entities;
using RSM.Kata.Core.Entities;

namespace RSM.Kata.Core.Handlers
{
    public class PhysicalProductOrderHandler : IOrderHandler

    {
        private IOrder _order;
        public PhysicalProductOrderHandler(IOrder order)
        {
            _order = order;
        }

        public void ProcessOrder()
        {
            //GeneratePackingSlip(this);
            //GenerateAgentCommision(this);
        }
    }
}
