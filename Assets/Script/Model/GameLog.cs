using System;
using System.Collections.Generic;

namespace GameData
{
    public class GameLog
    {
        public Dictionary<int,GameSystem.KeyLog[]> gamelog {get; private set;}
        
        public GameLog()
        {
            Init();
        }
        void Init()
        {
            this.gamelog = new();
        }
        public void SetKeyLog(int id,GameSystem.KeyLog keyLog){
            var logs =  gamelog[id];
            logs[keyLog.currentFrame] = keyLog;
        }
        public void AddLog(int id,int length)
        {
            gamelog.Add(id,new GameSystem.KeyLog[length]);
        }
        public void Delete(int id)
        {
             gamelog.Remove(id);
        }

    }
}
