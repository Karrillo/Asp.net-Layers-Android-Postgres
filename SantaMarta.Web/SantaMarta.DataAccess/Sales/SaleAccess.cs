﻿using SantaMarta.DataAccess.Entity;
using System.Collections.Generic;
using SantaMarta.Data.Models.Sales;
using System;

namespace SantaMarta.DataAccess.SaleAccess
{
    public class SaleAccess
    {
        ContextDb db = new ContextDb();

        public List<Sales> GetAll()
        {
            return null;
        }

        public List<Sales> GetById(Int64 id)
        {
            return null;
        }

        public int Update(Sales user)
        {
            return 0;
        }

        public int Create(Sales sales)
        {
            return db.Insert_Sale(sales);
        }

        public int Delete(Int64 id)
        {
            return db.Delete_Sale(id);
        }
    }
}
