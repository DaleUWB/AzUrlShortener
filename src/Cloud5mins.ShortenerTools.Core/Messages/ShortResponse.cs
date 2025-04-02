namespace Cloud5mins.ShortenerTools.Core.Messages
{
    public class ShortResponse
    {
        public string ShortUrl { get; set; }
        public string LongUrl { get; set; }
        public string Title { get; set; }
        public string CreatedBy { get; set; } // added by Dale and Yuping 4/25

        public ShortResponse() { }
        public ShortResponse(string host, string longUrl, string endUrl, string title, string createdby)
        {
            LongUrl = longUrl;
            ShortUrl = string.Concat(host, "/", endUrl);
            Title = title;
            Createdby = createdby; // added by Dale and Yuping 4/25

        }
    }
}