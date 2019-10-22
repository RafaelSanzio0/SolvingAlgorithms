# Leia 2 valores inteiros(A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos", indicando se os valores lidos são múltiplos entre si.

# Entrada
# A entrada contém valores inteiros.

# Saída
# A saída deve conter uma das mensagens conforme descrito acima.

a, b = str(input()).split(" ")
a = float(a)
b = float(b)

if a > b:
    if a % b == 0:
        print("Sao Multiplos")
    else:
        print("Nao sao Multiplos")

if b > a:
    if b % a == 0:
        print("Sao Multiplos")
    else:
        print("Nao sao Multiplos")
