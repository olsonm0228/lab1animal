using System;

class Teacher: Person, Talkable
{
    public int age{get;set;}

    public Teacher(int age, string Name): base(Name)
    {
        this.age = age;
    }

    public string Talk() {
        return "Don't forget to do the assigned reading!";
    }
}