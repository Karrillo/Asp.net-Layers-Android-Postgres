﻿using SantaMarta.Data.Models.SubCategories;
using SantaMarta.DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SantaMarta.DataAccess.SubCategoryAccess
{
    public class SubCategoryAccess
    {
        ContextDb db = new ContextDb();

        public List<SubCategories> GetAll()
        {
            List<SubCategories> subCategories = db.View_SubCategories().ToList();
            return subCategories;
        }

        public SubCategories GetById(int id)
        {
            return db.View_SubCategory(id);
        }

        public int Update(SubCategories subcaterory)
        {
            return db.Update_SubCategory(subcaterory);
        }

        public int Create(SubCategories subcaterory)
        {
            return db.Insert_SubCategory(subcaterory);
        }

        public int Delete(int id)
        {
            return db.Delete_SubCategory(id);
        }
    }
}
