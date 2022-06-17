namespace Task11.Data
{
    public interface IStudentService
    {
        public Student FindStudent(int studentID);

        public void DeleteStudent(int studentID);


    }
}
