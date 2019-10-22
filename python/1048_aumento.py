# empresa ABC resolveu conceder um aumento de salários a seus funcionários de acordo com a tabela abaixo:

# Salário	Percentual de Reajuste
# 0 - 400.00
# 400.01 - 800.00
# 800.01 - 1200.00
# 1200.01 - 2000.00
# Acima de 2000.00

# 15%
# 12%
# 10%
# 7%
# 4%

# Leia o salário do funcionário e calcule e mostre o novo salário, bem como o valor de reajuste ganho e o índice reajustado, em percentual.

# Entrada
# A entrada contém apenas um valor de ponto flutuante, com duas casas decimais.

# Saída
# Imprima 3 linhas na saída: o novo salário, o valor ganho de reajuste e o percentual de reajuste ganho, conforme exemplo abaixo.

salario = float(input())

if salario >= 0 and salario <= 400.00:
    n = salario * 0.15
    r = n+salario
    p = 0.15 * 100
elif salario >= 400.01 and salario <= 800.00:
    n = salario * 0.12
    r = n+salario
    p = 0.12 * 100
elif salario >= 800.01 and salario <= 1200.00:
    n = salario * 0.10
    r = n+salario
    p = 0.10 * 100
elif salario >= 1200.01 and salario <= 2000.00:
    n = salario * 0.07
    r = n+salario
    p = 0.07 * 100
elif salario > 2.000:
    n = salario * 0.04
    r = n+salario
    p = 0.04 * 100

print("Novo salario:", format(r, ".2f"))
print("Reajuste ganho:", format(n, ".2f"))
print("Em percentual:", format(p, ".0f"), "%")
