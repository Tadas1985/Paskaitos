using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TV_Programme
    {
        public List<TV_Show> ListOfTVShows { get; set; }

        public TV_Programme()
        {
            List<TV_Show> ListOfRTshows = new List<TV_Show>();
        }  

        public void AddTVShow(TV_Show tv1)
        {
            ListOfTVShows.Add(tv1);
        }
        public void RemoveTVShowByName( string name)
        {

            foreach (var item  in ListOfTVShows)
            {
                if (item.Title == "Name")
                { 
                    ListOfTVShows.Remove(item);
                    break;
                }
            }
            
        }

        public void RemoveTVShowByID(TV_Programme listOfTVShows, Guid guid)
        {
            foreach (var item in ListOfTVShows)
            {
                if (item.ID == guid)
                {
                    ListOfTVShows.Remove(item);
                }
                return;
            }
        }
        public void PrintProgram(List<TV_Show>list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Title}, {item.Duration}, {item.Description}, {item.ID}");
            }
        }
        
    }
    
}
