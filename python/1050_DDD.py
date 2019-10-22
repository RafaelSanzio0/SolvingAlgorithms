# Leia um número inteiro que representa um código de DDD para discagem interurbana. Em seguida, informe à qual cidade o DDD pertence, considerando a tabela abaixo:

# Se a entrada for qualquer outro DDD que não esteja presente na tabela acima, o programa deverá informar:
# DDD nao cadastrado

# Entrada
# A entrada consiste de um único valor inteiro.

# Saída
# Imprima o nome da cidade correspondente ao DDD existente na entrada. Imprima DDD nao cadastrado caso não existir DDD correspondente ao número digitado.

if DDD == 61:
    print("Brasilia")
elif DDD == 71:
    print("Salvador")
elif DDD == 11:
    print("Sao Paulo")
elif DDD == 21:
    print("Rio de Janeiro")
elif DDD == 32:
    print("Juiz de Fora")
elif DDD == 19:
    print("Campinas")
elif DDD == 27:
    print("Vitoria")
elif DDD == 31:
    print("Belo Horizonte")
else:
    print("DDD nao cadastrado")
