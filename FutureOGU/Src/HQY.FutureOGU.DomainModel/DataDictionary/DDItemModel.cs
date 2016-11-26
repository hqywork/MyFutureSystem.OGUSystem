/**********************************************************************************************************************
 * 变更历史：
 *      作者：张奇  时间：2016年11月17日	新建
 * 
 *********************************************************************************************************************/

using System;
using HQY.FutureOGU.Infrastructure.DomainModel;

namespace HQY.FutureOGU.DomainModel.DataDictionary
{
    /// <summary>
    /// 数据字典项模型。
    /// </summary>
    public sealed class DDItemModel : ICodeNameValueObject<Guid>, IObjectTime, IObjectSort
    {
        #region Properties

        /// <summary>
        /// 数据字典项的归属类别的唯一标识。
        /// </summary>
        public Guid CategoryId { get; set; }

        /// <summary>
        /// 数据字典项的归属类别模型。
        /// </summary>
        public DDCategoryModel ParaCategory { get; set; }

        #endregion

        #region Implementation of IObject<Guid>

        /// <summary>
        /// 数据字典项的唯一标识。
        /// </summary>
        public Guid Id { get; set; }

        #endregion

        #region Implementation of ICodeNameValueObject<Guid>

        /// <summary>
        /// 数据字典项的代码。
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 数据字典项的描述。
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 数据字典项的名称。
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 数据字典项的值。
        /// </summary>
        public string Value { get; set; }

        #endregion

        #region Implementation of IObjectTime

        /// <summary>
        /// 数据字典项的创建时间。
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 数据字典项的最后修改时间。
        /// </summary>
        public DateTime ModifyTime { get; set; }

        #endregion

        #region Implementation of IObjectSort

        /// <summary>
        /// 数据字典项的逻辑排序因子，一般是一个大于零的整数。
        /// </summary>
        public int Sort { get; set; }

        #endregion
    }
}
