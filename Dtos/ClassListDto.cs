namespace schoolMoney_backend.Dtos;

public class ClassListDto
{
    public string ClassId { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string SchoolName { get; set; } = string.Empty;
    public UserInClassDto Treasurer { get; set; } = new();
}