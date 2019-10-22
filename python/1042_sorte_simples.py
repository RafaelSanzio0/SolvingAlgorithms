# Leia 3 valores inteiros e ordene-os em ordem crescente. No final, mostre os valores em ordem crescente, uma linha em branco e em seguida, os valores na sequência como foram lidos.

# Entrada
# A entrada contem três números inteiros.

# Saída
# Imprima a saída conforme foi especificado.

a, b, c = str(input()).split(" ")

a = int(a)
b = int(b)
c = int(c)

if a > b and a > c and b < c:
    print(b)
    print(c)
    print(a)
    print("")
    print(a)
    print(b)
    print(c)
if a > b and a > c and c < b:
    print(c)
    print(b)
    print(a)
    print("")
    print(a)
    print(b)
    print(c)

if b > a and b > c and a < c:
    print(a)
    print(c)
    print(b)
    print("")
    print(a)
    print(b)
    print(c)
if b > a and b > c and c < a:
    print(c)
    print(a)
    print(b)
    print("")
    print(a)
    print(b)
    print(c)

if c > a and c > b and a < b:
    print(a)
    print(b)
    print(c)
    print("")
    print(a)
    print(b)
    print(c)
if c > a and c > b and b < a:
    print(b)
    print(a)
    print(c)
    print("")
    print(a)
    print(b)
    print(c)
