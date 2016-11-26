/**********************************************************************************************************************
 * 变更历史：
 *      作者：张奇  时间：2016年11月17日	新建
 * 
 *********************************************************************************************************************/

namespace HQY.FutureOGU.Infrastructure.DomainModel
{
    /// <summary>
    /// 包含了对象的一般属性的接口。
    /// </summary>
    /// <typeparam name="T">对象唯一 ID 的类型。</typeparam>
    public interface IObject<T>
    {
        #region Properties

        /// <summary>
        /// 对象的唯一 ID。
        /// </summary>
        T Id { get; set; }

        #endregion
    }
}
