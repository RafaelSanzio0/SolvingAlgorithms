# Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.

# Entrada
# A entrada contém dois valores inteiros representando a hora de início e a hora de fim do jogo.

# Saída
# Apresente a duração do jogo conforme exemplo abaixo.

start_hour,end_hour = gets.split.map(&:to_i)

if(start_hour >= 0 && start_hour <= 24) || (end_hour >= 0 && end_hour <= 24)
  if(start_hour > end_hour) || (start_hour == end_hour)
    hour = ((start_hour-end_hour)-24).abs
  else
    hour = end_hour - start_hour
  end
end

puts("O JOGO DUROU #{hour} HORA(S)")

