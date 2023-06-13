namespace WebApi.Models
{
    public class NullContact : IContact
    {
        private NullContact()
        {
            this.Id = 0;
            this.Surname = "nil";
            this.MainName = "nil";
            this.Otch = "nil";
            this.Phone = "0";
            this.Address = "popo";
            this.Caption = "nil";
        }

        static public NullContact Create()
        {
            return new NullContact();
        }
        public int Id { get; set; }
        public string Surname { get; set; }
        public string MainName { get; set; }
        public string Otch { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Caption { get; set; }
    }
}
