using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionVersionTwo : MonoBehaviour
{

    public Animator TooltipAnimator;

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Earth"))
        {
            TooltipAnimator.SetBool("Tooltip", false);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Earth"))
        {
            TooltipAnimator.SetBool("Tooltip", true);
        }

    }

}
        
