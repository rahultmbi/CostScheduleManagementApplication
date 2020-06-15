using API.Data;
using System.Linq;

namespace CostManagementAPI.Models
{
    public class DummyData
    {
        public static void Initialize(ApplicationDbContext db)
        {
            if (!db.Contributors.Any())
            {
                db.Contributors.Add(new Contributor
                {
                    ContributorId = 1,
                    Name = "Naresh",
                    Address="Hyderabad",
                    Type="Authour"
                });
                db.Contributors.Add(new Contributor
                {
                    ContributorId = 2,
                    Name = "Rohit",
                    Address="Mumbai",
                    Type="Blogger"
                });
                db.Contributors.Add(new Contributor
                {
                    ContributorId = 3,
                    Name = "Rahul",
                    Address="Bangalore",
                    Type="Authour"
                });
                db.Contributors.Add(new Contributor
                {
                    ContributorId = 4,
                    Name = "Venkata",
                    Address="Chennai",
                    Type="Blogger"
                });
                
            }
            if (!db.Editors.Any())
            {
                db.Editors.Add(new Editor
                {
                    EditorId = 1,
                    Name= "Reddy",
                    Address="Hyderabad"
                });
                db.Editors.Add(new Editor
                {
                    EditorId = 2,
                    Name= "Singh",
                    Address="Hyderabad"
                });
                db.Editors.Add(new Editor
                {
                    EditorId = 3,
                    Name= "Kumar",
                    Address="Hyderabad"
                });
                db.Editors.Add(new Editor
                {
                    EditorId = 4,
                    Name= "Potla",
                    Address="Hyderabad"
                });
            }
            if (!db.RoyaltyTypes.Any())
            {
                db.RoyaltyTypes.Add(new RoyaltyType
                {
                    RoyaltyTypeId = 1,
                    Type= "ROYALTIES PAID ON RETAIL SALES"
                });
                db.RoyaltyTypes.Add(new RoyaltyType
                {
                    RoyaltyTypeId = 2,
                    Type = "ROYALTIES PAID ON NET SALES"
                });
                db.RoyaltyTypes.Add(new RoyaltyType
                {
                    RoyaltyTypeId = 3,
                    Type = "PROFIT SHARING"
                });
            }

            if (!db.Materials.Any())
            {
                db.Materials.Add(new Material
                {
                    MaterialId = 1,
                    CoverType= "Hard cover"
                });
                db.Materials.Add(new Material
                {
                    MaterialId = 2,
                    CoverType= "Paper back"
                });
            }
            if (!db.EditionTypes.Any())
            {
                db.EditionTypes.Add(new EditionType
                {
                    EditionTypeId = 1,
                    Type= "CD"
                });
                db.EditionTypes.Add(new EditionType
                {
                    EditionTypeId = 2,
                    Type= "Book"
                });
            }
            if (!db.SalesTypes.Any())
            {
                db.SalesTypes.Add(new SalesType
                {
                    SalesTypeId = 1,
                    Type= "Competitors"
                });
                db.SalesTypes.Add(new SalesType
                {
                    SalesTypeId = 2,
                    Type= "Suppliers"
                });
                db.SalesTypes.Add(new SalesType
                {
                    SalesTypeId = 3,
                    Type= "Distributors"
                });
            }

            db.SaveChanges();
        }
    }
}
