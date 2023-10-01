using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Test.Rabbit.Consumer.Database.Models.Organizations;

internal class OrganizationsConfiguration : IEntityTypeConfiguration<OrganizationDb>
{
    public void Configure(EntityTypeBuilder<OrganizationDb> builder)
    {
        var seedData = Enumerable.Range(1, 10)
            .Select(num => new OrganizationDb() { Id = Guid.NewGuid(), Name = $"Organization {num}" });
        
        builder.HasData(seedData);
    }
}