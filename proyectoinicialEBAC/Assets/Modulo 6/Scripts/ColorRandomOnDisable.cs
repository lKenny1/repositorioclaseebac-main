using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorRandomOnDisable : MonoBehaviour
{
    public GameObject PrefabCubo;
    // Start is called before the first frame update

    private void OnDisable()
    {
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCubo);
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



}
