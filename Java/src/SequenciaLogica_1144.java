import java.util.Scanner;
import static java.lang.Math.*;

/*
Escreva um programa que leia um valor inteiro N. N * 2 linhas de saída serão apresentadas
 na execução do programa, seguindo a lógica do exemplo abaixo.
 Para valores com mais de 6 dígitos, todos os dígitos devem ser apresentados.
 */

public class SequenciaLogica_1144 {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int entrada = scanner.nextInt();

        for(int i = 1; i <= entrada ; i++) {
            System.out.printf("%d %d %d\n",i,(int)(pow(i,2)),(int)pow(i,3));
            System.out.printf("%d %d %d\n",i,(int)(pow(i,2)+1),(int)pow(i,3)+1);
        }
    }
}





