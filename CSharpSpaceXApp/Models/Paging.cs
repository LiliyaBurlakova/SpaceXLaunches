namespace CSharpSpaceXApp.Models
{
    public class Paging
    {
        public int? PrevPage { get; set; }

        public int CurrPage { get; set; }

        public int? NextPage { get; set; }

        public int TotalPages { get; set; }
    }
}
