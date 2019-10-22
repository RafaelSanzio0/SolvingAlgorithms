# Leia um valor de ponto flutuante com duas casas decimais. Este valor representa um valor monetário. A seguir, calcule o menor número de notas e moedas possíveis no qual o valor pode ser decomposto. As notas consideradas são de 100, 50, 20, 10, 5, 2. As moedas possíveis são de 1, 0.50, 0.25, 0.10, 0.05 e 0.01. A seguir mostre a relação de notas necessárias.

# Entrada
# O arquivo de entrada contém um valor de ponto flutuante N(0 ≤ N ≤ 1000000.00).

# Saída
# Imprima a quantidade mínima de notas e moedas necessárias para trocar o valor inicial, conforme exemplo fornecido.

# Obs: Utilize ponto(.) para separar a parte decimal.

N = float(input())
N += 0.001

n100 = 0
n50 = 0
n20 = 0
n10 = 0
n5 = 0
n2 = 0
n1 = 0
n0_50 = 0
n0_25 = 0
n0_010 = 0
n0_05 = 0
n0_01 = 0

while N >= 100:
    n100 += 1
    N -= 100
while N >= 50:
    n50 += 1
    N -= 50
while N >= 20:
    n20 += 1
    N -= 20
while N >= 10:
    n10 += 1
    N -= 10
while N >= 5:
    n5 += 1
    N -= 5
while N >= 2:
    n2 += 1
    N -= 2
while N >= 1:
    n1 += 1
    N -= 1
while N >= 0.50:
    n0_50 += 1
    N -= 0.50
while N >= 0.25:
    n0_25 += 1
    N -= 0.25
while N >= 0.10:
    n0_010 += 1
    N -= 0.10
while N >= 0.05:
    n0_05 += 1
    N -= 0.05
while N >= 0.01:
    n0_01 += 1
    N -= 0.01

print("NOTAS:")
print(n100, "nota(s) de R$ 100.00")
print(n50, "nota(s) de R$ 50.00")
print(n20, "nota(s) de R$ 20.00")
print(n10, "nota(s) de R$ 10.00")
print(n5, "nota(s) de R$ 5.00")
print(n2, "nota(s) de R$ 2.00")
print("MOEDAS:")
print(n1, "moeda(s) de R$ 1.00")
print(n0_50, "moeda(s) de R$ 0.50")
print(n0_25, "moeda(s) de R$ 0.25")
print(n0_010, "moeda(s) de R$ 0.10")
print(n0_05, "moeda(s) de R$ 0.05")
print(n0_01, "moeda(s) de R$ 0.01")
