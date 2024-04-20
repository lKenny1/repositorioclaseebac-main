using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuevoCuboAwake : MonoBehaviour
{
    public GameObject PrefabCubo;
    

    // Start is called before the first frame update
    private void Awake()
    {
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCubo);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
