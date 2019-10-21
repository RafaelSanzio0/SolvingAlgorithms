n = gets.to_i

(1..n).each do |impares|
  unless (impares % 2 == 0)
    puts impares
  end
end
