using FriendOrganizer.DataAccess;
using FriendOrganizer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        private Func<FriendOrganizerDbContext> _contextCreator;

        public FriendDataService(Func<FriendOrganizerDbContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }

        //public IEnumerable<Friend> GetAll()
        //{
        //    //// TODO: Load data from real database
        //    //yield return new Friend { FirstName = "Arthur", LastName = "Black" };
        //    //yield return new Friend { FirstName = "Holly", LastName = "Newman" };
        //    //yield return new Friend { FirstName = "Remy", LastName = "Villarreal" };
        //    //yield return new Friend { FirstName = "Kassandra", LastName = "Gardner" };

        //    //using (var ctx = new FriendOrganizerDbContext())
        //    using (var ctx = _contextCreator())
        //    {
        //        return ctx.Friends.AsNoTracking().ToList();
        //    }
        //}

        //public async Task<List<Friend>> GetAllAsync()
        //{
        //    using (var ctx = _contextCreator())
        //    {
        //        var friends = await ctx.Friends.AsNoTracking().ToListAsync();
        //        await Task.Delay(5000);
        //        return friends;
        //    }
        //}

        public async Task<Friend> GetByIdAsync(int friendId)
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Friends.AsNoTracking().SingleAsync(f => f.Id == friendId);
            }
        }
    }
}
