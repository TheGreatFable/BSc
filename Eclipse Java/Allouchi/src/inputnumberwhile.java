import java.util.Scanner;

public class inputnumberwhile {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		int nb, a;
		a=(int)(Math.random()*100);
		System.out.println("input numbers until you gess it: ");
		Scanner imp =new Scanner(System.in);
		nb=imp.nextInt();
		while (nb!=a)
		{
			if (nb>a) System.out.println("its less");
			if (nb<a) System.out.println("its higher");
			System.out.print("re-enter a number: ");
			nb=imp.nextInt();
		}
		System.out.print("Sibta");
		
		
	}

}
