using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Globalization;
using System;

class Dog: Pet, Talkable
{
    private bool isFriendly{get;}

    public Dog(bool isFriendly, string Name): base(Name)
    {
        this.isFriendly = isFriendly;
    }

    public string Talk() {
        return "Bark";
    }

    public string toString() {
        return "Dog: " + "Name=" + Name + " friendly=" + isFriendly;
    }
}