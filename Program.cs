class program
{
    public static void Main(string[] args)
    {
        Account a1 = new Account(4000,1,2000,100);
        Account a2 = new Account(-500,2,400,10);
        Console.WriteLine(a1.getid());
        Console.WriteLine(a1.withdraw(4000,2000));
        Console.WriteLine(a1.diposit(4000,2000));
        Console.WriteLine(a1.display(1,100));
        a1.checkvalidity(4000);
        Console.WriteLine(a1.gettotalbalance(4000));
        Console.WriteLine(a1.getcurrentbalance(4000));
        Console.WriteLine(a1.getfee3(4000,2000));
        Console.WriteLine(a2.getid());
        Console.WriteLine(a2.withdraw(-500, 400));
        Console.WriteLine(a2.diposit(-500, 400));
        Console.WriteLine(a2.display(2, 10));
        a2.checkvalidity(-500);
        Console.WriteLine(a2.gettotalbalance(-500));
        Console.WriteLine(a2.getcurrentbalance(-500));
        Console.WriteLine(a2.getfee3(-500, 400));
        Console.WriteLine(a2.getfee());
        GamingEventTeam teamA = new GamingEventTeam(1, "A", false); 
        GamingEventTeam teamB = new GamingEventTeam(2, "B", true);
        GamingEventTeam teamC = new GamingEventTeam(3, "C", false); 
        GamingEventTeam teamD = new GamingEventTeam(4, "D", true); 
        GamingEventTeam teamE = new GamingEventTeam(5, "E", false); 
        GamingEventTeam teamNFS = new GamingEventTeam(101, "NFS", false); 
        GamingEventTeam teamDOTA = new GamingEventTeam(102, "DOTA", true);  
        teamA.GetTShirt(teamA.team_name); 
        teamB.GetTShirt(teamB.team_name); 
        teamC.GetTShirt(teamC.team_name); 
        teamD.GetTShirt(teamD.team_name); 
        teamE.GetTShirt(teamE.team_name); 
        Pay fees teamA.payfees(teamA.team_name); 
        teamB.payfees(teamB.team_name); 
        teamC.payfees(teamC.team_name); 
        teamD.payfees(teamD.team_name); 
        teamE.payfees(teamE.team_name); 
        teamA.verifyeliminate(teamA.isElemenated); 
        teamB.verifyeliminate(teamB.isElemenated); 
        teamC.verifyeliminate(teamC.isElemenated); 
        teamD.verifyeliminate(teamD.isElemenated); 
        teamE.verifyeliminate(teamE.isElemenated); 
        teamNFS.calculatecost(10, teamNFS.team_name); 
        teamDOTA.calculatecost(8, teamDOTA.team_name); 
        Console.WriteLine($"Team A name: {teamA.geteamname(teamA.team_name)}"); 
        Console.WriteLine($"Team B name: {teamB.geteamname(teamB.team_name)}"); 
        teamNFS.getid(teamNFS.team_name); teamDOTA.getid(teamDOTA.team_name); 
        teamNFS.getteamnumber(teamNFS.team_name); teamDOTA.getteamnumber(teamDOTA.team_name); 
        Console.WriteLine($"Team A ID: {teamA.getteamid()}");
        Console.WriteLine($"Team DOTA ID: {teamDOTA.getteamid()}");
        Team teamNFS = new Team(1, "NFS", "Participant1", 5, "InstituteA", 0, "Danish", 101, 5, "M", false); 
        Team teamDOTA = new Team(2, "DOTA", "Participant2", 7, "InstituteB", 0, "English", 102, 5, "L", true); 
        Team teamA = new Team(3, "A", "Participant3", 6, "InstituteC", 0, "Spanish", 103, 5, "S", true); 
        Team teamB = new Team(4, "B", "Participant4", 4, "InstituteD", 0, "French", 104, 5, "XL", false);
        int randomNumberNFS = teamNFS.submitsolution();
        int randomNumberDOTA = teamDOTA.submitsolution(); 
        teamNFS.gettotalpoint(teamNFS.turn, randomNumberNFS); 
        teamDOTA.gettotalpoint(teamDOTA.turn, randomNumberDOTA); 
        teamNFS.payfees(teamNFS.planguage); 
        teamDOTA.payfees(teamDOTA.planguage);
        teamNFS.gettotalfee(1); 
        teamDOTA.gettotalfee(2); 
        teamNFS.winteam(5, randomNumberNFS); 
        teamDOTA.winteam(5, randomNumberDOTA); 
        teamNFS.gettshirt(teamNFS.teamname, teamNFS.t_shirt_size); 
        teamDOTA.gettshirt(teamDOTA.teamname, teamDOTA.t_shirt_size); 
        teamNFS.teamvalidate(teamNFS.teamname); 
        teamDOTA.teamvalidate(teamDOTA.teamname); 
        teamA.teamvalidate(teamA.teamname); 
        teamB.teamvalidate(teamB.teamname); 
        Console.WriteLine($"Team NFS name: {teamNFS.getteamname()}"); 
        Console.WriteLine($"Team DOTA name: {teamDOTA.getteamname()}"); 
        teamNFS.getteamid(teamNFS.teamid); 
        teamDOTA.getteamid(teamDOTA.teamid); 
        teamNFS.checkvalidityparticipant(teamNFS.teamname);
        teamDOTA.checkvalidityparticipant(teamDOTA.teamname); 
        teamA.checkvalidityparticipant(teamA.teamname); 
        teamB.checkvalidityparticipant(teamB.teamname); 
        teamNFS.getinstitute(teamNFS.teamname);
        teamDOTA.getinstitute(teamDOTA.teamname); /
        Console.WriteLine($"Participant count for team NFS: {teamNFS.getpcount(teamNFS.turn)}"); 
        Console.WriteLine($"Participant count for team DOTA: {teamDOTA.getpcount(teamDOTA.turn)}"); 
        Console.WriteLine($"Total points for team NFS: {teamNFS.gettotalpointt(teamNFS.turn, teamNFS.pcount)}"); 
        Console.WriteLine($"Total points for team DOTA: {teamDOTA.gettotalpointt(teamDOTA.turn, teamDOTA.pcount)}");
        teamNFS.getplanguage(teamNFS.teamname); 
        teamDOTA.getplanguage(teamDOTA.teamname);
        teamNFS.getroomnumber(teamNFS.teamid); 
        teamDOTA.getroomnumber(teamDOTA.teamid); 
        teamNFS.check_validity_of_turn(teamNFS.turn, teamNFS.exist);
        teamDOTA.check_validity_of_turn(teamDOTA.turn,teamNFS.turn);
        Participant participant1 = new Participant(1, "Alice", "123 Main St", "Institution A", "M"); 
        Participant participant2 = new Participant(2, "Bob", "456 Maple Ave", "Institution B", "L"); 
        Participant participant3 = new Participant(3, "Charlie", "789 Elm St", "Institution A", "S"); 
        
        participant1.DisplayDetails();  
        participant2.DisplayDetails(); 
        participant3.DisplayDetails();
        participant1.CheckAddress("Main"); 
        participant2.CheckAddress("Main"); 
        participant1.ValidateTshirtSize(); 
        participant2.ValidateTshirtSize(); 
        participant3.ValidateTshirtSize(); 
        Participant[] participants = { participant1, participant2, participant3 };
        Participant.CalculateParticipantsFromInstitution(participants, "Institution A");

    }
}
