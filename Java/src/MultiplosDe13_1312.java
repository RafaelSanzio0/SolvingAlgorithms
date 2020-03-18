/*
Escreva um algoritmo que leia 2 valores inteiros X e Y calcule a soma
 dos números que não são múltiplos de 13 entre X e Y, incluindo ambos.
 */
import java.util.Scanner;

public class MultiplosDe13_1312 {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        int x = scanner.nextInt(),y = scanner.nextInt(), somador = 0;

        if(y < x){
            for (int i = y; i <= x; i++) {
                if(i % 13 != 0){
                    somador += i;
                }
            }
        }else{
            for (int i = x; i <= y; i++) {
                if(i % 13 != 0){
                    somador += i;
                }
            }
        }
        System.out.println(somador);
    }
}
