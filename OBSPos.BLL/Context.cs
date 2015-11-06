


using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using SubSonic.DataProviders;
using SubSonic.Extensions;
using SubSonic.Linq.Structure;
using SubSonic.Query;
using SubSonic.Schema;
using System.Data.Common;
using System.Collections.Generic;

namespace OBS.Pos.Business
{
    public partial class PosDB : IQuerySurface
    {

        public IDataProvider DataProvider;
        public DbQueryProvider provider;
        
        public bool TestMode
		{
            get
			{
                return DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            }
        }

        public PosDB() 
        { 
            DataProvider = ProviderFactory.GetProvider("ApplicationServices");
            Init();
        }

        public PosDB(string connectionStringName)
        {
            DataProvider = ProviderFactory.GetProvider(connectionStringName);
            Init();
        }

		public PosDB(string connectionString, string providerName)
        {
            DataProvider = ProviderFactory.GetProvider(connectionString,providerName);
            Init();
        }

		public ITable FindByPrimaryKey(string pkName)
        {
            return DataProvider.Schema.Tables.SingleOrDefault(x => x.PrimaryKey.Name.Equals(pkName, StringComparison.InvariantCultureIgnoreCase));
        }

        public Query<T> GetQuery<T>()
        {
            return new Query<T>(provider);
        }
        
        public ITable FindTable(string tableName)
        {
            return DataProvider.FindTable(tableName);
        }
               
        public IDataProvider Provider
        {
            get { return DataProvider; }
            set {DataProvider=value;}
        }
        
        public DbQueryProvider QueryProvider
        {
            get { return provider; }
        }
        
        BatchQuery _batch = null;
        public void Queue<T>(IQueryable<T> qry)
        {
            if (_batch == null)
                _batch = new BatchQuery(Provider, QueryProvider);
            _batch.Queue(qry);
        }

        public void Queue(ISqlQuery qry)
        {
            if (_batch == null)
                _batch = new BatchQuery(Provider, QueryProvider);
            _batch.Queue(qry);
        }

        public void ExecuteTransaction(IList<DbCommand> commands)
		{
            if(!TestMode)
			{
                using(var connection = commands[0].Connection)
				{
                   if (connection.State == ConnectionState.Closed)
                        connection.Open();
                   
                   using (var trans = connection.BeginTransaction()) 
				   {
                        foreach (var cmd in commands) 
						{
                            cmd.Transaction = trans;
                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();
                        }
                        trans.Commit();
                    }
                    connection.Close();
                }
            }
        }

        public IDataReader ExecuteBatch()
        {
            if (_batch == null)
                throw new InvalidOperationException("There's nothing in the queue");
            if(!TestMode)
                return _batch.ExecuteReader();
            return null;
        }
			
        public Query<Supplier> Suppliers { get; set; }
        public Query<ProductSupplier> ProductSuppliers { get; set; }
        public Query<Period> Periods { get; set; }
        public Query<ProductCategory> ProductCategories { get; set; }
        public Query<ProductStock> ProductStocks { get; set; }
        public Query<UnitOfMeasurement> UnitOfMeasurements { get; set; }
        public Query<StockCount> StockCounts { get; set; }
        public Query<Role> Roles { get; set; }
        public Query<User> Users { get; set; }
        public Query<Tax> Taxes { get; set; }
        public Query<Shift> Shifts { get; set; }
        public Query<Category> Categories { get; set; }
        public Query<AppSetting> AppSettings { get; set; }
        public Query<Location> Locations { get; set; }
        public Query<StockType> StockTypes { get; set; }
        public Query<TransactionType> TransactionTypes { get; set; }
        public Query<PaymentType> PaymentTypes { get; set; }
        public Query<PaymentMode> PaymentModes { get; set; }
        public Query<CustomerOut> CustomerOuts { get; set; }
        public Query<Customer> Customers { get; set; }
        public Query<Currency> Currencies { get; set; }
        public Query<PayTran> PayTrans { get; set; }
        public Query<Product> Products { get; set; }

			

