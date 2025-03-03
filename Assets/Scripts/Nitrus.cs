using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nitrus {

    public Nitrus(){}

    public void boost(GameObject Samurai, float boostForce , Camera camera , float fieldOfView){
        Rigidbody R = Samurai.GetComponent<Rigidbody>();
        R.AddForce(Samurai.transform.forward * boostForce );
        camera.fieldOfView += fieldOfView;
    }

}
