namespace NewsletterAppMVC.Models
{
    public class NewsletterSignUps
    {
        public int Id { get; set; } 
        public string FirstName { get; set; }       
        public string LastName { get; set; }    

        public string EmailAddress {  get; set; }

        public string SocialSecurityNumber { get; set; }
    }
}
