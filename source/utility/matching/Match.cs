using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using developwithpassion.specifications.core;

namespace code.utility.matching
{
  public class Match<Item>
  {
    public delegate object Attribute(Item item);
    private Attribute attrib;

    public Match(Attribute attrib)
    {
      this.attrib = attrib;
    }

    public static Match<Item> with_attribute(Attribute attrib)
    {
      return new Match<Item>(attrib);
    }

    public IMatchA<Item> equal_to(object attrib_value)
    {
      return new CriteriaMatch<Item>(x => attrib(x).Equals(attrib_value));
    }
  }
}
