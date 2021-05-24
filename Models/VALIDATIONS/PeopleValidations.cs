using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace csharp_crud_mvc_api_ef_sql.Models
{
    // MATCH CON CLASE DE EF PEOPLE
    [MetadataType(typeof(people.MetaData))]
    public partial class people
    {        
        sealed class MetaData
        {
            [Required] // Regla de negocio
            public string name;
        }
    }
}