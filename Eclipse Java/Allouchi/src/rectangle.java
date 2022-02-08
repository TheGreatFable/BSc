
public class rectangle {

	private int width;
	private int heigth;
	private String color;
	private boolean filled;
	
	public int getWidth()
	{
		return width;
	}
	public int getHeigth()
	{
		return heigth;
	}
	public String getColor()
	{
		return color;
	}
	public boolean isFilled()
	{
		return filled;
	}
	public void setHeigth(int x)
	{
		heigth=x;
	}
	public void setWidth(int x)
	{
		width=x;
	}
	public void setColor(String x)
	{
		color=x;
	}
	public void setFilled(boolean x)
	{
		filled=x;
	}
	
	public rectangle()
	{
		width=1;
		heigth=1;
	}
	public rectangle(int width,int heigth)
	{
		this.width=width;
		this.heigth=heigth;
	}
	public String toString()
	{
		return "this is a rectangle class of width: "+width+" and heigth: "+heigth;
	}
	
}
