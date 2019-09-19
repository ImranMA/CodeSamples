 ## EFCore Seperate Library 

I get question many times, how to setup EF core in seperate class library without referecning connection string.

The simple DB example show how to wire up ASP.NET core (EFCoreMVC)
so your database logic can exist in seperate library (EFCore.Persistence) and
not to use seperate connection string in ClassLibrary (EFCore.Persistence).

I am using DB first to make it more clear.

I have Database "Test" with only table "Student" - fields 
ID,Name  (Script in project)

 
I have Simply Run following command in PM console.(you may not to run this since context is already created)
```
Scaffold-DbContext "Server=servername;Database=Test;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
```

You can see in startup.cs that i have wired up DB connection and referecning persistenc library. 

```
 public static IServiceCollection AddCustomDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            // Add DbContext using SQL Server Provider
            services.AddDbContext<TestContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("TestDBCon"), x => x.MigrationsAssembly("TESTEF.Persistence")));

            return services;
        }
```


I am retrieving students in MVC controller to prove that we don't need additional connecton stirng in Persistence Library. 
