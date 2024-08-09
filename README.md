# Serilog.Sinks.NetMail [![Build status](https://ci.appveyor.com/api/projects/status/sfvp7dw8u6aiodj1/branch/main?svg=true)](https://ci.appveyor.com/project/serilog/serilog-sinks-email/branch/main)

> ℹ️ Based on [Serilog.Sinks.Email](https://github.com/serilog/serilog-sinks-email/tree/dev)

Sends log events by SMTP email, using System.Net.Mail.

```csharp
await using var log = new LoggerConfiguration()
    .WriteTo.NetMail(
        from: "app@example.com",
        to: "support@example.com",
        host: "smtp.example.com")
    .CreateLogger();
```

Supported options are:

| Parameter              | Description                                                                                                                         |
|------------------------|-------------------------------------------------------------------------------------------------------------------------------------|
| `from`                 | The email address emails will be sent from.                                                                                         |
| `to`                   | The email address emails will be sent to. Multiple addresses can be separated with commas or semicolons.                            |
| `host`                 | The SMTP server to use.                                                                                                             |
| `port`                 | The port used for the SMTP connection. The default is 25.                                                                           |
| `enableSSL`            | Enable SSL                                                                                                                          |
| `credentials`          | The network credentials to use to authenticate with the mail server.                                                                |
| `useDefaultCredentials`| Use the Default Credentials, useful e.g. for NTML / Kerberos                                                                        |
| `subject`              | A message template describing the email subject. The default is `"Log Messages"`.                                                   |
| `body`                 | A message template describing the format of the email body. The default is `"{Timestamp} [{Level}] {Message}{NewLine}{Exception}"`. |
| `formatProvider`       | Supplies culture-specific formatting information. The default is to use the current culture.                                        |

An overload accepting `EmailSinkOptions` can be used to specify advanced options such as batched and/or HTML body templates.
