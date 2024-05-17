using System;
using AdvancedMath;

class test
{
    static void Main()
    {
        // Пример решения задачи по теореме Муавра-Лапласа с точным значением K
        double p = 0.8;      // Пример значения P (вероятность)
        int n = 100;         // Пример значения N (кол-во независимых испытаний)
        int k = 75;          // Пример значения K (кол-во наступления событий

        MuavraLaplaceSolverWithStableK bd = new MuavraLaplaceSolverWithStableK(p, k, n);

        double ProbabilityNow = bd.CalculateProbability();

        Console.WriteLine($"Ответ для задачи, решаемой по теореме Муавра-Лапласа с точным значением K: {ProbabilityNow}");
        Console.WriteLine();

        // Пример использования класса MathOperations
        double[] values = { 2, 4, 6, 8, 10 };
        double mean = ArrayOperations.CalculateArrayMean(values);
        double standardDeviation = ArrayOperations.CalculateStandardArrayDeviation(values);
        Console.WriteLine($"Среднее значение элемента массива: {mean}");
        Console.WriteLine($"Стандартное отклонение: {standardDeviation}");
        Console.WriteLine();

        // Пример использования метода NewtonRaphsonMethod
        Func<double, double> function = x => Math.Pow(x, 3) - 2 * x - 5; // Уравнение: x^3 - 2x - 5 = 0
        Func<double, double> derivative = x => 3 * Math.Pow(x, 2) - 2;   // Производная уравнения
        double initialGuess = 2;                                         // Начальное приближение
        double tolerance = 0.0001;                                       // Погрешность
        int maxIterations = 100;                                         // Максимальное количество итераций

        double root = ExtraMathOperations.NewtonRaphsonMethod(function, derivative, initialGuess, tolerance, maxIterations);
        Console.WriteLine($"Корень уравнения: {root}");

        // Пример использования метода NumericalIntegration
        Func<double, double> squareFunction = x => x * x;                // Функция для интегрирования: x^2
        double lowerBound = 0;                                           // Нижний предел интегрирования
        double upperBound = 1;                                           // Верхний предел интегрирования
        int numIntervals = 100;                                          // Количество интервалов разбиения

        double integral = ExtraMathOperations.NumericalIntegration(squareFunction, lowerBound, upperBound, numIntervals);
        Console.WriteLine($"Результат численного интегрирования функции x^2 на отрезке [0, 1]: {integral}");

        // Пример использования метода SolveDifferentialEquationEuler
        Func<double, double, double> derivatives = (x, y) => x * y; // y' = x * y
        double initialValueX = 0; // Начальное значение переменной x
        double initialValueY = 1; // Начальное значение переменной y
        double stepSize = 0.1; // Шаг интегрирования
        double endTime = 1; // Конечное время

        double[] resultY = Differentiaton.SolveDifferentialEquationEuler(derivatives, initialValueX, initialValueY, stepSize, endTime);

        // Вывод результатов
        Console.WriteLine("Результаты решения дифференциального уравнения методом Эйлера:");
        for (int i = 0; i < resultY.Length; i++)
        {
            Console.WriteLine($"y({initialValueX + i * stepSize}) = {resultY[i]}");
        }
        Console.WriteLine();

        // Решение дифференциального уравнения y' = x * y методом Рунге-Кутты
        Func<double, double, double> differentialEquation = (x, y) => x * y;
        double initialValueX2 = 0; // Начальное значение x
        double initialValueY2 = 1; // Начальное значение y
        double stepSize2 = 0.1; // Шаг интегрирования
        double endTime2 = 1; // Конечное время

        double[] resultY2 = Differentiaton.RungeKuttaSolver(differentialEquation, initialValueX2, initialValueY2, stepSize2, endTime2);

        // Вывод результатов
        Console.WriteLine("Результаты решения дифференциального уравнения методом Рунге-Кутты:");
        for (int i = 0; i < resultY.Length; i++)
        {
            Console.WriteLine($"y({initialValueX + i * stepSize}) = {resultY2[i]}");
        }
        Console.WriteLine();

        // Пример использования класса ComplexNumber 
        ComplexNumber c1 = new ComplexNumber(1, 2);
        ComplexNumber c2 = new ComplexNumber(3, 4);
        ComplexNumber sum = c1 + c2;
        ComplexNumber difference = c1 - c2;
        ComplexNumber product = c1 * c2;
        ComplexNumber quotient = c1 / c2;
        Console.WriteLine($"Сумма: {sum}");
        Console.WriteLine($"Разность: {difference}");
        Console.WriteLine($"Произведение: {product}");
        Console.WriteLine($"Частное: {quotient}");
        Console.WriteLine($"Модуль c1: {c1.Magnitude()}");
        Console.WriteLine($"Аргумент c1: {c1.Phase()} радиан");
        Console.WriteLine();
        Console.ReadKey();
    }
}