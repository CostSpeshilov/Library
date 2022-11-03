namespace LibraryConsole
{
    internal class Client
    {
        public Client(string name, string surName)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException($"\"{nameof(name)}\" не может быть пустым или содержать только пробел.", nameof(name));
            }

            if (string.IsNullOrWhiteSpace(surName))
            {
                throw new ArgumentException($"\"{nameof(surName)}\" не может быть пустым или содержать только пробел.", nameof(surName));
            }

            Name = name;
            SurName = surName;
        }

        public string Name { get; }
        public string SurName { get; }
    }
}