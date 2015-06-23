using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using UMRecruiteeWebsite.Business;
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

        public Boolean addSkillToRecruitee(Recruitee obj, Skill skill)
        {
            obj.Skills.Add(skill);
            using (RecruiteeBankContext db = new RecruiteeBankContext())
            {
                try
                {
                    Recruitee recruitee = db.Recruitees.SqlQuery("dbo.SelectRecruiteeById @RecruiteeId='" + obj.RecruiteeId.ToString() + "'").Single();

                    if (recruitee != null)
                    {
                        if (obj.Skills != null)
                        {
                            foreach (Skill ski in obj.Skills)
                            {                                
                                recruitee.Skills.Add(db.Skills.SqlQuery("dbo.SelectSkillById @SkillId='" + ski.SkillId.ToString() + "'").Single());
                            }
                        }

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


        //public void addSkillToRecruitee(System.Guid RecruiteeId, String SkillId)
        //{
        //    RecruiteeManager rmgr = new RecruiteeManager();
        //    SkillManager skmgr = new SkillManager();
        //    Recruitee robj = Recruitee.createRecruitee(RecruiteeId, null);
        //    Recruitee rec = rmgr.selectRecruiteeById(robj);
        //    Skill sobj = Skill.createSkill(SkillId, null, null);
        //    Skill ski = skmgr.selectSkillById(sobj);
        //    rec.Skills.Add(ski);
        //    rmgr.updateRecruitee(rec);
        //}


    }
}
