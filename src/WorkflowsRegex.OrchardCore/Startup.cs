using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;
using OrchardCore.Workflows.Helpers;
using WorkflowsRegex.OrchardCore.Activities;
using WorkflowsRegex.OrchardCore.Drivers;

namespace WorkflowsRegex.OrchardCore {
    [RequireFeatures("OrchardCore.Workflows")]
    public class Startup : StartupBase {
        public override void ConfigureServices(IServiceCollection services) {
            services.AddActivity<ValidateFormFieldRegexTask, ValidateFormFieldRegexTaskDisplay>();
        }
    }
}