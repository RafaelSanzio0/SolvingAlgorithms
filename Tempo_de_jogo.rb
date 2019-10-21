start_hour,end_hour = gets.split.map(&:to_i)

if(start_hour >= 0 && start_hour <= 24) || (end_hour >= 0 && end_hour <= 24)
  if(start_hour > end_hour) || (start_hour == end_hour)
    hour = ((start_hour-end_hour)-24).abs
  else
    hour = end_hour - start_hour
  end
end

puts("O JOGO DUROU #{hour} HORA(S)")

