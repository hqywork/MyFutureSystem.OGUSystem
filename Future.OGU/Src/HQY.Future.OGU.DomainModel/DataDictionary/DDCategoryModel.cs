/**********************************************************************************************************************
 * 变更历史：
 *      作者：张奇  时间：2016年11月17日	新建
 *      作者：张奇  时间：2016年12月08日	使用抽象后的基础实体模型进行重构
 * 
 *********************************************************************************************************************/

using System;
using System.Collections.Generic;
using HQY.Future.Infrastructure.Domain.EntityModel;

namespace HQY.Future.OGU.DomainModel.DataDictionary
{
    /// <summary>
    /// 数据字典类别模型。
    /// </summary>
    public sealed class DDCategoryModel : EntityModelOfGuid, IChildEntityModelOfGuid<DDItemModel>, ICnvOfEntityModel, IStateOfEntityModel, ITimeOfEntityModel
    {
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

        #region Implementation of IStateOfEntityModel

        /// <summary>状态。</summary>
        public int State { get; set; }

        #endregion

        #region Implementation of ITimeOfEntityModel

        /// <summary>创建时间。</summary>
        public DateTime CreateTime { get; set; }

        /// <summary>最后修改时间。</summary>
        public DateTime ModifyTime { get; set; }

        #endregion

        #region Implementation of IChildEntityModelOfGuid<DDItemModel>

        /// <summary>包含了子实体的集合。</summary>
        public ICollection<DDItemModel> Children { get; set; }

        /// <summary>子实体的数量。</summary>
        public long CountOfChild { get; set; }

        #endregion
    }
}
