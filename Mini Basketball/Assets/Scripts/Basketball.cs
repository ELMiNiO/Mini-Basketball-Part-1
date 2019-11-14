using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basketball : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem _goalParticleEffect = default;
    [SerializeField]
    private int _ballDestroyDelayTime = 2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Hoop")
        {
            ParticleEffect();
            Debug.Log("Goal!!!");
        }
    }

    void ParticleEffect()
    {
        Instantiate(_goalParticleEffect);
        _goalParticleEffect.Play();
    }

}
