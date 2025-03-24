class Video
{
    public string _title, _author;
    public int  _length; 
    public List <string> _commentsList;
    public Video(){
        _commentsList = new List<string>();
    }
    public void AddComment(string _name, string _comment){
        _commentsList.Add($"{_name}: {_comment}");
    }
}