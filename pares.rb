# Faça um programa que mostre os números pares entre 1 e 100, inclusive.

# Entrada
# Neste problema extremamente simples de repetição não há entrada.

# Saída
# Imprima todos os números pares entre 1 e 100, inclusive se for o caso, um em cada linha.

(1..100).each do |value|
  if value % 2 == 0
    puts value
  end
end
