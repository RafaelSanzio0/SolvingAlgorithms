start_hour,start_minute,end_hour,end_minute = gets.split.map(&:to_i)

if(start_hour >= 0 && start_hour <= 24) || (end_hour >= 0 && end_hour <= 24)
  if(start_hour > end_hour) || (start_hour == end_hour)
    hour = ((start_hour-end_hour)-24).abs
  else
    hour = end_hour - start_hour
  end
end

if(start_minute >= 0 && start_minute <= 60) || (end_minute >= 0 && end_minute <= 60)
  if(start_minute > end_minute) || (start_minute == end_minute)
    minute = (start_minute-end_minute)
  else
    minute = end_minute - start_minute
  end
end

if hour == 1
  hour = 0
  minute = (start_minute-end_minute+58)
end

puts("O JOGO DUROU #{hour} HORA(S) E #{minute} MINUTOS(S)")

