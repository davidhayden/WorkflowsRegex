using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Localization;
using OrchardCore.DisplayManagement.ModelBinding;
using OrchardCore.Workflows.Abstractions.Models;
using OrchardCore.Workflows.Activities;
using OrchardCore.Workflows.Models;

namespace WorkflowsRegex.OrchardCore.Activities {
    public class ValidateFormFieldRegexTask : TaskActivity {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUpdateModelAccessor _updateModelAccessor;

        public ValidateFormFieldRegexTask(
            IHttpContextAccessor httpContextAccessor,
            IUpdateModelAccessor updateModelAccessor,
            IStringLocalizer<ValidateFormFieldRegexTask> localizer
        ) {
            _httpContextAccessor = httpContextAccessor;
            _updateModelAccessor = updateModelAccessor;
            T = localizer;
        }

        public override string Name => nameof(ValidateFormFieldRegexTask);

        public override LocalizedString DisplayText => T["Validate Form Field Regex Task"];

        public override LocalizedString Category => T["Validation"];

        private IStringLocalizer T { get; set; }

        public string FieldName {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        public string Regex {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        public string ErrorMessage {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        public override IEnumerable<Outcome> GetPossibleOutcomes(WorkflowExecutionContext workflowContext,
            ActivityContext activityContext) {
            return Outcomes(T["Done"], T["Valid"], T["Invalid"]);
        }

        public override ActivityExecutionResult Execute(WorkflowExecutionContext workflowContext,
            ActivityContext activityContext) {
            var form = _httpContextAccessor.HttpContext.Request.Form;
            var fieldValue = form[FieldName];

            var re = new Regex(Regex);
            var isValid = re.IsMatch(fieldValue);
            var outcome = isValid ? "Valid" : "Invalid";

            if (!isValid) {
                var updater = _updateModelAccessor.ModelUpdater;

                updater?.ModelState.TryAddModelError(FieldName, ErrorMessage);
            }

            return Outcomes("Done", outcome);
        }
    }
}
