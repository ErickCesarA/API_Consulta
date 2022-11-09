using Microsoft.JSInterop;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq.Expressions;
using System.Text.Json.Serialization;

namespace API_consulta.Class.Patient
{
   public class ComorbidityModel
    {
        public int? ComorbidityId { protected get; set; }
        public string ComorbidityName { protected get; set; }
        public string? ComorbidityDescription { protected get; set; }
        public ComorbidityModel(int? ComorbidityId, string ComorbidityName, string ComorbidityDescription)
        {
            this.ComorbidityId = ComorbidityId;
            this.ComorbidityName = ComorbidityName;
            this.ComorbidityDescription = ComorbidityDescription;
        }
        public int? GetComorbidityId()
        {
            return this.ComorbidityId;
        }
        public string GetComorbidityName()
        {
            return this.ComorbidityName;
        }
        public string? GetComorbidityDescription()
        {
            return this.ComorbidityDescription;
        }
        //public bool Comorbidity { protected get; set; }
        //[NotMapped]
        //protected virtual List<ComorbidityModel>? WhichComorbidity { get; set; }

        public class ExpressionsPropertySimplify
        {
            public static readonly Expression<Func<ComorbidityModel, object?>> ComorbidityId = x => x.ComorbidityId;
            public static readonly Expression<Func<ComorbidityModel, string>> ComorbidityName = x => x.ComorbidityName;
            public static readonly Expression<Func<ComorbidityModel, string?>> ComorbidityDescription = x => x.ComorbidityDescription;
        }
    }
}
