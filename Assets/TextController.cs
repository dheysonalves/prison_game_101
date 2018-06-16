using UnityEngine;
using System.Collections;
using UnityEngine.UI;  // to use text, you need this 'header'


public class TextController : MonoBehaviour {
	

	public Text text; //It's need using unityengine.ui
	private enum States {screen_0,cell,glass,wall_0,blood_0,sheets_0,lock_0,sheets_1,cell_glass,lock_1,cell_wall,blood_1,corridor_0,
						stairs_0,closet_0,floor,stairs_1,stairs_2,corridor_1,corridor_1_2,in_closet,in_closet_2,corridor_2,prisoner_cell,
						corridor_3,corridor_3_1,door_x,box,letter,courtyard,courtyard_1,wrong,end_shadows,courtyard_2,attack_0,un_follow,
						dress_problem,undress};
	private States myState;
	// Use this for initialization
	void Start () {
		myState = States.screen_0;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
				if (myState == States.screen_0) {
					screen_0();
				}else if(myState == States.cell) {
					cell();
				} else if (myState == States.wall_0) {
					wall_0();
				} else if (myState == States.blood_0) {
					blood_0();
				} else if (myState == States.blood_1) {
					blood_1();
				} else if (myState == States.glass) {
					glass();
				} else if (myState == States.cell_glass) {
					cell_glass();
				} else if (myState == States.sheets_0) {
					sheets_0();
				} else if (myState == States.sheets_1) {
					sheets_1();
				} else if (myState == States.lock_0) {
					lock_0();
				} else if (myState == States.lock_1) {
					lock_1();
				} else if (myState == States.corridor_0) {
					corridor_0();
				} else if (myState == States.stairs_0) {
					stairs_0();
				} else if (myState == States.floor) {
					floor();
				} else if (myState == States.closet_0) {
					closet_0();
				} else if (myState == States.in_closet_2){
					in_closet_2();
				} else if (myState == States.in_closet){
					in_closet();
				}else if (myState == States.stairs_1) {
					stairs_1();
				} else if (myState == States.stairs_2) {
					stairs_2();
				} else if (myState == States.corridor_1) {
					corridor_1();
				}else if (myState == States.corridor_1_2) {
					corridor_1_2();
				} else if (myState == States.corridor_2) {
					corridor_2();
				} else if (myState == States.corridor_3) {
					corridor_3();
				} else if (myState == States.corridor_3_1) {
					corridor_3_1();
				} else if (myState == States.corridor_3_1) {
					corridor_3_1();
				} else if (myState == States.undress) {
					undress();
				} else if (myState == States.box) {
					box();
				} else if (myState == States.end_shadows) {
					end_shadows();
				}else if (myState == States.prisoner_cell) {
					prisoner_cell();
				} else if (myState == States.courtyard) {
					courtyard();
				} else if (myState == States.courtyard_1) {
					courtyard_1();
				} else if (myState == States.courtyard_2) {
					courtyard_2();
				}else if (myState == States.wrong) {
					wrong();
				}else if (myState == States.door_x) {
					door_x();
				}else if (myState == States.letter) {
					letter();	
				}else if (myState == States.attack_0) {
					attack_0();
				}else if (myState == States.un_follow){
					un_follow();
				}else if (myState == States.dress_problem){
					dress_problem();
			}
					
	}
	void screen_0 () {
	
		text.text = "Trapped by the traitors and sentenced to death,\n" + 
					"Professor Knox Makepeace waits without memories.\n" +
					" At the bottom of his cell, he thinks: running away\n" + 
					"is his only hope. Anguish and fear take over.\n\n" +
		
					"Press Space to Start the game";
					
		if (Input.GetKeyDown(KeyCode.Space))	{myState = States.cell;}
	}	
	#region State handler methods_1
	void cell (){
	
		text.text = "You are in a room. You don't remember how you get here, \n" +
					" but you know that is a Prison.You sitting in the ground, you feet \n" +
					"and hands has chains. Beside you there are some sheets on the floor \n" + 
					"and pieces of broken glass.In the walls, it's written something. \n" +
					"You can see blood in front of you. \n" +
					"There is a metal door with a Lock code beside you. \n" +
					"Behind this door, you hear no talk, but only screams. \n\n" +
					
					
					"Press W to view Wall, Press B to view Blood, Press S to view Sheets,\n " +
					"Press G to view Glass or Press L to view Lock.";
					
		if (Input.GetKeyDown(KeyCode.W))	{myState = States.wall_0;}
		if (Input.GetKeyDown(KeyCode.B))	{myState = States.blood_0;}
		if (Input.GetKeyDown(KeyCode.S))	{myState = States.sheets_0;}
		if (Input.GetKeyDown(KeyCode.G))	{myState = States.glass;}
		if (Input.GetKeyDown(KeyCode.L))	{myState = States.lock_0;}
		
		}
	void wall_0(){
	
		text.text = "The wall has a lot of marks of writing by hand.\n " + 
					"You don't know if you wrote, but it's written:\n\n " +
					"''GOD SAVE US ALL FROM THE MADNESS OF THIS WORLD''\n" + 
					"There is Blood here and pieces of glass.\n\n " +
					
					"Press B to view Blood, Press G to view the Glass,\n " + 
					"Press R to Return to roaming your cell";
					
		if (Input.GetKeyDown(KeyCode.B))	{myState = States.blood_1;}
		if (Input.GetKeyDown(KeyCode.G))	{myState = States.glass;}		
		if (Input.GetKeyDown(KeyCode.R))	{myState = States.cell;}
				
	}
	void blood_0(){
	
		text.text = "It's a mess. Looks like a pig was killed here.\n" + 
					"It's fresh blood. It comes from the wall.\n " + 
					"Like a pitcher of water. \n\n" +
					
					"Press R to Return to roaming your cell";			
							
		if (Input.GetKeyDown(KeyCode.R))	{myState = States.cell;}
		}
		
