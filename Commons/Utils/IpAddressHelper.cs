using System.Net;

namespace ApiCm.Commons.Utils;

public static class IpAddressHelper
{
    public static string GetClientIp(HttpContext ctx)
    {
        var cfIp = ctx.Request.Headers["CF-Connecting-IP"].ToString();
        if (IsValidPublicIp(cfIp))
            return cfIp;

        var xri = ctx.Request.Headers["X-Real-IP"].ToString();
        if (IsValidPublicIp(xri))
            return xri;

        var xff = ctx.Request.Headers["X-Forwarded-For"].ToString();
        if (!string.IsNullOrWhiteSpace(xff))
        {
            foreach (var raw in xff.Split(','))
            {
                var ip = raw.Trim();
                if (IsValidPublicIp(ip))
                    return ip;
            }
        }

        return ctx.Connection.RemoteIpAddress?.ToString() ?? "unknown";
    }

    private static bool IsValidPublicIp(string? ip)
    {
        if (string.IsNullOrWhiteSpace(ip))
            return false;
        if (!IPAddress.TryParse(ip, out var address))
            return false;

        if (address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
        {
            var bytes = address.GetAddressBytes();
            if (bytes[0] == 10)
                return false;
            if (bytes[0] == 172 && bytes[1] >= 16 && bytes[1] <= 31)
                return false;
            if (bytes[0] == 192 && bytes[1] == 168)
                return false;
            if (bytes[0] == 127)
                return false;
            if (bytes[0] == 169 && bytes[1] == 254)
                return false;
            if (bytes[0] == 100 && bytes[1] >= 64 && bytes[1] <= 127)
                return false;
        }
        else if (address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6)
        {
            if (IPAddress.IsLoopback(address))
                return false;
            var s = address.ToString().ToLowerInvariant();
            if (s.StartsWith("fe80:") || s.StartsWith("fc") || s.StartsWith("fd"))
                return false;
        }

        return true;
    }
}
