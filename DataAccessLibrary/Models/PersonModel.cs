namespace DataAccessLibrary.Models
{
    public class PersonModel
    {
        internal object personId;
        
        public int PersonId { get; set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
    }
}