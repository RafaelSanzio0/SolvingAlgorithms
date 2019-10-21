# Neste problema, você deverá ler 3 palavras que definem o tipo de animal possível segundo o esquema abaixo, da esquerda para a direita.  Em seguida conclua qual dos animais seguintes foi escolhido, através das três palavras fornecidas.

# Entrada
# A entrada contém 3 palavras, uma em cada linha, necessárias para identificar o animal segundo a figura acima, com todas as letras minúsculas.

# Saída
# Imprima o nome do animal correspondente à entrada fornecida.

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



