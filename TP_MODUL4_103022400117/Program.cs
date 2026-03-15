class Program
{
    static void Main(string[] args)
    {
        // Kode Pos
        KodePos kp = new KodePos();
        Console.WriteLine(kp.getKodePos("Cijaura"));

        // Door Machine
        DoorMachine pintu = new DoorMachine();
        pintu.ChangeState(DoorMachine.Trigger.BukaPintu);
        pintu.ChangeState(DoorMachine.Trigger.KunciPintu);
        pintu.ChangeState(DoorMachine.Trigger.KunciPintu);
        pintu.ChangeState(DoorMachine.Trigger.BukaPintu);

        Console.ReadLine();
    }
}