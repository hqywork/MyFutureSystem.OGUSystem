/**********************************************************************************************************************
 * 变更历史：
 *      作者：张奇  时间：2016年11月17日	新建
 * 
 *********************************************************************************************************************/

using HQY.FutureOGU.DomainModel.DataDictionary;
using HQY.FutureOGU.EfSqlserver.DataDictionary;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HQY.FutureOGU.EfSqlserver
{
    /// <summary>
    /// 组织机构人员数据库访问上下文。
    /// </summary>
    public class OguContext : DbContext
    {
        #region Entities

        /// <summary>
        /// 数据字典类别。
        /// </summary>
        public DbSet<DDCategoryModel> ParaCategories { get; set; }

        #endregion

        #region Member of DbContext

        /// <summary>
        /// 
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            DDModelMapping.Mapping(modelBuilder);
        }

        #endregion
    }
}
