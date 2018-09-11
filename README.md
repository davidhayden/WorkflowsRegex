# WorkflowsRegex

WorkflowsRegex.OrchardCore is an Orchard Core CMS Module that provides a regular expression validator in Workflows for form fields.

The module was built for a presentation. The version of Orchard Core CMS at the time, <i>beta 2</i>, did not include a regular expression validator for form fields.

## Status

[![Build status](https://ci.appveyor.com/api/projects/status/i89bs5l1sfv92qki?svg=true)](https://ci.appveyor.com/project/davidhayden/workflowsregex) [![Status](https://img.shields.io/myget/davidhayden-ci/v/WorkflowsRegex.OrchardCore.svg)](https://www.myget.org/feed/davidhayden-ci/package/nuget/WorkflowsRegex.OrchardCore)

## Getting Started

Add the NuGet package, **WorkflowsRegex.OrchardCore**, to the Orchard Core CMS Website. Launch the website and sign in as an administrator to enable the module from the dashboard under <i>Configuration</i> -> <i>Modules</i>.

![WorkflowsRegex.OrchardCore](https://github.com/davidhayden/WorkflowsRegex/blob/master/assets/custom-orchard-core-cms-workflows-activity.png?raw=true)

Create a workflow and select <em>Add Task</em>. Filter the workflow tasks by <em>Validation</em> and choose the <em>Regex Validator</em> task.

![Regex Validator](https://github.com/davidhayden/WorkflowsRegex/blob/master/assets/regular-expression-validator-orchard-core-cms-workflow-task.png?raw=true)

Edit the task settings. Enter a form field and a regular expression for validation.

![Orchard Core CMS Workflows Task Editor](https://github.com/davidhayden/WorkflowsRegex/blob/master/assets/orchard-core-cms-workflows-task-editor.png?raw=true)

For presentations, you can simply create a workflow that accepts a form submission and logs a validation error.

![Orchard Core CMS Workflow](https://github.com/davidhayden/WorkflowsRegex/blob/master/assets/orchard-core-cms-workflow.png?raw=true)

## Bugs

There are no known bugs.

## Road map

There are no plans to add any additional features.

## Credits
WorkflowsRegex.OrchardCore is created and maintained by David Hayden.