	void blood_1(){
	
		text.text = "It's fresh blood. It comes from the wall.\n " + 
					"Like a pitcher of water. \n\n" +
					
					"Press R to return to the Wall.";					
		if (Input.GetKeyDown(KeyCode.R))	{myState = States.wall_0;}		
	}
	void glass(){
	
		text.text = "Some big and small pieces of glass.\n " + 
					"Probably it was from a mirror. In some parts \n" +
					"of the glass is written some numbers. It might be useful. \n\n" +
					
					"Press T to take the glass or Press R to Return to roaming your cell ";	
									
		if (Input.GetKeyDown(KeyCode.T))	{myState = States.cell_glass;}
		if (Input.GetKeyDown(KeyCode.R))	{myState = States.cell;}
				
	}
	void sheets_0(){
	
		text.text = "Some sheets are blood stained. \n" + 
					"However the others has things written in blood: \n\n" +
					
					"''It might be open or not...crazy right?...Why won't you try it?'' " + 
					"It is weird \n\n" +
					"Press R to Return to roaming your Cell";					
		
		if (Input.GetKeyDown(KeyCode.R))	{myState = States.cell;}
			
		}
	void lock_0(){
	
		text.text = "It's locked.When you tried to push, " + 
					"nothing happens it looks like a wall. \n" +
					"You can see a password lock on the right \n\n" +
					
					"Press R to Return to roaming your Cell";					
		
		if (Input.GetKeyDown(KeyCode.R))	{myState = States.cell;} 
		
	}
		
