#if EXILED
using Exiled.Events.EventArgs.Player;
using UnityEngine;

namespace RealisticSizes
{
    public class EventHandlers : MonoBehaviour
    {
        public void PlayerDied(DiedEventArgs ev)
        {
            if (ev.Player != null)
            {
                Vector3 Size = new Vector3(1f, 1f, 1f);
                ev.Player.Scale = Size;
            }
        }
        public void PlayerSpawned(SpawnedEventArgs ev)
        {
            if (ev.Player != null) 
            {
                System.Random random = new System.Random();
                float randomFloat = (float)(random.NextDouble() * (Plugin.Instance.Config.MaxSize - Plugin.Instance.Config.MinSize) + Plugin.Instance.Config.MinSize);
                Vector3 Size = new Vector3 (randomFloat, randomFloat, randomFloat);
                if (ev.Player.IsHuman)
                {
                    ev.Player.Scale = Size;
                } 
            }
        }

    }
}
#endif