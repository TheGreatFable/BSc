import java.util.Scanner;

public class newone {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		char x;
		Scanner inp=new Scanner(System.in);
		System.out.print("enter a character b,r,y ");
		x= inp.next().charAt(0);
		if(x=='b') System.out.print("your choice is blue");
		else if(x=='r') System.out.print("your choice is red");
		else if(x=='y') System.out.print("your choice is yellow");
		else System.out.print("your choice is in another world");
		
	}

}
