namespace WebApplication1.Models.EventEntity
{
    public class Event
    {
            public Guid Id { get; set; }     // Primary Key
            public string Title { get; set; }
            public string Description { get; set; }
            public string Location { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime? EndDate { get; set; }  // optional
            public string Category { get; set; }    // e.g. "School Event", "Exam", "Holiday"
        }

    }

