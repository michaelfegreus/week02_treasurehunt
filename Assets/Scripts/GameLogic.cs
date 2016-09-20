using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour {

	bool didPlayerWin = false;
	bool north;
	bool east;
	bool south;
	bool west;
	string directionNS;
	string directionEW;
	public Transform playerObject;
	public Transform treasureObject;
	public Text statusText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (didPlayerWin) {
			statusText.text = "YOU GOT TREASURE AND YOU WIN!";
		} else if ((playerObject.position - treasureObject.position).magnitude < 5f) {
			statusText.text = "Press [SPACE] to get treasure!";
			if (Input.GetKey (KeyCode.Space)) {
				didPlayerWin = true;
			}
		} else {    //This compass I created is not pretty or elegant, but it's an attempt at a game mechanic. Game would be 10 times as interesting with collision objects to manuever around.
			north = false;
			east = false;
			south = false;
			west = false;
			directionNS = "";
			directionEW = "";
			if (playerObject.position.x < treasureObject.position.x){
				east = true;
			}
			if(playerObject.position.x > treasureObject.position.x){
				west = true;
			}
			if(playerObject.position.z < treasureObject.position.z){
				north = true;
			}
			if(playerObject.position.z > treasureObject.position.z){
				south = true;
			}
			if (((playerObject.position.z - treasureObject.position.z) < 5f) && ((playerObject.position.z - treasureObject.position.z) > -5f)) {
				north = false;
				south = false;
			}
			if (((playerObject.position.x - treasureObject.position.x) < 5f) && ((playerObject.position.x - treasureObject.position.x) > -5f)) {
				east = false;
				west = false;
			}
			if(north){
				directionNS = "NORTH";
			}
			if (south) {
				directionNS = "SOUTH";
			}
			if (east) {
				directionEW = "EAST";
			}
			if (west) {
				directionEW = "WEST";
			}
			statusText.text = "GO " + directionNS.ToString() + directionEW.ToString();
			Debug.Log (directionNS);
			Debug.Log (directionEW);
		}
	}
}
