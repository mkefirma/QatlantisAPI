﻿namespace QatlantisAPI.models
{
    public class Customer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public List<Case>? Cases { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }
}