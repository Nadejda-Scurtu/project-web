using System.ComponentModel.DataAnnotations.Schema;

namespace eUseControl.Domain.Entities
{
    public class Session
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public int UserId { get; set; }
    }
}
