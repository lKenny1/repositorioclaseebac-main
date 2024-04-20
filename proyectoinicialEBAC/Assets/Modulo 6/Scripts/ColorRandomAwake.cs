using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorRandomAwake : MonoBehaviour
{
    public GameObject PrefabCubo;
    private void Awake()
    {
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCubo);
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
