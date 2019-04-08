using Sear.it.objectmethod.sa.dao.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sear.it.objectmethod.sear.data.repository.it.objectmethod.sear.models
{
    public class IDaoItems
    {
        private String name;
        private int quantity;
        private int totalprice;

        public String getName()
        {
            return this.name;
        }
        public void setItem(String _name)
        {
            this.name = _name;
        }

        public int getQuantity()
        {
            return this.quantity;
        }
        public void setQuantity(int _quantity)
        {
            this.quantity = _quantity;
        }

        public int getTotalprice()
        {
            return this.totalprice;
        }
        public void setTotalprice(String _item, int _quantity)
        {
            int total = DaoItems.TotalPrice(_quantity, _item);
            this.totalprice = total;
        }
    }
}
