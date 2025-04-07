
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.EntityFrameworkCore.Design

dotnet tool install --global dotnet-ef


dotnet ef dbcontext scaffold "Data Source=Database\parkingslot.db" Microsoft.EntityFrameworkCore.Sqlite -o Models -f -c DatabaseContext --no-onconfiguring --no-build