using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalParticleEffectDestroyer : MonoBehaviour
{
    [SerializeField]
    private float _goldParticleEffectLifeTime = 3f;
    // Start is called before the first frame update
    void Start()
    {
        //Starting DelayDestruction IEnumerator
        //Note that StartCoroutine should be in Void Start or in a method
        //with conditions
        //DO NOT Put StartCoroutine in void Update, if you put it
        //in void Update DelayDestruction will get executed without any delay
        StartCoroutine(DelayDestruction());
    }

    // Update is called once per frame
    void Update()
    {

    }
    //Creating our own custom method
    void Destruction()
    {
        Destroy(this.gameObject);
    }
    //IEnumerator allows to execute method with delay
    IEnumerator DelayDestruction()
    {
        yield return new WaitForSeconds(_goldParticleEffectLifeTime);
        Destruction();
    }
}
