// Models.cs

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TicketTrackingSystem.Server.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required]
        public string? Username { get; set; }
        public UserRole Role { get; set; }
    }

    public enum UserRole
    {
        QA,
        RD,
        PM,
        Administrator
    }

    public class Ticket
    {
        public int TicketId { get; set; }
        [Required]
        public string? Summary { get; set; }
        public string? Description { get; set; }
        public TicketType Type { get; set; }
        public TicketStatus Status { get; set; }
        public User? CreatedBy { get; set; }
        public User? ResolvedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ResolvedAt { get; set; }
    }

    public enum TicketType
    {
        Bug,
        FeatureRequest,
        TestCase
    }

    public enum TicketStatus
    {
        Open,
        InProgress,
        Resolved,
        Closed
    }
}
