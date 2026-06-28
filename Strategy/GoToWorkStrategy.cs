using System;

public class GoToWorkStrategy : IStrategy
{
    public void Use()
    {
        // Эта стратегия выполняет свою уникальную последовательность действий.
        WakeUp();
        Dress();
        GoToBusStop();
        Arrive();
        DoWork();
    }

    // Внутренние шаги скрыты от клиента.
    private void WakeUp() { Console.WriteLine("Wake up."); }
    private void Dress() { Console.WriteLine("Dress."); }
    private void GoToBusStop() { Console.WriteLine("Go to bus stop."); }
    private void Arrive() { Console.WriteLine("Arrive."); }
    private void DoWork() { Console.WriteLine("Do work."); }
}