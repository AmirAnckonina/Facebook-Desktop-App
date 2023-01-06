using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBServiceLogic.DummyData
{
    public static class FBDummyDataFactory
    {
        public static IDummyData CreateDummyData(string i_RequestedDataType)
        {
            IDummyData dummyData;
            eDummyDataType dataType;
            bool dataTypeParsedSuccessfully = Enum.TryParse(i_RequestedDataType, out dataType);

            if (dataTypeParsedSuccessfully)
            {
                switch(dataType)
                {
                    case eDummyDataType.User:
                        dummyData = DummyUser.createDummyInfoForCurrentUser();
                        break;

                    case eDummyDataType.Groups:
                        dummyData = new DummyGroups();
                        break;

                    case eDummyDataType.Friends:
                        dummyData = new DummyFriends();
                        break;

                    default:
                        throw new DummyDataTypeException();
                }
            }

            else
            {
                throw new DummyDataTypeException();
            }

            return dummyData;
        }      
    }
}
