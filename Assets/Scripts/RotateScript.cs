using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour {

    public float X;
    public float Y;
    public float Z;

    private Vector3 _rotationToApply;

    void Start () {
        _rotationToApply = new Vector3(X, Y, Z);

    }
	
	void Update () {
        gameObject.transform.Rotate(_rotationToApply * Time.deltaTime);
	}
}
