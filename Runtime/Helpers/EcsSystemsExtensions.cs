using Leopotam.EcsLite;
using Leopotam.EcsLite.ExtendedSystems;

namespace LeoEcsPhysics
{
    public static class EcsSystemsExtensions
    {
        public static EcsSystems DelHerePhysics(this EcsSystems ecsSystems, string worldName = null)
        {
            ecsSystems.DelHere<OnTriggerEnterEvent>(worldName);
            ecsSystems.DelHere<OnTriggerStayEvent>(worldName);
            ecsSystems.DelHere<OnTriggerExitEvent>(worldName);
            ecsSystems.DelHere<OnCollisionEnterEvent>(worldName);
            ecsSystems.DelHere<OnCollisionStayEvent>(worldName);
            ecsSystems.DelHere<OnCollisionExitEvent>(worldName);
            ecsSystems.DelHere<OnControllerColliderHitEvent>(worldName);
            ecsSystems.DelHere<OnTriggerEnter2DEvent>(worldName);
            ecsSystems.DelHere<OnTriggerStay2DEvent>(worldName);
            ecsSystems.DelHere<OnTriggerExit2DEvent>(worldName);
            ecsSystems.DelHere<OnCollisionEnter2DEvent>(worldName);
            ecsSystems.DelHere<OnCollisionStay2DEvent>(worldName);
            ecsSystems.DelHere<OnCollisionExit2DEvent>(worldName);
            
            return ecsSystems;
        }
    }
}
