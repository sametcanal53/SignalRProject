using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnumController : ControllerBase
    {
        [HttpGet("GetEnumValues")]
        public IActionResult GetEnumValues(string enumTypeName)
        {
            var values = new Dictionary<int, string>();
            var enumType = GetEnumType(enumTypeName);
            if (enumType == null) return BadRequest();

            foreach (var value in Enum.GetValues(enumType))
            {
                values.Add(Convert.ToInt32(value), value.ToString().ToLowerInvariant().Replace("_", "-"));
            }

            return Ok(values);
        }

        private Type GetEnumType(string enumTypeName)
        {
            string namespaceName = "SignalR.Core.Enums";

            Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (var assembly in assemblies)
            {
                try
                {
                    if (!assembly.GetTypes().Any(t => t.Namespace != null && t.Namespace.StartsWith(namespaceName)))
                        continue;

                    Type[] types = assembly.GetTypes();
                    foreach (var type in types)
                    {
                        if (type.Namespace != null && type.Namespace.StartsWith(namespaceName) && type.IsEnum && type.Name == enumTypeName)
                        {
                            return type;
                        }
                    }
                }
                catch { }
            }

            return null;
        }
    }
}