import java.util.Scanner;

public class SequenciaCrescente_1146 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        
        int x = scanner.nextInt();

        while(x != 0){
            for (int i = 1; i <= x; i++) {
                System.out.printf("%d ",i);
            }
            System.out.println("\n");
            x = scanner.nextInt();
        }
    }
}
