using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook:BaseGradeBook
    {
        public StandardGradeBook(string name, bool bIsWeighted): base(name, bIsWeighted)
        {
            Type = GradeBookType.Standard;
        }
    }
}
