﻿/**********************************************************************************************************************
 * 变更历史：
 *      作者：张奇  时间：2016年11月17日	新建
 * 
 *********************************************************************************************************************/

namespace HQY.FutureOGU.Infrastructure.DomainModel
{
    /// <summary>
    /// 包含了对象排序属性的接口。
    /// </summary>
    public interface IObjectSort
    {
        #region Properties

        /// <summary>
        /// 对象在集合中排序因子，一般是一个大于零的整数。
        /// </summary>
        int Sort { get; set; }

        #endregion
    }
}
