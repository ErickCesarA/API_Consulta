using Microsoft.JSInterop;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq.Expressions;
using System.Text.Json.Serialization;

namespace API_consulta.Class.Patient
{
   public class ComorbidityModel
    {
        protected int ComorbidityId;
        protected string? ComorbidityName;
        protected string? ComorbidityDescription;
     
        public int comorbidityId
        {
            get { return ComorbidityId; }
            set { ComorbidityId = value; }
        }
        public string? comorbidityName
        {
            get { return ComorbidityName; }
            set { ComorbidityName = value; }
        }
        public string? comorbidityDescription
        {
            get { return ComorbidityDescription; }
            set { ComorbidityDescription = value; }
        }
 
        public class ExpressionsPropertySimplify
        {
            public static readonly Expression<Func<ComorbidityModel, object?>> ComorbidityId = x => x.ComorbidityId;
            public static readonly Expression<Func<ComorbidityModel, string?>> ComorbidityName = x => x.ComorbidityName;
            public static readonly Expression<Func<ComorbidityModel, string?>> ComorbidityDescription = x => x.ComorbidityDescription;
        }
    }
}
