using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    public enum GenreType
    {
        Horror = 1, RomCom, Fantasy, SciFi, Drama, Comedy, Action, Documentary, Suspence
            // Adding the 1 to Horror causes the list to start at 1 instead of 0.
    }

    // enum for MaturityRating:
    public enum MaturityRate { G, PG, PG_13, R, NC_17, MA}

    public class StreamingContent
    {
        public string Title { get; set; } // prop + tab + tab
        public string Description { get; set; }
        public float StarRating { get; set; }
        public MaturityRate MaturityRating { get; set; }
        public bool FamilyFriendly 
        {   
            get
            {
                switch (MaturityRating)
                {
                    case MaturityRate.G:
                    case MaturityRate.PG:
                        return true;
                    case MaturityRate.PG_13:
                    case MaturityRate.R:
                    case MaturityRate.NC_17:
                    case MaturityRate.MA:
                        return false;
                    default:        // default is needed for cases outside given parameters.
                        return false;
                }
                if((int)MaturityRating <=1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public GenreType TypeOfGenre { get; set; }

        public StreamingContent() { }
        public StreamingContent(string title, string description, int starRating, MaturityRate mRating, bool famFriend, GenreType tOG)
        {
            Title = title;
            Description = description;
            StarRating = starRating;
            MaturityRating = mRating;
           // FamilyFriendly = famFriend;
            TypeOfGenre = tOG;
        }
    }
}
