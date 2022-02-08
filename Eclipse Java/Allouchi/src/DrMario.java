import java.util.Scanner;

public class DrMario {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		int x,y;
		Scanner imp = new Scanner(System.in);
		System.out.print("input a number for x: ");
		x=imp.nextInt();
		System.out.print("input a number for y: ");
		y=imp.nextInt();
		System.out.print("the result is: ");
		if (x>y)System.out.print(x);
		else System.out.print(y);
	
	}

}
