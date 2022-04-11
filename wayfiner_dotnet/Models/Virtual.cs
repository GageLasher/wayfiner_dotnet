using System;
using wayfiner_dotnet.Interfaces;

namespace wayfiner_dotnet.Models
{
    public class Virtual<T> : IRepoItem<T>
    {
        public T Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatorId { get; set; }
    }
}