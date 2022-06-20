// ALL CREDIT FOR THIS CLASS GOES TO JediJosh

using GTA.Native;

namespace Groupe6Job.Util {
    public class HelpText {
        public static void Display(string text)
        {
            Function.Call(Hash._SET_TEXT_COMPONENT_FORMAT, "STRING");
            Function.Call(Hash._ADD_TEXT_COMPONENT_STRING, text);
            Function.Call(Hash._0x238FFE5C7B0498A6, 0, 0, 1, -1);
        }
    }
}