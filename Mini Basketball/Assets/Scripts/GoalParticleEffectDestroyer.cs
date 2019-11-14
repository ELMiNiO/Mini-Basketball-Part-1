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
        StartCoroutine(DelayDestruction());
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Destruction()
    {
        Destroy(this.gameObject);
    }

    IEnumerator DelayDestruction()
    {
        yield return new WaitForSeconds(_goldParticleEffectLifeTime);
        Destruction();
    }
}
