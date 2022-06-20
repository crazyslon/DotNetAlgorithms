namespace App.Extensions;

public static class ComparableExtensions
{
    public static bool LessThan<T>(this T value, T valueToCompare) where T : IComparable<T>
    {
        return value.CompareTo(valueToCompare) == -1;
    }

    public static bool Equal<T>(this T value, T valueToCompare) where T : IComparable<T>
    {
        return value.CompareTo(valueToCompare) == 0;
    }

    public static bool GreaterThan<T>(this T value, T valueToCompare) where T : IComparable<T>
    {
        return value.CompareTo(valueToCompare) == 1;
    }

    public static bool LessThanOrEqual<T>(this T value, T valueToCompare) where T : IComparable<T>
    {
        var result = value.CompareTo(valueToCompare);
        return result is -1 or 0;
    }
}