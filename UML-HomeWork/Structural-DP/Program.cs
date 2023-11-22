using System;

namespace Composite_DP;

// Component Interface
public interface ICatalogComponent
{
    void DrawHierarchy();
}

// Composite Class
public class ProductCatalog : ICatalogComponent
{
    private string _name;
    private List<ICatalogComponent> _components;
    public ProductCatalog(string name)
    {
        _name = name;
        _components = new List<ICatalogComponent>();
    }
    public void Add(ICatalogComponent catalogComponent)
    {
        _components.Add(catalogComponent);
    }
    public void Remove(ICatalogComponent catalogComponent)
    {
        _components.Remove(catalogComponent);
    }
    public void DrawHierarchy()
    {
        Console.WriteLine(_name);
        foreach (ICatalogComponent component in _components)
        {
            component.DrawHierarchy();
        }
    }
}

// Leaf Class
class Product : ICatalogComponent
{
    private string _name;
    public Product(string name)
    {
        _name = name;
    }
    public void DrawHierarchy()
    {
        Console.WriteLine(_name);
    }
}