# Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “eh o maior”. Utilize a fórmula:


# Obs.: a fórmula apenas calcula o maior entre os dois primeiros(a e b). Um segundo passo, portanto é necessário para chegar no resultado esperado.

# Entrada
# O arquivo de entrada contém três valores inteiros.

# Saída
# Imprima o maior dos três valores seguido por um espaço e a mensagem "eh o maior".

n = input().split(" ")
n1 = int(n[0])
n2 = int(n[1])
n3 = int(n[2])

if n1 > n2 and n1 > n3:
    print(n1, "eh o maior")
elif n2 > n1 and n2 > n3:
    print(n2, "eh o maior")
elif n3 > n1 and n3 > n2:
    print(n3, "eh o maior")
