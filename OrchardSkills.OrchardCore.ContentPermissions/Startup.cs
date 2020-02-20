using Microsoft.Extensions.DependencyInjection;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentTypes.Editors;
using OrchardCore.Data.Migration;
using OrchardCore.Modules;
using OrchardSkills.OrchardCore.ContentPermissions.Drivers;
using OrchardSkills.OrchardCore.ContentPermissions.Models;
using OrchardSkills.OrchardCore.ContentPermissions.Settings;

namespace OrchardSkills.OrchardCore.ContentPermissions
{
    public class Startup : StartupBase
    {

        public override void ConfigureServices(IServiceCollection servicesCollection)
        {
            servicesCollection.AddScoped<IContentPartDisplayDriver, ContentPermissionsDisplay>();
            servicesCollection.AddContentPart<ContentPermissionsPart>();

            servicesCollection.AddScoped<IContentTypePartDefinitionDisplayDriver, ContentPermissionsPartSettingsDisplayDriver>();

            servicesCollection.AddScoped<IDataMigration, Migrations>();
        }
    }
}
