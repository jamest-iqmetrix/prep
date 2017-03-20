using System;

namespace code.utility.matching
{
  public class MatchBuilder<ItemToMatch, Property>
  {
    PropertyAccessor<ItemToMatch, Property> accessor;

    public MatchBuilder(PropertyAccessor<ItemToMatch, Property> property_accessor)
    {
      accessor = property_accessor;
    }

    public IMatchA<ItemToMatch> equal_to(Property property)
    {
      return new CriteriaMatch<ItemToMatch>(item => accessor(item).Equals(property));
    }

    public IMatchA<ItemToMatch> equal_to_any(params Property[] values)
    {
      IMatchA<ItemToMatch> current = new CriteriaMatch<ItemToMatch>(element => false);

      foreach (var property in values)
      {
        current = current.or(equal_to(property));
      }

      return current;
    }
  }
}