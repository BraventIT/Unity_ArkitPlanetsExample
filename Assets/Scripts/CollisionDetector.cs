using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{

    private RaycastHit hit;

    public Animator TooltipAnimator;

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Camera.main.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction,Color.green);
        if (Physics.Raycast(ray, out hit,1000f))
        {
            if (hit.collider.CompareTag("Earth"))
            {
                TooltipAnimator.SetBool("Tooltip", true);
            }
        }
        else
        {
            TooltipAnimator.SetBool("Tooltip", false);
        }

    }
}
