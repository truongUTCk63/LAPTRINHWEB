using System.ComponentModel.DataAnnotations;

namespace lab123.Models
{
    public class Student
    {
        public int Id { get; set; }//Mã sinh viên


        [Required]
        public string? Name { get; set; } //Họ tên

        [Required(ErrorMessage = "Bat buoc")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
        public string? Email { get; set; } //Email

        [StringLength(100, MinimumLength = 8)]
        [Required]

        public string? Password { get; set; }//Mật khẩu
        [Required]
        public Branch? Branch { get; set; }//Ngành học
        [Required]
        public Gender? Gender { get; set; }//Giới tính
        public bool IsRegular { get; set; }//Hệ: true-chính qui, false-phi cq
       
        public string? Address { get; set; }//Địa chỉ
        [Required]
        [Range(typeof(DateTime), "1/1/1963", "12/31/2005")]
        public DateTime DateOfBorth { get; set; }//Ngày sinh
    }

}
