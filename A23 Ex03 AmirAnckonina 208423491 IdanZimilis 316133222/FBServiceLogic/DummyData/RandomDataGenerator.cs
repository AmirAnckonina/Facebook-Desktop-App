using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBServiceLogic.DummyData
{
    internal static class RandomDataGenerator
    {
        public static eOnlineStatus GenerateOnlineStatus()
        {
            eOnlineStatus status;
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            int randResult;

            randResult = rand.Next(0, Enum.GetValues(typeof(eOnlineStatus)).Length);
            status = (eOnlineStatus)randResult;

            return status;
        }

        public static long? GenerateRandLikesCount()
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            long? likes;
            likes = rand.Next(0, 1000000);

            return likes;
        }

        public static int GenerateRandGroupMemebersCount()
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            int members;
            members = rand.Next(0, 10000);

            return members;
        }
    }
}
