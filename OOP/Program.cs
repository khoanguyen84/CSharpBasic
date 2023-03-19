using System;

namespace OOP
{
    // Class
    // Object/ Instance
    // Fields
    // Properties
    // Methods
    // Contructors

    // 4 Tính chất của HĐT
    // Đóng gói, access modifiers (khả năng truy cập vào thuộc tính của đối tượng)
    // Kế thừa
    // Đa hình
    // Trừu tượng

    // Định nghĩa ra 1 kiểu dữ liệu mới
    // Định nghĩa ra 1 class

    // Access Modifier
    // + Internal: chỉ thể truy cập khi cùng 1 assembly
    // + Public: có thể truy câp bất kể ở đâu
    // + Protected: chỉ thể truy cập khi các lớp kế thừa nhau
    // + Private: chỉ có thể truy cập bên trong lớp đó mà thôi

    // Kiểu dữ liệu nguyên thủy: int, float, double, string, char.
    // Thông tin của 1 Staff: StaffId, Fullname, Gender, Age, Hobbies, Email
    // Định nghĩa ra 1 kiểu dữ liệu, phụ thuộc vào bài toán mình cần giải quyết
    // các cách để truy xuất đến fields
    // sử dụng các phương thức getter()/setter()
    class Program
    {
        static void Main(string[] args)
        {
            Staff staff1 = new Staff(true, 18);
            // staff1.setName("Khoa Nguyen");
            staff1.Name = "";
            // staff1.Age = 18;
            // Console.WriteLine(staff1.getName());
            Console.WriteLine(staff1.Name);
            Console.WriteLine(staff1.Age);

            Staff staff2 = new Staff();
            // staff2.setName("Vuong");
            staff2.Name = "Vuong";
            // Console.WriteLine(staff2.getName());
            // Console.WriteLine(staff2.Name);
        }
    }

    // this (context: ngữ cảnh)
    // Arrow Function
    class Staff
    {
        // Fields
        private string name;
        // Properties
        public int Age { get; set; }
        public bool Gender {get; set;}
        // Contructors
        public Staff(){

        }
        public Staff(bool gender, int age){
            this.Age = age;
            this.Gender = gender;
        }
        public Staff(bool gender, int age, string name){
            this.Age = age;
            this.Gender = gender;
            this.name = name;
        }
        // Methods
        // public void setName(string name){
        //     this.name = name;
        // }
        // public string getName(){
        //     return this.name;
        // }
        // public string Name{
        //     set{
        //         this.name = value;
        //     }
        //     get{
        //         return this.name;
        //     }
        // }
        public string Name{
            set => this.name = value; 
            get => this.name;
        }
        // public string Name
        // {
        //     set {
        //         if(string.IsNullOrEmpty(value)){
        //             this.name = "No name";
        //         }
        //         else{
        //             this.name = value;
        //         }
        //     }
                
        //     get => this.name;
        // }
        private string Test(){
            return "Hello";
        }
    }
}
