using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Test.Rabbit.Consumer.Database.Models.Organizations;

internal class OrganizationsConfiguration : IEntityTypeConfiguration<OrganizationDb>
{
    public void Configure(EntityTypeBuilder<OrganizationDb> builder)
    {
        // TODO: replace with sql script from resources
        var seedData = Enumerable.Range(1, 9)
            .Select(num => new OrganizationDb
            {
                Id = Guid.Parse($"750F2041-6C70-40FC-8C21-F5DD889A6AD{num}"), 
                Name = $"Organization {num}"
            });
        
        builder.HasData(seedData);
    }
}