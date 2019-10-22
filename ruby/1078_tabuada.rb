# Leia 1 valor inteiro N (2 < N < 1000). A seguir, mostre a tabuada de N:
# 1 x N = N      2 x N = 2N        ...       10 x N = 10N

# Entrada
# A entrada contém um valor inteiro N (2 < N < 1000).

# Saída
# Imprima a tabuada de N, conforme o exemplo fornecido.

n = gets.to_i
n2 = 0

(10).times do
  puts "#{n2+1} x #{n} = #{(n2+=1)*n}"
end
