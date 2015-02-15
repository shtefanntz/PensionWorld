namespace PensionWorld.Domain.MasterData
{
    public class Contact
    {
        public Address Address { get; set; }

        public string[] PhoneNumbers { get; set; }

        public string[] EmailAddresses { get; set; }
    }
}