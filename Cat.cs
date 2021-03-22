using System;

class Cat: Pet, Talkable
{
    private int mousesKilled{get;set;}

    public Cat(int mousesKilled, string Name): base(Name)
    {
        this.mousesKilled = mousesKilled;
    }

    public void AddMouse()
    {
        mousesKilled++;
    }

    public string Talk() {
        return "Meow";
    }

    public string toString() {
        return "Cat: " + "Name=" + Name + " mousesKilled=" + mousesKilled;
    }
}


