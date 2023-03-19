namespace OOP_3
{
    public class Student
    {
        // fields (trường) -> sử dung trong class, access modifier: private
        private string password;
        // properties (thuộc tính) -> 
        public string Fullname { get; set; }
        public bool Gender { get; set; }
        // contructors (phương thức khởi tạo)
        public Student(string fullname, bool gender)
        {
            Fullname = fullname;
            Gender = gender;
        }
        // methods (sự kiện/hành động)
        public string Greatting()
        {
            return $"Hello, I'm {Fullname}";
        }
    }
    // có 3 loại class
    // 1. normal class
    // 2. abstract class :trừa tượng
    //      -> tồn tại ít nhất 1 phương thức hoặc thuộc tính trừa tượng
    //      -> có thể chưa thuộc tính hoặc phương thức ko trừa tượng
    // 3. interface class (trừa tượng)
    //      -> chỉ chứa phương thức và thuộc tính trừa tượng
    
}