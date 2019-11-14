using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _ballObject = default;
    [SerializeField]
    private GameObject _basketLocation = default;
    [SerializeField]
    private int _maxBallCount = 2;
    private int _ballCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        SpawnBall();
    }

    void SpawnBall()
    {
        _ballCount = GameObject.FindGameObjectsWithTag("BasketBall").Length;
        if (_ballCount < _maxBallCount)
        {
            Instantiate(_ballObject, _basketLocation.transform.position, Quaternion.identity);
        }
    }

}
