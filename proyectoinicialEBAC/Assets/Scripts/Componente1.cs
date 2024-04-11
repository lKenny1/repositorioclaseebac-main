using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componente1 : MonoBehaviour
{
    private void Awake()
    {
        
    }
    public static GameObject miObjecto;
    // Start is called before the first frame update
    void Start()
    {
        miObjecto = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
