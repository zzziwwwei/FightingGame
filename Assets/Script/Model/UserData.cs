using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
namespace GameData
{
    public class UserData
    {
        string username;
        string token;
        public UserData(string username, string token)
        {
            this.username = username;
            this.token = token;
        }
        public class AccountData
        {
            Dictionary<int, string> have_character;
        }
        public void Token(string token)
        {
            if (token == this.token)
            {
                
                void ChangeUsername(string name, string token)
                {
                    this.username = name;
                }
                void GetToken(string token)
                {

                    this.token = token;
                }
            }
        }

    }
}
