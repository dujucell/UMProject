﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using UMRecruiteeWebsite.Models;
using UMRecruiteeWebsite.Service.Interface;

namespace UMRecruiteeWebsite.Service.Plugin
{
    public class SkillSvcEFImpl : ISkillSvc
    {
        public List<Skill> selectAllSkill()
        {
            RecruiteeBankContext db = new RecruiteeBankContext();

            try
            {
                return db.Database.SqlQuery(typeof(Skill), "dbo.SelectAllSkill").Cast<Skill>().ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Skill selectSkillById(Skill obj)
        {
            RecruiteeBankContext db = new RecruiteeBankContext();

            try
            {

                return db.Skills.SqlQuery("dbo.SelectSkillById @SkillId='" + obj.SkillId.ToString() + "'").Single();
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public Boolean insertSkill(Skill obj)
        {
            using (RecruiteeBankContext db = new RecruiteeBankContext())
            {
                try
                {
                    db.Skills.Add(obj);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }

        public Boolean updateSkill(Skill obj)
        {
            using (RecruiteeBankContext db = new RecruiteeBankContext())
            {
                try
                {
                    Skill skill = db.Skills.SqlQuery("dbo.SelectSkillById @Skill='" + obj.SkillId.ToString() + "'").Single();

                    if (skill != null)
                    {
                        skill.SkillName = obj.SkillName;
                        skill.SkillDescription = obj.SkillDescription;

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

        public Boolean deleteSkill(Skill obj)
        {
            using (RecruiteeBankContext db = new RecruiteeBankContext())
            {
                try
                {
                    Skill skill = db.Skills.SqlQuery("dbo.SelectSkillById @SkillId='" + obj.SkillId.ToString() + "'").Single();

                    if (skill != null)
                    {
                        db.Skills.Remove(skill);
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
