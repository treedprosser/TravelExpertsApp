using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelData;

namespace TravelExpertsApp
{
	public static class TravelPackageManager
	{
		//returns a ProductsSupplier list based on the form list
		public static List<ProductsSupplier>? GetProductsSuppliers(List<string> productList)
		{
			List<ProductsSupplier> prodSup = new List<ProductsSupplier>();
			try
			{
				using (TravelExpertsContext db = new TravelExpertsContext())
				{
					foreach (string p in productList)
					{
						//get product and supplier ids from the list
						int prodID = int.Parse(p.Split(" - ")[0].Split(":")[0]);
						int supID = int.Parse(p.Split(" - ")[1].Split(":")[0]);
						//get product and supplier from the database
						Product? prod = db.Products.Find(prodID);
						Supplier? sup = db.Suppliers.Find(supID);

						//if they are null, something is wrong
						//continue only if both exist
						if (prod != null &&	sup != null)
						{
							//gets the ProductsSupplier from the database
							var psquery = db.ProductsSuppliers
								.Where(p => p.ProductId == prod.ProductId && p.SupplierId == sup.SupplierId);
							ProductsSupplier? ps = psquery.Count() != 0 ? psquery.First() : null;
							if (ps == null)//if it doesnt exist, create one
							{
								ps = new ProductsSupplier()
								{
									ProductId = prod.ProductId,
									SupplierId = sup.SupplierId
								};
								db.ProductsSuppliers.Add(ps);
								db.SaveChanges();
							}
								//add to the ProductsSupplier list
							prodSup.Add(ps);
						}
						else
							return null; //return null if something went wrong
					}
				}
			}
			catch
			{
				return null; //if an error occured, return null
			}

			return prodSup; //return the ProductsSupplier list if everything is fine
		}

		//saves the package in the database
		public static bool SavePackage(bool isAdd, Package package, List<string> productList)
		{
			//gets the productsSuppliers list
			List<ProductsSupplier>? productsSuppliers = GetProductsSuppliers(productList);

			//if it is null, something is wrong
			if (productsSuppliers != null)
			{
				try
				{
					if (isAdd) //adds the package
						AddPackage(package, productsSuppliers);
					else //modifies the package
						ModifyPackage(package, productsSuppliers);
					return true; //returns true if it went alright
				}
				catch
				{
					return false;
				}					
			}
			else
				return false;
		}

		//modifies the package
		private static void ModifyPackage(Package package, List<ProductsSupplier> productsSuppliers)
		{
			using(TravelExpertsContext db = new TravelExpertsContext())
			{
				Package modPackage = db.Packages.Find(package.PackageId);
				//modPackage.ProductSuppliers.Clear(); this doesnt work
				foreach (ProductsSupplier ps in productsSuppliers)
				{
					modPackage.ProductSuppliers
						.Add(db.ProductsSuppliers.Find(ps.ProductSupplierId));
				}

				modPackage.PkgName = package.PkgName;
				modPackage.PkgDesc = package.PkgDesc;
				modPackage.PkgBasePrice = package.PkgBasePrice;
				modPackage.PkgAgencyCommission = package.PkgAgencyCommission;
				modPackage.PkgStartDate = package.PkgStartDate;
				modPackage.PkgEndDate = package.PkgEndDate;

				db.SaveChanges();
			}
		}

		//adds the package
		private static void AddPackage(Package package, List<ProductsSupplier> productsSuppliers)
		{
			using (TravelExpertsContext db = new TravelExpertsContext())
			{
				package.ProductSuppliers.Clear();
				foreach (ProductsSupplier ps in productsSuppliers)
				{
					package.ProductSuppliers
						.Add(db.ProductsSuppliers.Find(ps.ProductSupplierId));
				}

				db.Add(package);
				db.SaveChanges();
			}
		}
	}
}
