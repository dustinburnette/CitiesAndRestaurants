using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiesAndRestaurants
{
    class Program
    {
        class City
        {
            public string Name { get; set; }
            public string State { get; set; }
            public LatLng Latlng { get; set; }
            public List<Neighborhoods> Neighborhoods { get; set; }
            public List<Restaurants> Restaurants { get; set; }
            public List<City> NeighboringCities { get; set; }

        }
        class Neighborhoods
        {
            public string Name { get; set; }
            public City City { get; set; }
            public List<Restaurants> Restaurants { get; set; }
        }
        class Restaurants
        {
            public Address Address { get; set; }
            public string Name { get; set; }
            public Category Type { get; set; }
            public string WebsiteUrl { get; set; }

        }
        class LatLng
        {
            public double Lat { get; set; }
            public double Lng { get; set; }
        }
        class Address
        {
            public LatLng Latlng { get; set; }
            public string StreetAddress { get; set; }
            public int Zip { get; set; }
            public string State { get; set; }
            public City City { get; set; }
        }
        enum Category
        {
            Italian,
            American,
            Thai,
            German,
            French,
            English,
            Mexican,
            Spanish,
            Chinese,
            Korean,
            Japanese,
            Other,
        }

        static void Main(string[] args)
        {


            City dallas = new City();
            dallas.Name = "Dallas";
            dallas.State = "TX";
            LatLng dallasCoords = new LatLng();
            dallasCoords.Lat = 96.7970;
            dallasCoords.Lng = 32.7767;
            dallas.Latlng = dallasCoords;
            dallas.Neighborhoods = new List<Neighborhoods>();

            Neighborhoods deepEllum = new Neighborhoods();
            deepEllum.City = dallas;
            deepEllum.Name = "Deep Ellum";
            deepEllum.Restaurants = new List<Restaurants>();

            

            Neighborhoods upTown = new Neighborhoods();
            upTown.City = dallas;
            upTown.Name = "Uptown";
            upTown.Restaurants = new List<Restaurants>();

            dallas.Neighborhoods.Add(deepEllum);
            dallas.Neighborhoods.Add(upTown);

            Restaurants pecanLodge = new Restaurants();
            pecanLodge.Name = "Pecan Lodge";
            pecanLodge.Type = Category.American;
            pecanLodge.WebsiteUrl = "http://pecanlodge.com/";

            pecanLodge.Address = new Address();
            pecanLodge.Address.StreetAddress = "2702 Main St";
            pecanLodge.Address.City = dallas;
            pecanLodge.Address.Zip = 75226;
            pecanLodge.Address.Latlng = new LatLng();
            pecanLodge.Address.Latlng.Lat = 32.784065;
            pecanLodge.Address.Latlng.Lng = -96.783745;


            Restaurants monkeyKing = new Restaurants();
            monkeyKing.Name = "Monkey King";
            monkeyKing.Type = Category.Chinese;
            monkeyKing.WebsiteUrl = "http://monkeykingnoodlecompany.com/";

            monkeyKing.Address = new Address();
            monkeyKing.Address.StreetAddress = "2933 Main St";
            monkeyKing.Address.City = dallas;
            monkeyKing.Address.Zip = 75226;
            monkeyKing.Address.Latlng = new LatLng();
            monkeyKing.Address.Latlng.Lat = 32.784065;
            monkeyKing.Address.Latlng.Lng = -96.783745;

            deepEllum.Restaurants.Add(pecanLodge);
            deepEllum.Restaurants.Add(monkeyKing);





            //City dallas = new City();
            //dallas.Name = "Dallas";
            //dallas.State = "Texas";
            //dallas.Latlng.Lat = 96.7970;
            //dallas.Latlng.Lng = 32.7767;
            //dallas.Burroughs.Add(new Neighborhoods() {Name = "Bishop Arts District" });


            //dallas.Burroughs.Add(new Neighborhoods() {Name = "Deep Ellum" });

            //dallas.Restaurants.Add(new Restaurants() {Name = "Iron Cactus" });
            //dallas.Restaurants.Add(new Restaurants() { Name = "Five Sixty" });
            //dallas.Restaurants.Add(new Restaurants() { Name = "Meso Maya" });

            //dallas.Restaurants.Add(new Restaurants() { });

            //dallas.NeighboringCities.Add(new City { Name = "Plano"});
            //dallas.NeighboringCities.Add(new City { Name = "Irving" });
            //dallas.NeighboringCities.Add(new City { Name = "Duncanville" });








        }
    }
}
