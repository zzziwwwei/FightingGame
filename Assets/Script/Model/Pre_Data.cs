using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameData
{

    public class Pre_Data
    {
        public CharacterData swordsman = new();
        void Swordsman()
        {
            swordsman.@base.name = "Swordsman";
            swordsman.@base.id = 1;
            swordsman.value.hp = 100;
            swordsman.value.speed = 1;
            swordsman.value.skills = new List<string> { "", "", "" };//(技能)
            swordsman.value.attack = null;
            swordsman.value.defense = null;
            swordsman.value.jump = null;
            swordsman.skin.id = 0;
        }
        void Knigt()
        {
            swordsman.@base.name = "Knigt";
            swordsman.@base.id = 2;
            swordsman.value.hp = 100;
            swordsman.value.speed = 1;
            swordsman.value.skills = new List<string> { "", "", "" };//(技能)
            swordsman.value.attack = null;
            swordsman.value.defense = null;
            swordsman.value.jump = null;
            swordsman.skin.id = 0;
        }
        public class CharacterData
        {

            public Base @base { get; } = new();
            public Value value { get; } = new();
            public Skin skin { get; } = new();

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
    }
}