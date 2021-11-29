using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTrips
{
    internal class Start
    {
        //Methods SETUP PROGRAM
        public Start()
        {
            //Hardcoded data Destination
            Destination France = new Destination() { ID = 1, Country = Country.France, VisitedCountry = true, Language = Language.French, SpokenLanguage = true};
            Destination Japan = new Destination() { ID = 2, Country = Country.Japan, VisitedCountry = false, Language = Language.Japanese, SpokenLanguage = false };
            Destination USA = new Destination() { ID = 3, Country = Country.USA, VisitedCountry = true, Language = Language.English,SpokenLanguage = true };
            Destination Russia = new Destination() { ID = 4, Country = Country.Russia, VisitedCountry = true, Language = Language.Russian, SpokenLanguage = false};
            Destination Brazil = new Destination() { ID = 5, Country = Country.Brazil, VisitedCountry = true, Language = Language.Portuguese, SpokenLanguage = true };
            Destination Sweden = new Destination() { ID = 6, Country = Country.Sweden, VisitedCountry = true, Language = Language.Swedish, SpokenLanguage = true };
            Destination Lithuania = new Destination() { ID = 7, Country = Country.Lithuania, VisitedCountry = false, Language = Language.Lithuanian, SpokenLanguage = false };
            Destination Germany = new Destination() { ID = 8, Country = Country.Germany, VisitedCountry = true, Language = Language.German, SpokenLanguage = true};
            Destination Norway = new Destination() { ID = 9, Country = Country.Norway, VisitedCountry = true, Language = Language.Norwegian, SpokenLanguage = true};
            
            List<Destination> destinationList = new List<Destination>() { France, Japan, USA, Russia, Brazil, Sweden, Lithuania };
            //Vil gerne have, at de nye instanser af Destination bliver tilføjet til listen
            destinationList.Add(Norway); //Men hvad er det smarte? Jeg kunne jo lige så godt have skrevet det oppe i min liste?
            //List<Destination> tempDestinationListVisisted = new();
            //foreach (Destination item in destinationList)
            //{
            //    if (item.VisitedCountry)
            //        tempDestinationListVisisted.Add(item);
            //        Console.WriteLine(item.Country + " ");
            //}

            //if (tempDestinationListVisisted is not empty: write out "Jeg har været i...." + listen)
            Console.WriteLine("I HAVE BEEN TO:");
            //Hvor har du været
            foreach (Destination item in destinationList)
            {
                if (item.VisitedCountry)

                    Console.WriteLine(item.Country + " ");
            }

            //Hvor har du IKKE været 
            Console.WriteLine("I HAVEN'T BEEN TO :");
            foreach (Destination item in destinationList)
            {
                if (!item.VisitedCountry)

                    Console.WriteLine(item.Country + " ");
            }
            Console.ReadKey();

            //Talt sprog
            Console.WriteLine($"I SPEAK: ");
            foreach (Destination item in destinationList)
            {
                if (item.SpokenLanguage)

                    Console.WriteLine(item.Language + " ");
            }
            //IKKE Talt sprog
            Console.WriteLine($"I DON'T SPEAK: ");
            foreach (Destination item in destinationList)
            {
                if (!item.SpokenLanguage)

                    Console.WriteLine(item.Language + " ");
            }

            //Hardcoded data City
            PlaceCity Philidelphia = new PlaceCity() {Destination = USA, VisitedCity = true };
            PlaceCity Paris = new PlaceCity() { Destination = France, VisitedCity = true };//Hvordan knyttes denne til landet og trip?
            PlaceCity SydSverige = new PlaceCity() { Destination = Sweden, VisitedCity = true };
            PlaceCity Leipzig = new PlaceCity() { Destination = Germany, VisitedCity = false };
            PlaceCity SãoPaulo = new PlaceCity() { Destination = Brazil, VisitedCity = true };
            PlaceCity RioDeJaneiro = new PlaceCity() { Destination = Brazil, VisitedCity = true };
            PlaceCity Manaus = new PlaceCity() { Destination = Brazil, VisitedCity = false };

            //Vil gerne have, at denne skal hænge sammen, så den ikke er hardcoded som Paris-France, og at dette bliver et objekt

            //METODE: Spørg om land er besøgt/ svar fra by) --> returner svar: Ja/ nej, ikke true/ false
            Console.WriteLine("Have we visited France or Brazil yet? " + France.VisitedCountry, Brazil.VisitedCountry);



        //Hardcoded data TheDoneThing
        TheDoneThing Carvival = new TheDoneThing() {/*Parametre, men hvilke*/ }; 
            TheDoneThing SkiJump = new TheDoneThing() {/*Parametre, men hvilke*/ };
            TheDoneThing BauhausSchool = new TheDoneThing() {/*Parametre, men hvilke*/ };

            //Hardcoded data Food
            Food PhillyCheese = new Food() { /*Parametre, men hvilke*/ }; //Must relate to USA, Philidelphia 
            Food DeepPanPizza = new Food() { /*Parametre, men hvilke*/ }; //Must relate to USA, Chicago 
            Food Sashimi = new Food() { /*Parametre, men hvilke*/ }; //Must relate to Japan, INGEN BY
            Food RejesalatHotdog = new Food() { /*Parametre, men hvilke*/ }; //Must relate to Japan, INGEN BY

            //Hardcoded data Trip
           // Trip trip = new Trip() { TripID = 1, Type}; //ID her skal vel knyttes til ID i databasen???
            //Destination France = new Destination() { ID = 1, Country = Country.France, VisitedCountry = true, Language = Language.French, SpokenLanguage = true };
            //Nedenunder er der disse int'er
            //public int TripID { get; set; } //unikt for hver rejse
            //public enum ModeOfTransportation { car, plane, cycle, train, bus, } //flere skal kunne vælges
            //public enum Type { RoadTrip, Train, Hiking, Canoo, Work, LongWeekend, RoundTrip, ProjectOrConference, Regeneration, Tourism, FamilyVisit, FriendsVisit }
        }

        //metode: SIger jeg har været i frankrig, hvis vistitedCIty.Paris = true;
        public Country ifCityThenCountry(PlaceCity city)
        {
            return city.Destination.Country;
            //Destination dCoCi = new Destination();
            //return true; 
        }
    }




    }




