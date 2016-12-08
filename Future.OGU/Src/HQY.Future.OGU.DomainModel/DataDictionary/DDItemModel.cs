/**********************************************************************************************************************
 * 变更历史：
 *      作者：张奇  时间：2016年11月17日	新建
 *      作者：张奇  时间：2016年12月08日	使用抽象后的基础实体模型进行重构
 * 
 *********************************************************************************************************************/

using System;
using HQY.Future.Infrastructure.Domain.EntityModel;

namespace HQY.Future.OGU.DomainModel.DataDictionary
{
    /// <summary>
    /// 数据字典项模型。
    /// </summary>
    public sealed class DDItemModel : EntityModelOfGuid, IParentEntityModelOfGuid<DDCategoryModel>, ICnvOfEntityModel, ITimeOfEntityModel, ISortOfEntityModel
    {
        #region Implementation of IParentEntityModelOfGuid<DDCategoryModel>

        /// <summary>父实体模型。</summary>
        public DDCategoryModel Parent { get; set; }

        /// <summary>父实体模型的唯一标识。</summary>
        public Guid ParentId { get; set; }

        #endregion

        #region Implementation of ICnvOfEntityModel

        /// <summary>编号。</summary>
        public string Code { get; set; }

        /// <summary>描述。</summary>
        public string Description { get; set; }

        /// <summary>名称。</summary>
        public string Name { get; set; }

        /// <summary>值。</summary>
        public string Value { get; set; }

        #endregion

        #region Implementation of ITimeOfEntityModel

        /// <summary>创建时间。</summary>
        public DateTime CreateTime { get; set; }

        /// <summary>最后修改时间。</summary>
        public DateTime ModifyTime { get; set; }

        #endregion

        #region Implementation of ISortOfEntityModel

        /// <summary>实体的排序因子，一般是一个大于零的整数。</summary>
        public int Sort { get; set; }

        #endregion
    }
}
