﻿namespace eOrder.CORE.Requests
{
    public class UserRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string PasswordConfirmed { get; set; }
        public int? CityId { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
