using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GameSystem.Model
{
    enum Role_State
    {
        Move,
        Jump,
        Dash
    }
    public class Character
    {


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
