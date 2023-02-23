using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class CharacterOne : Character
{

    private static readonly string description = "I'm the Son of Anakin Skywalker";
    private static readonly string whoami = "Luke Skywalker";
    private static readonly string information = "Together with my sister, Leia, we were able to strike a critical blow to the empire!";
    private static readonly string greetingmsg = "I Am A Jedi, Like My Father Before Me";

    public CharacterOne() : base(description, whoami)
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
        return ("May the force be with you.");
    }
}