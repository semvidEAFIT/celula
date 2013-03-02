using UnityEngine;
using System.Collections;

public class TestMolecule : MonoBehaviour {
    public float force = 0;

    void Start() {
        rigidbody.AddRelativeForce(Vector3.right * force); 
    }
	// Update is called once per frame
	void Update () {
	    
	}
}
