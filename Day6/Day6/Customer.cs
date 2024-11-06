namespace Day6
{
    class Customer
    {   
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public Customer(string name, string mobile, string email)
        {
            Name = name;
            Mobile = mobile;
            Email = email;

           
        }
        public override string ToString()
        {
            return $"name is {Name}, Mobile is {Mobile}, Email is {Email}";
        }
    }
}
