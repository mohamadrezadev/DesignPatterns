using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatern.Menu_website;

    public abstract class CategoryComponent
    {
        public int Id { get; set; }
        public string Name { get; init; }

        public virtual string Print()
        {
            throw new NotImplementedException();
        }

        public abstract void Add(CategoryComponent categoryComponent);
        public abstract void Remove(CategoryComponent categoryComponent);
    }
    public class Category : CategoryComponent
    {
        public ICollection<CategoryComponent> menuItem=new List<CategoryComponent>();

        public override void Add(CategoryComponent categoryComponent)
        {
            menuItem.Add(categoryComponent);
        }

        public override void Remove(CategoryComponent categoryComponent)
        {
            menuItem.Remove(categoryComponent);
        }
        public override string Print()
        {
             string ul = @$"<ul>={Name} ";
            foreach (var item in menuItem)
            {
                ul += item.Print();
            }
            ul += $@"</ul>";
            return ul;
        }
    }
    public class CategoryItem : CategoryComponent
    {
        public string Link { get; set; }
        public CategoryItem(string name,string link)
        {
            Name= name;
            this.Link = link;
        }
        public override void Add(CategoryComponent categoryComponent)
        {
            throw new NotImplementedException();
        }

        public override void Remove(CategoryComponent categoryComponent)
        {
            throw new NotImplementedException();
        }
        public override string Print()
        {
            string li = @$"<li> <a href='{Link}'> {Name} </a> </li> ";
            return li;
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CategoryItem  CategoryItem { get; set; }
        public int   CategoryItemId { get; set; }

    }

