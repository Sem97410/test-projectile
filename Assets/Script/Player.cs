using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Jump
    private bool jumpKeyWasPressed;
   [SerializeField] private float jumpHeight = 6;

   //Movement
   private float horitalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       

        if(Input.GetKeyDown(KeyCode.Space)){
            jumpKeyWasPressed = true;
        }
        //blabla
        

    void FixedUpdate() {
        if(jumpKeyWasPressed){
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpHeight, ForceMode.VelocityChange);
            jumpKeyWasPressed = false;
        }

        
    }
}
