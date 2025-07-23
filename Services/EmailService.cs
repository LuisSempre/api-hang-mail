namespace ApiHangMail.Services;

public class EmailService
{
	public void SendWelcome(string email, string nome)
	{
		Console.WriteLine($"[EMAIL] Welcome {nome} <{email}> as {DateTime.Now}");
	}
}
