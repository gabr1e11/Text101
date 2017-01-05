using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

    public Text text;
    
	private enum States {
		cell, mirror, rags_0, lock_0, cell_mirror, rags_1, lock_1, corridor_0, stairs_0, stairs_1,
		stairs_2, courtyard, floor, corridor_1, corridor_2, corridor_3,closet_door, in_closet
		};
	private States myState;
    
    // Use this for initialization
	void Start () {
	    myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if 		(myState == States.cell) 		{cell();}
		else if (myState == States.rags_0) 	{rags_0();}
		else if (myState == States.rags_1) 	{rags_1();}
		else if (myState == States.lock_0) 		{lock_0();}
		else if (myState == States.lock_1) 		{lock_1();}
		else if (myState == States.mirror) 		{mirror();}
		else if (myState == States.cell_mirror) {cell_mirror();}
		else if (myState == States.corridor_0) 	{corridor_0();}
		else if (myState == States.stairs_0) 	{stairs_0();}
		else if (myState == States.stairs_1) 	{stairs_1();}
		else if (myState == States.stairs_2) 	{stairs_2();}
		else if (myState == States.courtyard) 	{courtyard();}
		else if (myState == States.floor) 		{floor();}
		else if (myState == States.corridor_1) 	{corridor_1();}
		else if (myState == States.corridor_2) 	{corridor_2();}
		else if (myState == States.corridor_3) 	{corridor_3();}
		else if (myState == States.closet_door) {closet_door();}
		else if (myState == States.in_closet) 	{in_closet();}
	}

    #region State handler methods
    void in_closet() {
		text.text = "TODO";
		if 		(Input.GetKeyDown(KeyCode.R)) 	{myState = States.corridor_2;}
		else if (Input.GetKeyDown(KeyCode.D)) 	{myState = States.corridor_3;}
	}
	
	void closet_door() {
		text.text = "TODO";
		if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.corridor_0;}
	}
	
	void corridor_3() {
		text.text = "TODO";
		if 		(Input.GetKeyDown(KeyCode.S)) 	{myState = States.courtyard;}
		else if (Input.GetKeyDown(KeyCode.U))	{myState = States.in_closet;}
	}
	
	void corridor_2() {
		text.text = "TODO";
		if 		(Input.GetKeyDown(KeyCode.C)) 	{myState = States.in_closet;}
		else if (Input.GetKeyDown(KeyCode.S)) 	{myState = States.stairs_2;}
	}
	
	void corridor_1() {
		text.text = "TODO";
		if (Input.GetKeyDown(KeyCode.P)) 		{myState = States.in_closet;}
		else if (Input.GetKeyDown(KeyCode.S)) 	{myState = States.stairs_1;}
	}
	
	void floor () {
		text.text = "TODO" ;
		if 		(Input.GetKeyDown(KeyCode.R)) 	{myState = States.corridor_0;}
		else if (Input.GetKeyDown(KeyCode.H)) 	{myState = States.corridor_1;}
	}	
	
	void courtyard () {
		text.text = "TODO" ;
		if (Input.GetKeyDown(KeyCode.P)) 		{myState = States.cell;}
	}	
	
	void stairs_0 () {
		text.text = "TODO" ;
		if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.corridor_0;}
	}
	
	void stairs_1 () {
		text.text = "TODO" ;
		if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.corridor_1;}
	}
	
	void stairs_2() {
		text.text = "TODO";
		if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.corridor_2;}
	}
	
	void cell () {
		text.text = "You are in a rotten prison cell. The smell of decaying tissue fills the space. " +
                    "There is an overwhelming silence around you and the only " +
                    "light in the cell comes from a window carved high into the wall, with some thick bars in it. " +
                    "The moon light sheds its shade into the room and allows you to examine it. " +
                    "You can see some dirty rags on the bed and a broken mirror on the wall. The door in " +
                    "front of is locked from the outside and there seems to be no other way out of there.\n\n\n" +
                    "* Press R to view Rags\n" +
                    "* Press M to view Mirror\n" +
                    "* Press L to view Lock\n";
        if 		(Input.GetKeyDown(KeyCode.R)) 	{myState = States.rags_0;}
		else if (Input.GetKeyDown(KeyCode.M)) 	{myState = States.mirror;}
		else if (Input.GetKeyDown(KeyCode.L)) 	{myState = States.lock_0;}
    }
    
	void mirror() {
        text.text = "You a look at the broken mirror and a disfigured face stares back at you. " +
                    "It takes a moment for you to realize that it is your own reflection, torn apart " +
                    "by each of the mirror's shards. Despite the mirror being broken, you barely recognize " +
                    "the person you see in the reflection. How much time have you been held prisoner here?\n\n\n" +
                    "* Press M to take the mirror\n" +
                    "* Press R to return Roaming your cell\n";

        if 		(Input.GetKeyDown(KeyCode.M)) 	{myState = States.cell_mirror;}
		else if (Input.GetKeyDown(KeyCode.R)) 	{myState = States.cell;}
    }
    
	void cell_mirror() {
        text.text = "TODO";
					
		if 		(Input.GetKeyDown(KeyCode.S)) 	{myState = States.rags_1;}
		else if (Input.GetKeyDown(KeyCode.L)) 	{myState = States.lock_1;}
    }
   
    void rags_0 () {
		text.text = "You can't believe you sleep in these things. They are tearing apart and smell " +
                    "to piss and feces. Undescribable critters can be seeing crawling between them. " +
                    "You are definitely not looking forward to sleep on those rags again tonight.\n\n\n" +
                    "* Press R to return Roaming your cell\n";
        if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.cell;}
    }
    
	void rags_1() {
		text.text = "TODO";
        if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.cell_mirror;}
    }
    
    void lock_0() {
		text.text = "You check the lock and you see it runs from your side of the door to the other side." +
                    "The opening is big enough for you to peek, so you stick your face into it and try " +
                    "check the room next to yours. It is pretty dark by you can see a torch through the peep hole\n\n\n" +
                    "* Press R to return Roaming your cell\n";
        if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.cell;}
    }
    
	void lock_1() {
		text.text = "TODO" ;
		if 		(Input.GetKeyDown(KeyCode.O)) 	{myState = States.corridor_0;}
		else if (Input.GetKeyDown(KeyCode.R)) 	{myState = States.cell_mirror;}
    }
    
	void corridor_0() {
		text.text = "TODO";
		if 		(Input.GetKeyDown(KeyCode.S)) 	{myState = States.stairs_0;}
		else if (Input.GetKeyDown(KeyCode.F)) 	{myState = States.floor;}
		else if (Input.GetKeyDown(KeyCode.C)) 	{myState = States.closet_door;}  
	}
    #endregion
}
