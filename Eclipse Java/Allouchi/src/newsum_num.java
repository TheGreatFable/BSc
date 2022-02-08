import java.util.Scanner;

public class newsum_num {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		
		int num, sum=0;
		
		System.out.println("input a number");
		Scanner imp=new Scanner(System.in);
		num=imp.nextInt();
		while (num>0)
		{
			sum=sum+num%10;
		    num=num/10;
		}
		System.out.println(sum);
		
		
	}

}
