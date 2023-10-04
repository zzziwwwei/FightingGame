
using UnityEngine;
using GameData;
using Palmmedia.ReportGenerator.Core.Common;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System;
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
        GameData.PlayerData playerData;
        GameData.GameLog gameLog;
       
        void Start()
        {
           
        }

      

        void LoadData()
        {
            userData = new("", 1, "token");
            playerData = new();
            gameLog = new();
            gameLog.AddLog(userData.user_id);
        }


    }
}
