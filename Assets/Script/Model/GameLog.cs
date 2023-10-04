using System;
using System.Collections.Generic;

namespace GameData
{
    public class GameLog
    {
        public Dictionary<int,GameSystem.KeyLog[]> gamelog {get; private set;}
        
        int length;
        public GameLog()
        {
            Init();
        }
        void Init()
        {
            this.gamelog = new();
            this.length = 60*60*3;
        }
        public void SetKeyLog(int id,GameSystem.KeyLog keyLog){
            var logs =  gamelog[id];
            logs[keyLog.currentFrame] = keyLog;
        }
        public void AddLog(int id)
        {
            gamelog.Add(id,new GameSystem.KeyLog[length]);
        }
        public void Delete(int id)
        {
             gamelog.Remove(id);
        }

    }
}
