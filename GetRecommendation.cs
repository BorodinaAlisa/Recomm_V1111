namespace DB_993
{
    public class GetRecommendation
    {
        public List<Realty> listRealty { get; set; }
        public decimal RatingPrice { get; set; }
        public int RatingFloоr { get; set; }
        public int RatingRooms { get; set; }
        public int RatingSquare { get; set; }
        public string? RatingCity { get; set; }
        public string? RatingType { get; set; }
        public string? RatingForWhat { get; set; }
        public GetRecommendation(List<Realty> listRealty)
        {
            this.listRealty = listRealty;
            GetRatingRealty();
        }
        public void GetRatingRealty()
        {
            RatingCity = listRealty[0].City;
            RatingType = listRealty[0].Type;
            RatingForWhat = listRealty[0].ForWhat;

            for (int i = 0; i < listRealty.Count; i++)
            {
                RatingPrice += listRealty[i].Price;
                RatingRooms += listRealty[i].Rooms;
                RatingFloоr += listRealty[i].Floor;
                RatingSquare += listRealty[i].Square;
            }
            RatingPrice = RatingPrice / listRealty.Count;
            RatingRooms = RatingRooms / listRealty.Count;
            RatingFloоr = RatingFloоr / listRealty.Count;
            RatingSquare = RatingSquare / listRealty.Count;
        }

    }
}
