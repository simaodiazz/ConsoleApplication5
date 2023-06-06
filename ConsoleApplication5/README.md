# Exercicio 1

```csharp
var array = new int[5];
```

# Exercicio 2

```csharp
var array = new int[5];
array[0] = 199;
```

# Exercicio 3

```csharp
var array = new int[5];
array[array.Length - 1] = 250;
```

# Exercicio 4

```csharp
var array = { 1, 2, 3, 4, 5}
```

# Exercicio 5
```csharp
var array = new[]{ 1, 2, 3, 4, 5 };
Console.WriteLine("O valor da segunda posição é {0}", array[2]);
```

# Exercicio 6

```csharp
var array = new[]{ 1, 2, 3, 4, 5 };
Console.WriteLine("O valor da segunda posição é {0}", array[array.Length - 1]);
```

# Exercicio 7

```csharp
var array = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };
```

# Exercicio 8

```csharp
var array = new int[] { 1, 2, 3, 4 };
```

# Exercicio 9

```csharp
var array = new int[] { 1, 4, 7, 12, 9, 2, 5, 16, 99, 2 };
foreach (var i in array) Console.Write(i + " ");
```

# Exercicio 10

```csharp
var array = new int[5];
            
for (var i = 1; i <= 5; i++)
{
    Console.Write("Escreva o {0} número: ", i);
    array[i - 1] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Array final: ");
foreach (var value in array) Console.Write(value + " ");
```

# Exercicio 11

```csharp
var array = new int[5];
            
for (var i = 1; i <= 5; i++)
{
    Console.Write("Escreva o {0} número: ", i);
    array[i - 1] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Array final: {0}", string.Join(", ", array));
```

# Exercicio 12

```csharp
var array = new int[5];
            
for (var i = 1; i <= 5; i++)
{
    Console.Write("Escreva o {0} número: ", i);
    array[i - 1] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Array final: {0}", string.Join(", ", array.Reverse()));
```

# Exercicio 13

```csharp
var array = new int[5];
            
for (var i = 1; i <= 5; i++)
{
    Console.Write("Escreva o {0} número: ", i);
    array[i - 1] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Array final: {0}", string.Join(", ", array.Reverse()));

Console.Write("Quer verificar se existe algum número repetido (S/n): ");

var input = Console.ReadLine()?.ToLower();
            
if (input.Equals('n'))
{
    Console.WriteLine("Bye!");
    return;
}
            
Console.WriteLine("A partir de agora caso queira encerrar a aplicação é só digitar uma String");

while (true)
{
    Console.Write("Escreva o número: ");

    int value;
    try
    {
        value = int.Parse(Console.ReadLine());
    }
    catch (Exception exception)
    {
        Console.WriteLine("Bye!");
        return;
    }
                
    Console.WriteLine(array.Contains(value) ? "O valor {0} existe na array" : "O valor {0} não existe na array", value);
}
```

# Exercicio 14

```csharp
var array = new int[10];
var random = new Random();
for (var i = 0; i < array.Length; i++)
{
    array[i] = random.Next(1, 21);
}
            
Console.WriteLine("Para fechar a aplicação digite uma string");

while (true)
{

    Console.Write("Digite um número: ");
    var value = 0;

    try
    {
        value = int.Parse(Console.ReadLine());
    }
    catch (Exception exception)
    {
        Console.WriteLine("Bye!");
    }
                
    Console.WriteLine(array.Contains(value) ? "O valor {0} existe na array na posição {1}" : "O valor {0} não existe na array na posição {1}", value, );
}
```

# Exercicio 15
```csharp
var array = new int[10];
var random = new Random();
for (var i = 0; i < array.Length; i++)
{
    array[i] = random.Next(1, 21);
}

Console.WriteLine("Para fechar a aplicação digite uma string");

while (true)
{
    Console.Write("Digite um número: ");
    var value = 0;

    try
    {
        value = int.Parse(Console.ReadLine());
    }
    catch (Exception exception)
    {
        Console.WriteLine("Bye!");
    }

    Console.WriteLine(
        array.Contains(value)
            ? "O valor {0} existe na array na posição {1}"
            : "O valor {0} não existe na array", value, Array.IndexOf(array, value));
}
```

# Exercicio 16

