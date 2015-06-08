using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using UMRecruiteeWebsite.Models;
using UMRecruiteeWebsite.Service.Interface;

namespace UMRecruiteeWebsite.Service.Plugin
{
    public class RecruiteeSvcEFImpl : IRecruiteeSvc
    {
        public List<Recruitee> selectAllRecruitee()
        {
            RecruiteeBankContext db = new RecruiteeBankContext();

            try
            {
                return db.Database.SqlQuery(typeof(Recruitee), "dbo.SelectAllRecruitee").Cast<Recruitee>().ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Recruitee selectRecruiteeById(Recruitee obj)
        {
            RecruiteeBankContext db = new RecruiteeBankContext();

            try
            {

                return db.Recruitees.SqlQuery("dbo.SelectRecruiteeById @RecruiteeId='" + obj.RecruiteeId.ToString() + "'").Single();
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public Boolean insertRecruitee(Recruitee obj)
        {
            using (RecruiteeBankContext db = new RecruiteeBankContext())
            {
                try
                {
                    db.Recruitees.Add(obj);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }

        public Boolean updateRecruitee(Recruitee obj)
        {
            using (RecruiteeBankContext db = new RecruiteeBankContext())
            {
                try
                {

                    Recruitee recruitee = db.Recruitees.SqlQuery("dbo.SelectRecruiteeById @RecruiteeId='" + obj.RecruiteeId.ToString() + "'").Single();

                    if (recruitee != null)
                    {
                        recruitee.RankingId = obj.RankingId;

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

        public Boolean deleteRecruitee(Recruitee obj)
        {
            using (RecruiteeBankContext db = new RecruiteeBankContext())
            {
                try
                {
                    Recruitee recruitee = db.Recruitees.SqlQuery("dbo.SelectRecruiteeById @RecruiteeId='" + obj.RecruiteeId.ToString() + "'").Single();

                    if (recruitee != null)
                    {
                        db.Recruitees.Remove(recruitee);
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
