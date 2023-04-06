using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models;

namespace WebApplication1.FluentApi
{
    public class ImageGalleryConfigration : IEntityTypeConfiguration<ImageGalleryModel>
    {
        public void Configure(EntityTypeBuilder<ImageGalleryModel> builder)
        {
            builder.ToTable("ImageGallery");
            builder.HasKey(x => x.Id);
        }
    }
}
