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

            if (!db.Imprint.Any())
            {
                db.Imprint.Add(new Imprint
                {
                    ContriutorName = "Ruskin Bond",
                    Title = "The Blue Umbrella",
                    EditorName = "Penguin India",
                    Type ="Rupa Publications",
                    CoverType = "Paperback",
                    ISBN = "9788171673407"
                });
                db.Imprint.Add(new Imprint
                {
                    ContriutorName = "Jawaharlal Nehru",
                    Title = "The Discovery of India ",
                    EditorName = "Penguin India",
                    Type ="Penguin India",
                    CoverType = "Paperback",
                    ISBN = "0143031031"
                });
                db.Imprint.Add(new Imprint
                {
                    ContriutorName = "Salman Rushdie",
                    Title = "Midnight's Children",
                    EditorName = "Rupa Publications",
                    Type ="RHUK",
                    CoverType = "Hardcover",
                    ISBN = "9780099582076"
                });
                db.Imprint.Add(new Imprint
                {
                    ContriutorName = "Aravind Adiga",
                    Title = "The White Tiger",
                    EditorName = "HarperCollins",
                    Type ="HarperCollins",
                    CoverType = "Hardcover",
                    ISBN = "8172238479"
                });
                db.Imprint.Add(new Imprint
                {
                    ContriutorName = "Ruskin Bond",
                    Title = "The Perfect Murder",
                    EditorName = "Rupa Publications",
                    Type ="Rupa Publications",
                    CoverType = "Kindle Edition",
                    ISBN = "B01MY09C7U"
                });
                db.Imprint.Add(new Imprint
                {
                    ContriutorName = "Amish",
                    Title = "The Immortals of Meluha",
                    EditorName = "Westland",
                    Type ="Westland",
                    CoverType = "Paperback",
                    ISBN = "9789380658742"
                });
            }
           
           if (!db.ScheduleTemplates.Any())
            {
                db.ScheduleTemplates.Add(new ScheduleTemplates
                {
                    TemplateName = "Batch A",
                    DateRange = "Jan"
                });
                db.ScheduleTemplates.Add(new ScheduleTemplates
                {
                    TemplateName = "Batch A",
                    DateRange = "Mar"
                });
                db.ScheduleTemplates.Add(new ScheduleTemplates
                {
                    TemplateName = "Batch A",
                    DateRange = "Apr"
                });
                db.ScheduleTemplates.Add(new ScheduleTemplates
                {
                    TemplateName = "Batch A",
                    DateRange = "Aug"
                });

                db.ScheduleTemplates.Add(new ScheduleTemplates
                {
                    TemplateName = "Batch A",
                    DateRange = "Sep"
                });
                db.ScheduleTemplates.Add(new ScheduleTemplates
                {
                    TemplateName = "Batch A",
                    DateRange = "Dec"
                });
            }

             if (!db.RoyaltyTemplates.Any())
            {
                 db.RoyaltyTemplates.Add(new RoyaltyTemplate
                {
                    RoyaltyTemplateName = "Royalty Free Edition",
                    RoyaltyType = "ROYALTIES PAID ON RETAIL SALES",
                });
                
                db.RoyaltyTemplates.Add(new RoyaltyTemplate
                {
                    RoyaltyTemplateName = "Profit Split",
                    RoyaltyType = "PROFIT SHARING",
                });
                 
                db.RoyaltyTemplates.Add(new RoyaltyTemplate
                {
                    RoyaltyTemplateName = "Online Sales Royality",
                    RoyaltyType = "ROYALTIES PAID ON RETAIL SALES",
                });
                
                db.RoyaltyTemplates.Add(new RoyaltyTemplate
                {
                    RoyaltyTemplateName = "Gain Share",
                    RoyaltyType = "PROFIT SHARING",
                });
                 db.RoyaltyTemplates.Add(new RoyaltyTemplate
                {
                    RoyaltyTemplateName = "Gross Revenue Royalty",
                    RoyaltyType = "ROYALTIES PAID ON NET SALES",
                });
                 
            }
            db.SaveChanges();
        }
    }
}
