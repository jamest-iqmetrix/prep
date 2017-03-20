﻿namespace code.utility.matching
{
  public static class MatchExtensions
  {
    public static IMatchA<Element> or<Element>(this IMatchA<Element> left, IMatchA<Element> right)
    {
		  return new BinaryMatch<Element>(left, right, BinaryMatches.or);
    }

	  public static IMatchA<Element> and<Element>(this IMatchA<Element> left, IMatchA<Element> right)
	  {
		  return new BinaryMatch<Element>(left, right, BinaryMatches.and);
	  }

    public static IMatchA<Element> not<Element>(this IMatchA<Element> to_negate)
    {
      return new NegatingMatch<Element>(to_negate);
    }
  }
}