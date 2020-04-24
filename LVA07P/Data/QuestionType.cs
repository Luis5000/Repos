    namespace LVA07P.Data
    {
        using System.Collections.Generic;
        public class QuestionType
        {
            public int Id { get; set; }
            public string Level { get; set; }
            public string OpenAnswer { get; set; }
            public string MultipleChoice { get; set; }
            public string ClosedAnswer { get; set; }

            public ICollection <Question> Questions { get; set; }

}
}
