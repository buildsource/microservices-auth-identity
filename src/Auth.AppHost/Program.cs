var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Auth_API>("auth.api");

builder.Build().Run();
