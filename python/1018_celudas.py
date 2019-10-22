# Leia um valor inteiro. A seguir, calcule o menor número de notas possíveis(cédulas) no qual o valor pode ser decomposto. As notas consideradas são de 100, 50, 20, 10, 5, 2 e 1. A seguir mostre o valor lido e a relação de notas necessárias.

# Entrada
# O arquivo de entrada contém um valor inteiro N(0 < N < 1000000).

# Saída
# Imprima o valor lido e, em seguida, a quantidade mínima de notas de cada tipo necessárias, conforme o exemplo fornecido. Não esqueça de imprimir o fim de linha após cada linha, caso contrário seu programa apresentará a mensagem: “Presentation Error”.

n = int(input())

n100 = 0
n50 = 0
n20 = 0
n10 = 0
n5 = 0
n2 = 0
n1 = 0

print(n)

while n >= 100:
    n100 += 1
    n -= 100
while n >= 50:
    n50 += 1
    n -= 50
while n >= 20:
    n20 += 1
    n -= 20
while n >= 10:
    n10 += 1
    n -= 10
while n >= 5:
    n5 += 1
    n -= 5
while n >= 2:
    n2 += 1
    n -= 2
while n >= 1:
    n1 += 1
    n -= 1

print(n100, "nota(s) de R$ 100,00")
print(n50, "nota(s) de R$ 50,00")
print(n20, "nota(s) de R$ 20,00")
print(n10, "nota(s) de R$ 10,00")
print(n5, "nota(s) de R$ 5,00")
print(n2, "nota(s) de R$ 2,00")
print(n1, "nota(s) de R$ 1,00")
