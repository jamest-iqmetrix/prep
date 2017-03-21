using Machine.Specifications;

namespace code.utility.matching
{
  [Subject(typeof(Between))]
  class BetweenSpecs
  {
    public class SomeType
    {
    }

    public class when_creating_its_strategy
    {
      It returns_a_criteria_the_matches_values_between_the_provided_values = () =>
      {
        var criteria = Between.values(2, 8);

        criteria(4).ShouldBeTrue();
        criteria(9).ShouldBeFalse();
      };
    }

    public class when_creating_a_ReturnType
    {

      Establish c = () =>
      {

      };
    }
  }
}
