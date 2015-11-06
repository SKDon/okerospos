


using System;
using SubSonic.Schema;
using System.Collections.Generic;
using SubSonic.DataProviders;
using System.Data;

namespace OBS.Pos.Business {
	
        /// <summary>
        /// Table: Suppliers
        /// Primary Key: SupplierId
        /// </summary>

        public class SuppliersTable: DatabaseTable {
            
            public SuppliersTable(IDataProvider provider):base("Suppliers",provider){
                ClassName = "Supplier";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("SupplierId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int64,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SupplierName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Address", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("ContactFirstName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("ContactLastName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("ContactPhone", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("ContactEmail", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("ContactAddress", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });
                    
                
                
            }
            
            public IColumn SupplierId{
                get{
                    return this.GetColumn("SupplierId");
                }
            }
				
   			public static string SupplierIdColumn{
			      get{
        			return "SupplierId";
      			}
		    }
            
            public IColumn SupplierName{
                get{
                    return this.GetColumn("SupplierName");
                }
            }
				
   			public static string SupplierNameColumn{
			      get{
        			return "SupplierName";
      			}
		    }
            
            public IColumn Address{
                get{
                    return this.GetColumn("Address");
                }
            }
				
   			public static string AddressColumn{
			      get{
        			return "Address";
      			}
		    }
            
            public IColumn ContactFirstName{
                get{
                    return this.GetColumn("ContactFirstName");
                }
            }
				
   			public static string ContactFirstNameColumn{
			      get{
        			return "ContactFirstName";
      			}
		    }
            
            public IColumn ContactLastName{
                get{
                    return this.GetColumn("ContactLastName");
                }
            }
				
   			public static string ContactLastNameColumn{
			      get{
        			return "ContactLastName";
      			}
		    }
            
            public IColumn ContactPhone{
                get{
                    return this.GetColumn("ContactPhone");
                }
            }
				
   			public static string ContactPhoneColumn{
			      get{
        			return "ContactPhone";
      			}
		    }
            
            public IColumn ContactEmail{
                get{
                    return this.GetColumn("ContactEmail");
                }
            }
				
   			public static string ContactEmailColumn{
			      get{
        			return "ContactEmail";
      			}
		    }
            
            public IColumn ContactAddress{
                get{
                    return this.GetColumn("ContactAddress");
                }
            }
				
   			public static string ContactAddressColumn{
			      get{
        			return "ContactAddress";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: ProductSuppliers
        /// Primary Key: SupplyId
        /// </summary>

        public class ProductSuppliersTable: DatabaseTable {
            
            public ProductSuppliersTable(IDataProvider provider):base("ProductSuppliers",provider){
                ClassName = "ProductSupplier";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("SupplyId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int64,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SupplierId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int64,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ProductIId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int64,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn SupplyId{
                get{
                    return this.GetColumn("SupplyId");
                }
            }
				
   			public static string SupplyIdColumn{
			      get{
        			return "SupplyId";
      			}
		    }
            
            public IColumn SupplierId{
                get{
                    return this.GetColumn("SupplierId");
                }
            }
				
   			public static string SupplierIdColumn{
			      get{
        			return "SupplierId";
      			}
		    }
            
            public IColumn ProductIId{
                get{
                    return this.GetColumn("ProductIId");
                }
            }
				
   			public static string ProductIIdColumn{
			      get{
        			return "ProductIId";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Periods
        /// Primary Key: PeriodId
        /// </summary>

        public class PeriodsTable: DatabaseTable {
            
            public PeriodsTable(IDataProvider provider):base("Periods",provider){
                ClassName = "Period";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("PeriodId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int64,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("PeriodName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Year", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StartDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("EndDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn PeriodId{
                get{
                    return this.GetColumn("PeriodId");
                }
            }
				
   			public static string PeriodIdColumn{
			      get{
        			return "PeriodId";
      			}
		    }
            
            public IColumn PeriodName{
                get{
                    return this.GetColumn("PeriodName");
                }
            }
				
   			public static string PeriodNameColumn{
			      get{
        			return "PeriodName";
      			}
		    }
            
            public IColumn Year{
                get{
                    return this.GetColumn("Year");
                }
            }
				
   			public static string YearColumn{
			      get{
        			return "Year";
      			}
		    }
            
            public IColumn StartDate{
                get{
                    return this.GetColumn("StartDate");
                }
            }
				
   			public static string StartDateColumn{
			      get{
        			return "StartDate";
      			}
		    }
            
            public IColumn EndDate{
                get{
                    return this.GetColumn("EndDate");
                }
            }
				
   			public static string EndDateColumn{
			      get{
        			return "EndDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: ProductCategories
        /// Primary Key: 
        /// </summary>

        public class ProductCategoriesTable: DatabaseTable {
            
            public ProductCategoriesTable(IDataProvider provider):base("ProductCategories",provider){
                ClassName = "ProductCategory";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ProductId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int64,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CategoryId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int64,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn ProductId{
                get{
                    return this.GetColumn("ProductId");
                }
            }
				
   			public static string ProductIdColumn{
			      get{
        			return "ProductId";
      			}
		    }
            
            public IColumn CategoryId{
                get{
                    return this.GetColumn("CategoryId");
                }
            }
				
   			public static string CategoryIdColumn{
			      get{
        			return "CategoryId";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: ProductStock
        /// Primary Key: StockId
        /// </summary>

        public class ProductStockTable: DatabaseTable {
            
            public ProductStockTable(IDataProvider provider):base("ProductStock",provider){
                ClassName = "ProductStock";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("StockId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int64,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ProductId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int64,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("PeriodId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int64,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("TargetLocationId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int64,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SourceLocationId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int64,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Quantity", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StockType", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int16,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StockDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsFrozen", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn StockId{
                get{
                    return this.GetColumn("StockId");
                }
            }
				
   			public static string StockIdColumn{
			      get{
        			return "StockId";
      			}
		    }
            
            public IColumn ProductId{
                get{
                    return this.GetColumn("ProductId");
                }
            }
				
   			public static string ProductIdColumn{
			      get{
        			return "ProductId";
      			}
		    }
            
            public IColumn PeriodId{
                get{
                    return this.GetColumn("PeriodId");
                }
            }
				
   			public static string PeriodIdColumn{
			      get{
        			return "PeriodId";
      			}
		    }
            
            public IColumn TargetLocationId{
                get{
                    return this.GetColumn("TargetLocationId");
                }
            }
				
   			public static string TargetLocationIdColumn{
			      get{
        			return "TargetLocationId";
      			}
		    }
            
            public IColumn SourceLocationId{
                get{
                    return this.GetColumn("SourceLocationId");
                }
            }
				
   			public static string SourceLocationIdColumn{
			      get{
        			return "SourceLocationId";
      			}
		    }
            
            public IColumn Quantity{
                get{
                    return this.GetColumn("Quantity");
                }
            }
				
   			public static string QuantityColumn{
			      get{
        			return "Quantity";
      			}
		    }
            
            public IColumn StockType{
                get{
                    return this.GetColumn("StockType");
                }
            }
				
   			public static string StockTypeColumn{
			      get{
        			return "StockType";
      			}
		    }
            
            public IColumn StockDate{
                get{
                    return this.GetColumn("StockDate");
                }
            }
				
   			public static string StockDateColumn{
			      get{
        			return "StockDate";
      			}
		    }
            
            public IColumn IsFrozen{
                get{
                    return this.GetColumn("IsFrozen");
                }
            }
				
   			public static string IsFrozenColumn{
			      get{
        			return "IsFrozen";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: UnitOfMeasurement
        /// Primary Key: MeasurementId
        /// </summary>

        public class UnitOfMeasurementTable: DatabaseTable {
            
            public UnitOfMeasurementTable(IDataProvider provider):base("UnitOfMeasurement",provider){
                ClassName = "UnitOfMeasurement";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("MeasurementId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int64,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MeasurementName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Description", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 2000
                });

                Columns.Add(new DatabaseColumn("ScaleFactor", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Double,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn MeasurementId{
                get{
                    return this.GetColumn("MeasurementId");
                }
            }
				
   			public static string MeasurementIdColumn{
			      get{
        			return "MeasurementId";
      			}
		    }
            
            public IColumn MeasurementName{
                get{
                    return this.GetColumn("MeasurementName");
                }
            }
				
   			public static string MeasurementNameColumn{
			      get{
        			return "MeasurementName";
      			}
		    }
            
            public IColumn Description{
                get{
                    return this.GetColumn("Description");
                }
            }
				
   			public static string DescriptionColumn{
			      get{
        			return "Description";
      			}
		    }
            
            public IColumn ScaleFactor{
                get{
                    return this.GetColumn("ScaleFactor");
                }
            }
				
   			public static string ScaleFactorColumn{
			      get{
        			return "ScaleFactor";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: StockCount
        /// Primary Key: CountId
        /// </summary>

        public class StockCountTable: DatabaseTable {
            
            public StockCountTable(IDataProvider provider):base("StockCount",provider){
                ClassName = "StockCount";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("CountId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int64,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("PeriodId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int64,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ProductId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int64,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CountedQuantity", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SystemQuantity", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CountedStockDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SystemStockDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn CountId{
                get{
                    return this.GetColumn("CountId");
                }
            }
				
   			public static string CountIdColumn{
			      get{
        			return "CountId";
      			}
		    }
            
            public IColumn PeriodId{
                get{
                    return this.GetColumn("PeriodId");
                }
            }
				
   			public static string PeriodIdColumn{
			      get{
        			return "PeriodId";
      			}
		    }
            
            public IColumn ProductId{
                get{
                    return this.GetColumn("ProductId");
                }
            }
				
   			public static string ProductIdColumn{
			      get{
        			return "ProductId";
      			}
		    }
            
            public IColumn CountedQuantity{
                get{
                    return this.GetColumn("CountedQuantity");
                }
            }
				
   			public static string CountedQuantityColumn{
			      get{
        			return "CountedQuantity";
      			}
		    }
            
            public IColumn SystemQuantity{
                get{
                    return this.GetColumn("SystemQuantity");
                }
            }
				
   			public static string SystemQuantityColumn{
			      get{
        			return "SystemQuantity";
      			}
		    }
            
            public IColumn CountedStockDate{
                get{
                    return this.GetColumn("CountedStockDate");
                }
            }
				
   			public static string CountedStockDateColumn{
			      get{
        			return "CountedStockDate";
      			}
		    }
            
            public IColumn SystemStockDate{
                get{
                    return this.GetColumn("SystemStockDate");
                }
            }
				
   			public static string SystemStockDateColumn{
			      get{
        			return "SystemStockDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Roles
        /// Primary Key: RoleId
        /// </summary>

        public class RolesTable: DatabaseTable {
            
            public RolesTable(IDataProvider provider):base("Roles",provider){
                ClassName = "Role";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("RoleId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int64,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("RoleName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Description", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 2000
                });

                Columns.Add(new DatabaseColumn("AccessList", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 4000
                });
                    
                
                
            }
            
            public IColumn RoleId{
                get{
                    return this.GetColumn("RoleId");
                }
            }
				
   			public static string RoleIdColumn{
			      get{
        			return "RoleId";
      			}
		    }
            
            public IColumn RoleName{
                get{
                    return this.GetColumn("RoleName");
                }
            }
				
   			public static string RoleNameColumn{
			      get{
        			return "RoleName";
      			}
		    }
            
            public IColumn Description{
                get{
                    return this.GetColumn("Description");
                }
            }
				
   			public static string DescriptionColumn{
			      get{
        			return "Description";
      			}
		    }
            
            public IColumn AccessList{
                get{
                    return this.GetColumn("AccessList");
                }
            }
				
   			public static string AccessListColumn{
			      get{
        			return "AccessList";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Users
        /// Primary Key: UserId
        /// </summary>

        public class UsersTable: DatabaseTable {
            
            public UsersTable(IDataProvider provider):base("Users",provider){
                ClassName = "User";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("UserId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int64,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("UserName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Password", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Binary,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("IsLoggedIn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LastLoginActivity", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LastPasswordUpdate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("RoleId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int64,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ShiftId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int64,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsEnabled", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn UserId{
                get{
                    return this.GetColumn("UserId");
                }
            }
				
   			public static string UserIdColumn{
			      get{
        			return "UserId";
      			}
		    }
            
            public IColumn UserName{
                get{
                    return this.GetColumn("UserName");
                }
            }
				
   			public static string UserNameColumn{
			      get{
        			return "UserName";
      			}
		    }
            
            public IColumn Password{
                get{
                    return this.GetColumn("Password");
                }
            }
				
   			public static string PasswordColumn{
			      get{
        			return "Password";
      			}
		    }
            
            public IColumn IsLoggedIn{
                get{
                    return this.GetColumn("IsLoggedIn");
                }
            }
				
   			public static string IsLoggedInColumn{
			      get{
        			return "IsLoggedIn";
      			}
		    }
            
            public IColumn LastLoginActivity{
                get{
                    return this.GetColumn("LastLoginActivity");
                }
            }
				
   			public static string LastLoginActivityColumn{
			      get{
        			return "LastLoginActivity";
      			}
		    }
            
            public IColumn LastPasswordUpdate{
                get{
                    return this.GetColumn("LastPasswordUpdate");
                }
            }
				
   			public static string LastPasswordUpdateColumn{
			      get{
        			return "LastPasswordUpdate";
      			}
		    }
            
            public IColumn RoleId{
                get{
                    return this.GetColumn("RoleId");
                }
            }
				
   			public static string RoleIdColumn{
			      get{
        			return "RoleId";
      			}
		    }
            
            public IColumn ShiftId{
                get{
                    return this.GetColumn("ShiftId");
                }
            }
				
   			public static string ShiftIdColumn{
			      get{
        			return "ShiftId";
      			}
		    }
            
            public IColumn IsEnabled{
                get{
                    return this.GetColumn("IsEnabled");
                }
            }
				
   			public static string IsEnabledColumn{
			      get{
        			return "IsEnabled";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Taxes
        /// Primary Key: TaxId
        /// </summary>

        public class TaxesTable: DatabaseTable {
            
            public TaxesTable(IDataProvider provider):base("Taxes",provider){
                ClassName = "Tax";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("TaxId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int64,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("TaxName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Description", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 2000
                });

                Columns.Add(new DatabaseColumn("TaxValue", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn TaxId{
                get{
                    return this.GetColumn("TaxId");
                }
            }
				
   			public static string TaxIdColumn{
			      get{
        			return "TaxId";
      			}
		    }
            
            public IColumn TaxName{
                get{
                    return this.GetColumn("TaxName");
                }
            }
				
   			public static string TaxNameColumn{
			      get{
        			return "TaxName";
      			}
		    }
            
            public IColumn Description{
                get{
                    return this.GetColumn("Description");
                }
            }
				
   			public static string DescriptionColumn{
			      get{
        			return "Description";
      			}
		    }
            
            public IColumn TaxValue{
                get{
                    return this.GetColumn("TaxValue");
                }
            }
				
   			public static string TaxValueColumn{
			      get{
        			return "TaxValue";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Shifts
        /// Primary Key: ShiftId
        /// </summary>

        public class ShiftsTable: DatabaseTable {
            
            public ShiftsTable(IDataProvider provider):base("Shifts",provider){
                ClassName = "Shift";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ShiftId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int64,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ShiftName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Description", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 10
                });

                Columns.Add(new DatabaseColumn("StartDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("EndDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn ShiftId{
                get{
                    return this.GetColumn("ShiftId");
                }
            }
				
   			public static string ShiftIdColumn{
			      get{
        			return "ShiftId";
      			}
		    }
            
            public IColumn ShiftName{
                get{
                    return this.GetColumn("ShiftName");
                }
            }
				
   			public static string ShiftNameColumn{
			      get{
        			return "ShiftName";
      			}
		    }
            
            public IColumn Description{
                get{
                    return this.GetColumn("Description");
                }
            }
				
   			public static string DescriptionColumn{
			      get{
        			return "Description";
      			}
		    }
            
            public IColumn StartDate{
                get{
                    return this.GetColumn("StartDate");
                }
            }
				
   			public static string StartDateColumn{
			      get{
        			return "StartDate";
      			}
		    }
            
            public IColumn EndDate{
                get{
                    return this.GetColumn("EndDate");
                }
            }
				
   			public static string EndDateColumn{
			      get{
        			return "EndDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Categories
        /// Primary Key: CategoryId
        /// </summary>

        public class CategoriesTable: DatabaseTable {
            
            public CategoriesTable(IDataProvider provider):base("Categories",provider){
                ClassName = "Category";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("CategoryId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int64,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ParentId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int64,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CategoryName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Description", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 2000
                });

                Columns.Add(new DatabaseColumn("CategoryImage", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Binary,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 2147483647
                });
                    
                
                
            }
            
            public IColumn CategoryId{
                get{
                    return this.GetColumn("CategoryId");
                }
            }
				
   			public static string CategoryIdColumn{
			      get{
        			return "CategoryId";
      			}
		    }
            
            public IColumn ParentId{
                get{
                    return this.GetColumn("ParentId");
                }
            }
				
   			public static string ParentIdColumn{
			      get{
        			return "ParentId";
      			}
		    }
            
            public IColumn CategoryName{
                get{
                    return this.GetColumn("CategoryName");
                }
            }
				
   			public static string CategoryNameColumn{
			      get{
        			return "CategoryName";
      			}
		    }
            
            public IColumn Description{
                get{
                    return this.GetColumn("Description");
                }
            }
				
   			public static string DescriptionColumn{
			      get{
        			return "Description";
      			}
		    }
            
            public IColumn CategoryImage{
                get{
                    return this.GetColumn("CategoryImage");
                }
            }
				
   			public static string CategoryImageColumn{
			      get{
        			return "CategoryImage";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: AppSettings
        /// Primary Key: 
        /// </summary>

        public class AppSettingsTable: DatabaseTable {
            
            public AppSettingsTable(IDataProvider provider):base("AppSettings",provider){
                ClassName = "AppSetting";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("AppSettingId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 10
                });

                Columns.Add(new DatabaseColumn("SettingName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("SettingValue", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }
            
            public IColumn AppSettingId{
                get{
                    return this.GetColumn("AppSettingId");
                }
            }
				
   			public static string AppSettingIdColumn{
			      get{
        			return "AppSettingId";
      			}
		    }
            
            public IColumn SettingName{
                get{
                    return this.GetColumn("SettingName");
                }
            }
				
   			public static string SettingNameColumn{
			      get{
        			return "SettingName";
      			}
		    }
            
            public IColumn SettingValue{
                get{
                    return this.GetColumn("SettingValue");
                }
            }
				
   			public static string SettingValueColumn{
			      get{
        			return "SettingValue";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Locations
        /// Primary Key: LocationId
        /// </summary>

        public class LocationsTable: DatabaseTable {
            
            public LocationsTable(IDataProvider provider):base("Locations",provider){
                ClassName = "Location";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("LocationId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int64,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LocationName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Description", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 2000
                });

                Columns.Add(new DatabaseColumn("Address", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("ContactName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("ContactPhone", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("ContactEmail", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });
                    
                
                
            }
            
            public IColumn LocationId{
                get{
                    return this.GetColumn("LocationId");
                }
            }
				
   			public static string LocationIdColumn{
			      get{
        			return "LocationId";
      			}
		    }
            
            public IColumn LocationName{
                get{
                    return this.GetColumn("LocationName");
                }
            }
				
   			public static string LocationNameColumn{
			      get{
        			return "LocationName";
      			}
		    }
            
            public IColumn Description{
                get{
                    return this.GetColumn("Description");
                }
            }
				
   			public static string DescriptionColumn{
			      get{
        			return "Description";
      			}
		    }
            
            public IColumn Address{
                get{
                    return this.GetColumn("Address");
                }
            }
				
   			public static string AddressColumn{
			      get{
        			return "Address";
      			}
		    }
            
            public IColumn ContactName{
                get{
                    return this.GetColumn("ContactName");
                }
            }
				
   			public static string ContactNameColumn{
			      get{
        			return "ContactName";
      			}
		    }
            
            public IColumn ContactPhone{
                get{
                    return this.GetColumn("ContactPhone");
                }
            }
				
   			public static string ContactPhoneColumn{
			      get{
        			return "ContactPhone";
      			}
		    }
            
            public IColumn ContactEmail{
                get{
                    return this.GetColumn("ContactEmail");
                }
            }
				
   			public static string ContactEmailColumn{
			      get{
        			return "ContactEmail";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: StockTypes
        /// Primary Key: StockTypeId
        /// </summary>

        public class StockTypesTable: DatabaseTable {
            
            public StockTypesTable(IDataProvider provider):base("StockTypes",provider){
                ClassName = "StockType";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("StockTypeId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int16,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Description", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 2000
                });
                    
                
                
            }
            
            public IColumn StockTypeId{
                get{
                    return this.GetColumn("StockTypeId");
                }
            }
				
   			public static string StockTypeIdColumn{
			      get{
        			return "StockTypeId";
      			}
		    }
            
            public IColumn Name{
                get{
                    return this.GetColumn("Name");
                }
            }
				
   			public static string NameColumn{
			      get{
        			return "Name";
      			}
		    }
            
            public IColumn Description{
                get{
                    return this.GetColumn("Description");
                }
            }
				
   			public static string DescriptionColumn{
			      get{
        			return "Description";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: TransactionTypes
        /// Primary Key: TransactionTypeId
        /// </summary>

        public class TransactionTypesTable: DatabaseTable {
            
            public TransactionTypesTable(IDataProvider provider):base("TransactionTypes",provider){
                ClassName = "TransactionType";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("TransactionTypeId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int16,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Description", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 2000
                });
                    
                
                
            }
            
            public IColumn TransactionTypeId{
                get{
                    return this.GetColumn("TransactionTypeId");
                }
            }
				
   			public static string TransactionTypeIdColumn{
			      get{
        			return "TransactionTypeId";
      			}
		    }
            
            public IColumn Name{
                get{
                    return this.GetColumn("Name");
                }
            }
				
   			public static string NameColumn{
			      get{
        			return "Name";
      			}
		    }
            
            public IColumn Description{
                get{
                    return this.GetColumn("Description");
                }
            }
				
   			public static string DescriptionColumn{
			      get{
        			return "Description";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: PaymentTypes
        /// Primary Key: PaymentTypeId
        /// </summary>

        public class PaymentTypesTable: DatabaseTable {
            
            public PaymentTypesTable(IDataProvider provider):base("PaymentTypes",provider){
                ClassName = "PaymentType";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("PaymentTypeId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int16,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Description", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 2000
                });
                    
                
                
            }
            
            public IColumn PaymentTypeId{
                get{
                    return this.GetColumn("PaymentTypeId");
                }
            }
				
   			public static string PaymentTypeIdColumn{
			      get{
        			return "PaymentTypeId";
      			}
		    }
            
            public IColumn Name{
                get{
                    return this.GetColumn("Name");
                }
            }
				
   			public static string NameColumn{
			      get{
        			return "Name";
      			}
		    }
            
            public IColumn Description{
                get{
                    return this.GetColumn("Description");
                }
            }
				
   			public static string DescriptionColumn{
			      get{
        			return "Description";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: PaymentModes
        /// Primary Key: ModeId
        /// </summary>

        public class PaymentModesTable: DatabaseTable {
            
            public PaymentModesTable(IDataProvider provider):base("PaymentModes",provider){
                ClassName = "PaymentMode";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ModeId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int64,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Description", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 2000
                });

                Columns.Add(new DatabaseColumn("PaymentType", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int16,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IconIndex", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn ModeId{
                get{
                    return this.GetColumn("ModeId");
                }
            }
				
   			public static string ModeIdColumn{
			      get{
        			return "ModeId";
      			}
		    }
            
            public IColumn Name{
                get{
                    return this.GetColumn("Name");
                }
            }
				
   			public static string NameColumn{
			      get{
        			return "Name";
      			}
		    }
            
            public IColumn Description{
                get{
                    return this.GetColumn("Description");
                }
            }
				
   			public static string DescriptionColumn{
			      get{
        			return "Description";
      			}
		    }
            
            public IColumn PaymentType{
                get{
                    return this.GetColumn("PaymentType");
                }
            }
				
   			public static string PaymentTypeColumn{
			      get{
        			return "PaymentType";
      			}
		    }
            
            public IColumn IconIndex{
                get{
                    return this.GetColumn("IconIndex");
                }
            }
				
   			public static string IconIndexColumn{
			      get{
        			return "IconIndex";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: CustomerOuts
        /// Primary Key: CustomerOutId
        /// </summary>

        public class CustomerOutsTable: DatabaseTable {
            
            public CustomerOutsTable(IDataProvider provider):base("CustomerOuts",provider){
                ClassName = "CustomerOut";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("CustomerOutId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int64,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CustomerId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int64,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Memo", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Amount", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("PostDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn CustomerOutId{
                get{
                    return this.GetColumn("CustomerOutId");
                }
            }
				
   			public static string CustomerOutIdColumn{
			      get{
        			return "CustomerOutId";
      			}
		    }
            
            public IColumn CustomerId{
                get{
                    return this.GetColumn("CustomerId");
                }
            }
				
   			public static string CustomerIdColumn{
			      get{
        			return "CustomerId";
      			}
		    }
            
            public IColumn Memo{
                get{
                    return this.GetColumn("Memo");
                }
            }
				
   			public static string MemoColumn{
			      get{
        			return "Memo";
      			}
		    }
            
            public IColumn Amount{
                get{
                    return this.GetColumn("Amount");
                }
            }
				
   			public static string AmountColumn{
			      get{
        			return "Amount";
      			}
		    }
            
            public IColumn PostDate{
                get{
                    return this.GetColumn("PostDate");
                }
            }
				
   			public static string PostDateColumn{
			      get{
        			return "PostDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Customers
        /// Primary Key: CustomerId
        /// </summary>

        public class CustomersTable: DatabaseTable {
            
            public CustomersTable(IDataProvider provider):base("Customers",provider){
                ClassName = "Customer";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("CustomerId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int64,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CustomerName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("PaymentModeId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int64,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Address", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Email", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("ContactFirstName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("ContactLastName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("ContactPhone", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("ContactEmail", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("ContactAddress", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("MinBalance", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MinCredit", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("OpenBalance", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreatedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreatedBy", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("ModifiedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedBy", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });
                    
                
                
            }
            
            public IColumn CustomerId{
                get{
                    return this.GetColumn("CustomerId");
                }
            }
				
   			public static string CustomerIdColumn{
			      get{
        			return "CustomerId";
      			}
		    }
            
            public IColumn CustomerName{
                get{
                    return this.GetColumn("CustomerName");
                }
            }
				
   			public static string CustomerNameColumn{
			      get{
        			return "CustomerName";
      			}
		    }
            
            public IColumn PaymentModeId{
                get{
                    return this.GetColumn("PaymentModeId");
                }
            }
				
   			public static string PaymentModeIdColumn{
			      get{
        			return "PaymentModeId";
      			}
		    }
            
            public IColumn Address{
                get{
                    return this.GetColumn("Address");
                }
            }
				
   			public static string AddressColumn{
			      get{
        			return "Address";
      			}
		    }
            
            public IColumn Email{
                get{
                    return this.GetColumn("Email");
                }
            }
				
   			public static string EmailColumn{
			      get{
        			return "Email";
      			}
		    }
            
            public IColumn ContactFirstName{
                get{
                    return this.GetColumn("ContactFirstName");
                }
            }
				
   			public static string ContactFirstNameColumn{
			      get{
        			return "ContactFirstName";
      			}
		    }
            
            public IColumn ContactLastName{
                get{
                    return this.GetColumn("ContactLastName");
                }
            }
				
   			public static string ContactLastNameColumn{
			      get{
        			return "ContactLastName";
      			}
		    }
            
            public IColumn ContactPhone{
                get{
                    return this.GetColumn("ContactPhone");
                }
            }
				
   			public static string ContactPhoneColumn{
			      get{
        			return "ContactPhone";
      			}
		    }
            
            public IColumn ContactEmail{
                get{
                    return this.GetColumn("ContactEmail");
                }
            }
				
   			public static string ContactEmailColumn{
			      get{
        			return "ContactEmail";
      			}
		    }
            
            public IColumn ContactAddress{
                get{
                    return this.GetColumn("ContactAddress");
                }
            }
				
   			public static string ContactAddressColumn{
			      get{
        			return "ContactAddress";
      			}
		    }
            
            public IColumn MinBalance{
                get{
                    return this.GetColumn("MinBalance");
                }
            }
				
   			public static string MinBalanceColumn{
			      get{
        			return "MinBalance";
      			}
		    }
            
            public IColumn MinCredit{
                get{
                    return this.GetColumn("MinCredit");
                }
            }
				
   			public static string MinCreditColumn{
			      get{
        			return "MinCredit";
      			}
		    }
            
            public IColumn OpenBalance{
                get{
                    return this.GetColumn("OpenBalance");
                }
            }
				
   			public static string OpenBalanceColumn{
			      get{
        			return "OpenBalance";
      			}
		    }
            
            public IColumn CreatedOn{
                get{
                    return this.GetColumn("CreatedOn");
                }
            }
				
   			public static string CreatedOnColumn{
			      get{
        			return "CreatedOn";
      			}
		    }
            
            public IColumn CreatedBy{
                get{
                    return this.GetColumn("CreatedBy");
                }
            }
				
   			public static string CreatedByColumn{
			      get{
        			return "CreatedBy";
      			}
		    }
            
            public IColumn ModifiedOn{
                get{
                    return this.GetColumn("ModifiedOn");
                }
            }
				
   			public static string ModifiedOnColumn{
			      get{
        			return "ModifiedOn";
      			}
		    }
            
            public IColumn ModifiedBy{
                get{
                    return this.GetColumn("ModifiedBy");
                }
            }
				
   			public static string ModifiedByColumn{
			      get{
        			return "ModifiedBy";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Currencies
        /// Primary Key: CurrencyId
        /// </summary>

        public class CurrenciesTable: DatabaseTable {
            
            public CurrenciesTable(IDataProvider provider):base("Currencies",provider){
                ClassName = "Currency";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("CurrencyId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CurrencyName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Symbol", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 5
                });
                    
                
                
            }
            
            public IColumn CurrencyId{
                get{
                    return this.GetColumn("CurrencyId");
                }
            }
				
   			public static string CurrencyIdColumn{
			      get{
        			return "CurrencyId";
      			}
		    }
            
            public IColumn CurrencyName{
                get{
                    return this.GetColumn("CurrencyName");
                }
            }
				
   			public static string CurrencyNameColumn{
			      get{
        			return "CurrencyName";
      			}
		    }
            
            public IColumn Symbol{
                get{
                    return this.GetColumn("Symbol");
                }
            }
				
   			public static string SymbolColumn{
			      get{
        			return "Symbol";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: PayTrans
        /// Primary Key: TransactionId
        /// </summary>

        public class PayTransTable: DatabaseTable {
            
            public PayTransTable(IDataProvider provider):base("PayTrans",provider){
                ClassName = "PayTran";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("TransactionId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Guid,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CustomerId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int64,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Memo", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("TransactionType", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int16,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CurrencyId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("PaymentModeId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int64,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CardNum", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("CardExpiryDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Amount", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn TransactionId{
                get{
                    return this.GetColumn("TransactionId");
                }
            }
				
   			public static string TransactionIdColumn{
			      get{
        			return "TransactionId";
      			}
		    }
            
            public IColumn CustomerId{
                get{
                    return this.GetColumn("CustomerId");
                }
            }
				
   			public static string CustomerIdColumn{
			      get{
        			return "CustomerId";
      			}
		    }
            
            public IColumn Memo{
                get{
                    return this.GetColumn("Memo");
                }
            }
				
   			public static string MemoColumn{
			      get{
        			return "Memo";
      			}
		    }
            
            public IColumn TransactionType{
                get{
                    return this.GetColumn("TransactionType");
                }
            }
				
   			public static string TransactionTypeColumn{
			      get{
        			return "TransactionType";
      			}
		    }
            
            public IColumn CurrencyId{
                get{
                    return this.GetColumn("CurrencyId");
                }
            }
				
   			public static string CurrencyIdColumn{
			      get{
        			return "CurrencyId";
      			}
		    }
            
            public IColumn PaymentModeId{
                get{
                    return this.GetColumn("PaymentModeId");
                }
            }
				
   			public static string PaymentModeIdColumn{
			      get{
        			return "PaymentModeId";
      			}
		    }
            
            public IColumn CardNum{
                get{
                    return this.GetColumn("CardNum");
                }
            }
				
   			public static string CardNumColumn{
			      get{
        			return "CardNum";
      			}
		    }
            
            public IColumn CardExpiryDate{
                get{
                    return this.GetColumn("CardExpiryDate");
                }
            }
				
   			public static string CardExpiryDateColumn{
			      get{
        			return "CardExpiryDate";
      			}
		    }
            
            public IColumn Amount{
                get{
                    return this.GetColumn("Amount");
                }
            }
				
   			public static string AmountColumn{
			      get{
        			return "Amount";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Products
        /// Primary Key: ProductId
        /// </summary>

        public class ProductsTable: DatabaseTable {
            
            public ProductsTable(IDataProvider provider):base("Products",provider){
                ClassName = "Product";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ProductId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int64,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ProductCode", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("ProductName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Description", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 2000
                });

                Columns.Add(new DatabaseColumn("MeasurementId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int64,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ProductImage", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Binary,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 2147483647
                });

                Columns.Add(new DatabaseColumn("ApplyVAT", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ApplyNHIL", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("UnitPrice", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CostPrice", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("UsedInSales", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("UsedInProduction", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MinLevel", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ReOrderLevel", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("UseIfNotInStock", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn ProductId{
                get{
                    return this.GetColumn("ProductId");
                }
            }
				
   			public static string ProductIdColumn{
			      get{
        			return "ProductId";
      			}
		    }
            
            public IColumn ProductCode{
                get{
                    return this.GetColumn("ProductCode");
                }
            }
				
   			public static string ProductCodeColumn{
			      get{
        			return "ProductCode";
      			}
		    }
            
            public IColumn ProductName{
                get{
                    return this.GetColumn("ProductName");
                }
            }
				
   			public static string ProductNameColumn{
			      get{
        			return "ProductName";
      			}
		    }
            
            public IColumn Description{
                get{
                    return this.GetColumn("Description");
                }
            }
				
   			public static string DescriptionColumn{
			      get{
        			return "Description";
      			}
		    }
            
            public IColumn MeasurementId{
                get{
                    return this.GetColumn("MeasurementId");
                }
            }
				
   			public static string MeasurementIdColumn{
			      get{
        			return "MeasurementId";
      			}
		    }
            
            public IColumn ProductImage{
                get{
                    return this.GetColumn("ProductImage");
                }
            }
				
   			public static string ProductImageColumn{
			      get{
        			return "ProductImage";
      			}
		    }
            
            public IColumn ApplyVAT{
                get{
                    return this.GetColumn("ApplyVAT");
                }
            }
				
   			public static string ApplyVATColumn{
			      get{
        			return "ApplyVAT";
      			}
		    }
            
            public IColumn ApplyNHIL{
                get{
                    return this.GetColumn("ApplyNHIL");
                }
            }
				
   			public static string ApplyNHILColumn{
			      get{
        			return "ApplyNHIL";
      			}
		    }
            
            public IColumn UnitPrice{
                get{
                    return this.GetColumn("UnitPrice");
                }
            }
				
   			public static string UnitPriceColumn{
			      get{
        			return "UnitPrice";
      			}
		    }
            
            public IColumn CostPrice{
                get{
                    return this.GetColumn("CostPrice");
                }
            }
				
   			public static string CostPriceColumn{
			      get{
        			return "CostPrice";
      			}
		    }
            
            public IColumn UsedInSales{
                get{
                    return this.GetColumn("UsedInSales");
                }
            }
				
   			public static string UsedInSalesColumn{
			      get{
        			return "UsedInSales";
      			}
		    }
            
            public IColumn UsedInProduction{
                get{
                    return this.GetColumn("UsedInProduction");
                }
            }
				
   			public static string UsedInProductionColumn{
			      get{
        			return "UsedInProduction";
      			}
		    }
            
            public IColumn MinLevel{
                get{
                    return this.GetColumn("MinLevel");
                }
            }
				
   			public static string MinLevelColumn{
			      get{
        			return "MinLevel";
      			}
		    }
            
            public IColumn ReOrderLevel{
                get{
                    return this.GetColumn("ReOrderLevel");
                }
            }
				
   			public static string ReOrderLevelColumn{
			      get{
        			return "ReOrderLevel";
      			}
		    }
            
            public IColumn UseIfNotInStock{
                get{
                    return this.GetColumn("UseIfNotInStock");
                }
            }
				
   			public static string UseIfNotInStockColumn{
			      get{
        			return "UseIfNotInStock";
      			}
		    }
            
                    
        }
        
}