# Pra_05 — ASP.NET WebForms Leave Management (Sample)

## Project Overview

Pra_05 is a sample ASP.NET WebForms application implementing a simple leave management workflow. It contains pages for authentication, submitting leave requests, and basic navigation used for learning and demonstration in a .NET WebForms environment.

## Features

- User login page (`login.aspx`) for authentication
- Main/default page (`default.aspx`) as the application entry
- Leave submission/management page (`leave.aspx`)
- WebForms-based architecture using code-behind (`*.aspx.cs`)
- Uses NuGet packages and Roslyn toolchain included under `/packages` and `/bin/roslyn`

## Prerequisites

- Windows (development environment)
- Visual Studio 2015, 2017, 2019, or later with Web Development workload
- .NET Framework 4.5 or later (project targets 4.x family)
- NuGet CLI (optional) for package restore

## Setup and Build

1. Open the solution file in Visual Studio: `Pra_05.slnx`.
2. Restore NuGet packages (Visual Studio will typically do this automatically). From the command line you can run:

```powershell
nuget restore "Pra_05.slnx"
```

3. Build the solution in Visual Studio (`Build -> Build Solution`) or using MSBuild:

```powershell
msbuild "Pra_05.slnx" /t:Restore,Build
```

Notes:

- The `packages/` folder contains `Microsoft.CodeDom.Providers.DotNetCompilerPlatform` and Roslyn tool config used by the project.
- If you run into compiler or CodeDom provider issues, ensure the `bin/roslyn` folder and `Microsoft.CodeDom.Providers.DotNetCompilerPlatform` entries are present in the output.

## Run (Local Development)

- Press `F5` in Visual Studio to run with IIS Express.
- Alternatively, publish to a local IIS site if preferred (use `Publish` dialog in Visual Studio).

## Project Structure (important files)

- `default.aspx`, `default.aspx.cs` — Main entry page and code-behind
- `login.aspx`, `login.aspx.cs` — Login page
- `leave.aspx`, `leave.aspx.cs` — Leave submission/management page
- `Global.asax`, `Global.asax.cs` — Application-level events
- `Web.config` — App configuration
- `Pra_05/` — Project folder containing `Pra_05.csproj` and project-specific files
- `packages/` — NuGet package content checked into the repository
- `bin/` — Compiled binaries and Roslyn tooling (not all files are committed; use build to generate)
- `App_Data/` — Local data storage area (if used by the app)

## Configuration

- Edit `Web.config` to adjust connection strings, appSettings, or authentication settings if your environment requires it.
- If the project uses a database, ensure database connection strings are set and the DB is available.

## Dependencies

- Microsoft.CodeDom.Providers.DotNetCompilerPlatform (see `packages.config` and `packages/` folder)
- Roslyn toolchain shipped under `bin/roslyn` (compiler helpers for CodeDom)

## Common Tasks

Restore packages (command line):

```powershell
nuget restore "Pra_05.slnx"
```

Clean and rebuild in Visual Studio from the IDE: `Build -> Clean Solution` then `Build -> Build Solution`.

Run locally in Visual Studio: `F5` or `Ctrl+F5`.

## Deployment

- Publish from Visual Studio (`Build -> Publish`) to IIS, Azure, or a file system folder.
- When deploying to IIS, ensure:
  - The target machine has the required .NET Framework installed.
  - Application pool is set to the correct .NET CLR version.
  - All required files from `bin/` (including Roslyn files if needed) are included.

## Testing

- This repository does not include automated tests. Add unit or integration tests as needed using your preferred test framework (MSTest, xUnit, NUnit).

## Troubleshooting

- "Compiler provider" or Roslyn errors: confirm `Microsoft.CodeDom.Providers.DotNetCompilerPlatform` package is installed and `bin/roslyn` is present.
- NuGet package restore failures: run `nuget restore` and check `packages.config` for package versions.
- Configuration errors: check `Web.config` for malformed configuration entries.

## Contributing

- Make changes on a feature branch and open a pull request with a clear description.
- Update this `README.md` with any breaking changes or setup updates.

## License

Specify your preferred license here (e.g., MIT). If unsure, ask the project owner for the correct license.

## Contact / Maintainers

For questions about this sample or setup issues, contact the project owner or maintainer.

---

_Generated README for the Pra_05 ASP.NET WebForms sample._
