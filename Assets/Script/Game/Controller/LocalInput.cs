using System;
using UnityEngine;

namespace GameSystem
{
    [Flags]
    public enum Key
    {
        NONE = 0,
        UP = 1,
        DOWN = 2,
        RIGHT = 4,
        LEFT = 8,
        UP_Up = 16,
        DOWN_Up = 32,
        RIGHT_Up = 64,
        LEFT_Up = 128,
        DEFENSE = 512,
        DASH = 1024,
        ATTACK = 2048,
    }
    public class LocalInput : MonoBehaviour
    {
        Tick tick;
        Key key = new();

        void Start()
        {
            tick.tick += InputKey;
        }
        void Update()
        {
            GetKey();
            GetKeyUp();
        }
        void GetKey()
        {
            if (Input.GetKey(KeyCode.UpArrow))
                key |= Key.UP;
            if (Input.GetKey(KeyCode.DownArrow))
                key |= Key.DOWN;
            if (Input.GetKey(KeyCode.RightArrow))
                key |= Key.RIGHT;
            if (Input.GetKey(KeyCode.LeftArrow))
                key |= Key.LEFT;
            if (Input.GetKey(KeyCode.Z))
                key |= Key.DEFENSE;
            if (Input.GetKey(KeyCode.X))
                key |= Key.DASH;
            if (Input.GetKey(KeyCode.C))
                key |= Key.ATTACK;
        }
        void GetKeyUp()
        {
            if (Input.GetKeyUp(KeyCode.UpArrow))
                key |= Key.UP_Up;
            if (Input.GetKeyUp(KeyCode.DownArrow))
                key |= Key.DOWN_Up;
            if (Input.GetKeyUp(KeyCode.RightArrow))
                key |= Key.RIGHT_Up;
            if (Input.GetKeyUp(KeyCode.LeftArrow))
                key |= Key.LEFT_Up;
        }

        void InputKey(int f)
        {
            if (key.HasFlag(Key.UP) && key.HasFlag(Key.DOWN))
            {
                key ^= Key.UP;
                key ^= Key.DOWN;
                key |= Key.UP_Up;
                key |= Key.DOWN_Up;
            }
            if (key.HasFlag(Key.RIGHT) && key.HasFlag(Key.LEFT))
            {
                key ^= Key.RIGHT;
                key ^= Key.LEFT;
                key |= Key.RIGHT_Up;
                key |= Key.LEFT_Up;
            }
           
           
        }
    }
}