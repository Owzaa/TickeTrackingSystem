namespace TickeTrackingSystem.Server
{
    // TicketModel
    public class Ticket
    {
        public Guid TicketId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public TicketStatus Status { get; set; }
        public TicketPriority Priority { get; set; }
        public string? Category { get; set; }
        public Guid AssignedUserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? CompletedAt { get; set; }
        public DateTime? ClosedAt { get; set; }

    }

    // TicketStatus
    public enum TicketStatus
    {
        Open,
        InProgress,
        Completed,
        Closed
    }
    
    // TicketPriority
    public enum TicketPriority
    {
        Low,
        Medium,
        High
    }

    // UserModel
    public class User
    {
        public int UserId { get; set; }
        public string? Username { get; set; }
        public UserRole Role { get; set; }

    }

    // UserRoles = QA,RD,PM & Adminstrator
    public enum UserRole
    {
        QA,
        RD,
        PM,
        Administrator
    }

    // BugModel
    public class Bug
    {
        public int BugId { get; set; }
        public string? Summary { get; set; }
        public string? Description { get; set; }
        public required User CreatedBy { get; set; }
        public required User ResolvedBy { get; set; }
    }

}
