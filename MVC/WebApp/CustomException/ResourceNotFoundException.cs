namespace CustomException;
public class ResourceNotFoundException:Exception{
    public ResourceNotFoundException(string msg):base(msg){} 
}