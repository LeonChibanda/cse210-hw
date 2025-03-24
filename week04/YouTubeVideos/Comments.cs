class Comments
{
    public string _comments, _name;
    public Comments(){
        
    }
    public void DisplayComments(Video v){
        Console.WriteLine($"Title: {v._title} \nAuthor: {v._author} \nDuration: {v._length} \nComments:");
        foreach (string item in v._commentsList)
        {
            System.Console.WriteLine(item);
        }
    }
}