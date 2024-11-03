    public class Team
    {
        public int teamid;
        public string teamname;
        public string participant;
        public int pcount;
        public string institute;
        public int totalpoint = 0;
        public string planguage;
        public int roomnumber;
        public int turn = 5;
        public string t_shirt_size;
        public bool exist=false;
        public Team(int teamid, string teamname, string participant, int pcount, string institute, int totalpoint, string planguage, int roomnumber, int turn, string shirt_size,bool exist)
        {
            this.teamid = teamid;
            this.teamname = teamname;
            this.participant = participant;
            this.pcount = pcount;
            this.institute = institute;
            this.totalpoint = totalpoint;
            this.planguage = planguage;
            this.roomnumber = roomnumber;
            this.turn = turn;
            t_shirt_size = shirt_size;
            this.exist = exist;
        }

        public int submitsolution()
        {
            Random rand = new Random();
            int randomnumber = rand.Next(0, 101);
            Console.WriteLine($"Random number between 0 and 100 is:{randomnumber}");
            return randomnumber;
        }
        public (int, int) gettotalpoint(int turn, int randomnumber)
        {
            int totalpoint = 0;
            while (turn > 0)
            {

                Console.WriteLine($"The present turn is:{turn}");
                turn--;
            }

            totalpoint = turn + randomnumber;
            Console.WriteLine($"The present turn is:{turn}");
            Console.WriteLine($"The present total point is:{totalpoint}");
            return (turn, totalpoint);
        }
        public string payfees(string planguage)
        {
            Console.WriteLine("The planguage fee is 3000");
            return planguage;
        }
        public int gettotalfee(int languagenumber)
        {
            int c = languagenumber * 3000;
            Console.WriteLine($"The total fee for planguage is:{c}");
            return c;
        }
        public int winteam(int initialturn, int randomnumber)
        {
            {
                var (remainingTurn, totalPoints) = gettotalpoint(initialturn, randomnumber);
                if (totalpoint > 50)
                {
                    Console.WriteLine("Team A wins.");
                    return 1;
                }
                else
                {

                    Console.WriteLine("Team B wins.");
                    return 2;
                }
            }
        }
        public (string, string) gettshirt(string teamname, string t_shirt_size)
        {
            Console.WriteLine($"The team name is:{teamname} and the t-shirt size is:{t_shirt_size}");
            return (teamname, t_shirt_size);
        }
        public void teamvalidate(string teamname)
        {
            if (teamname == "DOTA" || teamname == "NFS")
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid!");
            }
        }
        public string getteamname()
        {
            return teamname;
        }
        public int getteamid(int teamid)
        {
            if (teamid == 1)
            {
                Console.WriteLine($"Team is NFS.It's id is:{teamid}");
            }
            if (teamid == 2)
            {
                Console.WriteLine($"Team is DOTA.It's id is:{teamid}");
            }
            return teamid;
        }
        public void checkvalidityparticipant(string teamname)
        {
            if (teamname == "DOTA" || teamname == "NFS")
            {
                Console.WriteLine("Valid Participant");
            }
            else
            {
                Console.WriteLine("Invalid Participant!");
            }
        }
        public string getinstitute(string teamname)
        {

            if (teamname == "DOTA")
            {
                Console.WriteLine($"The team institute is:{teamname}");
            }
            if (teamname == "NFS")
            {
                Console.WriteLine($"The team institute is:{teamname}");
            }
            return teamname;

        }
        public int getpcount(int turn)
        {
            return turn;
        }

        public int gettotalpointt(int turn, int pcount)
        {
            return turn * pcount;
        }
        public void getplanguage(string teamname)
        {
            if (teamname == "DOTA")
            {
                Console.WriteLine("The language of DOTA is Danish");
            }
            if (teamname == "NFS")
            {
                Console.WriteLine("The language of NFS is NFS");

            }
        }
        public int getroomnumber(int teamid)
        { 
           int roomnumber = teamid * 100;
            Console.WriteLine($"The room of the team which id is:{teamid} room number is:{roomnumber}");
            return roomnumber;

        }
        public void check_validity_of_turn(int turn,bool exist)
        {
            while (!exist)
            {
                if(turn>0)
                {
                    Console.WriteLine("Exist");
                }
                turn--;
            }
            if(turn==0&&exist)
            {
                Console.WriteLine("Dead and not exist.");
            }
            
        }
    }
}

