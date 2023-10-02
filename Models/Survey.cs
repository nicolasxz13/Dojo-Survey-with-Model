namespace Dojo_Survey_with_Model.Models
{
    public class Survey
    {
        public string Name {get; set;}
        public string Location{get; set;}
        public string Favorite{get; set;}
        public string Comment{get; set;}
        public Survey(){
            
        }
        public Survey(string name,string location,string favorite,string comment){
            Name = name;
            Location = location;
            Favorite = favorite;
            Comment = comment;
        }
    }
}
