using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GameData
{
    public class Pre_CharacterData
    {
        public readonly string name = "warrior";
        public readonly int id = 1;
        public interface IAttack
        {
        }
        public interface IDefense
        {
        }
        public interface IDash
        {
        }
        public interface Value
        {
        }  
        public class AbilityValue : IAttack, IDefense, IDash,Value
        {

        }

    }

}