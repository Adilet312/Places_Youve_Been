using System;
using System.Collections.Generic; 

namespace PlacesYouveBeen.Models
{
    public class Place
    {
        private string cityname;
        private string picturelink;
        private string journal;
        private int lengthofstay;
        private string[] companions;
        private int id;
        private static List<Place> placeslist = new List<Place>{};

        public Place()
        {

        }

        public Place(string cityname, string picturelink, string journal, int lengthofstay)
        {
            this.cityname = cityname;
            this.picturelink = picturelink;
            this.journal = journal;
            this.lengthofstay = lengthofstay;
            this.companions = null;
            placeslist.Add(this);
            this.id = placeslist.Count;
        }
        public Place(string cityname, string picturelink, string journal, int lengthofstay, string[] companions)
        {
            this.cityname = cityname;
            this.picturelink = picturelink;
            this.journal = journal;
            this.lengthofstay = lengthofstay;
            this.companions = companions;
            placeslist.Add(this);
            this.id = placeslist.Count;
        }

        public string getCityName()
        {
            return this.cityname;
        }
        public void setCityName(string newname)
        {
            this.cityname = newname;
        }
        public string getPictureLink()
        {
            return this.picturelink;
        }
        public void setPictureLink(string newpicture)
        {
            this.picturelink = newpicture;
        }

        public string getJournal()
        {
            return this.journal;
        }
        public void setJournal(string newjournal)
        {
            this.journal = newjournal;
        }
        public int getLengthOfStay()
        {
            return this.lengthofstay;
        }
        public void setLengthOfStay(int newlengthofstay)
        {
            this.lengthofstay = newlengthofstay;
        }
        public string[] getCompanions()
        {
            return this.companions;
        }
        public void setCompanions(string[] newcompanions)
        {
            this.companions = newcompanions;
        }
         public int getId()
        {
            return this.id;
        }


         public static List<Place> getAllPlaces()
        {
            return placeslist;
        }
        public static void clearAllPlaces()
        {
            placeslist.Clear();
        }
        public static Place Find(int searchId)
        {
            return placeslist[searchId-1];
        }
        public string toString()
        {
            string result ="City name: "+this.cityname + ", Journal: " +this.journal +
            ", Length of the stay: " + this.lengthofstay  + ", Id: " + this.id;
            return result;
        }

    }
}