using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GameData
{
    public class Character
    {
        public class CharacterData
        {
            public Base @base = new();
            public Value value = new();
            public Skin skin = new();

        }
        public class Base
        {
            public string name;
            public int id;
        }
        public class Value
        {
            public int hp;
            public int speed;
            public List<string> skills;

            public Attack attack = new();
            public Defense defense = new();
            public Jump jump = new();

            public class Attack
            {

            }
            public class Defense
            {

            }
            public class Jump
            {

            }
        }
        public class Skin
        {
            public int id;
        }
        [Flags]
        public enum Skill
        {
            //D:防 J:跳 A:功        
        }

        public interface IAttack
        {

        }
        public interface IDefense
        {
        }
        public interface IDash
        {
        }
        public interface IAbilityValue
        {

        }
        public class BaseCharacter : IAttack, IDefense, IDash, IAbilityValue
        {
            public readonly string name;
            public readonly int id;

        }
    }


}