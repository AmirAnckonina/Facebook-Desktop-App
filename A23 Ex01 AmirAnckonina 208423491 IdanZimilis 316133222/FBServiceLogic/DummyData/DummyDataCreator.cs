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
            dummy.Hometown = "Givattayim";
            dummy.Education = "Jaffa College";
            dummy.PictureURL = "https://scontent.ftlv19-1.fna.fbcdn.net/v/t39.30808-6/278259031_10217472948335929_6944866859029329988_n.jpg?_nc_cat=102&amp;ccb=1-7&amp;_nc_sid=09cbfe&amp;_nc_ohc=ZAyYx_OTH_oAX9W-O7s&amp;tn=nxpwZqIw4rlQvPQw&amp;_nc_ht=scontent.ftlv19-1.fna&amp;oh=00_AfCljiyUKYs49SoAAm-koF7V3lIREhPShV2Bx1y5yaBVhw&amp;oe=63873135";
            dummy.OnlineStatus = GenerateRandOnlineStatus();
            dummyFriends.Add(dummy);

            dummy = new DummyUser();
            dummy.Name = "Idan Zimilis";
            dummy.Hometown = "Jaffa";
            dummy.Education = "Jaffa College";
            dummy.PictureURL = "https://scontent.ftlv19-1.fna.fbcdn.net/v/t39.30808-6/245628574_6703347393016523_4021478128689167373_n.jpg?_nc_cat=109&amp;ccb=1-7&amp;_nc_sid=09cbfe&amp;_nc_ohc=VEedENsrxO8AX9YNqAr&amp;_nc_ht=scontent.ftlv19-1.fna&amp;oh=00_AfDauvbFW2K_cEIbMGWkT8VALu-7ppP1Gq-hfvzdL31elg&amp;oe=63868B0B";
            dummy.OnlineStatus = GenerateRandOnlineStatus();
            dummyFriends.Add(dummy);

            dummy = new DummyUser();
            dummy.Name = "Erez Cohen";
            dummy.Hometown = "Givattayim";
            dummy.Education = "Jaffa College";
            dummy.PictureURL = ">https://scontent.ftlv19-1.fna.fbcdn.net/v/t39.30808-6/316040001_440216028312472_5391648209224016818_n.jpg?_nc_cat=104&amp;ccb=1-7&amp;_nc_sid=0debeb&amp;_nc_ohc=owh0IQLYHmcAX_ZDz4h&amp;_nc_ht=scontent.ftlv19-1.fna&amp;oh=00_AfCI1ehV9hWIXoR4ltrVPZx8xaTs2LhjMcE4sxQXaESfGA&amp;oe=6385BCDC";
            dummy.OnlineStatus = GenerateRandOnlineStatus();
            dummyFriends.Add(dummy);

            dummy = new DummyUser();
            dummy.Name = "Chen Berger";
            dummy.Hometown = "Jaffa";
            dummy.Education = "Technion";
            dummy.PictureURL = "https://scontent.ftlv19-1.fna.fbcdn.net/v/t1.6435-9/188702416_10219651285140593_802735205831804679_n.jpg?_nc_cat=105&amp;ccb=1-7&amp;_nc_sid=09cbfe&amp;_nc_ohc=J7a_N_ZfkOQAX9nS8n2&amp;_nc_ht=scontent.ftlv19-1.fna&amp;oh=00_AfCj0-cyekLxAGcn7XFdILsMuhY5G_6M4VMCnkcVOvqG7g&amp;oe=63A927CB";
            dummy.OnlineStatus = GenerateRandOnlineStatus();
            dummyFriends.Add(dummy);

            dummy = new DummyUser();
            dummy.Name = "Snir Sherf";
            dummy.Hometown = "Givattayim";
            dummy.Education = "Tel Aviv University";
            dummy.PictureURL = "https://scontent.ftlv19-1.fna.fbcdn.net/v/t1.6435-9/57155385_10218643605226975_6288622751808749568_n.jpg?_nc_cat=109&amp;ccb=1-7&amp;_nc_sid=09cbfe&amp;_nc_ohc=LXJKrC9MIHkAX8OsdwG&amp;tn=nxpwZqIw4rlQvPQw&amp;_nc_ht=scontent.ftlv19-1.fna&amp;oh=00_AfCaP_f8drB9KLQwP5Kj1mmXg1MPwIZcp_S808Wj-3RjNg&amp;oe=63A94371";
            dummy.OnlineStatus = GenerateRandOnlineStatus();
            dummyFriends.Add(dummy);

            dummy = new DummyUser();
            dummy.Name = "Amir Kirshenzwig";
            dummy.Hometown = "Holon";
            dummy.Education = "HIT";
            dummy.PictureURL = "https://scontent.ftlv19-1.fna.fbcdn.net/v/t1.6435-9/111713405_10218036624093631_252183103263708259_n.jpg?_nc_cat=105&amp;ccb=1-7&amp;_nc_sid=09cbfe&amp;_nc_ohc=y0p7hYFWIekAX-pQ373&amp;_nc_ht=scontent.ftlv19-1.fna&amp;oh=00_AfAMqJEAVJj0oXi7PzPKuiA6cEwhmJn23OR4VAwt84rATQ&amp;oe=63A943B8";
            dummy.OnlineStatus = GenerateRandOnlineStatus();
            dummyFriends.Add(dummy);

            dummy = new DummyUser();
            dummy.Name = "Desig Patter";
            dummy.Hometown = "Givatayim";
            dummy.Education = "Jaffa College";
            dummy.PictureURL = "https://scontent.ftlv19-1.fna.fbcdn.net/v/t1.6435-9/117803866_3020504371412230_6906581810340608107_n.jpg?_nc_cat=102&amp;ccb=1-7&amp;_nc_sid=09cbfe&amp;_nc_ohc=lQHiYQ-N1k4AX_liUdO&amp;_nc_ht=scontent.ftlv19-1.fna&amp;oh=00_AfBEQObHheRwlTmK-6_s2-Iffal6If0lHOzU7x7BmVqQbg&amp;oe=63A92801";
            dummy.OnlineStatus = GenerateRandOnlineStatus();
            dummyFriends.Add(dummy);


            return dummyFriends;
        }
    }
}
