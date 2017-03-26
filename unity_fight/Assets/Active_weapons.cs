using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Active_weapons : MonoBehaviour
{
    private Animator animator;
    private AnimatorStateInfo animator_state;
    public bool attack_flag;
    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        attack_flag = false;
    }

    // Update is called once per frame
    void Update()
    {
        animator_state = animator.GetCurrentAnimatorStateInfo(0);

        if (animator_state.fullPathHash == Animator.StringToHash("Base Layer.Attack_down")
            || animator_state.fullPathHash == Animator.StringToHash("Base Layer.Attack_up")
            || animator_state.fullPathHash == Animator.StringToHash("Base Layer.Attack_down_to_up")
            || animator_state.fullPathHash == Animator.StringToHash("Base Layer.Attack_up_to_down"))
        {
            attack_flag = true;
        }
        else
        {
            attack_flag = false;
        }
    }
}
