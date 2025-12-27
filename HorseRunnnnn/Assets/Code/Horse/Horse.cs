using UnityEngine;

namespace Code.Horse
{
    public enum HorseState
    {
        IDLE,
        RUN
    }
    
    public class Horse : MonoBehaviour
    {
        public Animator Animator { get; private set; }
        public HorseMovement Mover { get; private set; }
        
        
    }
}
