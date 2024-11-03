    public class Participant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Institution { get; set; }
        public string TshirtSize { get; set; } 
        public(int id, string name, string address, string institution, string tshirtSize) 
            { 
            Id = id; 
            Name = name;
            Address = address; 
            Institution = institution; 
            TshirtSize = tshirtSize; 
} 
    public void DisplayDetails() 
    { 
        Console.WriteLine($"ID: {Id}"); 
        Console.WriteLine($"Name: {Name}"); 
        Console.WriteLine($"Address: {Address}"); 
        Console.WriteLine($"Institution: {Institution}"); 
        Console.WriteLine($"T-shirt Size: {TshirtSize}"); 
    }
    public bool CheckAddress(string keyword) 
    { 
        if (Address.Contains(keyword)) 
        { 
            Console.WriteLine($"The address contains the keyword: {keyword}"); 
            return true; 
        } 
        else 
        { 
            Console.WriteLine($"The address does not contain the keyword: {keyword}");
            return false; 
        } 
    } 
    public void ValidateTshirtSize() 
    { 
        string[] validSizes = { "S", "M", "L", "XL", "XXL" }; 
        if (Array.Exists(validSizes, size => size == TshirtSize)) 
        { 
            Console.WriteLine("T-shirt size is valid."); 
        } 
        else 
        { 
            Console.WriteLine("T-shirt size is invalid."); 
        } 
    } 
    public static int CalculateParticipantsFromInstitution(Participant[] participants, string institution) 
    { 
        int count = 0; 
        foreach (var participant in participants) 
        { 
            if (participant.Institution == institution) 
            { 
                count++; 
            } 
        } 
        Console.WriteLine($"Total participants from {institution}: {count}"); 
        return count; 
    }

    }
 }

