var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.BlazorAppAspire>("blazorappaspire");

builder.Build().Run();
