using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IKControllera : MonoBehaviour
{
    public Transform objToPickUp;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void OnAnimatorIK(int layerIndex)    {
        float reach = animator.GetFloat("RightHandReach");
        animator.SetIKPositionWeight(AvatarIKGoal.RightHand, reach);
        animator.SetIKPosition(AvatarIKGoal.RightHand, objToPickUp.position);
    }
}