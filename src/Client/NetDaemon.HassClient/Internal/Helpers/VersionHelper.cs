namespace NetDaemon.Client.Internal.Helpers;

internal static partial class VersionHelper
{
    public static Version ReplaceBeta(string version)
        => Version.Parse(BetaVersion().Replace(version, ".0").Replace(".dev0", ".0"));

    [GeneratedRegex("\\.0b\\d+$")]
    private static partial Regex BetaVersion();
}
