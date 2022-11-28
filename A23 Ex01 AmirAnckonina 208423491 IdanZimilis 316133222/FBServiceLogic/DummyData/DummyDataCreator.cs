using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBServiceLogic.DummyData
{
    public static class DummyDataCreator
    {
        public static long? GenerateRandLikesCount()
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            long ? likes;

            likes = rand.Next(0, 1000000);

            return likes;
        }

        private static eOnlineStatus GenerateRandOnlineStatus()
        {
            eOnlineStatus status;
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            int randResult;

            randResult = rand.Next(0, Enum.GetValues(typeof(eOnlineStatus)).Length);
            status = (eOnlineStatus)randResult;

            return status;
        }

        public static DummyCurrentUser CreateDummyDataForCurrentUser(string i_Name, string i_ProfilePictureURL)
        {
            DummyCurrentUser dummyCurrUser = new DummyCurrentUser();

            dummyCurrUser.Name = i_Name;
            dummyCurrUser.Hometown = "Givatayim";
            dummyCurrUser.Education = "Jaffa College";
            dummyCurrUser.PictureURL = i_ProfilePictureURL;
            dummyCurrUser.OnlineStatus = eOnlineStatus.active;
            dummyCurrUser.Groups = CreateDummyGroups();
            dummyCurrUser.Friends = CreateDummyFriends();

            return dummyCurrUser;
        }

        private static List<DummyGroup> CreateDummyGroups()
        {
            List<DummyGroup> dummyGroups = new List<DummyGroup>();
            DummyGroup group;
            
            group = new DummyGroup();
            group.Name = "DP.COURSE.MTA.A23";
            group.PictureURL = "https://www.pngitem.com/pimgs/m/105-1052269_facebook-groups-facebook-groups-logo-png-transparent-png.png";
            group.MembersCount = 23;
            group.Privacy = eGroupPrivacy.Closed;
            dummyGroups.Add(group);

            group = new DummyGroup();
            group.Name = "Maccabi Haifa Fans";
            group.PictureURL = "https://upload.wikimedia.org/wikipedia/en/d/db/Maccabi_Haifa_FC_Logo_2020.png";
            group.MembersCount = 6000;
            group.Privacy = eGroupPrivacy.Open;
            dummyGroups.Add(group);

            group = new DummyGroup();
            group.Name = "Pregnant Women Tel Aviv";
            group.MembersCount = 6000;
            group.Privacy = eGroupPrivacy.Secret;
            group.PictureURL = "https://wwwen.uni.lu/var/storage/images/media/images/lcl_images/no_picture/1416637-1-fre-FR/no_picture.png";
            dummyGroups.Add(group);


            return dummyGroups;
        }

        public static List<DummyUser> CreateDummyFriends()
        {
            List<DummyUser> dummyFriends = new List<DummyUser>();
            DummyUser dummy;

            dummy = new DummyUser();
            dummy.Name = "Amir Anckonina";
            dummy.Hometown = "Givatayim";
            dummy.Education = "Jaffa College";
            dummy.PictureURL = "https://post.medicalnewstoday.com/wp-content/uploads/sites/3/2020/02/322868_1100-800x825.jpg";
            dummy.OnlineStatus = GenerateRandOnlineStatus();
            dummyFriends.Add(dummy);

            dummy = new DummyUser();
            dummy.Name = "Idan Zimilis";
            dummy.Hometown = "Jaffa";
            dummy.Education = "Jaffa College";
            dummy.PictureURL = "https://i.natgeofe.com/n/4f5aaece-3300-41a4-b2a8-ed2708a0a27c/domestic-dog_thumb_4x3.jpg";
            dummy.OnlineStatus = GenerateRandOnlineStatus();
            dummyFriends.Add(dummy);

            dummy = new DummyUser();
            dummy.Name = "Erez Cohen";
            dummy.Hometown = "Givatayim";
            dummy.Education = "Jaffa College";
            dummy.PictureURL = "https://d17fnq9dkz9hgj.cloudfront.net/breed-uploads/2022/03/teddybear-dog-breeds.jpeg?bust=1646780646";
            dummy.OnlineStatus = GenerateRandOnlineStatus();
            dummyFriends.Add(dummy);

            dummy = new DummyUser();
            dummy.Name = "Chen Berger";
            dummy.Hometown = "Jaffa";
            dummy.Education = "Technion";
            dummy.PictureURL = " https://www.cdc.gov/healthypets/images/pets/angry-dog.jpg?_=03873";
            dummy.OnlineStatus = GenerateRandOnlineStatus();
            dummyFriends.Add(dummy);

            dummy = new DummyUser();
            dummy.Name = "Snir Sherf";
            dummy.Hometown = "Givatayim";
            dummy.Education = "Tel Aviv University";
            dummy.PictureURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ363CgmldrjqU6bRNyGZHSljkQUSV8izOhBA&usqp=CAU";
            dummy.OnlineStatus = GenerateRandOnlineStatus();
            dummyFriends.Add(dummy);

            dummy = new DummyUser();
            dummy.Name = "Amir Kirshenzwig";
            dummy.Hometown = "Holon";
            dummy.Education = "HIT";
            dummy.PictureURL = "https://images.newscientist.com/wp-content/uploads/2022/04/05152010/SEI_97255351.jpg";
            dummy.OnlineStatus = GenerateRandOnlineStatus();
            dummyFriends.Add(dummy);

            dummy = new DummyUser();
            dummy.Name = "Desig Patter";
            dummy.Hometown = "Givatayim";
            dummy.Education = "Jaffa College";
            dummy.PictureURL = "https://media.newyorker.com/photos/5d0d56a203a303d37b7e4451/1:1/w_1660,h_1660,c_limit/Hutton-DevilExpression.jpg";
            dummy.OnlineStatus = GenerateRandOnlineStatus();
            dummyFriends.Add(dummy);


            return dummyFriends;
        }
    }
}
