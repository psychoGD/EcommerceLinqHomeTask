using ECommerce.Commands;
using ECommerce.DataAccess.SqlServer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ECommerce.Domain.ViewModels
{
    public class AdminMenuViewModel:BaseViewModel
    {
		private ProductRepository _products;
		private OrderRepository _orders;

		private ObservableCollection<Order> orders;

		public ObservableCollection<Order> Orders
		{
			get { return orders; }
			set { orders = value;OnPropertyChanged(); }
		}


		private ObservableCollection<Product> products;

		public ObservableCollection<Product> Products
		{
			get { return products; }
			set { products = value;OnPropertyChanged(); }
		}


		private string name;

		public string Name
		{
			get { return name; }
			set { name = value;OnPropertyChanged(); }
		}

		private string description;

		public string Description
		{
			get { return description; }
			set { description = value;OnPropertyChanged(); }
		}
		
		private double price;

		public double Price
		{
			get { return price; }
			set { price = value;OnPropertyChanged(); }
		}

		private int discount;

		public int Discount
		{
			get { return discount; }
			set { discount = value;OnPropertyChanged(); }
		}

		private int quantity;

		public int Quantity
		{
			get { return quantity; }
			set { quantity = value;OnPropertyChanged(); }
		}

		public RelayCommand AddProductCommand{ get; set; }
		public RelayCommand BackCommand { get; set; }

		public Product CheckNewProduct(string Name,string Description,int quantity,int discount,decimal price)
		{
            if (price > 0 && Name!=string.Empty && Description!=string.Empty && quantity>0 && price>0 && discount>=0)
            {
				return new Product{ Name = Name,
					Description = Description,
					Quantity = quantity,
					Discount = discount,
					Price = price
				};
            }
			return null;
        }
		public AdminMenuViewModel()
		{
			_products = new ProductRepository();
			_orders = new OrderRepository();

			Products = _products.GetAllData();
			Orders = _orders.GetAllData();
			AddProductCommand = new RelayCommand(o =>
			{
				try
				{
					var quantityCopy = Convert.ToInt32(quantity);
					var discountCopy = Convert.ToInt32(discount);
					var priceCopy = Convert.ToDecimal(price);
					var product = CheckNewProduct(Name, Description, quantityCopy, discountCopy, priceCopy);
                    if (product!=null)
					{
						_products.AddData(product);
						MessageBox.Show("Product Added Succesfully");
						Products = _products.GetAllData();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				Order order = new Order();
			});

			BackCommand = new RelayCommand(o =>
			{
				App.DeleteLastView();
			});
		}
	}
}
