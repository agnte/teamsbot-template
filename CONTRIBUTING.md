# Contributing to Teams Bot Template

Thank you for your interest in contributing to the Teams Bot Template!

## Template Structure

This is a `dotnet new` template project. The template files are in the root directory and the template configuration is in `.template.config/`.

### Key Files

- `.template.config/template.json` - Template metadata and configuration
- `TeamsBotTemplate.csproj` - Project file (name will be replaced when template is used)
- All `.cs` files - C# source code with `TeamsBotTemplate` namespace that gets replaced

## Testing the Template

### Install the template locally

```bash
dotnet new install .
```

### Create a test project

```bash
cd /tmp
dotnet new teamsbot -n MyTestBot
cd MyTestBot
dotnet build
dotnet run
```

### Uninstall the template

```bash
dotnet new uninstall .
```

## Template Parameters

The template supports the following parameters:

- `--Framework` - Target framework (net8.0 or net9.0)

## Making Changes

1. **Update source files** - Modify the `.cs`, `.csproj`, and other project files as needed
2. **Update template.json** - If adding new parameters or changing metadata
3. **Test locally** - Always test your changes by installing and using the template
4. **Update README.md** - Document any new features or changes

## Template Conventions

- Use `TeamsBotTemplate` as the namespace - it will be replaced with the user's project name
- The `.csproj` file name should be `TeamsBotTemplate.csproj` - it will be renamed automatically
- The `sourceName` in `template.json` controls what gets replaced

## Adding New Features

When adding new features:

1. Keep the template minimal - it's a starting point, not a complete application
2. Use standard Bot Framework and Teams SDK patterns
3. Include comments explaining complex code
4. Update the README with usage instructions
5. Ensure the template builds and runs without configuration

## Package Versions

When updating NuGet packages:

- Use stable versions, not preview/beta
- Test with both net8.0 and net9.0
- Document any version-specific features in comments

## Questions?

Open an issue for questions, suggestions, or bug reports.
