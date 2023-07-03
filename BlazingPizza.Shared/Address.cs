namespace BlazingPizza;

public class Address
{
    public int Id { get; set; }

    [Required(ErrorMessage = "이름이 비었습니다"), MaxLength(100)]
    public string Name { get; set; }

    [Required(ErrorMessage = "주소1이 비엇슴돠"), MaxLength(100)]
    public string Line1 { get; set; }

    [MaxLength(100)] public string Line2 { get; set; }

    [Required(ErrorMessage = "도시이름이 비엇슴둥"), MaxLength(50)]
    public string City { get; set; }

    [Required(ErrorMessage = "지역이 비엇슴다"), MaxLength(20)]
    public string Region { get; set; }

    [Required(ErrorMessage = "우편번호!"), MaxLength(20)]
    public string PostalCode { get; set; }
}