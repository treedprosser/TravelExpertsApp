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
		public static List<ProductsSupplier>? GetProductsSuppliers(Package pkg, List<string> productList)
		{
			List<ProductsSupplier> prodSup = new List<ProductsSupplier>();
			try
			{
				using (TravelExpertsContext db = new TravelExpertsContext())
				{
					foreach (string p in productList)
					{
						int prodID = int.Parse(p.Split(" - ")[0].Split(":")[0]);
						int supID = int.Parse(p.Split(" - ")[1].Split(":")[0]);
						Product? prod = db.Products.Find(prodID);
						Supplier? sup = db.Suppliers.Find(supID);

						if (prod != null &&	sup != null)
						{
							ProductsSupplier ps = db.ProductsSuppliers
								.Where(p => p.ProductId == prod.ProductId && p.SupplierId == sup.SupplierId).First();
							if (ps == null)
							{
								ps = new ProductsSupplier()
								{
									ProductId = prod.ProductId,
									SupplierId = sup.SupplierId
								};
								db.ProductsSuppliers.Add(ps);
								db.SaveChanges();
							}
								
							prodSup.Add(ps);
						}
						else
							return null;
					}
				}
			}
			catch
			{
				return null;
			}

			return prodSup;
		}

		public static bool SavePackage(bool isAdd, Package package, List<string> productList)
		{
			List<ProductsSupplier>? productsSuppliers = GetProductsSuppliers(package, productList);

			if (productsSuppliers != null)
			{
				try
				{
					if (isAdd)
						AddPackage(package, productsSuppliers);
					else
						ModifyPackage(package, productsSuppliers);
					return true;
				}
				catch
				{
					return false;
				}					
			}
			else
				return false;
		}

		private static void ModifyPackage(Package package, List<ProductsSupplier> productsSuppliers)
		{
			using(TravelExpertsContext db = new TravelExpertsContext())
			{
				Package modPackage = db.Packages.Find(package.PackageId);
				modPackage.ProductSuppliers.Clear();
				foreach(ProductsSupplier ps in productsSuppliers)
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
