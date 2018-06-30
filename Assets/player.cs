using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {


    public Rigidbody m_player;
  
    private bool isgrounded = true;
    public float Force = 5;
    public float speed =1;
    public Transform playerTrigger, enemyTrigger;
    public float closePos = .02f;
   

	// Use this for initialization
	void Start () {

        m_player = GetComponent<Rigidbody>();
        playerTrigger = GetComponent<Transform>();
        enemyTrigger = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        float Hori = Input.GetAxis("Horizontal")*speed;
        float Verti = Input.GetAxis("Vertical")*speed;

        Vector3 movement = new Vector3(Hori, 0, 0);

        transform.Translate(movement);
       
;
      
    }



     
    






}
