import java.util.Scanner;
public class binary {
public static void main(String[] args) {
// TODO Auto-generated method stub
		int b1, b2, i = 0, rem = 0;
		int[] sum = new int[10];		
		Scanner inp = new Scanner(System.in);
		System.out.print("Input first binary number: ");
		b1 = inp.nextInt();
		System.out.print("Input second binary number: ");
		b2 = inp.nextInt();		
		while (b1 != 0 || b2 != 0) 
		{
			sum[i++] = (b1 % 10 + b2 % 10 + rem) % 2;
			rem = (b1 % 10 + b2 % 10 + rem) / 2;
			b1 = b1 / 10;
			b2 = b2 / 10;
		  }		
		if (rem != 0)
		{
		   sum[i++] = rem;
		  }		
		--i;
		System.out.print("Sum of two binary numbers: ");		
		while (i >= 0) 
		{
			System.out.print(sum[i--]);
			}		
		System.out.print("\n");  		
	}
}
