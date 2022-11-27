using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBServiceLogic.DummyData
{
    public static class DummyDataCreator
    {
        public static int GenerateRandLikesCount()
        {
            Random rand = new Random();
            int likes;

            likes = rand.Next(0, 1000000);

            return likes;
        }

        public static SingleDummyUser SetDummyDataForCurrentUser(string i_Name, string i_ProfilePictureURL)
        {
            SingleDummyUser dummyUser = new SingleDummyUser();

            dummyUser.Name = i_Name;
            dummyUser.Hometown = "Givatayim";
            dummyUser.Education = "Jaffa College";
            dummyUser.ProfilePictureURL = i_ProfilePictureURL;

            return dummyUser;
        }

        public static DummyUsers CreateDummyUsers()
        {
            DummyUsers dummyUsers = new DummyUsers();

            SingleDummyUser dummy = new SingleDummyUser();
            dummy.Name = "Amir Anckonina";
            dummy.Hometown = "Givattayim";
            dummy.Education = "Jaffa College";
            dummy.ProfilePictureURL = "https://scontent.ftlv19-1.fna.fbcdn.net/v/t39.30808-6/278259031_10217472948335929_6944866859029329988_n.jpg?_nc_cat=102&amp;ccb=1-7&amp;_nc_sid=09cbfe&amp;_nc_ohc=ZAyYx_OTH_oAX9W-O7s&amp;tn=nxpwZqIw4rlQvPQw&amp;_nc_ht=scontent.ftlv19-1.fna&amp;oh=00_AfCljiyUKYs49SoAAm-koF7V3lIREhPShV2Bx1y5yaBVhw&amp;oe=63873135";
            dummyUsers.FBUsers.Add(dummy);

            dummy.Name = "Idan Zimilis";
            dummy.Hometown = "Jaffa";
            dummy.Education = "Jaffa College";
            dummy.ProfilePictureURL = "https://scontent.ftlv19-1.fna.fbcdn.net/v/t39.30808-6/245628574_6703347393016523_4021478128689167373_n.jpg?_nc_cat=109&amp;ccb=1-7&amp;_nc_sid=09cbfe&amp;_nc_ohc=VEedENsrxO8AX9YNqAr&amp;_nc_ht=scontent.ftlv19-1.fna&amp;oh=00_AfDauvbFW2K_cEIbMGWkT8VALu-7ppP1Gq-hfvzdL31elg&amp;oe=63868B0B";
            dummyUsers.FBUsers.Add(dummy);

            dummy.Name = "Erez Cohen";
            dummy.Hometown = "Givattayim";
            dummy.Education = "Jaffa College";
            dummy.ProfilePictureURL = ">https://scontent.ftlv19-1.fna.fbcdn.net/v/t39.30808-6/316040001_440216028312472_5391648209224016818_n.jpg?_nc_cat=104&amp;ccb=1-7&amp;_nc_sid=0debeb&amp;_nc_ohc=owh0IQLYHmcAX_ZDz4h&amp;_nc_ht=scontent.ftlv19-1.fna&amp;oh=00_AfCI1ehV9hWIXoR4ltrVPZx8xaTs2LhjMcE4sxQXaESfGA&amp;oe=6385BCDC";
            dummyUsers.FBUsers.Add(dummy);

            dummy.Name = "Chen Berger";
            dummy.Hometown = "Jaffa";
            dummy.Education = "Technion";
            dummy.ProfilePictureURL = "https://scontent.ftlv19-1.fna.fbcdn.net/v/t1.6435-9/188702416_10219651285140593_802735205831804679_n.jpg?_nc_cat=105&amp;ccb=1-7&amp;_nc_sid=09cbfe&amp;_nc_ohc=J7a_N_ZfkOQAX9nS8n2&amp;_nc_ht=scontent.ftlv19-1.fna&amp;oh=00_AfCj0-cyekLxAGcn7XFdILsMuhY5G_6M4VMCnkcVOvqG7g&amp;oe=63A927CB";
            dummyUsers.FBUsers.Add(dummy);

            dummy.Name = "Snir Sherf";
            dummy.Hometown = "Givattayim";
            dummy.Education = "Tel Aviv University";
            dummy.ProfilePictureURL = "https://scontent.ftlv19-1.fna.fbcdn.net/v/t1.6435-9/57155385_10218643605226975_6288622751808749568_n.jpg?_nc_cat=109&amp;ccb=1-7&amp;_nc_sid=09cbfe&amp;_nc_ohc=LXJKrC9MIHkAX8OsdwG&amp;tn=nxpwZqIw4rlQvPQw&amp;_nc_ht=scontent.ftlv19-1.fna&amp;oh=00_AfCaP_f8drB9KLQwP5Kj1mmXg1MPwIZcp_S808Wj-3RjNg&amp;oe=63A94371";
            dummyUsers.FBUsers.Add(dummy);

            dummy.Name = "Amir Kirshenzwig";
            dummy.Hometown = "Holon";
            dummy.Education = "HIT";
            dummy.ProfilePictureURL = "https://scontent.ftlv19-1.fna.fbcdn.net/v/t1.6435-9/111713405_10218036624093631_252183103263708259_n.jpg?_nc_cat=105&amp;ccb=1-7&amp;_nc_sid=09cbfe&amp;_nc_ohc=y0p7hYFWIekAX-pQ373&amp;_nc_ht=scontent.ftlv19-1.fna&amp;oh=00_AfAMqJEAVJj0oXi7PzPKuiA6cEwhmJn23OR4VAwt84rATQ&amp;oe=63A943B8";
            dummyUsers.FBUsers.Add(dummy);

            dummy.Name = "Desig Patter";
            dummy.Hometown = "Givatayim";
            dummy.Education = "Jaffa College";
            dummy.ProfilePictureURL = "https://scontent.ftlv19-1.fna.fbcdn.net/v/t1.6435-9/117803866_3020504371412230_6906581810340608107_n.jpg?_nc_cat=102&amp;ccb=1-7&amp;_nc_sid=09cbfe&amp;_nc_ohc=lQHiYQ-N1k4AX_liUdO&amp;_nc_ht=scontent.ftlv19-1.fna&amp;oh=00_AfBEQObHheRwlTmK-6_s2-Iffal6If0lHOzU7x7BmVqQbg&amp;oe=63A92801";
            dummyUsers.FBUsers.Add(dummy);
           

            return dummyUsers;
        }
    }
}
