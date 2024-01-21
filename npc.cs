using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcScript : MonoBehaviour
{
    public int Health = 3;
    public int Level = 2;
    public float Speed = 1.2f;

    // Start is called before the first frame update
    void Start()
    {

        Health += Level;
        print (Health);
    }

    // Update is called once per frame
    void Update()
    {
      Vector3 newPosition = transform.position;
      newPosition.z += Speed * Time.deltaTime;   
      transform.position = newPosition;
    }
}
