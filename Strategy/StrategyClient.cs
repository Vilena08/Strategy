using System;

public class StrategyClient
{
    // Клиент хранит ссылку на текущую стратегию через интерфейс.
    private IStrategy _strategy;

    // Метод для динамической замены стратегии в рантайме.
    public void SetStrategy(IStrategy strategy)
    {
        _strategy = strategy;
    }

    // Выполнение текущей стратегии.
    public void UseStrategy()
    {
        if (_strategy != null)
        {
            _strategy.Use(); // Делегирование выполнения стратегии.
        }
        else
        {
            Console.WriteLine("Strategy not set."); // Обработка случая, когда стратегия не задана.
        }
    }
}