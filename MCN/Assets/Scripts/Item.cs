using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Item : MonoBehaviour
{
    public Outline outline; 

    // Start is called before the first frame update
    void Start()
    {
        outline = gameObject.AddComponent(typeof(Outline)) as Outline;
        OutlineStop();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Interaction()
    {

    }
    public void OutlineStart()
    {
        outline.enabled = true;
    }
    public void OutlineStop()
    {
        outline.enabled = false;
    }
}
