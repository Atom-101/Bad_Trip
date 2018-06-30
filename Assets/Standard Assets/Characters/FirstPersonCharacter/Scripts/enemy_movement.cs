using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_movement : MonoBehaviour
{


    public float speed = 2;
  
    public float LeftPoint = -21.21f;
    public float RightPoint = -13.79f;
    private int Direction = 2;
    private GameObject MushroomMan;//1for right and 2 for left
                              // Use this for initialization
   
    // Update is called once per frame
    void Update()
    {
       
            if (Direction == 1)
            {
                transform.Translate(Vector3.right * 2 * Time.deltaTime, Space.World);
                Direction = 1;
            }

            if (this.transform.position.x > RightPoint)
            {
                Direction = 2;
            }

            if (Direction == 2)
            {
                transform.Translate(Vector3.right * -2 * Time.deltaTime, Space.World);
                Direction = 2;
            }

            if (this.transform.position.x < LeftPoint)
            {
                Direction = 1;
            }
        
    }


 
}
