import java.util.Scanner;

public class password {

	public static void main(String[] args) {
		// TODO Auto-generated method stub				
		
		String a;
		Scanner inp= new Scanner(System.in);		
		System.out.print("input your password: ");
		System.out.print("\n");
		a=inp.next();									
		if(check(a)==true) System.out.print("Welcome");
		else System.out.print("Access Denied");
		inp.close();		
	}

	static boolean check(String a)
	{		
		int u,d,c1=0,c2=0;
		if (a.length() >=8) {
		for(u=0;u<a.length();u++)
			{
				char g=a.charAt(u);
				d=(int)g;
				if(d>=65 && d<=90) c1++;
				if(d>=48 && d<=57)	c2++;
			}
		if (c1<2) return false;
		if (c2<2) return false;
		}else return false;
		return true;				
	}
	
	
	
}
