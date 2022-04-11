using System;
using wayfiner_dotnet.Interfaces;

namespace wayfiner_dotnet.Models
{
    public class Profile : IRepoItem<string>
    {
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public string Name { get; set; }
        public string Picture { get; set; }


    }
    public class Account : Profile
    {


        public string Email { get; set; }

    }
}