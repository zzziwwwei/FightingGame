using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameSystem.View
{

    enum Role_State
    {
        Move,
        Jump,
        Dash
    }

    public class AnimationController : MonoBehaviour
    {
        Queue<(int, Role_State, int)> role_changeList;
        Dictionary<int, Animator> roles;
        public Animator_Controller animator_Controller;
        void Init()
        {
            role_changeList = new();
            roles = new();
        }
        void Role_Update(int id, Role_State state, int frame)
        {
            role_changeList.Enqueue((id, state, frame));
        }
        void Update()
        {

        }
        void Start()
        {
            Init();
            roles.Add(1, animator_Controller.GetAnimator(Animator_enum.warrior).GetComponent<Animator>());
            roles[1].Play("Idle",0,0f);
            roles[1].Play("Walk",0,0f);
           
        }
    }
}