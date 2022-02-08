import java.util.Scanner;

public class findnum {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		int [] x=new int[20];
		int i,nb;
		int a=0;
		for (i=0;i<20;i++)
		{
			x[i]=(int)(Math.random()*100);
			System.out.print("|"+x[i]);
		}
		System.out.print("\n");		
		System.out.println("input a number");
		Scanner inp=new Scanner(System.in);
		nb=inp.nextInt();
		for (i=0;i<20;i++)
		{
			if(x[i]==nb)
			{
				System.out.println("found at the position of "+i);
				a++;
			}
		}
		if(a==0) System.out.println("not found");
		System.out.println("the sum is "+a);	
		
		
		
	}

}
