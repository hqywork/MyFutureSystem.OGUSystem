/**********************************************************************************************************************
 * 变更历史：
 *      作者：张奇  时间：2016年11月17日	新建
 * 
 *********************************************************************************************************************/

namespace HQY.FutureOGU.Infrastructure.DomainModel
{
    /// <summary>
    /// 包含了对象备注属性的接口。
    /// </summary>
    public interface IObjectNote
    {
        #region Properties

        /// <summary>
        /// 常规备注。
        /// </summary>
        string Note { get; set; }

        /// <summary>
        /// 第二备注。
        /// </summary>
        string SecondNote { get; set; }

        /// <summary>
        /// 第三备注。
        /// </summary>
        string ThirdNote { get; set; }

        #endregion
    }
}