	void cell_glass(){
	
		text.text = "You are in a place with pieces of glass and blood on the ground. \n " + 
					"In front of you has more sheets. Beside you has a door. \n\n" +
					
					"Press S to view Sheets, Press L to view Lock";		
								
		if (Input.GetKeyDown(KeyCode.S))	{myState = States.sheets_1;}
		if (Input.GetKeyDown(KeyCode.L))	{myState = States.lock_1;}
		
	}
	void sheets_1(){
	
		text.text = "Nothing really interesting. But it has things written in blood: \n " + 
					"'You didn't try to open... a mistake, do it!' \n\n" +
					
					"Press R to Return to roaming your Cell";					
			
		if (Input.GetKeyDown(KeyCode.R))	{myState = States.cell_glass;}
			
		}
	void lock_1(){
	
		text.text = "You hear screams outside the door. \n" +
					"The Lock Code is here. You can try to open with \n  " + 
					"the combination of numbers on the glass are 0-8-9. \n\n" +
					
					"Press H to 089, Press Y to 890, Press Z to 908";					
			
		
		if (Input.GetKeyDown(KeyCode.Y))	{myState = States.wrong;}
		if (Input.GetKeyDown(KeyCode.Z))	{myState = States.corridor_0;}		
		if (Input.GetKeyDown(KeyCode.H))	{myState = States.wrong;}
		}
	void wrong(){
		
		text.text = "The combination is wrong \n\n" +
					
				
					"Press R to Return and try again.";					
		
		if (Input.GetKeyDown(KeyCode.R))	{myState = States.lock_1;}
		
	}
	void corridor_0(){
	
		text.text = "The door makes a creepy sound, the only sound on the corridor.\n" +
					"You're in a hallway. It looks like an abandoned prison.\n" +   
					"It's in pieces; There are stairs in front of you and,\n"+
					"behind you there is a door that looks like a closet.\n" +
					"There is a lot of trash on the floor too, and doesn’t smell very good.\n" +	
					"You know there's someone else in the place because\n" +
					"you heard some noise in the hallway.\n\n"+
					
					"Press S to view Stairs, Press F to view Floor or Press C to view Closet ";				
		
		if (Input.GetKeyDown(KeyCode.S))	{ myState = States.stairs_0; }
		if (Input.GetKeyDown(KeyCode.F))	{ myState = States.floor; }
		if (Input.GetKeyDown(KeyCode.C))	{ myState = States.closet_0; }
	} 
	#endregion
	#region State out_cell
	void stairs_0(){
		 
		text.text = "All the cells are open. There isn't prisoners. \n " +
					"Inside the cells on the floor are full of cotton and spilled milk. \n " +
					"Maybe it happened a rebellion.The cotton probably are from the beds. \n " +
					"But you don’t understand why there is milk.\n\n " +
					
					"Press R to Return to the corridor";  
					
		if (Input.GetKeyDown(KeyCode.R))	{ myState = States.corridor_0; }
	}
	void floor(){
		
		text.text = "You can see some parts of an animal.\n " +
					"There is what it was a heart and a leg. It might be from a pig.\n " +
					"Some hair strands are here too.\n  " +
					"Through the trash you can see a hair clip.\n\n" +
				
					"Press T to Take the Hairclip or Press R to Return to the corridor";  
					
		if (Input.GetKeyDown(KeyCode.T))	{myState = States.corridor_1;}
		if (Input.GetKeyDown(KeyCode.R))	{myState = States.corridor_0;}
	}
	void closet_0(){
		
		text.text = "It’s locked. You confirm, it was a closet.\n   " +
					"In the door there’s marks of knife, " +
					"like if someone was counting.\n\n " +
				
					"Press R to Return to the corridor";  
		
		if (Input.GetKeyDown(KeyCode.R))	{myState = States.corridor_0;}
	}

	void corridor_1(){
		
		text.text = "You are in the corridor B, beside the Closet door.\n " +
					"On your right there’s a stair that leads you to \n" + 
					"the upside right prison cells.\n\n " +
				
					"Press P to Pick the Closet or Press S to climb the Stairs";  
		
		if (Input.GetKeyDown(KeyCode.P))	{myState = States.in_closet;}
		if (Input.GetKeyDown(KeyCode.S))	{myState = States.stairs_1;}
	}
	void corridor_1_2(){
		
		text.text = "You are free of the chains. You touch your wrist\n " +
					"to feel more comfortable \n" + 
					"You are in the corridor B, beside the Closet door.\n\n " +
				
					"Press P to Pick the Closet";  
		
		if (Input.GetKeyDown(KeyCode.P))	{myState = States.in_closet_2;}
		
	}
	void in_closet(){
		
		text.text = "You open the closet. There is a yardmen disguise.\n\n " +
					
		
					"Press D to Dress the clothes \n " + 
					"Press G to Go to the northeast corridor \n" +
					"Press R to Return to corridor B";
					
		if (Input.GetKeyDown(KeyCode.D))	{myState = States.dress_problem;}			
		if (Input.GetKeyDown(KeyCode.G))	{myState = States.corridor_2;}
		if (Input.GetKeyDown(KeyCode.R))	{myState = States.corridor_1;}
		
	}
	void in_closet_2(){
		
		text.text = "You open the closet. There is a yardmen disguise.\n\n " +
			
			
					"Press D to Dress the clothes \n "; 
				
				
		if (Input.GetKeyDown(KeyCode.D))	{myState = States.corridor_3;}

	}
	void dress_problem(){
		
		text.text = "You can't dress the clothes.\n" +
					"You still are with chains.\n\n" +
			
			 
					"Press G to Go to the northeast corridor\n " +
					"Press R to Return to corridor B\n";  
		
		if (Input.GetKeyDown(KeyCode.G))	{myState = States.corridor_2;}
		if (Input.GetKeyDown(KeyCode.R))	{myState = States.corridor_1;}
	}
	
