
using System.Collections.Generic;
using Unity.VisualScripting;

namespace GameSystem.Model
{
    public class PlayerData
    {
        public class Data
        {
            string name;
            int id;
            string charactor;
            int charactor_id;
        }
        public Dictionary<int, Data> playerDatas;

    }
    public class RoleData_inGame
    {
        public Dictionary<int, RoleData> roleData_inGame;
        public void Add(int id)
        {
            roleData_inGame.Add(id, new RoleData());
        }
        public void Delete(int id)
        {
            roleData_inGame.Remove(id);
        }
        public class RoleData
        {
            int id;
            int position;
            State state;
            int statusCurrentFrame;
        }
        public enum State
        {
            move,
            jump,
            dash,
            attack1,
            attack2,
            attack3
        }

    }
}
