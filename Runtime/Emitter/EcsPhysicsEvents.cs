using System.Collections;
using System.Collections.Generic;
using Leopotam.EcsLite;
using UnityEngine;

namespace LeoEcsPhysics
{
    public static class EcsPhysicsEvents
    {
        public static EcsWorld ecsWorld;

        public static void RegisterTriggerEnterEvent(GameObject senderGameObject, Collider collider)
        {
            var eventEntity = ecsWorld.NewEntity();
            var pool = ecsWorld.GetPool<OnTriggerEnterEvent>();
            pool.Add(eventEntity);
            ref var eventComponent = ref pool.Get(eventEntity);
            eventComponent.senderGameObject = senderGameObject;
            eventComponent.collider = collider;
        }

        public static void RegisterTriggerStayEvent(GameObject senderGameObject, Collider collider)
        {
            var eventEntity = ecsWorld.NewEntity();
            var pool = ecsWorld.GetPool<OnTriggerStayEvent>();
            pool.Add(eventEntity);
            ref var eventComponent = ref pool.Get(eventEntity);
            eventComponent.senderGameObject = senderGameObject;
            eventComponent.collider = collider;
        }

        public static void RegisterTriggerExitEvent(GameObject senderGameObject, Collider collider)
        {
            var eventEntity = ecsWorld.NewEntity();
            var pool = ecsWorld.GetPool<OnTriggerExitEvent>();
            pool.Add(eventEntity);
            ref var eventComponent = ref pool.Get(eventEntity);
            eventComponent.senderGameObject = senderGameObject;
            eventComponent.collider = collider;
        }

        public static void RegisterCollisionEnterEvent(GameObject senderGameObject, Collider collider, ContactPoint firstContactPoint, Vector3 relativeVelocity)
        {
            var eventEntity = ecsWorld.NewEntity();
            var pool = ecsWorld.GetPool<OnCollisionEnterEvent>();
            pool.Add(eventEntity);
            ref var eventComponent = ref pool.Get(eventEntity);
            eventComponent.senderGameObject = senderGameObject;
            eventComponent.collider = collider;
            eventComponent.firstContactPoint = firstContactPoint;
            eventComponent.relativeVelocity = relativeVelocity;
        }

        public static void RegisterCollisionStayEvent(GameObject senderGameObject, Collider collider, ContactPoint firstContactPoint, Vector3 relativeVelocity)
        {
            var eventEntity = ecsWorld.NewEntity();
            var pool = ecsWorld.GetPool<OnCollisionStayEvent>();
            pool.Add(eventEntity);
            ref var eventComponent = ref pool.Get(eventEntity);
            eventComponent.senderGameObject = senderGameObject;
            eventComponent.collider = collider;
            eventComponent.firstContactPoint = firstContactPoint;
            eventComponent.relativeVelocity = relativeVelocity;
        }

        public static void RegisterCollisionExitEvent(GameObject senderGameObject, Collider collider, ContactPoint firstContactPoint, Vector3 relativeVelocity)
        {
            var eventEntity = ecsWorld.NewEntity();
            var pool = ecsWorld.GetPool<OnCollisionExitEvent>();
            pool.Add(eventEntity);
            ref var eventComponent = ref pool.Get(eventEntity);
            eventComponent.senderGameObject = senderGameObject;
            eventComponent.collider = collider;
            eventComponent.firstContactPoint = firstContactPoint;
            eventComponent.relativeVelocity = relativeVelocity;
        }

        public static void RegisterControllerColliderHitEvent(GameObject senderGameObject, Collider collider, Vector3 hitNormal, Vector3 moveDirection)
        {
            var eventEntity = ecsWorld.NewEntity();
            var pool = ecsWorld.GetPool<OnControllerColliderHitEvent>();
            pool.Add(eventEntity);
            ref var eventComponent = ref pool.Get(eventEntity);
            eventComponent.senderGameObject = senderGameObject;
            eventComponent.collider = collider;
            eventComponent.hitNormal = hitNormal;
            eventComponent.moveDirection = moveDirection;
        }
    }
}