using System.Linq;

namespace DebugProxyDemo.Model
{
#if DEBUG
public class DiscographyDebugProxy
{
    private readonly Discography __discography;

    public DiscographyDebugProxy(Discography discography)
    {
        __discography = discography;
    }

    public string FirstRecord
    {
        get
        {
            var first = __discography.Records.OrderBy(d => d.ReleaseDate).First();
            return $"{first.Title} ({first.ReleaseDate.Year})";
        }
    }

    public string LastRecord
    {
        get
        {
            var first = __discography.Records.OrderBy(d => d.ReleaseDate).Last();
            return $"{first.Title} ({first.ReleaseDate.Year})";
        }
    }

    public int NumberOfRecords => __discography.Records.Count;
}
#endif

}
