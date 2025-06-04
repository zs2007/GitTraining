//
public class login 
{
	public int Id {get;set;}
	public string UserName {get;set;}
	public string Password {get;set;}
}

public bool login(login   req)
{

     if (req.UserName =="ziad"	 and req.Password=="ali")
		   return true;
	   return false;
		   
}


