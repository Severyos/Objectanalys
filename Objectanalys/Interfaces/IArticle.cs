namespace Objectanalys.Interfaces;
public interface IArticle
{
    string ISBN { get; set; }
    string Title { get; set; }
    string Language { get; set; }
    string ArticlePublisher { get; set; }
    List<string> Authors { get; set; }
    List<string> Translators { get; set; }
    DateTime ReleaseDate { get; set; }
    string Edition { get; set; }
    string Serie { get; set; }
}
