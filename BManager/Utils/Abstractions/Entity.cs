using System.ComponentModel.DataAnnotations.Schema;

namespace BManager.Utils.Abstractions
{
    public class Entity
    {
        public Guid Id{get; set;}
        [NotMapped]
        public static string IdProperty = "Id";
        [NotMapped]
        public static string NameProperty = "Name";
        [NotMapped]
        public static string TableName = "";
        public string? GetId()
        {
            var type = this.GetType();
            var idInfo = type.GetProperty(IdProperty);
            return idInfo?.GetValue(this)?.ToString();
        }

        public string? GetName()
        {
            var type = this.GetType();
            var idInfo = type.GetProperty(NameProperty);
            return idInfo?.GetValue(this)?.ToString();
        }

    }
}
