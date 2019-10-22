# Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A seguir, calcule e mostre o valor da conta a pagar.

# CODIGO          ESPECIFICAÇÃO         PREÇO
# 1               HOT DOG               4,00
# 2               X-SALADA              4,50
# 3               X-BACON               5,00
# 4               TORRADA               2,00
# 5               REFRIGERANTE          1,50

# Entrada
# O arquivo de entrada contém dois valores inteiros correspondentes ao código e à quantidade de um item conforme tabela acima.

# Saída
# O arquivo de saída deve conter a mensagem "Total: R$ " seguido pelo valor a ser pago, com 2 casas após o ponto decimal.

n = input().split(" ")

c = int(n[0])
q = int(n[1])

if c == 1:
    total = q*4
    print("Total:", "R$", format(total, ".2f"))
elif c == 2:
     total = q*4.50
     print("Total:", "R$", format(total, ".2f"))
elif c == 3:
     total = q*5
     print("Total:", "R$", format(total, ".2f"))
elif c == 4:
     total = q*2
     print("Total:", "R$", format(total, ".2f"))
elif c == 5:
     total = q*1.50
     print("Total:", "R$", format(total, ".2f"))
