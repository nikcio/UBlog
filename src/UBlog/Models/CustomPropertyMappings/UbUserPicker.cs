using Nikcio.UHeadless.UmbracoContent.Properties.Bases.Models;
using Nikcio.UHeadless.UmbracoContent.Properties.EditorsValues.Default.Commands;
using Umbraco.Cms.Core.Services;

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
            else if (value is int id)
            {
                var user = userService.GetUserById(id);
                Name = user.Name;
            }
        }
    }
}
