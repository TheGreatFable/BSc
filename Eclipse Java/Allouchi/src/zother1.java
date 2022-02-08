import java.util.Scanner;

public class zother1 {

	public static void main(String[] args) {

		String st;
		int s=0,i;
		System.out.println("enter a String");
		Scanner inp=new Scanner(System.in);
		st=inp.next();
		for(i=0;i<st.length();i++)
		{
			if (st.charAt(i)=='a'||st.charAt(i)=='i'||st.charAt(i)=='o'||st.charAt(i)=='e'||st.charAt(i)=='u') 
				s++;
		}
		System.out.println(s);
	

		
		System.out.println("enter a String");
		Scanner inp1=new Scanner(System.in);
		st=inp1.next();
		for(i=0;i<st.length();i++)
		{
			if (st.charAt(i)!='a'&&st.charAt(i)!='i'&&st.charAt(i)!='o'&&st.charAt(i)!='e'&&st.charAt(i)!='u') 
				System.out.print(st.charAt(i));
		}
		System.out.print("\n");
		
		String st1="",bt="Sagesse";
		for(i=0;i<bt.length();i++)
			st1=bt.charAt(i)+st1;
		System.out.println(st1);
		

		char a;
		a='A';		
		i=(int)a;
		System.out.println(i);
		i=i+32;
		a=(char)i;
		System.out.println(a);
		
		
		
		
		inp.close();
		inp1.close();
	}

}
