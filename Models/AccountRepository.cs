namespace BusinnessUnits.Models
{
    public class AccountRepository
    {
        public static List<accountName> Accounts { get; set; }= new List<accountName>(){
                new accountName
                {
                    ID = 1,
                    AccountName = "Morgan Stanely",
                    BU_Head = "Mr.A",
                },
                new accountName
                {
                    ID = 2,
                    AccountName = "GS",
                    BU_Head = "Ms.B",
                }

            };
    }
}
