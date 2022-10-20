using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeEffectController : MonoBehaviour
{
    [SerializeField] private ParticleSystem smoke;

    private void Start()
    {
        smoke.Play(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Waffle"))
        {
            smoke.Play(true);
        }
    }

}
