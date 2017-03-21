using Machine.Specifications;

namespace code.utility.matching
{
  class BetweenSpecs
  {
    public class when_creating_its_strategy
    {
      static protected Criteria<int> criteria;

      private Because b = () =>
      {
        criteria = Between.values(2, 8);
      };

      It returns_a_criteria_the_matches_values_between_the_provided_values = () =>
      {
        criteria(4).ShouldBeTrue();
        criteria(9).ShouldBeFalse();
      };
    }
    
  }
}
