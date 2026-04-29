# Copilot instructions for InventarioISP20

Repository: InventarioISP20 (Windows Forms .NET 8 desktop app)

Overview
- This is a Windows Forms desktop application targeting .NET 8 (net8.0-windows). The entry point is Destop\Program.cs which opens MenuPrincipalView.
- UI views live under Destop\Views and are generated partial classes with .Designer.cs and resource files.

Build, test, lint
- Build: dotnet build "Destop\Desktop.csproj" -c Debug
- Run (exe): run bin\Debug\net8.0-windows\Destop.exe or use dotnet run --project "Destop\Desktop.csproj"
- No tests or linting configuration were found. There is no test project in the repository. If tests are added, run a single test with: dotnet test --filter "FullyQualifiedName~Namespace.Class.Method" or use --filter "DisplayName=..." depending on the test framework.

High-level architecture
- Single WinForms project (Destop) with Program.cs as startup.
- Views are standard WinForms Forms (partial classes). Resources are embedded via .resx files; designer files hold control wiring.
- Third-party dependency: FontAwesome.Sharp (icons).
- No web/API or database layers present in repository root; business logic appears UI-centric inside the Destop project.

Key conventions and notes
- UI navigation: MenuPrincipalView constructs and Show()s other views (e.g., ArticulosView). Expect forms to be opened modelessly unless ShowDialog() is used.
- Designer-managed files: Do not edit *.Designer.cs or *.resx by hand; modify via the Windows Forms designer to avoid losing changes.
- Project targets net8.0-windows and uses <UseWindowsForms>true</UseWindowsForms>.
- Use ApplicationConfiguration.Initialize() (auto-generated) for app-wide settings.

Existing AI assistant configs
- No CLAUDE.md, AGENTS.md, .cursorrules, .windsurfrules, CONVENTIONS.md, or similar assistant config files were found.

Suggested additions for future maintainers (optional)
- Add a CONTRIBUTING.md with setup steps (Visual Studio 2022/2023, .NET 8 SDK) and how to run the app.
- Add a test project and CI build step for dotnet build/dotnet test.

MCP servers
- (No MCP servers configured here.)

If changes are desired, say which area to extend (build/test/CI, adding tests, or adding contributor setup steps).

## Mandatory instructions
-Hablar en español
