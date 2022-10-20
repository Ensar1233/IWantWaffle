using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceCreamMachine : MonoBehaviour
{

    [SerializeField] private float speedUp = 1f;
    [SerializeField] private GameObject limit;
    private void Update()
    {
        UpMove();
    }
    private int ChangeValue()
    {
        return limit.GetComponent<Limit>().value;
    }
    private void UpMove()
    {
        transform.Translate((ChangeValue() *  Vector3.up )* speedUp * Time.deltaTime);
    }
}
