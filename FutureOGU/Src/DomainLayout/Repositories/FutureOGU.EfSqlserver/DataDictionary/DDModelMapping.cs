/**********************************************************************************************************************
 * 变更历史：
 *      作者：张奇  时间：2016年11月17日	新建
 * 
 *********************************************************************************************************************/

using HQY.FutureOGU.DomainModel.DataDictionary;
using Microsoft.EntityFrameworkCore;

namespace HQY.FutureOGU.EfSqlserver.DataDictionary
{
    /// <summary>
    /// 数据字典模型映射策略。
    /// </summary>
    internal sealed class DDModelMapping
    {
        #region Fields

        private readonly ModelBuilder _builder;

        #endregion

        #region Constructors

        private DDModelMapping(ModelBuilder builder)
        {
            this._builder = builder;
        }


        #endregion

        #region Private's Methods

        /// <summary>
        /// 进行 <see cref="DDCategoryModel"/> 的映射。
        /// </summary>
        private void DDCategoryMapping()
        {
            var metadata = this._builder.Entity<DDCategoryModel>().ToTable("DDCategory");

            metadata.HasKey(entity => entity.Id)
                    .ForSqlServerIsClustered()
                    .ForSqlServerHasName("PK_DDCategory_Id");
            metadata.Property(c => c.Id)
                    .ValueGeneratedOnAdd();

            metadata.Property(c => c.Code)
                    .IsRequired()
                    .HasMaxLength(32);
            metadata.Property(c => c.Name)
                    .IsRequired()
                    .HasMaxLength(64);
            metadata.Property(c => c.Description).HasMaxLength(255);
            metadata.Property(c => c.Value).HasMaxLength(255);
            metadata.Property(c => c.State).IsRequired();
            metadata.Property(c => c.CreateTime)
                    .ValueGeneratedOnAdd();
            metadata.Property(c => c.ModifyTime)
                    .ValueGeneratedOnAddOrUpdate();

            metadata.HasMany(p => p.ParaItems)
                    .WithOne(f => f.ParaCategory)
                    .HasForeignKey(f=>f.CategoryId)
                    .HasConstraintName("FK_DDItem_CategoryId")
                    .IsRequired();

        }

        /// <summary>
        /// 进行 <see cref="DDItemModel"/> 的映射。
        /// </summary>
        private void DDItemModelMapping()
        {
            var metadata = this._builder.Entity<DDItemModel>().ToTable("DDItem");

            metadata.HasKey(entity => entity.Id)
                    .ForSqlServerIsClustered()
                    .ForSqlServerHasName("PK_DDItem_Id");
            metadata.Property(c => c.Id)
                    .ValueGeneratedOnAdd();

            metadata.Property(c => c.Code)
                    .IsRequired()
                    .HasMaxLength(32);
            metadata.Property(c => c.Name)
                    .IsRequired()
                    .HasMaxLength(64);
            metadata.Property(c => c.Description).HasMaxLength(255);
            metadata.Property(c => c.Value).HasMaxLength(255);
            metadata.Property(c => c.CreateTime)
                    .ValueGeneratedOnAdd();
            metadata.Property(c => c.ModifyTime)
                    .ValueGeneratedOnAddOrUpdate();

            metadata.Property(c => c.Sort).IsRequired();
            metadata.Property(c => c.CategoryId).IsRequired();
        }

        #endregion

        /// <summary>
        /// 进行 Fluent API 映射。
        /// </summary>
        /// <param name="builder">ORM 关系构建器。</param>
        public static void Mapping(ModelBuilder builder)
        {
            var mapping = new DDModelMapping(builder);
            mapping.DDCategoryMapping();
            mapping.DDItemModelMapping();
        }
    }
}
