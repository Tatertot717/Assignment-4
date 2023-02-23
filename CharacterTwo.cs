using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class CharacterTwo : Character
{

    private static readonly string description = "I am a robot. I cannot be offended";
    private static readonly string whoami = "Baymax";
    private static readonly string information = "On a scale of one to ten, how would you rate your pain?";
    private static readonly string greetingmsg = "I'm your personal healthcare companion";

    public CharacterTwo() : base(description, whoami)
    {
    }

    public override string getInformation()
    {
        return (information);
    }

    public override string greeting()
    {
        return (greetingmsg);
    }

    public override string sayGoodbye()
    {
        return ("Are you satisfied with your care?");
    }
}