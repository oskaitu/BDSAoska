namespace MyApp.Tests;

public class LeapYearTests
{
    [Fact]
    public void LeapYear_tests(){
        var ily = new IsLeapYear();

        var test1 = 0;
        var test2 = 4;
        var test3 = 500;
        var test4 = 1640;


        var result1 = ily.isLeapYear(test1);
        var result2 = ily.isLeapYear(test2); 
        var result3 = ily.isLeapYear(test3); 
        var result4 = ily.isLeapYear(test4);     



        result1.Should().Be(false);
        result2.Should().Be(false);
        result3.Should().Be(false);
        result4.Should().Be(true);






        
    }
}