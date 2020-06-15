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
            db.SaveChanges();
        }
    }
}
