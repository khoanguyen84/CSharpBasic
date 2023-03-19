namespace OOP
{
    abstract class Anminal
    {
        public string Name { get; set; }
        public string Greeting()
        {
            return this.Name;
        }
        public abstract string Move();
    }
}


// 1 phương thức abstract phải nằm trong 1 lớp abstract
// 1 lớp abstract có thể không chưa 1 phương thức abtract nào cả
// Phương thức abstract thì chỉ tên hàm và tham số không có thân hàm