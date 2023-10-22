using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameSystem.View
{
    public enum Animator_enum
    {
        warrior,
        shooter
    }
    public class Animator_Controller : MonoBehaviour
    {

        public GameObject warrior;
        public GameObject shooter;
        public GameObject GetAnimator(Animator_enum animator)
        {
            GameObject anim;
            switch (animator)
            {
                case Animator_enum.warrior:
                    anim = Instantiate(warrior, new Vector3(0, 0, 0), Quaternion.identity);
                    anim.transform.SetParent(this.transform);
                    return anim;
                case Animator_enum.shooter:
                    anim = Instantiate(shooter, new Vector3(0, 0, 0), Quaternion.identity);
                    anim.transform.SetParent(this.transform);
                    return anim;
            }
            return null;
        }
    }
}