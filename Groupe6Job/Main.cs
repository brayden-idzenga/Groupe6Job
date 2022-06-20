using System;
using GTA;
using GTA.Math;

using Groupe6Job.Util;

namespace Groupe6Job {
    public class Main : Script {
        // Mission vars
        Boolean Working = false;
        Boolean OnDelivery = false;
        Vehicle Truck;

        // Blips
        Blip StartJobBlip;

        // Vectors
        Vector3 StartJobPos = new Vector3(20.9f, -659.9f, 31);
        Vector3 TruckSpawnPos = new Vector3(34.7f, -648.8f, 31.6f);

        public Main() {
            Tick += OnTick;
            StartJobBlip = BlipManager.CreateBlip(StartJobBlip, StartJobPos);
        }

        private void OnTick(Object sender, EventArgs e) {
            if (!Working) {
                if (Game.Player.Character.Position.DistanceTo(StartJobPos) <= 5) {
                    HelpText.Display("Press ~INPUT_CONTEXT~ to start your shift");

                    if (Game.IsControlJustPressed(0, GTA.Control.Context)) {
                        StartJobBlip = BlipManager.RemoveBlip(StartJobBlip);
                        Truck = World.CreateVehicle();
                        Working = true;
                    }
                }
            }

            if (Working) {

            }
        }
    }
}