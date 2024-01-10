namespace RudimentsAPI;

public class Rudiment
{
    public int PASNumber { get; set; }

    public string RudimentName { get; set; }
   
    public Rudiment(int pasNumber, string rudimentName)
    { 
        PASNumber = pasNumber;
        RudimentName = rudimentName;
    }
}