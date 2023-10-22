using System;
using System.Collections.Generic;
using System.Numerics;
using System;
using UnityEngine;


namespace GameSystem.Model
{
    public class GameLog : MonoBehaviour
    {
        public class Log
        {
            public int currentFrame;
            public GameSystem.Key key;

        }
        List<Log[]> gamelog;

        int length;
        void Init()
        {
            this.gamelog = new();
            this.length = 60 * 60 * 3;
        }
        public void LoadKey(int id, int currentFrame, Log log)
        {
            var logs = gamelog[id];
            logs[log.currentFrame] = log;
        }
        public Log GetKey(int id, int currentFrame)
        {            
            return gamelog[id][currentFrame];
        }
        public void AddLog()
        {
            gamelog.Add(new Log[length]);
        }
        public void DeleteLog(int id)
        {
            gamelog.Remove(gamelog[id]);
        }
        void Start()
        {
            Init();
        }

    }
}
