using GTA;
using GTA.Native;
using GTA.Math;

namespace Groupe6Job.Util {
    public class BlipManager {
        public static Blip CreateBlip(Blip b, Vector3 pos) {
            b = World.CreateBlip(pos);
            if (b.Exists()) {
                b.Sprite = BlipSprite.CashRegister;
                b.Color = BlipColor.Blue;
                b.Name = "Groupe 6 Job";
            }
            return b;
        }

        public static Blip RemoveBlip(Blip b) {
            if (b.Exists()) {
                b.Alpha = 0;
                b.Remove();
            }
            return b;
        }

        public static Blip ChangeSprite(Blip b, BlipSprite s) {
            if (b.Exists()) {
                b.Sprite = s;
            }
            return b;
        }
    }
}