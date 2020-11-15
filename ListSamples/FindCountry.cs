namespace ListSamples
{
    public class FindCountry
    {
        private string _country;

        public FindCountry(string country)
        {
            _country = country;
        }

        public bool FindCountryPredicate(Racer racer) =>
            racer?.Country == _country;
    }
}