```csharp
var array = new int[10];
var random = new Random();
for (var i = 0; i < array.Length; i++)
{
    array[i] = random.Next(1, 21);
}

Console.WriteLine("Para fechar a aplicação digite uma string");

while (true)
{
    Console.Write("Digite um número: ");
    var value = 0;

    try
    {
        value = int.Parse(Console.ReadLine());
    }
    catch (Exception exception)
    {
        Console.WriteLine("Bye!");
    }

    Console.WriteLine(
        array.Contains(value)
            ? "O valor {0} existe na array na posição {1} e existem {2} índices com o mesmo número"
            : "O valor {0} não existe na array", value, Array.IndexOf(array, value), array.Count(v => v == value));

```

# Exercicio 17

```csharp
var array = new int[10];
for (var i = 1; i <= 10; i++)
{
    Console.Write("Digite o {0} número: ", i);
    array[i - 1] = int.Parse(Console.ReadLine());
}

var avarage = array.Sum() / array.Length;
            
Console.WriteLine("Média de todos os elementos é {0}", avarage);
```

# Exercicio 18

```csharp
var array = new int[10];
for (var i = 1; i <= 10; i++)
{
    Console.Write("Digite o {0} número: ", i);
    array[i - 1] = int.Parse(Console.ReadLine());
}

var avarage = array.Sum() / array.Length;
            
for (var i = 0; i < 10; i++) array[i] = array[i] > avarage ? array[i] : 0;

Console.WriteLine("Média de todos os elementos é {0}", avarage);
Console.WriteLine("Array final: {0}", string.Join(", ", array));
```

# Exercicio 19

```csharp
Console.Write("Quantos números quer gerar: ");
var size = int.Parse(Console.ReadLine());
            
var array = new int[size];
var random = new Random();
            
Console.WriteLine("Gerando {0} valores aleatórios entre 1 e 6", size);

for (var i = 0; i < size; i++)
{
    array[i] = random.Next(1, 7);
}

for (var i = 1; i < 6; i++)
{
    int amount = array.Count(v => v == i);
    Console.WriteLine("Existem {0} ocorrências do número {1}", i, amount);
}
```

# Exercicio 20

```csharp
// Array Bidimensional
string[,] months = new string[,]
{
    { "Janeiro", "31" },
    { "Fevereiro", "28" },
    { "Março", "31" },
    { "Abril", "30" },
    { "Maio", "31" },
    { "Junho", "30" },
    { "Julho", "31" },
    { "Agosto", "31" },
    { "Setembro", "30" },
    { "Outubro", "31" },
    { "Novembro", "30" },
    { "Dezembro", "31" }
};

for (int i = 0; i < 12; i++)
{
    if (months[i, 1] == "30")
    {
        Console.WriteLine("O mês {0} tem 30 dias", months[i, 0]);
    }
}

```

# Exercicio 21

```csharp
var numbers = new int[5];
var stars = new int[2];

var random = new Random();
            
for (var i = 0; i < numbers.Length; i++)
{
    numbers[i] = random.Next(1, 51);
}
            
for (var i = 0; i < stars.Length; i++)
{
    stars[i] = random.Next(1, 11);
}
            
Console.WriteLine("Os números sorteados são {0}", string.Join(", ", numbers));
Console.WriteLine("As estrelas sorteadas são {0}", string.Join(", ", stars));
```

# Exercicio 22

```csharp
var kg = new int[] { 45, 51, 49, 64, 78, 59 };
Console.WriteLine("A soma de todos os elementos do vetor kg é {0}", kg.Sum());
Console.WriteLine("A média de kg dos valores registados no vetor é {0}", kg.Sum() / kg.Length);
```

# Exercicio 23

```csharp
var array = new int[4];
            
for (var i = 1; i <= 4; i++)
{
    Console.Write("Escreva o {0} número: ", i);
    array[i - 1] = int.Parse(Console.ReadLine());
}
            
Console.WriteLine("Soma de todos os elementos é {0}", array.Sum());
Console.WriteLine("Média de todos os elementos é {0}", array.Sum() / array.Length);
Console.WriteLine("O valor mais alto da array é {0}", array.Max());
Console.WriteLine("O valor mais baixo da array é {0}", array.Min());
```

# Exercicio 24

```csharp
Console.Write("Quantos valores você vai adicionar: ");
var size = int.Parse(Console.ReadLine());
            
var array = new int[size];
            
for (var i = 1; i <= size; i++)
{
    Console.Write("Escreva o {0} número: ", i);
    array[i - 1] = int.Parse(Console.ReadLine());
}
            
Console.WriteLine("Soma de todos os elementos é {0}", array.Sum());
Console.WriteLine("Média de todos os elementos é {0}", array.Sum() / array.Length);
Console.WriteLine("O valor mais alto da array é {0}", array.Max());
Console.WriteLine("O valor mais baixo da array é {0}", array.Min()); 
```
