namespace Study02.Helpers
{
    public class Role
    {
        public Role(Roles name)
        {
            Name = name.ToString();
        }

        public string Name { get; set; }
    }
}
