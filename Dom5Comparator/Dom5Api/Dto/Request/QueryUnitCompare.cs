namespace Dom5Api.Dto.Request;

public class QueryUnitCompare
{
    public int LeftId { get; set; }
    public int RightId { get; set; }

    public bool IsValid => LeftId != 0 && RightId != 0;

    public static bool TryParse(string? value, IFormatProvider? provider,
                                out QueryUnitCompare? compare)
    {
        var trimmedValue = value?.TrimStart('(').TrimEnd(')');
        Console.WriteLine(trimmedValue);
        var segments = trimmedValue?.Split(',',
                StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

        if (segments?.Length != 2)
        {
            compare = new();
            return false;
        }

        if (segments.Any(value => !int.TryParse(value, out int nr)))
        {
            compare = new();
            return false;
        }

        compare = new() { LeftId = int.Parse(segments[0]), RightId = int.Parse(segments[1]) };

        return true;
    }
}