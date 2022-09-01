namespace Test_Grade_Student;

public class UnitTest1
{
    [Fact]
    public void TestInputName() {
        string name = Program.InputName();

        Assert.IsType<string>(name);
    }

    [Fact]
    public void TestInputScore() {
        string score = Program.InputScore();

        Assert.IsType<string>(score);
    }

    [Fact]
    public void TestConvertStringToInt() {
        int number = Program.ConvertStringToInt("75");

        Assert.Equal(number, 75);
    }

    [Fact]
    public void TestConvertStringToIntIsInCorrect() {
       Assert.Throws<Exception>(() => Program.ConvertStringToInt("kittinun"));
    }

    [Fact]
    public void TestConvertScoreToGrade() {
        string grade = Program.ConvertScoreToGrade(75);

        Assert.Equal(grade, "Grade B+");
    }

    [Fact]
    public void TestIsGradeA() {
       int score = 85;

       Assert.True(Program.IsGradeA(score));
    }

    [Fact]
    public void TestIsGradeAIsInCorrect() {
        int score = 75;

        Assert.False(Program.IsGradeA(score));
    }

    [Fact]
    public void TestIsGradeBPlus() {
        int score = 75;

        Assert.True(Program.IsGradeBPlus(score));
    }

    [Fact]
    public void TestIsGradeBPlusIsInCorrect() {
        int score = 85;

        Assert.False(Program.IsGradeBPlus(score));
    }

    [Fact]
    public void TestIsGradeB() {
        int score = 70; 

        Assert.True(Program.IsGradeB(score));
    }

    [Fact]
    public void TestIsGradeBIsInCorrect() {
        int score = 79;

        Assert.False(Program.IsGradeB(score));
    }

    [Fact]
    public void TestIsGradeCPlus() {
        int score = 69;

        Assert.True(Program.IsGradeCPlus(score));
    }

    [Fact]
    public void TestIsGradeCPlusIsInCorrect() {
        int score = 60;

        Assert.False(Program.IsGradeCPlus(score));
    }

    [Fact]
    public void TestIsGradeC() {
        int score = 60; 

        Assert.True(Program.IsGradeC(score));
    }

    [Fact]
    public void TestIsGradeCIsInCorrect() {
        int score = 55;

        Assert.False(Program.IsGradeC(score));
    }

    [Fact]
    public void TestIsGradeDPlus() {
        int score = 59;

        Assert.True(Program.IsGradeDPlus(score));
    }

    [Fact]
    public void TestIsGradeDPlusIsInCorrect() {
        int score = 50;

        Assert.False(Program.IsGradeDPlus(score));
    }

    [Fact]
    public void TestIsGradeD() {
        int score = 50;

        Assert.True(Program.IsGradeD(score));
    }

    [Fact]
    public void TestIsGradeDIsInCorrect() {
        int score = 49;

        Assert.False(Program.IsGradeD(score));
    }

    [Fact]
    public void TestIsGradeF() {
        int score = 49;
        string grade = Program.ConvertScoreToGrade(score);

        Assert.Equal(grade, "Grade F");
    }
}