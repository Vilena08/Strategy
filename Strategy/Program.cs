using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // Создаём клиента, который будет использовать стратегии.
        StrategyClient client = new StrategyClient();

        // === Стратегия 1: Пойти на работу ===
        client.SetStrategy(new GoToWorkStrategy()); // Подставляем конкретную стратегию.
        client.UseStrategy();                       // Выполняем её.
        Console.WriteLine();                        // Разделитель для читаемости.

        // === Стратегия 2: Пойти в спортзал ===
        client.SetStrategy(new GoToGymStrategy());
        client.UseStrategy();
        Console.WriteLine();

        // === Стратегия 3: Пойти гулять ===
        client.SetStrategy(new GoWalkStrategy());
        client.UseStrategy();

        Console.ReadKey();
    }
}
//В паттерне Strategy интерфейс IStrategy определяет общий контракт для всех алгоритмов. Конкретные стратегии (GoToWorkStrategy, GoToGymStrategy, GoWalkStrategy) реализуют этот контракт по-своему. Клиент StrategyClient не зависит от конкретной реализации — он получает стратегию через метод SetStrategy() и вызывает её через UseStrategy(). Это позволяет динамически заменять алгоритмы во время выполнения программы без изменения кода клиента.
