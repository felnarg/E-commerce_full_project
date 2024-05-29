using Domain.Enums;

namespace Domain
{
    public class User
    {
        public string? UserId { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? FullName { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public bool? IsActive { get; set; }
        public string? ShippingAddress { get; set; }
        public string? PhoneNumber { get; set; }
        public PaymentType? PreferredPaymentMethod { get; set; }
        
    }
}
