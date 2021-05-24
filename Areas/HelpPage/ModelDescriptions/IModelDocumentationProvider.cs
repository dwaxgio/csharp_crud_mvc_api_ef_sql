using System;
using System.Reflection;

namespace csharp_crud_mvc_api_ef_sql.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}