namespace PruebasApis.MarvelApi
{
    public class Character
    {
    }

    public class CharacterDataWrapper
    {
        public int Code { get; set; }

        public string status { get; set; }

        public string Copyright { get; set; }

        public string AttibutionText { get; set; }

        public string AttributionHTML { get; set; }

        public CharacterDataContainer Data { get; set; }

        public string Etag { get; set; }


    }

    public class CharacterDataContainer
    {
        public int Offset { get; set; }

        public int Limit { get; set; }

        public int Total { get; set; }

        public int Count { get; set; }

        public List<Character> Results { get; set; }

    }

    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descripcion { get; set; }
        public string Modified { get; set; }
        public string ResourceURI { get; set; }
        public List<MarvelUrl> Urls { get; set; }
        public MarvelImage Thumbnail { get; set; }
        public ComicList Comics { get; set; }
        public StoryList Stories { get; set; }
        public EventList Events { get; set; }
        public SeriesList Series { get; set; }

    }

    public class MarvelUrl
    {
        public string type { get; set; }
        public string url { get; set; }

    }

    public class MarvelImage
    {
        public string path { get; set; }
        public string extension { get; set; }

    }

    public class ComicList
    {
        public int available { get; set; }
        public int returned { get; set; }
        public string collectionURI { get; set; }
        public ComicSummary[] items { get; set; }
    }

    public class ComicSummary
    {
        public string resourceURI { get; set; }
        public string name { get; set; }

    }
    public class StoryList
    {
        public int available { set; get; }
        public int returned { set; get; }
        public string collectionURI { set; get; }
        public StorySummary[] items { set; get; }
    }
    public class StorySummary
    {
        public string resourceURL { get; set; }
        public string name { get; set; }
        public string type { get; set; }
    }
    public class EventList
    {
        public int available { get; set; }
        public int returned { get; set; }
        public string collectionURI { get; set; }
        public EventSummary[] items { get; set; }
    }

    public class EventSummary
    {
        public string resourceURI { get; set; }
        public string name { set; get; }

    }
    public class SeriesList
    {
        public int available { get; set; }
        public int returned { get; set; }
        public string collectionURI { get; set; }
        public SeriesSummary[] items { get; set; }

    }
    public class SeriesSummary
    {
        public string resourceURI { get; set; }
        public string name { set; get; }

    }



}
