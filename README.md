-Command
Add-Migration MyMigration -Project DotNet-101.Infrastructure -StartupProject DotNet-101.Api
Update-Database MyMigration -Project DotNet-101.Infrastructure -StartupProject DotNet-101.Api
