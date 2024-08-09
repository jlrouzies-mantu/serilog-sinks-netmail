﻿using System;
using Xunit;

namespace Serilog.Sinks.NetMail.Tests;

public class LoggerConfigurationEmailExtensionsTests
{
    public static object?[][] GetMailAddressSplitCases()
    {
        return
        [
            [null, Array.Empty<string>()],
            ["", Array.Empty<string>()],
            ["to@localhost", new[] {"to@localhost" }],
            ["to@localhost, Example <example@example.com>; Another <another@example.com> ", new[] {"to@localhost", "Example <example@example.com>", "Another <another@example.com>" }]
        ];
    }

    [Theory]
    [MemberData(nameof(GetMailAddressSplitCases))]
    public void SplitsMailAddressesCorrectly(string? to, string[] expected)
    {
        var actual = LoggerConfigurationEmailExtensions.SplitToAddresses(to);
        Assert.Equivalent(expected, actual);
    }
}
