/**********************************************************************************************************************
 * 变更历史：
 *      作者：张奇  时间：2016年11月17日	新建
 * 
 *********************************************************************************************************************/

using System;
using System.Collections.Generic;
using HQY.FutureOGU.Infrastructure.DomainModel;

namespace HQY.FutureOGU.DomainModel.DataDictionary
{
    /// <summary>
    /// 数据字典类别模型。
    /// </summary>
    public sealed class DDCategoryModel : ICodeNameValueObject<Guid>, IObjectState, IObjectTime
    {
        #region Properties

        /// <summary>
        /// 此类别下的所有数据字典项组成的集合。
        /// </summary>
        public IEnumerable<DDItemModel> ParaItems { get; set; }

        #endregion

        #region Implementation of IObject<Guid>

        /// <summary>
        /// 类别的唯一标识。
        /// </summary>
        public Guid Id { get; set; }

        #endregion

        #region Implementation of ICodeNameValueObject<Guid>

        /// <summary>
        /// 类别代码。不能同时存在多个相同代码的类别。
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 类别描述。
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 类别名称。不能同时存在多个相同名称的类别。
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 类别值。
        /// </summary>
        public string Value { get; set; }

        #endregion

        #region Implementation of IObjectState

        /// <summary>
        /// 类别的状态。1-表示可由用户维护；0-表示不能由用户维护。
        /// </summary>
        public int State { get; set; }

        #endregion

        #region Implementation of IObjectTime

        /// <summary>
        /// 类别的创建时间。
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 类别的最后修改时间。
        /// </summary>
        public DateTime ModifyTime { get; set; }

        #endregion
    }
}
