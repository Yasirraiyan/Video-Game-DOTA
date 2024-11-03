    public class GamingEventTeam
    {
        public int team_id;
        public string team_name;
        public bool isElemenated=false;
        public int team_number;
       
        public GamingEventTeam(int team_id, string team_name, bool isElemenated)
        {
            this.team_id = team_id;
            this.team_name = team_name;
            this.isElemenated = isElemenated;
            
        }
        public string GetTShirt(string team_name)
        {
            
            if(team_name=="A")
            {
                Console.WriteLine($"The teams shirt size is M:{team_name}");
            }
            if (team_name == "B")
            {
                Console.WriteLine($"The teams shirt size is L:{team_name}");
            }
            if (team_name == "C")
            {
                Console.WriteLine($"The teams shirt size is XL:{team_name}");
            }
            if (team_name == "D")
            {
                Console.WriteLine($"The teams shirt size is XXL:{team_name}");
            }
            if (team_name == "E")
            {
                Console.WriteLine($"The teams shirt size is XXL:{team_name}");
            }
            else
            {
                Console.WriteLine("Invalid!");

            }
            return team_name;
        }
        public void payfees(string team_name)
        {
            if (team_name == "A")
            {
                Console.WriteLine("The teams pay fee 3000");
            }
            if (team_name == "B")
            {
                Console.WriteLine($"The teams pay fee:{2*3000}");
            }
            if (team_name == "C")
            {
                Console.WriteLine($"The teams pay fee:{3*3000}");
            }
            if (team_name == "D")
            {
                Console.WriteLine($" The teams pay fee 3000{4*3000}");
            }
            if (team_name == "E")
            {
                Console.WriteLine($"The teams pat=y fee:{5*3000}");
            }
            else
            {
                Console.WriteLine("Not paying any fee!");

            }
        }
        public bool verifyeliminate(bool isElemenated)
        {
            if(!isElemenated)
            {
                Console.WriteLine("The team will be elemenated");
            }
            else
            {
                Console.WriteLine("Not elemenated");
            }
            return isElemenated;

        }
        public void calculatecost(int team_number,string team_name)
        {
            if(team_name=="NFS")
            {
                Console.WriteLine($"The NFS team is paying:{team_number*500}");
            }
            if(team_name=="DOTA")
            {
                Console.WriteLine($"The Dota team is paying:{team_number * 1200}");
            }
            else
            {
                Console.WriteLine("Not Paying.");
            }
        }
        public string geteamname(string team_name)
        {
            return team_name;

        }
        public void getid(string team_name)
        {
            if (team_name=="NFS")
            {
                Console.WriteLine("Team id is 101.");
            }
            if (team_name == "DOTA")
            {
                Console.WriteLine("Team id is 102.");
            }
        }
        public void getteamnumber(string team_name)
        {
            if( team_name=="NFS")
            {
                Console.WriteLine("Team number is  1.");
            }
            if(team_name=="DOTA")
            {
                Console.WriteLine("Team number is  2.");
            }
        }
        public int getteamid()
        {
            return team_id;
        }
    }
}