	void stairs_1(){
		
		text.text = "Looks like the same prison cell corridor you have \n " +
					"been in a couple of minutes. \n" +
					"But there is a prison cell with a closed door.\n\n " +
				
					"Press C to open the Cell or Press R to Return to the corridor B";  
		
		if (Input.GetKeyDown(KeyCode.R))	{myState = States.corridor_1;}
		if (Input.GetKeyDown(KeyCode.C))	{myState = States.prisoner_cell;}
	}
	void prisoner_cell(){
		
		text.text = "There is a dead man here.Looks like he was stabbed in the heart.\n " +
					"The knife is on the floor and his eyes are wide open.There is coffee mixed with\n " +
					"blood spilled on the floor. \n On the wall it's written: \n\n" +
			
					"''I was Punished by my sins, thank you - Dale Cooper'' \n\n" +
					
					"Behind his body there is a key and open chains. \n" + 
					"Maybe it might help to get rid of yours.\n\n" +
					
					"Press O to Open the chains"; 
		
		
		if (Input.GetKeyDown(KeyCode.O))	{myState = States.corridor_1_2;}
	}
	void corridor_2(){
		
		text.text = "This southeast corridor C there is a lot of \n" +
					"dead people on the floor. Many of them are only prisoners. \n" +
					"You can’t see a cop. On your left there’s a stair. \n" +
					"On your front, the passage is blocked by many tables. \n\n" +
				
				
					"Press S to climb the Stairs or Press B to get Back to the closet";  
		
		if (Input.GetKeyDown(KeyCode.B))	{myState = States.in_closet;}
		if (Input.GetKeyDown(KeyCode.S))	{myState = States.stairs_2;}
	}
	void stairs_2(){
		
		text.text = "Looks like the same prison cell corridor \n " +
					" you have been in a couple of minutes. \n" +
				
					"Press R to Return to the corridor C";  
		
		if (Input.GetKeyDown(KeyCode.R))	{myState = States.corridor_2;}
		
	}
	void corridor_3(){
		
		text.text = "You are in the Corridor D. Dressed like a yardmen.\n " +
					"On front of you has a stair who gives you the way to the courtyard.\n " +
					"and between the freedom and you, three cops are talking.\n " +
					"On your right there is a noisy door open. \n\n" +

					"Press S to climb the Stairs, Press U to Undress the disguise, \n" +
					" Press D to enter the Door ";  
		
		if (Input.GetKeyDown(KeyCode.S))	{myState = States.courtyard;}
		if (Input.GetKeyDown(KeyCode.U))	{myState = States.undress;}
		if (Input.GetKeyDown(KeyCode.D))	{myState = States.door_x;}
	}
	void undress(){
		
		text.text = "When you reach the closet again. The real yardmen around \n " +
					"some guards have found you. They shot you on the shoulder.\n\n " +
					"YOU GOT ARRESTED AGAIN. \n\n " +
				
					"Wanna try again?\n\n" +
					"Press P to Play again"; 
		
		if (Input.GetKeyDown(KeyCode.P))	{myState = States.screen_0;}
		
	}
	void corridor_3_1(){
		
		text.text = "You are in the Corridor D. The cops aren't here anymore.\n " +
					"You can hear voices approaching.\n " +
					"On your left there is a box.\n " +
					"In front of you it's freedom \n\n" +
				
					"Press R to Run to the Stairs, Press H to Hide behind the box, \n" + 
					"Press S to Sneak through the shadows";
		
		if (Input.GetKeyDown(KeyCode.R))	{myState = States.courtyard_1;}
		if (Input.GetKeyDown(KeyCode.H))	{myState = States.box;}
		if (Input.GetKeyDown(KeyCode.S))	{myState = States.end_shadows;}
	}
	
