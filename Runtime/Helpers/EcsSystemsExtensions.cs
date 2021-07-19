using Leopotam.EcsLite;

namespace LeoEcsPhysics
{
    public static class EcsSystemsExtensions
    {
        public static EcsSystems DelHerePhysics(this EcsSystems ecsSystems)
        {
            ecsSystems.DelHere<OnTriggerEnterEvent>();
            ecsSystems.DelHere<OnTriggerStayEvent>();
            ecsSystems.DelHere<OnTriggerExitEvent>();
            ecsSystems.DelHere<OnCollisionEnterEvent>();
            ecsSystems.DelHere<OnCollisionStayEvent>();
            ecsSystems.DelHere<OnCollisionExitEvent>();
            ecsSystems.DelHere<OnControllerColliderHitEvent>();
            ecsSystems.DelHere<OnTriggerEnter2DEvent>();
            ecsSystems.DelHere<OnTriggerStay2DEvent>();
            ecsSystems.DelHere<OnTriggerExit2DEvent>();
            ecsSystems.DelHere<OnCollisionEnter2DEvent>();
            ecsSystems.DelHere<OnCollisionStay2DEvent>();
            ecsSystems.DelHere<OnCollisionExit2DEvent>();
            
            return ecsSystems;
        }
    }
}
