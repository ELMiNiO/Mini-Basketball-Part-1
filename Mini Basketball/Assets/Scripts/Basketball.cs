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
    //Checking Trigger Using unity Tag system
    /*
     * If you want to create Tage select your gameobject
     * In Inspector panel in the top, left side there is section called Tag
     * Click on it -> Go Add Taggs... then you can create your own custom tags
     */
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Hoop")
        {
            ParticleEffect();
            Debug.Log("Goal!!!");
        }
    }
    //Creating our own custom method
    void ParticleEffect()
    {
        Instantiate(_goalParticleEffect);
        _goalParticleEffect.Play();
    }

}
