using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] public Transform groundCheckTransform = null;
    [SerializeField] private LayerMask playerMask;
    private bool jumpKeyWasPressed;
    private float horizontalInput;
    private Rigidbody rigidbodyComponent;
    private int superJumpsRemaining;
    public string playerName = "Lucy";
    private int characterLevel = 1;

    // Start is called before the first frame update
    void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody>();

    Name();

    void Name ()
    {
         Debug.Log(playerName);
    }


/*With the method Characterinfo, two parameters are given to the method, with two different parametertypes, int which is numbers, and string which is characters. 
These are then used to print out the player name which is stated by the string variable playername, and the current level of the player, which is stated by the int variable characterLevel
When calling the method, the value to the paramaters are then given, which is called arguemnts, and they show the method that the two paramterers in the parantheses needs to be replaced 
with the macthing types of variables, that is written in the paranetheses*/   
    CharacterInfo("Lucy", characterLevel);

    void CharacterInfo (string name, int level)
    {
        /*These are interpolated string, which is another way to insert variables into text, by calling the $. 
        When this code is run by the compiler the console will print out "Your player name is: "Lucy", becuase thats the value of the variable, 
        the same goes for the second line with the player level.*/
        //Debug.Log($"Your player name is: {playerName}");
        //Debug.Log($"Your level is: {characterLevel}");
        Debug.LogFormat("Your player name is: {0} - Level: {1}", name, level);
        int newLevel = characterLevel + 9;
        Debug.Log("Your level is now: " + newLevel);
        
    }
    
    }


    // Update is called once per frame
    void Update()
    {      
        //Check if space key is pressed down
        if(Input.GetKeyDown(KeyCode.Space))
        {
            jumpKeyWasPressed = true; 
        }

        horizontalInput = Input.GetAxis("Horizontal");
    }

    //Fixedupdate is called once every physics update
    private void FixedUpdate()
    {

        rigidbodyComponent.velocity = new Vector3(horizontalInput, rigidbodyComponent.velocity.y, 0);

        if(Physics.OverlapSphere    (groundCheckTransform.position, 2f, playerMask).Length == 0)
        {
            return;
        }

        if(jumpKeyWasPressed)
        {
            float jumpPower = 5f;
            if (superJumpsRemaining > 0)
            {
                jumpPower *= 2;
                superJumpsRemaining-=1;
            }
            rigidbodyComponent.AddForce(Vector3.up * jumpPower, ForceMode.VelocityChange);
            jumpKeyWasPressed = false;
        }


    }
    private void OnTriggerEnter(Collider other)
    {
        if(other. gameObject.layer == 9)
        {
            Destroy(other.gameObject);
            superJumpsRemaining+=1;
           /*This code is to test out if the variable characterlevel is addeed with 1 each time the player collides with the gameobject coin */
            characterLevel+=1;
            Debug.Log("Your level is now: " + characterLevel);
        }
    }  

}  


