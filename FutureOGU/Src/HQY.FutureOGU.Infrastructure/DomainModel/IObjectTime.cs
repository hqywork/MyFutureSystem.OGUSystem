/**********************************************************************************************************************
 * 变更历史：
 *      作者：张奇  时间：2016年11月16日	新建
 * 
 *********************************************************************************************************************/

using System;

namespace HQY.FutureOGU.Infrastructure.DomainModel
{
    /// <summary>
    /// 包含了对象时间相关属性的接口。
    /// </summary>
    public interface IObjectTime
    {
        #region Properties

        /// <summary>
        /// 对象的创建时间。
        /// </summary>
        DateTime CreateTime { get; set; }

        /// <summary>
        /// 对象的最后修改时间。
        /// </summary>
        DateTime ModifyTime { get; set; }

        #endregion
    }
}
