using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace SignalRApi.Controllers
{
    public class EnumController : GenericController
    {
        [HttpGet("GetEnumValues")]
        public IActionResult GetEnumValues(string enumTypeName)
        {
            var values = new Dictionary<int, string>();
            var enumType = GetEnumTypes().FirstOrDefault(t => t.Name == enumTypeName);
            if (enumType == null) return BadRequest();

            foreach (var value in Enum.GetValues(enumType))
            {
                values.Add((int)value, value.ToString());
            };

            return Ok(values);
        }

        private List<Type> GetEnumTypes()
        {
            string namespaceName = "SignalR.Core.Enums";
            List<Type> enumTypes = new List<Type>();

            Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (var assembly in assemblies)
            {
                try
                {
                    // Assembly'nin tanımlanan namespace'e sahip olup olmadığını kontrol et
                    if (!assembly.GetTypes().Any(t => t.Namespace != null && t.Namespace.StartsWith(namespaceName)))
                        continue;

                    Type[] types = assembly.GetTypes();
                    foreach (var type in types)
                    {
                        if (type.Namespace != null && type.Namespace.StartsWith(namespaceName) && type.IsEnum)
                        {
                            enumTypes.Add(type);
                        }
                    }
                }
                catch (ReflectionTypeLoadException ex)
                {
                    // Assembly'nin tüm tiplerine erişimde bir sorun varsa devam et
                    foreach (var loaderException in ex.LoaderExceptions)
                    {
                        Console.WriteLine(loaderException.Message);
                    }
                }
            }

            return enumTypes;
        }
    }
}
