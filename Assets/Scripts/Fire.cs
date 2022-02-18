using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField] private float _fireTime;

    float _time;
    private void OnEnable()
    {
        _time = Time.time + _fireTime;
    }
    private void Update()
    {
        if (_time < Time.time)
            gameObject.SetActive(false);
    }
}
