using System;

public class DoorMachine
{
    public enum State { Terkunci, Terbuka };
    public enum Trigger { KunciPintu, BukaPintu };
    private State currentState;

    public DoorMachine()
    {
        currentState = State.Terkunci;
        Console.WriteLine("Pintu terkunci");
    }

    public void ChangeState(Trigger trigger)
    {
        switch (currentState)
        {
            case State.Terkunci:
                if (trigger == Trigger.BukaPintu)
                {
                    currentState = State.Terbuka;
                    Console.WriteLine("Pintu tidak terkunci");
                }
                else if (trigger == Trigger.KunciPintu)
                {
                    currentState = State.Terkunci;
                    Console.WriteLine("Pintu terkunci");
                }
                break;

            case State.Terbuka:
                if (trigger == Trigger.KunciPintu)
                {
                    currentState = State.Terkunci;
                    Console.WriteLine("Pintu terkunci");
                }
                else if (trigger == Trigger.BukaPintu)
                {
                    currentState = State.Terbuka;
                    Console.WriteLine("Pintu tidak terkunci");
                }
                break;
        }
    }
}
