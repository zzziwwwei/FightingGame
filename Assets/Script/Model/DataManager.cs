
using UnityEngine;
using GameData;
namespace GameSystem
{
    public class DataManager : MonoBehaviour
    {
        
        private static DataManager _instance;
        public static DataManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = FindObjectOfType<DataManager>();
                    if (_instance == null)
                    {
                        GameObject singletonObject = new GameObject("singletonObject");
                        _instance = singletonObject.AddComponent<DataManager>();
                    }
                }
                return _instance;
            }
        }
        private void Awake()
        {
            if (_instance != null && _instance != this)
            {
                Destroy(this.gameObject);
                return;
            }
            DontDestroyOnLoad(this.gameObject);
        }
        
        GameData.UserData userData;
        GameData.GameLog gameLog;
        void LoadData(){

            gameLog = new();
        }


    }
}
