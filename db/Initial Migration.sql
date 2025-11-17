$env:TUTORIAL_CONNECTION="CONNECTION_STRING"

dotnet ef migrations add InitialSchema
dotnet ef database update