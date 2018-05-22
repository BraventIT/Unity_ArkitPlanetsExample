using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchInputManager : MonoBehaviour
{


    private RaycastHit hit;

    public GameObject MarsHintPanel;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                Vector2 touchDeltaPosition = Input.GetTouch(0).position;
                Ray ray = Camera.main.ScreenPointToRay(touchDeltaPosition);
                if (Physics.Raycast(ray, out hit))
                {

                    if (hit.transform.gameObject.CompareTag("Mars"))
                    {
                        MarsHintPanel.SetActive(!MarsHintPanel.activeSelf);
                    }
                    

                }
            }
        }
        else if (Input.GetMouseButtonDown(0))
        {
            Vector2 touchDeltaPosition = Input.mousePosition;
            Ray ray = Camera.main.ScreenPointToRay(touchDeltaPosition);
            if (Physics.Raycast(ray, out hit))
            {

                if (hit.transform.gameObject.CompareTag("Mars"))
                {
                    MarsHintPanel.SetActive(!MarsHintPanel.activeSelf);
                }

            }
        }
    }
}
