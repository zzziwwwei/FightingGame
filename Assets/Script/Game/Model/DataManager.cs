
using UnityEngine;
namespace GameSystem.Model
{
    public class CharactorData
    {
        CharactorData charactorData;
        CharactorData GetData()
        {
            return charactorData;
        }
    }

    public class DataManager : MonoBehaviour
    {
        public GameSystem.Model.UserData userData;
        public GameSystem.Model.PlayerData playerData;
        public GameSystem.Model.GameLog gameLog;
        public GameSystem.Model.CharactorData charactorData;
        void Start()
        {
        }
        public void LoadData()
        {
            userData = new("", 1, "token");
            playerData = new();
            gameLog = new();
            //gameLog.AddLog(userData.user_id);
        }


    }
}
