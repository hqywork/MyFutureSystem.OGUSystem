/**********************************************************************************************************************
 * 变更历史：
 *      作者：张奇  时间：2016年11月17日	新建
 * 
 *********************************************************************************************************************/

namespace HQY.FutureOGU.Infrastructure.DomainModel
{
    /// <summary>
    /// 表示由代码-名称-描述-值构成的对象。
    /// </summary>
    /// <typeparam name="T">对象唯一 ID 的类型。</typeparam>
    public interface ICodeNameValueObject<T> : IObject<T>
    {
        #region Properties

        /// <summary>
        /// 对象代码。
        /// </summary>
        string Code { get; set; }

        /// <summary>
        /// 对象描述。
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// 对象名称。
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// 对象值。
        /// </summary>
        string Value { get; set; }

        #endregion
    }
}
