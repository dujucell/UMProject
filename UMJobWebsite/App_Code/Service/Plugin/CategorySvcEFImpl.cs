﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UMJobWebsite.Models;
using UMJobWebsite.Service.Interface;

namespace UMJobWebsite.Service.Plugin
{
    public class CategorySvcEFImpl : ICategorySvc
    {
        public List<Category> selectAllCategory()
        {
            JobBankContext db = new JobBankContext();

            try 
            {
                return db.Database.SqlQuery(typeof(Category), "dbo.SelectAllCategory").Cast<Category>().ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Category selectCategoryById(Category obj)
        {
            JobBankContext db = new JobBankContext();

            try
            {

                return db.Categories.SqlQuery("dbo.SelectCategoryById @CategoryId='" + obj.CategoryId.ToString() + "'").Single();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Boolean insertCategory(Category obj)
        {
            using (JobBankContext db = new JobBankContext())
            {
                try
                {
                    db.Categories.Add(obj);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }

        public Boolean updateCategory(Category obj)
        {
            using (JobBankContext db = new JobBankContext())
            {
                try
                {

                    Category category = db.Categories.SqlQuery("dbo.SelectCategoryById @CategoryId='" + obj.CategoryId.ToString() + "'").Single();

                    if (category != null)
                    {
                        category.CategoryName = obj.CategoryName;
                        category.CategoryDescription = obj.CategoryDescription;

                        #region Database Submission with Rollback

                        try
                        {
                            db.SaveChanges();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            return false;
                        }
                        #endregion
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }

        public Boolean deleteCategory(Category obj)
        {
            using (JobBankContext db = new JobBankContext())
            {
                try
                {
                    Category category = db.Categories.SqlQuery("dbo.SelectCategoryById @CategoryId='" + obj.CategoryId.ToString() + "'").Single();

                    if (category != null)
                    {
                        db.Categories.Remove(category);
                        #region Database Submission

                        try
                        {
                            db.SaveChanges();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            return false;
                        }

                        #endregion
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
    
    
    
    
    }
}