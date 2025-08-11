# Conceito abstrato sobre Stack e Heap

Os dois conceitos são abstratos. Não existe fisicamente uma área da memória especifica para a stack (e muito menos sua área é fisicamente empilhada) e não existe também uma área reservada para o heap, pelo contrário, ele costuma ser bastante fragmentado. Usamos o conceito para entender melhor o funcionamento e suas implicações.

# O que são Stack?

Stack (pilha), neste contexto, é uma forma otimizada para organizar dados na memória alocados em sequência rápida e de liberação automática. Ela é uma porção de memória reservada para empilhar os dados necessários durante a execução dos blocos de código. Usada para value types, variáveis locais e endereços de objetos (referência). A stack funciona como uma pilha de pratos, ultimo que entra é o primeiro que sai (LIFO - Last in, First out).

```csharp
	Stack<int> stack = new Stack<int>();

	stack.Push(1);
	stack.Push(2);
	stack.Push(3);
	stack.Push(4);
	stack.Push(5);

	while (stack.Count > 0)
	{
		Console.WriteLine(stack.Pop());
	}           
```

# O que são Heap?

**Heap (monte)** é a organização de memória mais flexível que permite o uso de qualquer área lógica disponível. Basicamente funciona como uma gaveta bagunçada, o sistema encontra o espaço disponível e guarda o objeto. Fica claro que o heap não é uma área da memória , mesmo conceituando abstratamente, ele é um conjunto de pequenas áreas da memória.
