using FriendOrganizer.Model;
using System.Collections.Generic;

namespace FriendOrganizer.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        public IEnumerable<Friend> GetAll()
        {
            // TODO: Load data from real database
            yield return new Friend { FirstName = "Arthur", LastName = "Black" };
            yield return new Friend { FirstName = "Holly", LastName = "Newman" };
            yield return new Friend { FirstName = "Remy", LastName = "Villarreal" };
            yield return new Friend { FirstName = "Kassandra", LastName = "Gardner" };
        }
    }
}
