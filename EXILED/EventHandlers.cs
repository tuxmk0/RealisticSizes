#if EXILED
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluginAPI.Events;
using PluginAPI.Core.Attributes;
using Exiled.Events.EventArgs.Server;
using Exiled.Events.EventArgs.Player;
using Exiled.API.Features;
using MEC;
using RueI.Displays;
using RueI.Elements;
using RueI.Displays.Scheduling;
using RueI;
using System;
using System.IO;
using System.Threading;
using Exiled.API.Features;
using RealisticSizes;
using System.Timers;
using Exiled.API.Features.Doors;
using Interactables.Interobjects.DoorUtils;
using CommandSystem.Commands.RemoteAdmin.Doors;
using UnityEngine;
using PluginAPI.Core.Doors;
using System.Security.Policy;
using PlayerRoles;
using Unity.Mathematics;
using System.Threading;
using System.Collections;
using RealisticSizes.Commands;
using Exiled.API.Enums;
using Exiled.API.Features.Roles;

namespace RealisticSizes
{
    public class EventHandlers : MonoBehaviour
    {
        
        public void OnRoundStarted()
        {
            
        }
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