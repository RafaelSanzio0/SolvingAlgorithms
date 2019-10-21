a = gets.chomp
b = gets.chomp
c = gets.chomp

if a == "vertebrado" && b == "ave" && c == "carnivoro"
  puts("aguia")
elsif a == "vertebrado" && b == "ave" && c == "onivoro"
  puts("pomba")
elsif a == "vertebrado" && b == "mamifero" && c == "onivoro"
  puts("homem")
elsif a == "vertebrado" && b == "mamifero" && c == "herbivoro"
  puts("vaca")
elsif a == "invertebrado" && b == "inseto" && c == "hematofago"
  puts("pulga")
elsif a == "invertebrado" && b == "inseto" && c == "herbivoro"
  puts("lagarta")
elsif a == "invertebrado" && b == "anelideo" && c == "hematofago"
  puts("sanguessuga")
elsif a == "invertebrado" && b == "anelideo" && c == "onivoro"
  puts("minhoca")
end



