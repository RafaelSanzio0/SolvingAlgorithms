# Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso.

# Entrada
# O arquivo de entrada contém 1 valor inteiro qualquer.

# Saída
# Imprima todos os valores ímpares de 1 até X, inclusive X, se for o caso.

n = gets.to_i

(1..n).each do |impares|
  unless (impares % 2 == 0)
    puts impares
  end
end
