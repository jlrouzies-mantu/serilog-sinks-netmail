using Serilog;

Log.Logger = new LoggerConfiguration()
    .WriteTo.NetMail("from@localhost", "to@localhost", "localhost")
    .CreateLogger();

Log.Information("Hello, world!");

await Log.CloseAndFlushAsync();
