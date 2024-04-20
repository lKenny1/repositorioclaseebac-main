using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboOnDIS : MonoBehaviour
{
    public GameObject PrefabCubo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDisable()
    {
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCubo);
    }
}
