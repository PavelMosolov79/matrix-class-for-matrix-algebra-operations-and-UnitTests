# Матричный калькулятор

Этот проект представляет собой простой матричный калькулятор, который позволяет выполнять операции над матрицами, такие как сложение, вычитание и умножение. Проект написан на языке C#.

## Как начать

1. Склонируйте репозиторий на свой локальный компьютер с помощью команды Git:

```shell
git clone https://github.com/yourusername/MatrixCalculator.git

1. Откройте проект в вашей среде разработки, поддерживающей C# (например, Visual Studio).

2. Выполните сборку проекта.

3. Запустите приложение.

Основные функции
Проект содержит следующие основные функции:

Сложение матриц.
Вычитание матриц.
Умножение матриц.
Транспонирование матриц.
Поиск минимального элемента в матрице.
Преобразование матрицы в строку.

Использование
Пример использования основных функций:
`` Ruby 
int[,] data1 = { { 1, 2 }, { 3, 4 } };
int[,] data2 = { { 2, 0 }, { 1, 2 } };
Matrix matrix1 = new Matrix(data1);
Matrix matrix2 = new Matrix(data2);

Matrix resultAddition = matrix1 + matrix2;
Matrix resultSubtraction = matrix1 - matrix2;
Matrix resultMultiplication = matrix1 * matrix2;
Matrix resultTranspose = matrix1.Transpose();
int minValue = matrix1.Min();
string matrixAsString = matrix1.ToString();
``