using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class CharacterThree : Character
{

    private static readonly string description = "J.A.R.V.I.S., make a note. Remind me not to wake up in the morning ever again";
    private static readonly string whoami = "Tony Stark";
    private static readonly string information = "Iron Man. That’s kind of catchy. It’s got a nice ring to it. I mean it’s not technically accurate. The suit’s a gold titanium alloy, but it’s kind of provocative, the imagery anyway";
    private static readonly string greetingmsg = "Genius, billionaire, playboy, philanthropist";

    public CharacterThree() : base(description, whoami)
    {
    }

    public override string getInformation()
    {
        return(information);
    }

    public override string greeting()
    {
        return(greetingmsg);
    }

    public override string sayGoodbye()
    {
        return("I am iron man.");
    }
}