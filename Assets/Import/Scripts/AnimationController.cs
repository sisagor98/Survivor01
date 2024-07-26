using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnimationController : MonoBehaviour
{

    public Animator animator;

    private static int ANIMATOR_PARAM_WALK_SPEED = Animator.StringToHash("Run");


    public void SetAnimWalkSpeed(float value)
    {
        animator.SetFloat(ANIMATOR_PARAM_WALK_SPEED, value);
    }
}