        #region ' Aggregates and SubSonic Queries '
        public Select SelectColumns(params string[] columns)
        {
            return new Select(DataProvider, columns);
        }

        public Select Select
        {
            get { return new Select(this.Provider); }
        }

        public Insert Insert
		{
            get { return new Insert(this.Provider); }
        }

        public Update<T> Update<T>() where T:new()
		{
            return new Update<T>(this.Provider);
        }

        public SqlQuery Delete<T>(Expression<Func<T,bool>> column) where T:new()
        {
            LambdaExpression lamda = column;
            SqlQuery result = new Delete<T>(this.Provider);
            result = result.From<T>();
            result.Constraints=lamda.ParseConstraints().ToList();
            return result;
        }

        public SqlQuery Max<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = DataProvider.FindTable(objectName).Name;
            return new Select(DataProvider, new Aggregate(colName, AggregateFunction.Max)).From(tableName);
        }

        public SqlQuery Min<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = this.Provider.FindTable(objectName).Name;
            return new Select(this.Provider, new Aggregate(colName, AggregateFunction.Min)).From(tableName);
        }

        public SqlQuery Sum<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = this.Provider.FindTable(objectName).Name;
            return new Select(this.Provider, new Aggregate(colName, AggregateFunction.Sum)).From(tableName);
        }

        public SqlQuery Avg<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = this.Provider.FindTable(objectName).Name;
            return new Select(this.Provider, new Aggregate(colName, AggregateFunction.Avg)).From(tableName);
        }

        public SqlQuery Count<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = this.Provider.FindTable(objectName).Name;
            return new Select(this.Provider, new Aggregate(colName, AggregateFunction.Count)).From(tableName);
        }

        public SqlQuery Variance<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = this.Provider.FindTable(objectName).Name;
            return new Select(this.Provider, new Aggregate(colName, AggregateFunction.Var)).From(tableName);
        }

        public SqlQuery StandardDeviation<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = this.Provider.FindTable(objectName).Name;
            return new Select(this.Provider, new Aggregate(colName, AggregateFunction.StDev)).From(tableName);
        }

        #endregion

        void Init()
        {
            provider = new DbQueryProvider(this.Provider);

            #region ' Query Defs '
            Suppliers = new Query<Supplier>(provider);
            ProductSuppliers = new Query<ProductSupplier>(provider);
            Periods = new Query<Period>(provider);
            ProductCategories = new Query<ProductCategory>(provider);
            ProductStocks = new Query<ProductStock>(provider);
            UnitOfMeasurements = new Query<UnitOfMeasurement>(provider);
            StockCounts = new Query<StockCount>(provider);
            Roles = new Query<Role>(provider);
            Users = new Query<User>(provider);
            Taxes = new Query<Tax>(provider);
            Shifts = new Query<Shift>(provider);
            Categories = new Query<Category>(provider);
            AppSettings = new Query<AppSetting>(provider);
            Locations = new Query<Location>(provider);
            StockTypes = new Query<StockType>(provider);
            TransactionTypes = new Query<TransactionType>(provider);
            PaymentTypes = new Query<PaymentType>(provider);
            PaymentModes = new Query<PaymentMode>(provider);
            CustomerOuts = new Query<CustomerOut>(provider);
            Customers = new Query<Customer>(provider);
            Currencies = new Query<Currency>(provider);
            PayTrans = new Query<PayTran>(provider);
            Products = new Query<Product>(provider);
            #endregion


            #region ' Schemas '
        	if(DataProvider.Schema.Tables.Count == 0)
			{
            	DataProvider.Schema.Tables.Add(new SuppliersTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ProductSuppliersTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new PeriodsTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ProductCategoriesTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ProductStockTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new UnitOfMeasurementTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new StockCountTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new RolesTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new UsersTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TaxesTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ShiftsTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new CategoriesTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new AppSettingsTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new LocationsTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new StockTypesTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TransactionTypesTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new PaymentTypesTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new PaymentModesTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new CustomerOutsTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new CustomersTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new CurrenciesTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new PayTransTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ProductsTable(DataProvider));
            }
            #endregion
        }
    }
}