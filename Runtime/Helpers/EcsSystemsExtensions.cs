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

            return ecsSystems;
        }
    }
}