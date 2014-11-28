 var particles : ParticleEmitter;
 
 function OnTriggerEnter (other : Collider){
     if(other.gameObject.FindWithTag("Player")){    
         particles.emit = true;        
     } else{
         particles.emit = false;
     }
 }