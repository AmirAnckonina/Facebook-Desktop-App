using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBServiceLogic.DummyData
{
    public class DummyFriends : IDummyData
    {
        public DummyFriends()
        {
            this.Friends = createDummyFriends();
        }

        public List<DummyUser> Friends { get; set; } 

        private List<DummyUser> createDummyFriends()
        {
            List<DummyUser> dummyFriends = new List<DummyUser>();
            DummyUser dummy;

            dummy = new DummyUser();
            dummy.Name = "Amir Anckonina";
            dummy.Hometown = "Givatayim";
            dummy.Education = "Jaffa College";
            dummy.PictureURL = "https://post.medicalnewstoday.com/wp-content/uploads/sites/3/2020/02/322868_1100-800x825.jpg";
            dummy.OnlineStatus = RandomDataGenerator.GenerateOnlineStatus();
            dummyFriends.Add(dummy);

            dummy = new DummyUser();
            dummy.Name = "Idan Zimilis";
            dummy.Hometown = "Jaffa";
            dummy.Education = "Jaffa College";
            dummy.PictureURL = "https://i.natgeofe.com/n/4f5aaece-3300-41a4-b2a8-ed2708a0a27c/domestic-dog_thumb_4x3.jpg";
            dummy.OnlineStatus = RandomDataGenerator.GenerateOnlineStatus();
            dummyFriends.Add(dummy);

            dummy = new DummyUser();
            dummy.Name = "Erez Cohen";
            dummy.Hometown = "Givatayim";
            dummy.Education = "Jaffa College";
            dummy.PictureURL = "https://d17fnq9dkz9hgj.cloudfront.net/breed-uploads/2022/03/teddybear-dog-breeds.jpeg?bust=1646780646";
            dummy.OnlineStatus = RandomDataGenerator.GenerateOnlineStatus();
            dummyFriends.Add(dummy);

            dummy = new DummyUser();
            dummy.Name = "Chen Berger";
            dummy.Hometown = "Jaffa";
            dummy.Education = "Technion";
            dummy.PictureURL = " https://www.cdc.gov/healthypets/images/pets/angry-dog.jpg?_=03873";
            dummy.OnlineStatus = RandomDataGenerator.GenerateOnlineStatus();
            dummyFriends.Add(dummy);

            dummy = new DummyUser();
            dummy.Name = "Snir Sherf";
            dummy.Hometown = "Givatayim";
            dummy.Education = "Tel Aviv University";
            dummy.PictureURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ363CgmldrjqU6bRNyGZHSljkQUSV8izOhBA&usqp=CAU";
            dummy.OnlineStatus = RandomDataGenerator.GenerateOnlineStatus();
            dummyFriends.Add(dummy);

            dummy = new DummyUser();
            dummy.Name = "Amir Kirshenzwig";
            dummy.Hometown = "Holon";
            dummy.Education = "HIT";
            dummy.PictureURL = "https://images.newscientist.com/wp-content/uploads/2022/04/05152010/SEI_97255351.jpg";
            dummy.OnlineStatus = RandomDataGenerator.GenerateOnlineStatus();
            dummyFriends.Add(dummy);

            dummy = new DummyUser();
            dummy.Name = "Desig Patter";
            dummy.Hometown = "Givatayim";
            dummy.Education = "Jaffa College";
            dummy.PictureURL = "https://media.newyorker.com/photos/5d0d56a203a303d37b7e4451/1:1/w_1660,h_1660,c_limit/Hutton-DevilExpression.jpg";
            dummy.OnlineStatus = RandomDataGenerator.GenerateOnlineStatus();
            dummyFriends.Add(dummy);

            return dummyFriends;
        }
    }
}