	void door_x(){
		
		text.text = "The room looks like a cave. On the middle a woman is sitting in a chair \n" +
					"with her head falling in the shoulders. In her left hands there is a bottle. \n" +
					"When you look more close you realize that it’s a cyanide bottle.  \n" +
					"She commit suicide or it was murdered. On the floor, on her right there is a letter. \n\n" +
				
					"Press R to Read the letter, Press B to Return to Corridor";  
		
		if (Input.GetKeyDown(KeyCode.R))	{myState = States.letter;}
		if (Input.GetKeyDown(KeyCode.B))	{myState = States.corridor_3_1;}
	}
	void letter(){
		
		text.text = 
					" ''You might not remember, but I am your wife. \n" +
					"I am probably dead....sorry for that love...Anyway, did you saw my art?\n " +
					"I think they enjoyed in that block...\n "+
					" We got arrested when we were going to kill your uncle. \n" +
					" Jonny Boy lied to us about his location. \n\n" +
					"Well, long story...If you are here its because you followed my tracks. \n" +
					"I am not very good in games...But I hope you made it. \n" +
					" You got to scape and run to the north, Gonzalez's House. \n" +
					"He knows that you are coming...at least he hopes so.\n " +
					"Take the courtyard and run before they catch you \n\n" +
					"Good luck,Love you always, Margaret.''\n" +
					
					"Press B to get Back to Corridor ";  
		
		if (Input.GetKeyDown(KeyCode.B))	{myState = States.corridor_3_1;}
	}
	void courtyard(){
		
		text.text = "You pretend to be a yardmen.\n " +
					"The cops looks at you distrustful.\n" + 
					"However you reach courtyard.\n " +
					"You are a free person now. \n\n" + 
					"Go and discover a new world.  \n\n " +
				
					"Press P to Play again";  
		
		if (Input.GetKeyDown(KeyCode.P))	{myState = States.screen_0;}
		
	}
	void courtyard_1(){
		
		text.text = "You climb the stairs, but someone stops you and cut you throat.\n  " +
					"You don’t know who it was, but you fall into the courtyard.\n\n" + 
					"YOU ARE DEAD! \n\n " + 
					 
					"Wanna try again?\n\n" +
					"Press P to Play again";  
		
		if (Input.GetKeyDown(KeyCode.P))	{myState = States.screen_0;}
		
	}void courtyard_2(){
		
		text.text = "You run with Gonzales through the gates.  \n" +
					"He has a Ford V8 1936, you enter and go to his home\n\n" + 
					"Now,You are a free man. \n" + 
					"Go and discover a new world \n\n " + 
				
					
					"Press P to Play again";  
			
		if (Input.GetKeyDown(KeyCode.P))	{myState = States.screen_0;}
		
	}
	void box(){
		
		text.text = "The three people appear in front of you. \n" +
					"You recognize one of them, it's your cousin, Jonny Boy: \n\n" +
					
					"''Good trade we made boys. I would not imagine that his wife  \n" +
					"was a monster, didn't know such skills...It's good that we shut her down'' \n" +
					
					"Your anger grows faster...but you hear a voice calling you in the shadows \n\n" +
					
					"Press A to listen to your Anger , Press S to Sneak through the shadows";  
		
		if (Input.GetKeyDown(KeyCode.A))	{myState = States.attack_0;}
		if (Input.GetKeyDown(KeyCode.S))	{myState = States.end_shadows;}
	}
	void end_shadows(){
		
		text.text = "There's a man in the shadows. \n" +
					"He says that he is Gonzalez, a friend of your wife. \n" +
				
					"and wants to help to escape through the courtyard \n\n" +
					
					"Press F to follow him or Press U to Unfollow"; 
		
		if (Input.GetKeyDown(KeyCode.F))	{myState = States.courtyard_2;}
		if (Input.GetKeyDown(KeyCode.U))	{myState = States.un_follow;}
		}
	void attack_0(){
		
		text.text = "You hit Jonny Boy. The guards got suprised \n" +
					"You try to run to the courtyard, but they got you \n" +
				
					"''These rats always run from their cells, get him back!'' said Jonny Boy \n\n" +
					
				
					"YOU GOT ARRESTED AGAIN!\n\n" +
				
					"Press P to Play again";  
			
			if (Input.GetKeyDown(KeyCode.P))	{myState = States.screen_0;}		
	}
	void un_follow(){
		
		text.text = "Jonny Boy and his mates found you\n\n" +
				
					"YOU GOT ARRESTED AGAIN!\n\n" +
				
					"Press P to Play again";  
		
		if (Input.GetKeyDown(KeyCode.P))	{myState = States.screen_0;}
	}
	#endregion
}