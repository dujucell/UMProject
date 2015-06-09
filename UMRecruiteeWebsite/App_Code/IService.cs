using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using UMRecruiteeWebsite.DomainDTO;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{

    #region Category
    [OperationContract]
    List<CategoryDto> selectAllCategory();

    [OperationContract]
    CategoryDto selectCategoryById(CategoryDto obj);

    [OperationContract]
    Boolean insertCategory(CategoryDto obj);

    [OperationContract]
    Boolean updateCategory(CategoryDto obj);

    [OperationContract]
    Boolean deleteCategory(CategoryDto obj);

    #endregion

    #region Ranking
    [OperationContract]
    List<RankingDto> selectAllRanking();

    [OperationContract]
    RankingDto selectRankingById(RankingDto obj);

    [OperationContract]
    Boolean insertRanking(RankingDto obj);

    [OperationContract]
    Boolean updateRanking(RankingDto obj);

    [OperationContract]
    Boolean deleteRanking(RankingDto obj);

    #endregion

    #region Recruitee

    [OperationContract]
    List<RecruiteeDto> selectAllRecruitee();

    [OperationContract]
    RecruiteeDto selectRecruiteeById(RecruiteeDto obj);

    [OperationContract]
    Boolean insertRecruitee(RecruiteeDto obj);

    [OperationContract]
    Boolean updateRecruitee(RecruiteeDto obj);

    [OperationContract]
    Boolean deleteRecruitee(RecruiteeDto obj);

    #endregion

    #region Skill
    [OperationContract]
    List<SkillDto> selectAllSkill();

    [OperationContract]
    SkillDto selectSkillById(SkillDto obj);

    [OperationContract]
    Boolean insertSkill(SkillDto obj);

    [OperationContract]
    Boolean updateSkill(SkillDto obj);

    [OperationContract]
    Boolean deleteSkill(SkillDto obj);

    #endregion

}
