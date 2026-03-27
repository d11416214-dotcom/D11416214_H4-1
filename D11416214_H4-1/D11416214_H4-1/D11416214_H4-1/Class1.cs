using System;

public class Manager
{
	private readonly DateTime Startup;
	public Manage()
	{
		Startup = DateTime.Now;
	}
	public DateTime GetStartup()
	{
		return Startup;
	}
}
