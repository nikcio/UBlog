using Nikcio.UHeadless.Commands.Properties;
using Nikcio.UHeadless.Models.Dtos.Propreties.PropertyValues;
using Umbraco.Cms.Core.Security;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;

namespace UBlog.Models.CustomPropertyMappings
{
    public class UbUserPicker : PropertyValueBaseGraphType
    {
        public string Name { get; set; }

        public UbUserPicker(CreatePropertyValue createPropertyValue, IUserService userService) : base(createPropertyValue)
        {
            var value = createPropertyValue.Property.GetValue(createPropertyValue.Culture);
            if (value == null)
            {
                return;
            }
            else if(value is int id)
            {
                var user = userService.GetUserById(id);
                Name = user.Name;
            }
        }
    }
}
