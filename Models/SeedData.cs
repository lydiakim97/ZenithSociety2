//SeedData.cs 

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ZenithWebsite.Models;

namespace ZenithWebsite.Models
{
    public class SeedData
    {
        public static void Initialize(ZenithContext db)
        {

            if (!db.Activities.Any())
            {
                // Activity Seed Data
                db.Activities.Add(new Activity
                {
                    Description = "Senior's Golf Tournament",
                    CreationDate = new DateTime(2017, 03, 04)

                });
                db.Activities.Add(new Activity
                {
                    Description = "Leadership General Assembly Meeting",
                    CreationDate = new DateTime(2017, 03, 04)
                });

                db.Activities.Add(new Activity
                {
                    Description = "Youth Bowling Tournament",
                    CreationDate = new DateTime(2017, 03, 04)
                });

                db.Activities.Add(new Activity
                {
                    Description = "Young ladies cooking lessons",
                    CreationDate = new DateTime(2017, 04, 04)
                });

                db.Activities.Add(new Activity
                {
                    Description = "Youth craft leassons",
                    CreationDate = new DateTime(2017, 04, 04)
                });

                db.Activities.Add(new Activity
                {
                    Description = "Youth choir practice",
                    CreationDate = new DateTime(2017, 04, 04)
                });

                db.Activities.Add(new Activity
                {
                    Description = "Lunch",
                    CreationDate = new DateTime(2017, 05, 04)
                });

                db.Activities.Add(new Activity
                {
                    Description = "Pancake Breakfast",
                    CreationDate = new DateTime(2017, 05, 04)
                });

                db.SaveChanges();

                // Events Seed Data
                db.Events.Add(new Event
                {
                    EventFrom = new DateTime(2017, 03, 27, 8, 30, 0),
                    EventTo = new DateTime(2017, 03, 07, 10, 20, 0),
                    EnteredBy = "a",
                    ActivityId = 1,
                    CreationDate = Convert.ToDateTime("2017/03/01"),
                    IsActive = true
                });

                db.Events.Add(new Event
                {
                    EventFrom = new DateTime(2017, 03, 27, 11, 30, 0),
                    EventTo = new DateTime(2017, 03, 27, 12, 20, 0),
                    EnteredBy = "a",
                    ActivityId = 2,
                    CreationDate = Convert.ToDateTime("2017/03/01"),
                    IsActive = true
                });

                db.Events.Add(new Event
                {
                    EventFrom = new DateTime(2017, 03, 28, 6, 30, 0),
                    EventTo = new DateTime(2017, 03, 28, 10, 20, 0),
                    EnteredBy = "a",
                    ActivityId = 3,
                    CreationDate = Convert.ToDateTime("2017/03/01"),
                    IsActive = true
                });

                db.Events.Add(new Event
                {
                    EventFrom = new DateTime(2017, 03, 29, 12, 30, 0),
                    EventTo = new DateTime(2017, 03, 29, 15, 20, 0),
                    EnteredBy = "a",
                    ActivityId = 4,
                    CreationDate = Convert.ToDateTime("2017/03/01"),
                    IsActive = true
                });

                db.Events.Add(new Event
                {
                    EventFrom = new DateTime(2017, 03, 29, 15, 30, 0),
                    EventTo = new DateTime(2017, 03, 29, 17, 20, 0),
                    EnteredBy = "a",
                    ActivityId = 5,
                    CreationDate = Convert.ToDateTime("2017/03/01"),
                    IsActive = false
                });

                db.Events.Add(new Event
                {
                    EventFrom = new DateTime(2017, 03, 30, 9, 30, 0),
                    EventTo = new DateTime(2017, 03, 30, 10, 20, 0),
                    EnteredBy = "a",
                    ActivityId = 6,
                    CreationDate = Convert.ToDateTime("2017/03/01"),
                    IsActive = true
                });

                db.Events.Add(new Event
                {
                    EventFrom = new DateTime(2017, 03, 31, 14, 30, 0),
                    EventTo = new DateTime(2017, 03, 31, 16, 20, 0),
                    EnteredBy = "a",
                    ActivityId = 7,
                    CreationDate = Convert.ToDateTime("2017/03/01"),
                    IsActive = false
                });

                db.Events.Add(new Event
                {
                    EventFrom = new DateTime(2017, 04, 03, 8, 30, 0),
                    EventTo = new DateTime(2017, 04, 01, 10, 20, 0),
                    EnteredBy = "a",
                    ActivityId = 8,
                    CreationDate = Convert.ToDateTime("2017/03/01"),
                    IsActive = true
                });

                db.Events.Add(new Event
                {
                    EventFrom = new DateTime(2017, 04, 03, 11, 30, 0),
                    EventTo = new DateTime(2017, 04, 01, 14, 20, 0),
                    EnteredBy = "a",
                    ActivityId = 8,
                    CreationDate = Convert.ToDateTime("2017/03/01"),
                    IsActive = true
                });

                db.Events.Add(new Event
                {
                    EventFrom = new DateTime(2017, 04, 03, 15, 30, 0),
                    EventTo = new DateTime(2017, 04, 03, 17, 20, 0),
                    EnteredBy = "a",
                    ActivityId = 7,
                    CreationDate = Convert.ToDateTime("2017/03/01"),
                    IsActive = false
                });

                db.Events.Add(new Event
                {
                    EventFrom = new DateTime(2017, 04, 04, 10, 30, 0),
                    EventTo = new DateTime(2017, 04, 04, 12, 20, 0),
                    EnteredBy = "a",
                    ActivityId = 6,
                    CreationDate = Convert.ToDateTime("2017/03/01"),
                    IsActive = true
                });

                db.Events.Add(new Event
                {
                    EventFrom = new DateTime(2017, 04, 04, 12, 30, 0),
                    EventTo = new DateTime(2017, 04, 04, 14, 20, 0),
                    EnteredBy = "a",
                    ActivityId = 5,
                    CreationDate = Convert.ToDateTime("2017/03/01"),
                    IsActive = false
                });

                db.Events.Add(new Event
                {
                    EventFrom = new DateTime(2017, 04, 04, 16, 30, 0),
                    EventTo = new DateTime(2017, 04, 04, 17, 20, 0),
                    EnteredBy = "a",
                    ActivityId = 4,
                    CreationDate = Convert.ToDateTime("2017/03/01"),
                    IsActive = true
                });

                db.Events.Add(new Event
                {
                    EventFrom = new DateTime(2017, 04, 05, 7, 30, 0),
                    EventTo = new DateTime(2017, 04, 05, 10, 20, 0),
                    EnteredBy = "a",
                    ActivityId = 3,
                    CreationDate = Convert.ToDateTime("2017/03/01"),
                    IsActive = true
                });

                db.Events.Add(new Event
                {
                    EventFrom = new DateTime(2017, 04, 05, 11, 30, 0),
                    EventTo = new DateTime(2017, 04, 05, 14, 20, 0),
                    EnteredBy = "a",
                    ActivityId = 2,
                    CreationDate = Convert.ToDateTime("2017/03/01"),
                    IsActive = true
                });

                db.Events.Add(new Event
                {
                    EventFrom = new DateTime(2017, 04, 07, 11, 30, 0),
                    EventTo = new DateTime(2017, 04, 07, 12, 20, 0),
                    EnteredBy = "a",
                    ActivityId = 1,
                    CreationDate = Convert.ToDateTime("2017/03/01"),
                    IsActive = false
                });

                db.SaveChanges();
            }
        }
    }
}
