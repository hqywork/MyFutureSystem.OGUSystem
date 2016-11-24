/**********************************************************************************************************************
 * 变更历史：
 *      作者：张奇  时间：2016年11月17日	新建
 * 
 *********************************************************************************************************************/

namespace HQY.FutureOGU.Infrastructure.DomainModel
{
    /// <summary>
    /// 包含了对象版本属性的接口。
    /// </summary>
    public interface IObjectVersion
    {
        #region Properties

        /// <summary>
        /// 对象的当前版本。
        /// </summary>
        string Version { get; }

        #endregion
    }
}
