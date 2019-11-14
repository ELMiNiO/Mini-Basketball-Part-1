using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketballHoop : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3.5f;
    [SerializeField]
    private Transform _startMarker = default;
    [SerializeField]
    private Transform _endMarker = default;
    /*
     * Example of bad implementation setting up movement location by hard coding it
     * Each time you want to change the position
     * you have to come and change it in the script.
     */
    //private Vector3 pointA = new Vector3(-3.5f, 1.6f, 4.9f);
    //private Vector3 pointB = new Vector3(2.7f, 1.6f, 4.9f);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //moving an object back and forth using Verctor3.Lerp
        //Verctor3.Lerp -> Linearly interpolates between two points.
        transform.position = Vector3.Lerp(_startMarker.position, _endMarker.position, Mathf.PingPong(Time.time * _speed, 1));
    }
}
