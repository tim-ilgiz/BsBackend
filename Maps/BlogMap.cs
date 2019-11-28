using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bsbackend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace bsbackend.Maps
{
    public class BlogMap
    {
        public BlogMap(EntityTypeBuilder<Blog> entityBuilder)
        {
            //Таблицы и столбцы Postgres находятся в нижнем регистре, а наши классы C # - в PascalCase, мы должны сопоставить имя и свойства таблицы с нашей моделью.
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.ToTable("blog");

            entityBuilder.Property(x => x.Id).HasColumnName("id");
            entityBuilder.Property(x => x.Name).HasColumnName("name");
        }
    }
}
