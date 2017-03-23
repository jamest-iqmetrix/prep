using System;

namespace code.utility.containers
{
  public class ContainerFacade : IFetchDependencies
  {
    IFindFactoriesForAType factory_registry;

    public ContainerFacade(IFindFactoriesForAType factory_registry)
    {
      this.factory_registry = factory_registry;
    }

    public ItemToFetch an<ItemToFetch>()
    {
      var factory = factory_registry.get_factory_that_can_create(typeof(ItemToFetch));

      return (ItemToFetch)factory.create();
    }

    public object an(Type type_to_fetch)
    {
      throw new NotImplementedException();
    }
  }
}