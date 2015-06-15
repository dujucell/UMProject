﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using UMRecruiteeWebsite.Business;
using UMRecruiteeWebsite.DomainDTO;
using UMRecruiteeWebsite.Models;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
public class ServiceWCF : IServiceWCF
{
    #region Category
 
    public List<CategoryDto> selectAllCategory()
    {
        CategoryManager mgr = new CategoryManager();
        List<Category> catList = mgr.selectAllCategory();
        List<CategoryDto> dtoList = new List<CategoryDto>();

        foreach (Category cat in catList)
        {
            dtoList.Add(CategoryDto.createCategoryDTO(cat));
        }

        return dtoList;
    }

    public CategoryDto selectCategoryById(CategoryDto dto)
    {
        CategoryManager mgr = new CategoryManager();
        Category obj = new Category();
        obj.CategoryId = dto.CategoryId;
        obj = mgr.selectCategoryById(obj);
        if (obj != null)
        {
            return CategoryDto.createCategoryDTO(obj);
        }
        else
        {
            return null;
        }
    }

    public Boolean insertCategory(CategoryDto dto)
    {
        Category obj = Category.createCategory(dto.CategoryId, dto.CategoryName, dto.CategoryDescription); 
        CategoryManager mgr = new CategoryManager();
        return mgr.insertCategory(obj);
    }
    
    public Boolean updateCategory(CategoryDto dto)
    {
        Category obj = Category.createCategory(dto.CategoryId, dto.CategoryName, dto.CategoryDescription);
        CategoryManager mgr = new CategoryManager();
        return mgr.updateCategory(obj);
    }

    public Boolean deleteCategory(CategoryDto dto)
    {
        Category obj = Category.createCategory(dto.CategoryId, dto.CategoryName, dto.CategoryDescription);
        CategoryManager mgr = new CategoryManager();
        return mgr.deleteCategory(obj);
    }

    #endregion  

    #region Ranking

    public List<RankingDto> selectAllRanking()
    {
        RankingManager mgr = new RankingManager();
        List<Ranking> ranList = mgr.selectAllRanking();
        List<RankingDto> dtoList = new List<RankingDto>();

        foreach (Ranking ran in ranList)
        {
            dtoList.Add(RankingDto.createRankingDTO(ran));
        }

        return dtoList;
    }

    public RankingDto selectRankingById(RankingDto dto)
    {
        RankingManager mgr = new RankingManager();
        Ranking obj = new Ranking();
        obj.RankingId = dto.RankingId;
        obj = mgr.selectRankingById(obj);
        if (obj != null)
        {
            return RankingDto.createRankingDTO(obj);
        }
        else
        {
            return null;
        }
    }

    public Boolean insertRanking(RankingDto dto)
    {
        Ranking obj = Ranking.createRanking(dto.RankingId, dto.RankingName);
        RankingManager mgr = new RankingManager();
        return mgr.insertRanking(obj);
    }

    public Boolean updateRanking(RankingDto dto)
    {
        Ranking obj = Ranking.createRanking(dto.RankingId, dto.RankingName);
        RankingManager mgr = new RankingManager();
        return mgr.updateRanking(obj);
    }

    public Boolean deleteRanking(RankingDto dto)
    {
        Ranking obj = Ranking.createRanking(dto.RankingId, dto.RankingName);
        RankingManager mgr = new RankingManager();
        return mgr.deleteRanking(obj);
    }

    #endregion

    #region Recruitee

    public List<RecruiteeDto> selectAllRecruitee()
    {
        RecruiteeManager mgr = new RecruiteeManager();
        List<Recruitee> recList = mgr.selectAllRecruitee();
        List<RecruiteeDto> dtoList = new List<RecruiteeDto>();

        foreach (Recruitee rec in recList)
        {
            dtoList.Add(RecruiteeDto.createRecruiteeDTO(rec));
        }

        return dtoList;
    }

    public RecruiteeDto selectRecruiteeById(RecruiteeDto dto)
    {
        RecruiteeManager mgr = new RecruiteeManager();
        Recruitee obj = new Recruitee();
        obj.RecruiteeId = dto.RecruiteeId;
        obj = mgr.selectRecruiteeById(obj);

        if (obj != null)
        {
            return RecruiteeDto.createRecruiteeDTO(obj);
        }
        else
        {
            return null;
        }
    }

    public Boolean insertRecruitee(RecruiteeDto dto)
    {
        Recruitee obj = Recruitee.createRecruitee(dto.RecruiteeId, dto.RankingId);
        RecruiteeManager mgr = new RecruiteeManager();
        return mgr.insertRecruitee(obj);
    }

    public Boolean updateRecruitee(RecruiteeDto dto)
    {
        Recruitee obj = Recruitee.createRecruitee(dto.RecruiteeId, dto.RankingId);
        RecruiteeManager mgr = new RecruiteeManager();
        return mgr.updateRecruitee(obj);
    }

    public Boolean deleteRecruitee(RecruiteeDto dto)
    {
        Recruitee obj = Recruitee.createRecruitee(dto.RecruiteeId, dto.RankingId);
        RecruiteeManager mgr = new RecruiteeManager();
        return mgr.deleteRecruitee(obj);
    }

    #endregion

    #region Skill

    public List<SkillDto> selectAllSkill()
    {
        SkillManager mgr = new SkillManager();
        List<Skill> skillList = mgr.selectAllSkill();
        List<SkillDto> dtoList = new List<SkillDto>();

        foreach (Skill skill in skillList)
        {
            dtoList.Add(SkillDto.createSkillDTO(skill));
        }

        return dtoList;
    }

    public SkillDto selectSkillById(SkillDto dto)
    {
        SkillManager mgr = new SkillManager();
        Skill obj = new Skill();
        obj.SkillId = dto.SkillId;
        obj = mgr.selectSkillById(obj);

        if (obj != null)
        {
            return SkillDto.createSkillDTO(obj);
        }
        else
        {
            return null;
        }
    }

    public Boolean insertSkill(SkillDto dto)
    {
        Skill obj = Skill.createSkill(dto.SkillId, dto.SkillName, dto.SkillDescription);
        SkillManager mgr = new SkillManager();
        return mgr.insertSkill(obj);
    }

    public Boolean updateSkill(SkillDto dto)
    {
        Skill obj = Skill.createSkill(dto.SkillId, dto.SkillName, dto.SkillDescription);
        SkillManager mgr = new SkillManager();
        return mgr.updateSkill(obj);
    }

    public Boolean deleteSkill(SkillDto dto)
    {
        Skill obj = Skill.createSkill(dto.SkillId, dto.SkillName, dto.SkillDescription);
        SkillManager mgr = new SkillManager();
        return mgr.deleteSkill(obj);
    }
    
    #endregion
   
}
