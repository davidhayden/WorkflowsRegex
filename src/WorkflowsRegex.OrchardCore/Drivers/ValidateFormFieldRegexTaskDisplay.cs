using OrchardCore.Workflows.Display;
using WorkflowsRegex.OrchardCore.Activities;
using WorkflowsRegex.OrchardCore.ViewModels;

namespace WorkflowsRegex.OrchardCore.Drivers {
    public class
        ValidateFormFieldRegexTaskDisplay : ActivityDisplayDriver<ValidateFormFieldRegexTask,
            ValidateFormFieldRegexTaskViewModel> {
        protected override void EditActivity(ValidateFormFieldRegexTask activity,
            ValidateFormFieldRegexTaskViewModel model) {
            model.FieldName = activity.FieldName;
            model.Regex = activity.Regex;
            model.ErrorMessage = activity.ErrorMessage;
        }

        protected override void UpdateActivity(ValidateFormFieldRegexTaskViewModel model,
            ValidateFormFieldRegexTask activity) {
            activity.FieldName = model.FieldName?.Trim();
            activity.Regex = model.Regex?.Trim();
            activity.ErrorMessage = model.ErrorMessage?.Trim();
        }
    }
}