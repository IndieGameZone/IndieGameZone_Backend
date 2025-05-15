var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.IndieGameZone_API>("indiegamezone-api");

builder.Build().Run();
