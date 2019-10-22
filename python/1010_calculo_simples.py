# Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Após, calcule e mostre o valor a ser pago.

# Entrada
# O arquivo de entrada contém duas linhas de dados. Em cada linha haverá 3 valores, respectivamente dois inteiros e um valor com 2 casas decimais.

# Saída
# A saída deverá ser uma mensagem conforme o exemplo fornecido abaixo, lembrando de deixar um espaço após os dois pontos e um espaço após o "R$". O valor deverá ser apresentado com 2 casas após o ponto.

peça1 = input().split(" ")
peça2 = input().split(" ")

p1 = int(peça1[1])
p11 = float(peça1[2])
p2 = int(peça2[1])
p22 = float(peça2[2])

valor = (p1*p11)+(p2*p22)

print("VALOR A PAGAR:", "R$", format(valor, ".2f"))
