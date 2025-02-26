namespace GradApp.Data.Models;

public class ResponseModel<T>
{
    public string Message { get; set;} = null!;
    public int StatusCode { get; set;}
    public bool Success { get; set;}
    public T? Model { get; set;} 
}
