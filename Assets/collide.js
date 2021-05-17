function OnCollisionEnter (myCollision : Collision) 
{ 
 
if(myCollision.gameObject.name == "Cube")
{ 
Destroy (gameObject);
} 
}
