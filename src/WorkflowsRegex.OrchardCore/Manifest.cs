using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Regular Expression Validator",
    Author = "David Hayden",
    Website = "https://www.davidhayden.me",
    Version = "2.0.0",
    Description = "Adds a regular expression validator for form fields to Workflows.",
    Category = "Workflows",
    Dependencies = new[] {
        "OrchardCore.Workflows"
    }
)]