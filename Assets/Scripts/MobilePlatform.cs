using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobilePlatform : MonoBehaviour
{
    [SerializeField]
    private Transform _pointA, _pointB;

    private bool _avanti = true;
    [SerializeField]
    private float _speed = 3.0f;

    private void FixedUpdate() {
        if(_avanti){
            transform.position = Vector3.MoveTowards(transform.position,_pointB.position, Time.deltaTime * _speed);
            if(transform.position == _pointB.position)
            {
                _avanti = false;
            }
            
        }
        else{
            transform.position = Vector3.MoveTowards(transform.position,_pointA.position, Time.deltaTime * _speed);
            if(transform.position == _pointA.position)
            {
                _avanti = true;
            }
        }
    }

    private void OnTriggerEnter(Collider other) {
        other.transform.parent = this.transform;
    }

    private void OnTriggerExit(Collider other) {
        other.transform.parent = null;
    }
}
