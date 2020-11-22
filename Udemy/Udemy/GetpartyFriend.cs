using System;
using System.Collections.Generic;
using System.Text;

namespace Udemy
{
    public class GetpartyFriend
    {
        public List<string> GetPartyFriends(List<string> list, int count)
        {
            List<string> partyFriends = new List<string>();

            while(count > partyFriends.Count)
            {
                string currentFriend = GetpartyFriends(list);
                partyFriends.Add(currentFriend);
                list.Remove(currentFriend);
            }
            return partyFriends;
        }

        public string GetpartyFriends(List<string> list)
        {
            string result = null;

            int len = list[0].Length;

            foreach(string str in list)
            {
                if(str.Length < len)
                {
                    result = str;
                }

            }

            return result;
        }
    }
}
