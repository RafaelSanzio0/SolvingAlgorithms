# Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano, p1(x1, y1) e p2(x2, y2) e calcule a distância entre eles, mostrando 4 casas decimais após a vírgula, segundo a fórmula:

# Distancia =

# Entrada
# O arquivo de entrada contém duas linhas de dados. A primeira linha contém dois valores de ponto flutuante: x1 y1 e a segunda linha contém dois valores de ponto flutuante x2 y2.

# Saída
# Calcule e imprima o valor da distância segundo a fórmula fornecida, com 4 casas após o ponto decimal.

import math

xy = input().split(" ")
yx = input().split(" ")

x1 = float(xy[0])
y1 = float(xy[1])
x2 = float(yx[0])
y2 = float(yx[1])

planoC = math.sqrt((x2 - x1)**2 + (y2 - y1)**2)

print(format(planoC, ".4f"))
