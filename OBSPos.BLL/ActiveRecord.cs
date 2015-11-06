


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SubSonic.DataProviders;
using SubSonic.Extensions;
using System.Linq.Expressions;
using SubSonic.Schema;
using System.Collections;
using SubSonic;
using SubSonic.Repository;
using System.ComponentModel;
using System.Data.Common;

namespace OBS.Pos.Business
{
    
    
    /// <summary>
    /// A class which represents the Suppliers table in the Pos Database.
    /// </summary>
    public partial class Supplier: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<Supplier> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<Supplier>(new OBS.Pos.Business.PosDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<Supplier> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(Supplier item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                Supplier item=new Supplier();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<Supplier> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        OBS.Pos.Business.PosDB _db;
        public Supplier(string connectionString, string providerName) {

            _db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                Supplier.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Supplier>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public Supplier(){
             _db=new OBS.Pos.Business.PosDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public Supplier(Expression<Func<Supplier, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<Supplier> GetRepo(string connectionString, string providerName){
            OBS.Pos.Business.PosDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new OBS.Pos.Business.PosDB();
            }else{
                db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            }
            IRepository<Supplier> _repo;
            
            if(db.TestMode){
                Supplier.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Supplier>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<Supplier> GetRepo(){
            return GetRepo("","");
        }
        
        public static Supplier SingleOrDefault(Expression<Func<Supplier, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            Supplier single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static Supplier SingleOrDefault(Expression<Func<Supplier, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            Supplier single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<Supplier, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<Supplier, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<Supplier> Find(Expression<Func<Supplier, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<Supplier> Find(Expression<Func<Supplier, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<Supplier> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<Supplier> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<Supplier> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<Supplier> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<Supplier> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<Supplier> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "SupplierId";
        }

        public object KeyValue()
        {
            return this.SupplierId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<long>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.SupplierName.ToString();
        }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(Supplier)){
                Supplier compare=(Supplier)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        public string DescriptorValue()
        {
            return this.SupplierName.ToString();
        }

        public string DescriptorColumn() {
            return "SupplierName";
        }
        public static string GetKeyColumn()
        {
            return "SupplierId";
        }        
        public static string GetDescriptorColumn()
        {
            return "SupplierName";
        }
        
        #region ' Foreign Keys '
        public IQueryable<ProductSupplier> ProductSuppliers
        {
            get
            {
                
                  var repo=OBS.Pos.Business.ProductSupplier.GetRepo();
                  return from items in repo.GetAll()
                       where items.SupplierId == _SupplierId
                       select items;
            }
        }

        #endregion
        

        long _SupplierId;
        public long SupplierId
        {
            get { return _SupplierId; }
            set
            {
                if(_SupplierId!=value){
                    _SupplierId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="SupplierId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _SupplierName;
        public string SupplierName
        {
            get { return _SupplierName; }
            set
            {
                if(_SupplierName!=value){
                    _SupplierName=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="SupplierName");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Address;
        public string Address
        {
            get { return _Address; }
            set
            {
                if(_Address!=value){
                    _Address=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Address");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _ContactFirstName;
        public string ContactFirstName
        {
            get { return _ContactFirstName; }
            set
            {
                if(_ContactFirstName!=value){
                    _ContactFirstName=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ContactFirstName");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _ContactLastName;
        public string ContactLastName
        {
            get { return _ContactLastName; }
            set
            {
                if(_ContactLastName!=value){
                    _ContactLastName=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ContactLastName");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _ContactPhone;
        public string ContactPhone
        {
            get { return _ContactPhone; }
            set
            {
                if(_ContactPhone!=value){
                    _ContactPhone=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ContactPhone");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _ContactEmail;
        public string ContactEmail
        {
            get { return _ContactEmail; }
            set
            {
                if(_ContactEmail!=value){
                    _ContactEmail=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ContactEmail");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _ContactAddress;
        public string ContactAddress
        {
            get { return _ContactAddress; }
            set
            {
                if(_ContactAddress!=value){
                    _ContactAddress=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ContactAddress");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<Supplier, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the ProductSuppliers table in the Pos Database.
    /// </summary>
    public partial class ProductSupplier: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<ProductSupplier> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<ProductSupplier>(new OBS.Pos.Business.PosDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<ProductSupplier> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(ProductSupplier item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                ProductSupplier item=new ProductSupplier();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<ProductSupplier> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        OBS.Pos.Business.PosDB _db;
        public ProductSupplier(string connectionString, string providerName) {

            _db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                ProductSupplier.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<ProductSupplier>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public ProductSupplier(){
             _db=new OBS.Pos.Business.PosDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public ProductSupplier(Expression<Func<ProductSupplier, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<ProductSupplier> GetRepo(string connectionString, string providerName){
            OBS.Pos.Business.PosDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new OBS.Pos.Business.PosDB();
            }else{
                db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            }
            IRepository<ProductSupplier> _repo;
            
            if(db.TestMode){
                ProductSupplier.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<ProductSupplier>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<ProductSupplier> GetRepo(){
            return GetRepo("","");
        }
        
        public static ProductSupplier SingleOrDefault(Expression<Func<ProductSupplier, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            ProductSupplier single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static ProductSupplier SingleOrDefault(Expression<Func<ProductSupplier, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            ProductSupplier single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<ProductSupplier, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<ProductSupplier, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<ProductSupplier> Find(Expression<Func<ProductSupplier, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<ProductSupplier> Find(Expression<Func<ProductSupplier, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<ProductSupplier> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<ProductSupplier> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<ProductSupplier> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<ProductSupplier> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<ProductSupplier> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<ProductSupplier> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "SupplyId";
        }

        public object KeyValue()
        {
            return this.SupplyId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<long>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.SupplierId.ToString();
        }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(ProductSupplier)){
                ProductSupplier compare=(ProductSupplier)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        public string DescriptorValue()
        {
            return this.SupplierId.ToString();
        }

        public string DescriptorColumn() {
            return "SupplierId";
        }
        public static string GetKeyColumn()
        {
            return "SupplyId";
        }        
        public static string GetDescriptorColumn()
        {
            return "SupplierId";
        }
        
        #region ' Foreign Keys '
        public IQueryable<Product> Products
        {
            get
            {
                
                  var repo=OBS.Pos.Business.Product.GetRepo();
                  return from items in repo.GetAll()
                       where items.ProductId == _ProductIId
                       select items;
            }
        }

        public IQueryable<Supplier> Suppliers
        {
            get
            {
                
                  var repo=OBS.Pos.Business.Supplier.GetRepo();
                  return from items in repo.GetAll()
                       where items.SupplierId == _SupplierId
                       select items;
            }
        }

        #endregion
        

        long _SupplyId;
        public long SupplyId
        {
            get { return _SupplyId; }
            set
            {
                if(_SupplyId!=value){
                    _SupplyId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="SupplyId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        long _SupplierId;
        public long SupplierId
        {
            get { return _SupplierId; }
            set
            {
                if(_SupplierId!=value){
                    _SupplierId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="SupplierId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        long? _ProductIId;
        public long? ProductIId
        {
            get { return _ProductIId; }
            set
            {
                if(_ProductIId!=value){
                    _ProductIId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ProductIId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<ProductSupplier, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the Periods table in the Pos Database.
    /// </summary>
    public partial class Period: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<Period> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<Period>(new OBS.Pos.Business.PosDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<Period> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(Period item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                Period item=new Period();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<Period> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        OBS.Pos.Business.PosDB _db;
        public Period(string connectionString, string providerName) {

            _db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                Period.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Period>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public Period(){
             _db=new OBS.Pos.Business.PosDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public Period(Expression<Func<Period, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<Period> GetRepo(string connectionString, string providerName){
            OBS.Pos.Business.PosDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new OBS.Pos.Business.PosDB();
            }else{
                db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            }
            IRepository<Period> _repo;
            
            if(db.TestMode){
                Period.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Period>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<Period> GetRepo(){
            return GetRepo("","");
        }
        
        public static Period SingleOrDefault(Expression<Func<Period, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            Period single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static Period SingleOrDefault(Expression<Func<Period, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            Period single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<Period, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<Period, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<Period> Find(Expression<Func<Period, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<Period> Find(Expression<Func<Period, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<Period> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<Period> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<Period> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<Period> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<Period> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<Period> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "PeriodId";
        }

        public object KeyValue()
        {
            return this.PeriodId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<long>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.PeriodName.ToString();
        }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(Period)){
                Period compare=(Period)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        public string DescriptorValue()
        {
            return this.PeriodName.ToString();
        }

        public string DescriptorColumn() {
            return "PeriodName";
        }
        public static string GetKeyColumn()
        {
            return "PeriodId";
        }        
        public static string GetDescriptorColumn()
        {
            return "PeriodName";
        }
        
        #region ' Foreign Keys '
        public IQueryable<ProductStock> ProductStocks
        {
            get
            {
                
                  var repo=OBS.Pos.Business.ProductStock.GetRepo();
                  return from items in repo.GetAll()
                       where items.PeriodId == _PeriodId
                       select items;
            }
        }

        public IQueryable<StockCount> StockCounts
        {
            get
            {
                
                  var repo=OBS.Pos.Business.StockCount.GetRepo();
                  return from items in repo.GetAll()
                       where items.PeriodId == _PeriodId
                       select items;
            }
        }

        #endregion
        

        long _PeriodId;
        public long PeriodId
        {
            get { return _PeriodId; }
            set
            {
                if(_PeriodId!=value){
                    _PeriodId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="PeriodId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _PeriodName;
        public string PeriodName
        {
            get { return _PeriodName; }
            set
            {
                if(_PeriodName!=value){
                    _PeriodName=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="PeriodName");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _Year;
        public int? Year
        {
            get { return _Year; }
            set
            {
                if(_Year!=value){
                    _Year=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Year");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        DateTime? _StartDate;
        public DateTime? StartDate
        {
            get { return _StartDate; }
            set
            {
                if(_StartDate!=value){
                    _StartDate=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="StartDate");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        DateTime? _EndDate;
        public DateTime? EndDate
        {
            get { return _EndDate; }
            set
            {
                if(_EndDate!=value){
                    _EndDate=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="EndDate");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<Period, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the ProductCategories table in the Pos Database.
    /// </summary>
    public partial class ProductCategory: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<ProductCategory> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<ProductCategory>(new OBS.Pos.Business.PosDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<ProductCategory> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(ProductCategory item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                ProductCategory item=new ProductCategory();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<ProductCategory> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        OBS.Pos.Business.PosDB _db;
        public ProductCategory(string connectionString, string providerName) {

            _db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                ProductCategory.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<ProductCategory>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public ProductCategory(){
             _db=new OBS.Pos.Business.PosDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public ProductCategory(Expression<Func<ProductCategory, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<ProductCategory> GetRepo(string connectionString, string providerName){
            OBS.Pos.Business.PosDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new OBS.Pos.Business.PosDB();
            }else{
                db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            }
            IRepository<ProductCategory> _repo;
            
            if(db.TestMode){
                ProductCategory.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<ProductCategory>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<ProductCategory> GetRepo(){
            return GetRepo("","");
        }
        
        public static ProductCategory SingleOrDefault(Expression<Func<ProductCategory, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            ProductCategory single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static ProductCategory SingleOrDefault(Expression<Func<ProductCategory, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            ProductCategory single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<ProductCategory, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<ProductCategory, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<ProductCategory> Find(Expression<Func<ProductCategory, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<ProductCategory> Find(Expression<Func<ProductCategory, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<ProductCategory> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<ProductCategory> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<ProductCategory> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<ProductCategory> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<ProductCategory> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<ProductCategory> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "ProductId";
        }

        public object KeyValue()
        {
            return this.ProductId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<long>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.CategoryId.ToString();
        }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(ProductCategory)){
                ProductCategory compare=(ProductCategory)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        public string DescriptorValue()
        {
            return this.CategoryId.ToString();
        }

        public string DescriptorColumn() {
            return "CategoryId";
        }
        public static string GetKeyColumn()
        {
            return "ProductId";
        }        
        public static string GetDescriptorColumn()
        {
            return "CategoryId";
        }
        
        #region ' Foreign Keys '
        public IQueryable<Category> Categories
        {
            get
            {
                
                  var repo=OBS.Pos.Business.Category.GetRepo();
                  return from items in repo.GetAll()
                       where items.CategoryId == _CategoryId
                       select items;
            }
        }

        public IQueryable<Product> Products
        {
            get
            {
                
                  var repo=OBS.Pos.Business.Product.GetRepo();
                  return from items in repo.GetAll()
                       where items.ProductId == _ProductId
                       select items;
            }
        }

        #endregion
        

        long _ProductId;
        public long ProductId
        {
            get { return _ProductId; }
            set
            {
                if(_ProductId!=value){
                    _ProductId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ProductId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        long _CategoryId;
        public long CategoryId
        {
            get { return _CategoryId; }
            set
            {
                if(_CategoryId!=value){
                    _CategoryId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CategoryId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<ProductCategory, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the ProductStock table in the Pos Database.
    /// </summary>
    public partial class ProductStock: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<ProductStock> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<ProductStock>(new OBS.Pos.Business.PosDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<ProductStock> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(ProductStock item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                ProductStock item=new ProductStock();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<ProductStock> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        OBS.Pos.Business.PosDB _db;
        public ProductStock(string connectionString, string providerName) {

            _db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                ProductStock.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<ProductStock>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public ProductStock(){
             _db=new OBS.Pos.Business.PosDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public ProductStock(Expression<Func<ProductStock, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<ProductStock> GetRepo(string connectionString, string providerName){
            OBS.Pos.Business.PosDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new OBS.Pos.Business.PosDB();
            }else{
                db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            }
            IRepository<ProductStock> _repo;
            
            if(db.TestMode){
                ProductStock.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<ProductStock>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<ProductStock> GetRepo(){
            return GetRepo("","");
        }
        
        public static ProductStock SingleOrDefault(Expression<Func<ProductStock, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            ProductStock single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static ProductStock SingleOrDefault(Expression<Func<ProductStock, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            ProductStock single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<ProductStock, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<ProductStock, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<ProductStock> Find(Expression<Func<ProductStock, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<ProductStock> Find(Expression<Func<ProductStock, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<ProductStock> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<ProductStock> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<ProductStock> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<ProductStock> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<ProductStock> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<ProductStock> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "StockId";
        }

        public object KeyValue()
        {
            return this.StockId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<long>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.ProductId.ToString();
        }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(ProductStock)){
                ProductStock compare=(ProductStock)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        public string DescriptorValue()
        {
            return this.ProductId.ToString();
        }

        public string DescriptorColumn() {
            return "ProductId";
        }
        public static string GetKeyColumn()
        {
            return "StockId";
        }        
        public static string GetDescriptorColumn()
        {
            return "ProductId";
        }
        
        #region ' Foreign Keys '
        public IQueryable<Location> Locations
        {
            get
            {
                
                  var repo=OBS.Pos.Business.Location.GetRepo();
                  return from items in repo.GetAll()
                       where items.LocationId == _SourceLocationId
                       select items;
            }
        }

        public IQueryable<Location> Locations1
        {
            get
            {
                
                  var repo=OBS.Pos.Business.Location.GetRepo();
                  return from items in repo.GetAll()
                       where items.LocationId == _TargetLocationId
                       select items;
            }
        }

        public IQueryable<Period> Periods
        {
            get
            {
                
                  var repo=OBS.Pos.Business.Period.GetRepo();
                  return from items in repo.GetAll()
                       where items.PeriodId == _PeriodId
                       select items;
            }
        }

        public IQueryable<Product> Products
        {
            get
            {
                
                  var repo=OBS.Pos.Business.Product.GetRepo();
                  return from items in repo.GetAll()
                       where items.ProductId == _ProductId
                       select items;
            }
        }

        public IQueryable<StockType> StockTypes
        {
            get
            {
                
                  var repo=OBS.Pos.Business.StockType.GetRepo();
                  return from items in repo.GetAll()
                       where items.StockTypeId == _StockType
                       select items;
            }
        }

        #endregion
        

        long _StockId;
        public long StockId
        {
            get { return _StockId; }
            set
            {
                if(_StockId!=value){
                    _StockId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="StockId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        long _ProductId;
        public long ProductId
        {
            get { return _ProductId; }
            set
            {
                if(_ProductId!=value){
                    _ProductId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ProductId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        long? _PeriodId;
        public long? PeriodId
        {
            get { return _PeriodId; }
            set
            {
                if(_PeriodId!=value){
                    _PeriodId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="PeriodId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        long _TargetLocationId;
        public long TargetLocationId
        {
            get { return _TargetLocationId; }
            set
            {
                if(_TargetLocationId!=value){
                    _TargetLocationId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="TargetLocationId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        long _SourceLocationId;
        public long SourceLocationId
        {
            get { return _SourceLocationId; }
            set
            {
                if(_SourceLocationId!=value){
                    _SourceLocationId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="SourceLocationId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        decimal _Quantity;
        public decimal Quantity
        {
            get { return _Quantity; }
            set
            {
                if(_Quantity!=value){
                    _Quantity=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Quantity");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        short _StockType;
        public short StockType
        {
            get { return _StockType; }
            set
            {
                if(_StockType!=value){
                    _StockType=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="StockType");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        DateTime _StockDate;
        public DateTime StockDate
        {
            get { return _StockDate; }
            set
            {
                if(_StockDate!=value){
                    _StockDate=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="StockDate");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool _IsFrozen;
        public bool IsFrozen
        {
            get { return _IsFrozen; }
            set
            {
                if(_IsFrozen!=value){
                    _IsFrozen=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="IsFrozen");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<ProductStock, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the UnitOfMeasurement table in the Pos Database.
    /// </summary>
    public partial class UnitOfMeasurement: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<UnitOfMeasurement> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<UnitOfMeasurement>(new OBS.Pos.Business.PosDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<UnitOfMeasurement> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(UnitOfMeasurement item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                UnitOfMeasurement item=new UnitOfMeasurement();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<UnitOfMeasurement> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        OBS.Pos.Business.PosDB _db;
        public UnitOfMeasurement(string connectionString, string providerName) {

            _db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                UnitOfMeasurement.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<UnitOfMeasurement>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public UnitOfMeasurement(){
             _db=new OBS.Pos.Business.PosDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public UnitOfMeasurement(Expression<Func<UnitOfMeasurement, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<UnitOfMeasurement> GetRepo(string connectionString, string providerName){
            OBS.Pos.Business.PosDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new OBS.Pos.Business.PosDB();
            }else{
                db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            }
            IRepository<UnitOfMeasurement> _repo;
            
            if(db.TestMode){
                UnitOfMeasurement.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<UnitOfMeasurement>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<UnitOfMeasurement> GetRepo(){
            return GetRepo("","");
        }
        
        public static UnitOfMeasurement SingleOrDefault(Expression<Func<UnitOfMeasurement, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            UnitOfMeasurement single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static UnitOfMeasurement SingleOrDefault(Expression<Func<UnitOfMeasurement, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            UnitOfMeasurement single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<UnitOfMeasurement, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<UnitOfMeasurement, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<UnitOfMeasurement> Find(Expression<Func<UnitOfMeasurement, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<UnitOfMeasurement> Find(Expression<Func<UnitOfMeasurement, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<UnitOfMeasurement> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<UnitOfMeasurement> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<UnitOfMeasurement> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<UnitOfMeasurement> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<UnitOfMeasurement> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<UnitOfMeasurement> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "MeasurementId";
        }

        public object KeyValue()
        {
            return this.MeasurementId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<long>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.MeasurementName.ToString();
        }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(UnitOfMeasurement)){
                UnitOfMeasurement compare=(UnitOfMeasurement)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        public string DescriptorValue()
        {
            return this.MeasurementName.ToString();
        }

        public string DescriptorColumn() {
            return "MeasurementName";
        }
        public static string GetKeyColumn()
        {
            return "MeasurementId";
        }        
        public static string GetDescriptorColumn()
        {
            return "MeasurementName";
        }
        
        #region ' Foreign Keys '
        public IQueryable<Product> Products
        {
            get
            {
                
                  var repo=OBS.Pos.Business.Product.GetRepo();
                  return from items in repo.GetAll()
                       where items.MeasurementId == _MeasurementId
                       select items;
            }
        }

        #endregion
        

        long _MeasurementId;
        public long MeasurementId
        {
            get { return _MeasurementId; }
            set
            {
                if(_MeasurementId!=value){
                    _MeasurementId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="MeasurementId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _MeasurementName;
        public string MeasurementName
        {
            get { return _MeasurementName; }
            set
            {
                if(_MeasurementName!=value){
                    _MeasurementName=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="MeasurementName");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Description;
        public string Description
        {
            get { return _Description; }
            set
            {
                if(_Description!=value){
                    _Description=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Description");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        double _ScaleFactor;
        public double ScaleFactor
        {
            get { return _ScaleFactor; }
            set
            {
                if(_ScaleFactor!=value){
                    _ScaleFactor=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ScaleFactor");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<UnitOfMeasurement, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the StockCount table in the Pos Database.
    /// </summary>
    public partial class StockCount: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<StockCount> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<StockCount>(new OBS.Pos.Business.PosDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<StockCount> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(StockCount item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                StockCount item=new StockCount();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<StockCount> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        OBS.Pos.Business.PosDB _db;
        public StockCount(string connectionString, string providerName) {

            _db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                StockCount.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<StockCount>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public StockCount(){
             _db=new OBS.Pos.Business.PosDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public StockCount(Expression<Func<StockCount, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<StockCount> GetRepo(string connectionString, string providerName){
            OBS.Pos.Business.PosDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new OBS.Pos.Business.PosDB();
            }else{
                db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            }
            IRepository<StockCount> _repo;
            
            if(db.TestMode){
                StockCount.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<StockCount>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<StockCount> GetRepo(){
            return GetRepo("","");
        }
        
        public static StockCount SingleOrDefault(Expression<Func<StockCount, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            StockCount single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static StockCount SingleOrDefault(Expression<Func<StockCount, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            StockCount single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<StockCount, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<StockCount, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<StockCount> Find(Expression<Func<StockCount, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<StockCount> Find(Expression<Func<StockCount, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<StockCount> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<StockCount> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<StockCount> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<StockCount> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<StockCount> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<StockCount> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "CountId";
        }

        public object KeyValue()
        {
            return this.CountId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<long>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.PeriodId.ToString();
        }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(StockCount)){
                StockCount compare=(StockCount)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        public string DescriptorValue()
        {
            return this.PeriodId.ToString();
        }

        public string DescriptorColumn() {
            return "PeriodId";
        }
        public static string GetKeyColumn()
        {
            return "CountId";
        }        
        public static string GetDescriptorColumn()
        {
            return "PeriodId";
        }
        
        #region ' Foreign Keys '
        public IQueryable<Period> Periods
        {
            get
            {
                
                  var repo=OBS.Pos.Business.Period.GetRepo();
                  return from items in repo.GetAll()
                       where items.PeriodId == _PeriodId
                       select items;
            }
        }

        public IQueryable<Product> Products
        {
            get
            {
                
                  var repo=OBS.Pos.Business.Product.GetRepo();
                  return from items in repo.GetAll()
                       where items.ProductId == _ProductId
                       select items;
            }
        }

        #endregion
        

        long _CountId;
        public long CountId
        {
            get { return _CountId; }
            set
            {
                if(_CountId!=value){
                    _CountId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CountId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        long _PeriodId;
        public long PeriodId
        {
            get { return _PeriodId; }
            set
            {
                if(_PeriodId!=value){
                    _PeriodId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="PeriodId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        long _ProductId;
        public long ProductId
        {
            get { return _ProductId; }
            set
            {
                if(_ProductId!=value){
                    _ProductId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ProductId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        decimal _CountedQuantity;
        public decimal CountedQuantity
        {
            get { return _CountedQuantity; }
            set
            {
                if(_CountedQuantity!=value){
                    _CountedQuantity=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CountedQuantity");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        decimal _SystemQuantity;
        public decimal SystemQuantity
        {
            get { return _SystemQuantity; }
            set
            {
                if(_SystemQuantity!=value){
                    _SystemQuantity=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="SystemQuantity");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        DateTime _CountedStockDate;
        public DateTime CountedStockDate
        {
            get { return _CountedStockDate; }
            set
            {
                if(_CountedStockDate!=value){
                    _CountedStockDate=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CountedStockDate");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        DateTime _SystemStockDate;
        public DateTime SystemStockDate
        {
            get { return _SystemStockDate; }
            set
            {
                if(_SystemStockDate!=value){
                    _SystemStockDate=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="SystemStockDate");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<StockCount, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the Roles table in the Pos Database.
    /// </summary>
    public partial class Role: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<Role> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<Role>(new OBS.Pos.Business.PosDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<Role> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(Role item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                Role item=new Role();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<Role> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        OBS.Pos.Business.PosDB _db;
        public Role(string connectionString, string providerName) {

            _db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                Role.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Role>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public Role(){
             _db=new OBS.Pos.Business.PosDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public Role(Expression<Func<Role, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<Role> GetRepo(string connectionString, string providerName){
            OBS.Pos.Business.PosDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new OBS.Pos.Business.PosDB();
            }else{
                db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            }
            IRepository<Role> _repo;
            
            if(db.TestMode){
                Role.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Role>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<Role> GetRepo(){
            return GetRepo("","");
        }
        
        public static Role SingleOrDefault(Expression<Func<Role, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            Role single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static Role SingleOrDefault(Expression<Func<Role, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            Role single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<Role, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<Role, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<Role> Find(Expression<Func<Role, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<Role> Find(Expression<Func<Role, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<Role> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<Role> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<Role> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<Role> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<Role> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<Role> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "RoleId";
        }

        public object KeyValue()
        {
            return this.RoleId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<long>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.RoleName.ToString();
        }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(Role)){
                Role compare=(Role)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        public string DescriptorValue()
        {
            return this.RoleName.ToString();
        }

        public string DescriptorColumn() {
            return "RoleName";
        }
        public static string GetKeyColumn()
        {
            return "RoleId";
        }        
        public static string GetDescriptorColumn()
        {
            return "RoleName";
        }
        
        #region ' Foreign Keys '
        public IQueryable<User> Users
        {
            get
            {
                
                  var repo=OBS.Pos.Business.User.GetRepo();
                  return from items in repo.GetAll()
                       where items.RoleId == _RoleId
                       select items;
            }
        }

        #endregion
        

        long _RoleId;
        public long RoleId
        {
            get { return _RoleId; }
            set
            {
                if(_RoleId!=value){
                    _RoleId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="RoleId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _RoleName;
        public string RoleName
        {
            get { return _RoleName; }
            set
            {
                if(_RoleName!=value){
                    _RoleName=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="RoleName");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Description;
        public string Description
        {
            get { return _Description; }
            set
            {
                if(_Description!=value){
                    _Description=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Description");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _AccessList;
        public string AccessList
        {
            get { return _AccessList; }
            set
            {
                if(_AccessList!=value){
                    _AccessList=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="AccessList");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<Role, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the Users table in the Pos Database.
    /// </summary>
    public partial class User: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<User> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<User>(new OBS.Pos.Business.PosDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<User> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(User item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                User item=new User();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<User> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        OBS.Pos.Business.PosDB _db;
        public User(string connectionString, string providerName) {

            _db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                User.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<User>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public User(){
             _db=new OBS.Pos.Business.PosDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public User(Expression<Func<User, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<User> GetRepo(string connectionString, string providerName){
            OBS.Pos.Business.PosDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new OBS.Pos.Business.PosDB();
            }else{
                db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            }
            IRepository<User> _repo;
            
            if(db.TestMode){
                User.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<User>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<User> GetRepo(){
            return GetRepo("","");
        }
        
        public static User SingleOrDefault(Expression<Func<User, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            User single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static User SingleOrDefault(Expression<Func<User, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            User single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<User, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<User, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<User> Find(Expression<Func<User, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<User> Find(Expression<Func<User, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<User> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<User> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<User> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<User> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<User> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<User> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "UserId";
        }

        public object KeyValue()
        {
            return this.UserId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<long>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.UserName.ToString();
        }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(User)){
                User compare=(User)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        public string DescriptorValue()
        {
            return this.UserName.ToString();
        }

        public string DescriptorColumn() {
            return "UserName";
        }
        public static string GetKeyColumn()
        {
            return "UserId";
        }        
        public static string GetDescriptorColumn()
        {
            return "UserName";
        }
        
        #region ' Foreign Keys '
        public IQueryable<Role> Roles
        {
            get
            {
                
                  var repo=OBS.Pos.Business.Role.GetRepo();
                  return from items in repo.GetAll()
                       where items.RoleId == _RoleId
                       select items;
            }
        }

        public IQueryable<Shift> Shifts
        {
            get
            {
                
                  var repo=OBS.Pos.Business.Shift.GetRepo();
                  return from items in repo.GetAll()
                       where items.ShiftId == _ShiftId
                       select items;
            }
        }

        #endregion
        

        long _UserId;
        public long UserId
        {
            get { return _UserId; }
            set
            {
                if(_UserId!=value){
                    _UserId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="UserId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _UserName;
        public string UserName
        {
            get { return _UserName; }
            set
            {
                if(_UserName!=value){
                    _UserName=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="UserName");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        byte[] _Password;
        public byte[] Password
        {
            get { return _Password; }
            set
            {
                if(_Password!=value){
                    _Password=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Password");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool _IsLoggedIn;
        public bool IsLoggedIn
        {
            get { return _IsLoggedIn; }
            set
            {
                if(_IsLoggedIn!=value){
                    _IsLoggedIn=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="IsLoggedIn");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        DateTime? _LastLoginActivity;
        public DateTime? LastLoginActivity
        {
            get { return _LastLoginActivity; }
            set
            {
                if(_LastLoginActivity!=value){
                    _LastLoginActivity=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LastLoginActivity");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        DateTime? _LastPasswordUpdate;
        public DateTime? LastPasswordUpdate
        {
            get { return _LastPasswordUpdate; }
            set
            {
                if(_LastPasswordUpdate!=value){
                    _LastPasswordUpdate=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LastPasswordUpdate");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        long? _RoleId;
        public long? RoleId
        {
            get { return _RoleId; }
            set
            {
                if(_RoleId!=value){
                    _RoleId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="RoleId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        long? _ShiftId;
        public long? ShiftId
        {
            get { return _ShiftId; }
            set
            {
                if(_ShiftId!=value){
                    _ShiftId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ShiftId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool? _IsEnabled;
        public bool? IsEnabled
        {
            get { return _IsEnabled; }
            set
            {
                if(_IsEnabled!=value){
                    _IsEnabled=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="IsEnabled");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<User, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the Taxes table in the Pos Database.
    /// </summary>
    public partial class Tax: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<Tax> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<Tax>(new OBS.Pos.Business.PosDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<Tax> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(Tax item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                Tax item=new Tax();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<Tax> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        OBS.Pos.Business.PosDB _db;
        public Tax(string connectionString, string providerName) {

            _db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                Tax.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Tax>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public Tax(){
             _db=new OBS.Pos.Business.PosDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public Tax(Expression<Func<Tax, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<Tax> GetRepo(string connectionString, string providerName){
            OBS.Pos.Business.PosDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new OBS.Pos.Business.PosDB();
            }else{
                db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            }
            IRepository<Tax> _repo;
            
            if(db.TestMode){
                Tax.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Tax>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<Tax> GetRepo(){
            return GetRepo("","");
        }
        
        public static Tax SingleOrDefault(Expression<Func<Tax, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            Tax single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static Tax SingleOrDefault(Expression<Func<Tax, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            Tax single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<Tax, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<Tax, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<Tax> Find(Expression<Func<Tax, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<Tax> Find(Expression<Func<Tax, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<Tax> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<Tax> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<Tax> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<Tax> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<Tax> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<Tax> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "TaxId";
        }

        public object KeyValue()
        {
            return this.TaxId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<long>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.TaxName.ToString();
        }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(Tax)){
                Tax compare=(Tax)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        public string DescriptorValue()
        {
            return this.TaxName.ToString();
        }

        public string DescriptorColumn() {
            return "TaxName";
        }
        public static string GetKeyColumn()
        {
            return "TaxId";
        }        
        public static string GetDescriptorColumn()
        {
            return "TaxName";
        }
        
        #region ' Foreign Keys '
        #endregion
        

        long _TaxId;
        public long TaxId
        {
            get { return _TaxId; }
            set
            {
                if(_TaxId!=value){
                    _TaxId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="TaxId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _TaxName;
        public string TaxName
        {
            get { return _TaxName; }
            set
            {
                if(_TaxName!=value){
                    _TaxName=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="TaxName");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Description;
        public string Description
        {
            get { return _Description; }
            set
            {
                if(_Description!=value){
                    _Description=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Description");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        decimal _TaxValue;
        public decimal TaxValue
        {
            get { return _TaxValue; }
            set
            {
                if(_TaxValue!=value){
                    _TaxValue=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="TaxValue");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<Tax, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the Shifts table in the Pos Database.
    /// </summary>
    public partial class Shift: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<Shift> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<Shift>(new OBS.Pos.Business.PosDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<Shift> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(Shift item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                Shift item=new Shift();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<Shift> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        OBS.Pos.Business.PosDB _db;
        public Shift(string connectionString, string providerName) {

            _db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                Shift.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Shift>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public Shift(){
             _db=new OBS.Pos.Business.PosDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public Shift(Expression<Func<Shift, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<Shift> GetRepo(string connectionString, string providerName){
            OBS.Pos.Business.PosDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new OBS.Pos.Business.PosDB();
            }else{
                db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            }
            IRepository<Shift> _repo;
            
            if(db.TestMode){
                Shift.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Shift>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<Shift> GetRepo(){
            return GetRepo("","");
        }
        
        public static Shift SingleOrDefault(Expression<Func<Shift, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            Shift single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static Shift SingleOrDefault(Expression<Func<Shift, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            Shift single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<Shift, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<Shift, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<Shift> Find(Expression<Func<Shift, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<Shift> Find(Expression<Func<Shift, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<Shift> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<Shift> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<Shift> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<Shift> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<Shift> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<Shift> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "ShiftId";
        }

        public object KeyValue()
        {
            return this.ShiftId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<long>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.ShiftName.ToString();
        }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(Shift)){
                Shift compare=(Shift)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        public string DescriptorValue()
        {
            return this.ShiftName.ToString();
        }

        public string DescriptorColumn() {
            return "ShiftName";
        }
        public static string GetKeyColumn()
        {
            return "ShiftId";
        }        
        public static string GetDescriptorColumn()
        {
            return "ShiftName";
        }
        
        #region ' Foreign Keys '
        public IQueryable<User> Users
        {
            get
            {
                
                  var repo=OBS.Pos.Business.User.GetRepo();
                  return from items in repo.GetAll()
                       where items.ShiftId == _ShiftId
                       select items;
            }
        }

        #endregion
        

        long _ShiftId;
        public long ShiftId
        {
            get { return _ShiftId; }
            set
            {
                if(_ShiftId!=value){
                    _ShiftId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ShiftId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _ShiftName;
        public string ShiftName
        {
            get { return _ShiftName; }
            set
            {
                if(_ShiftName!=value){
                    _ShiftName=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ShiftName");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Description;
        public string Description
        {
            get { return _Description; }
            set
            {
                if(_Description!=value){
                    _Description=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Description");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        DateTime? _StartDate;
        public DateTime? StartDate
        {
            get { return _StartDate; }
            set
            {
                if(_StartDate!=value){
                    _StartDate=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="StartDate");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        DateTime? _EndDate;
        public DateTime? EndDate
        {
            get { return _EndDate; }
            set
            {
                if(_EndDate!=value){
                    _EndDate=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="EndDate");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<Shift, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the Categories table in the Pos Database.
    /// </summary>
    public partial class Category: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<Category> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<Category>(new OBS.Pos.Business.PosDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<Category> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(Category item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                Category item=new Category();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<Category> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        OBS.Pos.Business.PosDB _db;
        public Category(string connectionString, string providerName) {

            _db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                Category.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Category>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public Category(){
             _db=new OBS.Pos.Business.PosDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public Category(Expression<Func<Category, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<Category> GetRepo(string connectionString, string providerName){
            OBS.Pos.Business.PosDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new OBS.Pos.Business.PosDB();
            }else{
                db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            }
            IRepository<Category> _repo;
            
            if(db.TestMode){
                Category.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Category>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<Category> GetRepo(){
            return GetRepo("","");
        }
        
        public static Category SingleOrDefault(Expression<Func<Category, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            Category single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static Category SingleOrDefault(Expression<Func<Category, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            Category single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<Category, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<Category, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<Category> Find(Expression<Func<Category, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<Category> Find(Expression<Func<Category, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<Category> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<Category> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<Category> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<Category> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<Category> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<Category> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "CategoryId";
        }

        public object KeyValue()
        {
            return this.CategoryId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<long>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.CategoryName.ToString();
        }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(Category)){
                Category compare=(Category)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        public string DescriptorValue()
        {
            return this.CategoryName.ToString();
        }

        public string DescriptorColumn() {
            return "CategoryName";
        }
        public static string GetKeyColumn()
        {
            return "CategoryId";
        }        
        public static string GetDescriptorColumn()
        {
            return "CategoryName";
        }
        
        #region ' Foreign Keys '
        public IQueryable<ProductCategory> ProductCategories
        {
            get
            {
                
                  var repo=OBS.Pos.Business.ProductCategory.GetRepo();
                  return from items in repo.GetAll()
                       where items.CategoryId == _CategoryId
                       select items;
            }
        }

        #endregion
        

        long _CategoryId;
        public long CategoryId
        {
            get { return _CategoryId; }
            set
            {
                if(_CategoryId!=value){
                    _CategoryId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CategoryId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        long? _ParentId;
        public long? ParentId
        {
            get { return _ParentId; }
            set
            {
                if(_ParentId!=value){
                    _ParentId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ParentId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _CategoryName;
        public string CategoryName
        {
            get { return _CategoryName; }
            set
            {
                if(_CategoryName!=value){
                    _CategoryName=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CategoryName");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Description;
        public string Description
        {
            get { return _Description; }
            set
            {
                if(_Description!=value){
                    _Description=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Description");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        byte[] _CategoryImage;
        public byte[] CategoryImage
        {
            get { return _CategoryImage; }
            set
            {
                if(_CategoryImage!=value){
                    _CategoryImage=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CategoryImage");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<Category, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the AppSettings table in the Pos Database.
    /// </summary>
    public partial class AppSetting: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<AppSetting> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<AppSetting>(new OBS.Pos.Business.PosDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<AppSetting> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(AppSetting item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                AppSetting item=new AppSetting();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<AppSetting> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        OBS.Pos.Business.PosDB _db;
        public AppSetting(string connectionString, string providerName) {

            _db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                AppSetting.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<AppSetting>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public AppSetting(){
             _db=new OBS.Pos.Business.PosDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public AppSetting(Expression<Func<AppSetting, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<AppSetting> GetRepo(string connectionString, string providerName){
            OBS.Pos.Business.PosDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new OBS.Pos.Business.PosDB();
            }else{
                db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            }
            IRepository<AppSetting> _repo;
            
            if(db.TestMode){
                AppSetting.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<AppSetting>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<AppSetting> GetRepo(){
            return GetRepo("","");
        }
        
        public static AppSetting SingleOrDefault(Expression<Func<AppSetting, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            AppSetting single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static AppSetting SingleOrDefault(Expression<Func<AppSetting, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            AppSetting single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<AppSetting, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<AppSetting, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<AppSetting> Find(Expression<Func<AppSetting, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<AppSetting> Find(Expression<Func<AppSetting, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<AppSetting> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<AppSetting> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<AppSetting> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<AppSetting> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<AppSetting> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<AppSetting> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "AppSettingId";
        }

        public object KeyValue()
        {
            return this.AppSettingId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<string>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.AppSettingId.ToString();
        }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(AppSetting)){
                AppSetting compare=(AppSetting)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        public string DescriptorValue()
        {
            return this.AppSettingId.ToString();
        }

        public string DescriptorColumn() {
            return "AppSettingId";
        }
        public static string GetKeyColumn()
        {
            return "AppSettingId";
        }        
        public static string GetDescriptorColumn()
        {
            return "AppSettingId";
        }
        
        #region ' Foreign Keys '
        #endregion
        

        string _AppSettingId;
        public string AppSettingId
        {
            get { return _AppSettingId; }
            set
            {
                if(_AppSettingId!=value){
                    _AppSettingId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="AppSettingId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _SettingName;
        public string SettingName
        {
            get { return _SettingName; }
            set
            {
                if(_SettingName!=value){
                    _SettingName=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="SettingName");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _SettingValue;
        public string SettingValue
        {
            get { return _SettingValue; }
            set
            {
                if(_SettingValue!=value){
                    _SettingValue=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="SettingValue");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<AppSetting, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the Locations table in the Pos Database.
    /// </summary>
    public partial class Location: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<Location> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<Location>(new OBS.Pos.Business.PosDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<Location> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(Location item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                Location item=new Location();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<Location> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        OBS.Pos.Business.PosDB _db;
        public Location(string connectionString, string providerName) {

            _db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                Location.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Location>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public Location(){
             _db=new OBS.Pos.Business.PosDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public Location(Expression<Func<Location, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<Location> GetRepo(string connectionString, string providerName){
            OBS.Pos.Business.PosDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new OBS.Pos.Business.PosDB();
            }else{
                db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            }
            IRepository<Location> _repo;
            
            if(db.TestMode){
                Location.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Location>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<Location> GetRepo(){
            return GetRepo("","");
        }
        
        public static Location SingleOrDefault(Expression<Func<Location, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            Location single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static Location SingleOrDefault(Expression<Func<Location, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            Location single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<Location, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<Location, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<Location> Find(Expression<Func<Location, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<Location> Find(Expression<Func<Location, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<Location> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<Location> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<Location> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<Location> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<Location> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<Location> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "LocationId";
        }

        public object KeyValue()
        {
            return this.LocationId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<long>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.LocationName.ToString();
        }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(Location)){
                Location compare=(Location)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        public string DescriptorValue()
        {
            return this.LocationName.ToString();
        }

        public string DescriptorColumn() {
            return "LocationName";
        }
        public static string GetKeyColumn()
        {
            return "LocationId";
        }        
        public static string GetDescriptorColumn()
        {
            return "LocationName";
        }
        
        #region ' Foreign Keys '
        public IQueryable<ProductStock> ProductStocks
        {
            get
            {
                
                  var repo=OBS.Pos.Business.ProductStock.GetRepo();
                  return from items in repo.GetAll()
                       where items.SourceLocationId == _LocationId
                       select items;
            }
        }

        public IQueryable<ProductStock> ProductStocks1
        {
            get
            {
                
                  var repo=OBS.Pos.Business.ProductStock.GetRepo();
                  return from items in repo.GetAll()
                       where items.TargetLocationId == _LocationId
                       select items;
            }
        }

        #endregion
        

        long _LocationId;
        public long LocationId
        {
            get { return _LocationId; }
            set
            {
                if(_LocationId!=value){
                    _LocationId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LocationId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _LocationName;
        public string LocationName
        {
            get { return _LocationName; }
            set
            {
                if(_LocationName!=value){
                    _LocationName=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LocationName");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Description;
        public string Description
        {
            get { return _Description; }
            set
            {
                if(_Description!=value){
                    _Description=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Description");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Address;
        public string Address
        {
            get { return _Address; }
            set
            {
                if(_Address!=value){
                    _Address=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Address");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _ContactName;
        public string ContactName
        {
            get { return _ContactName; }
            set
            {
                if(_ContactName!=value){
                    _ContactName=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ContactName");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _ContactPhone;
        public string ContactPhone
        {
            get { return _ContactPhone; }
            set
            {
                if(_ContactPhone!=value){
                    _ContactPhone=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ContactPhone");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _ContactEmail;
        public string ContactEmail
        {
            get { return _ContactEmail; }
            set
            {
                if(_ContactEmail!=value){
                    _ContactEmail=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ContactEmail");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<Location, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the StockTypes table in the Pos Database.
    /// </summary>
    public partial class StockType: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<StockType> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<StockType>(new OBS.Pos.Business.PosDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<StockType> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(StockType item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                StockType item=new StockType();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<StockType> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        OBS.Pos.Business.PosDB _db;
        public StockType(string connectionString, string providerName) {

            _db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                StockType.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<StockType>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public StockType(){
             _db=new OBS.Pos.Business.PosDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public StockType(Expression<Func<StockType, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<StockType> GetRepo(string connectionString, string providerName){
            OBS.Pos.Business.PosDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new OBS.Pos.Business.PosDB();
            }else{
                db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            }
            IRepository<StockType> _repo;
            
            if(db.TestMode){
                StockType.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<StockType>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<StockType> GetRepo(){
            return GetRepo("","");
        }
        
        public static StockType SingleOrDefault(Expression<Func<StockType, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            StockType single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static StockType SingleOrDefault(Expression<Func<StockType, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            StockType single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<StockType, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<StockType, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<StockType> Find(Expression<Func<StockType, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<StockType> Find(Expression<Func<StockType, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<StockType> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<StockType> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<StockType> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<StockType> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<StockType> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<StockType> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "StockTypeId";
        }

        public object KeyValue()
        {
            return this.StockTypeId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<short>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.Name.ToString();
        }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(StockType)){
                StockType compare=(StockType)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        public string DescriptorValue()
        {
            return this.Name.ToString();
        }

        public string DescriptorColumn() {
            return "Name";
        }
        public static string GetKeyColumn()
        {
            return "StockTypeId";
        }        
        public static string GetDescriptorColumn()
        {
            return "Name";
        }
        
        #region ' Foreign Keys '
        public IQueryable<ProductStock> ProductStocks
        {
            get
            {
                
                  var repo=OBS.Pos.Business.ProductStock.GetRepo();
                  return from items in repo.GetAll()
                       where items.StockType == _StockTypeId
                       select items;
            }
        }

        #endregion
        

        short _StockTypeId;
        public short StockTypeId
        {
            get { return _StockTypeId; }
            set
            {
                if(_StockTypeId!=value){
                    _StockTypeId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="StockTypeId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Name;
        public string Name
        {
            get { return _Name; }
            set
            {
                if(_Name!=value){
                    _Name=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Name");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Description;
        public string Description
        {
            get { return _Description; }
            set
            {
                if(_Description!=value){
                    _Description=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Description");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<StockType, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the TransactionTypes table in the Pos Database.
    /// </summary>
    public partial class TransactionType: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<TransactionType> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<TransactionType>(new OBS.Pos.Business.PosDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<TransactionType> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(TransactionType item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                TransactionType item=new TransactionType();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<TransactionType> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        OBS.Pos.Business.PosDB _db;
        public TransactionType(string connectionString, string providerName) {

            _db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                TransactionType.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<TransactionType>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public TransactionType(){
             _db=new OBS.Pos.Business.PosDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public TransactionType(Expression<Func<TransactionType, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<TransactionType> GetRepo(string connectionString, string providerName){
            OBS.Pos.Business.PosDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new OBS.Pos.Business.PosDB();
            }else{
                db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            }
            IRepository<TransactionType> _repo;
            
            if(db.TestMode){
                TransactionType.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<TransactionType>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<TransactionType> GetRepo(){
            return GetRepo("","");
        }
        
        public static TransactionType SingleOrDefault(Expression<Func<TransactionType, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            TransactionType single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static TransactionType SingleOrDefault(Expression<Func<TransactionType, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            TransactionType single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<TransactionType, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<TransactionType, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<TransactionType> Find(Expression<Func<TransactionType, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<TransactionType> Find(Expression<Func<TransactionType, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<TransactionType> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<TransactionType> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<TransactionType> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<TransactionType> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<TransactionType> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<TransactionType> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "TransactionTypeId";
        }

        public object KeyValue()
        {
            return this.TransactionTypeId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<short>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.Name.ToString();
        }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(TransactionType)){
                TransactionType compare=(TransactionType)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        public string DescriptorValue()
        {
            return this.Name.ToString();
        }

        public string DescriptorColumn() {
            return "Name";
        }
        public static string GetKeyColumn()
        {
            return "TransactionTypeId";
        }        
        public static string GetDescriptorColumn()
        {
            return "Name";
        }
        
        #region ' Foreign Keys '
        public IQueryable<PayTran> PayTrans
        {
            get
            {
                
                  var repo=OBS.Pos.Business.PayTran.GetRepo();
                  return from items in repo.GetAll()
                       where items.TransactionType == _TransactionTypeId
                       select items;
            }
        }

        #endregion
        

        short _TransactionTypeId;
        public short TransactionTypeId
        {
            get { return _TransactionTypeId; }
            set
            {
                if(_TransactionTypeId!=value){
                    _TransactionTypeId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="TransactionTypeId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Name;
        public string Name
        {
            get { return _Name; }
            set
            {
                if(_Name!=value){
                    _Name=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Name");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Description;
        public string Description
        {
            get { return _Description; }
            set
            {
                if(_Description!=value){
                    _Description=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Description");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<TransactionType, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the PaymentTypes table in the Pos Database.
    /// </summary>
    public partial class PaymentType: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<PaymentType> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<PaymentType>(new OBS.Pos.Business.PosDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<PaymentType> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(PaymentType item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                PaymentType item=new PaymentType();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<PaymentType> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        OBS.Pos.Business.PosDB _db;
        public PaymentType(string connectionString, string providerName) {

            _db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                PaymentType.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<PaymentType>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public PaymentType(){
             _db=new OBS.Pos.Business.PosDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public PaymentType(Expression<Func<PaymentType, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<PaymentType> GetRepo(string connectionString, string providerName){
            OBS.Pos.Business.PosDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new OBS.Pos.Business.PosDB();
            }else{
                db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            }
            IRepository<PaymentType> _repo;
            
            if(db.TestMode){
                PaymentType.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<PaymentType>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<PaymentType> GetRepo(){
            return GetRepo("","");
        }
        
        public static PaymentType SingleOrDefault(Expression<Func<PaymentType, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            PaymentType single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static PaymentType SingleOrDefault(Expression<Func<PaymentType, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            PaymentType single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<PaymentType, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<PaymentType, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<PaymentType> Find(Expression<Func<PaymentType, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<PaymentType> Find(Expression<Func<PaymentType, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<PaymentType> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<PaymentType> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<PaymentType> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<PaymentType> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<PaymentType> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<PaymentType> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "PaymentTypeId";
        }

        public object KeyValue()
        {
            return this.PaymentTypeId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<short>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.Name.ToString();
        }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(PaymentType)){
                PaymentType compare=(PaymentType)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        public string DescriptorValue()
        {
            return this.Name.ToString();
        }

        public string DescriptorColumn() {
            return "Name";
        }
        public static string GetKeyColumn()
        {
            return "PaymentTypeId";
        }        
        public static string GetDescriptorColumn()
        {
            return "Name";
        }
        
        #region ' Foreign Keys '
        public IQueryable<PaymentMode> PaymentModes
        {
            get
            {
                
                  var repo=OBS.Pos.Business.PaymentMode.GetRepo();
                  return from items in repo.GetAll()
                       where items.PaymentType == _PaymentTypeId
                       select items;
            }
        }

        #endregion
        

        short _PaymentTypeId;
        public short PaymentTypeId
        {
            get { return _PaymentTypeId; }
            set
            {
                if(_PaymentTypeId!=value){
                    _PaymentTypeId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="PaymentTypeId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Name;
        public string Name
        {
            get { return _Name; }
            set
            {
                if(_Name!=value){
                    _Name=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Name");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Description;
        public string Description
        {
            get { return _Description; }
            set
            {
                if(_Description!=value){
                    _Description=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Description");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<PaymentType, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the PaymentModes table in the Pos Database.
    /// </summary>
    public partial class PaymentMode: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<PaymentMode> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<PaymentMode>(new OBS.Pos.Business.PosDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<PaymentMode> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(PaymentMode item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                PaymentMode item=new PaymentMode();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<PaymentMode> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        OBS.Pos.Business.PosDB _db;
        public PaymentMode(string connectionString, string providerName) {

            _db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                PaymentMode.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<PaymentMode>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public PaymentMode(){
             _db=new OBS.Pos.Business.PosDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public PaymentMode(Expression<Func<PaymentMode, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<PaymentMode> GetRepo(string connectionString, string providerName){
            OBS.Pos.Business.PosDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new OBS.Pos.Business.PosDB();
            }else{
                db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            }
            IRepository<PaymentMode> _repo;
            
            if(db.TestMode){
                PaymentMode.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<PaymentMode>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<PaymentMode> GetRepo(){
            return GetRepo("","");
        }
        
        public static PaymentMode SingleOrDefault(Expression<Func<PaymentMode, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            PaymentMode single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static PaymentMode SingleOrDefault(Expression<Func<PaymentMode, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            PaymentMode single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<PaymentMode, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<PaymentMode, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<PaymentMode> Find(Expression<Func<PaymentMode, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<PaymentMode> Find(Expression<Func<PaymentMode, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<PaymentMode> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<PaymentMode> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<PaymentMode> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<PaymentMode> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<PaymentMode> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<PaymentMode> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "ModeId";
        }

        public object KeyValue()
        {
            return this.ModeId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<long>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.Name.ToString();
        }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(PaymentMode)){
                PaymentMode compare=(PaymentMode)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        public string DescriptorValue()
        {
            return this.Name.ToString();
        }

        public string DescriptorColumn() {
            return "Name";
        }
        public static string GetKeyColumn()
        {
            return "ModeId";
        }        
        public static string GetDescriptorColumn()
        {
            return "Name";
        }
        
        #region ' Foreign Keys '
        public IQueryable<Customer> Customers
        {
            get
            {
                
                  var repo=OBS.Pos.Business.Customer.GetRepo();
                  return from items in repo.GetAll()
                       where items.PaymentModeId == _ModeId
                       select items;
            }
        }

        public IQueryable<PayTran> PayTrans
        {
            get
            {
                
                  var repo=OBS.Pos.Business.PayTran.GetRepo();
                  return from items in repo.GetAll()
                       where items.PaymentModeId == _ModeId
                       select items;
            }
        }

        public IQueryable<PaymentType> PaymentTypes
        {
            get
            {
                
                  var repo=OBS.Pos.Business.PaymentType.GetRepo();
                  return from items in repo.GetAll()
                       where items.PaymentTypeId == _PaymentType
                       select items;
            }
        }

        #endregion
        

        long _ModeId;
        public long ModeId
        {
            get { return _ModeId; }
            set
            {
                if(_ModeId!=value){
                    _ModeId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ModeId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Name;
        public string Name
        {
            get { return _Name; }
            set
            {
                if(_Name!=value){
                    _Name=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Name");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Description;
        public string Description
        {
            get { return _Description; }
            set
            {
                if(_Description!=value){
                    _Description=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Description");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        short _PaymentType;
        public short PaymentType
        {
            get { return _PaymentType; }
            set
            {
                if(_PaymentType!=value){
                    _PaymentType=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="PaymentType");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _IconIndex;
        public int? IconIndex
        {
            get { return _IconIndex; }
            set
            {
                if(_IconIndex!=value){
                    _IconIndex=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="IconIndex");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<PaymentMode, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the CustomerOuts table in the Pos Database.
    /// </summary>
    public partial class CustomerOut: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<CustomerOut> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<CustomerOut>(new OBS.Pos.Business.PosDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<CustomerOut> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(CustomerOut item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                CustomerOut item=new CustomerOut();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<CustomerOut> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        OBS.Pos.Business.PosDB _db;
        public CustomerOut(string connectionString, string providerName) {

            _db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                CustomerOut.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<CustomerOut>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public CustomerOut(){
             _db=new OBS.Pos.Business.PosDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public CustomerOut(Expression<Func<CustomerOut, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<CustomerOut> GetRepo(string connectionString, string providerName){
            OBS.Pos.Business.PosDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new OBS.Pos.Business.PosDB();
            }else{
                db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            }
            IRepository<CustomerOut> _repo;
            
            if(db.TestMode){
                CustomerOut.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<CustomerOut>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<CustomerOut> GetRepo(){
            return GetRepo("","");
        }
        
        public static CustomerOut SingleOrDefault(Expression<Func<CustomerOut, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            CustomerOut single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static CustomerOut SingleOrDefault(Expression<Func<CustomerOut, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            CustomerOut single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<CustomerOut, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<CustomerOut, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<CustomerOut> Find(Expression<Func<CustomerOut, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<CustomerOut> Find(Expression<Func<CustomerOut, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<CustomerOut> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<CustomerOut> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<CustomerOut> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<CustomerOut> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<CustomerOut> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<CustomerOut> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "CustomerOutId";
        }

        public object KeyValue()
        {
            return this.CustomerOutId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<long>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.Memo.ToString();
        }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(CustomerOut)){
                CustomerOut compare=(CustomerOut)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        public string DescriptorValue()
        {
            return this.Memo.ToString();
        }

        public string DescriptorColumn() {
            return "Memo";
        }
        public static string GetKeyColumn()
        {
            return "CustomerOutId";
        }        
        public static string GetDescriptorColumn()
        {
            return "Memo";
        }
        
        #region ' Foreign Keys '
        public IQueryable<Customer> Customers
        {
            get
            {
                
                  var repo=OBS.Pos.Business.Customer.GetRepo();
                  return from items in repo.GetAll()
                       where items.CustomerId == _CustomerId
                       select items;
            }
        }

        #endregion
        

        long _CustomerOutId;
        public long CustomerOutId
        {
            get { return _CustomerOutId; }
            set
            {
                if(_CustomerOutId!=value){
                    _CustomerOutId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CustomerOutId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        long? _CustomerId;
        public long? CustomerId
        {
            get { return _CustomerId; }
            set
            {
                if(_CustomerId!=value){
                    _CustomerId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CustomerId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Memo;
        public string Memo
        {
            get { return _Memo; }
            set
            {
                if(_Memo!=value){
                    _Memo=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Memo");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        decimal _Amount;
        public decimal Amount
        {
            get { return _Amount; }
            set
            {
                if(_Amount!=value){
                    _Amount=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Amount");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        DateTime? _PostDate;
        public DateTime? PostDate
        {
            get { return _PostDate; }
            set
            {
                if(_PostDate!=value){
                    _PostDate=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="PostDate");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<CustomerOut, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the Customers table in the Pos Database.
    /// </summary>
    public partial class Customer: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<Customer> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<Customer>(new OBS.Pos.Business.PosDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<Customer> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(Customer item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                Customer item=new Customer();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<Customer> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        OBS.Pos.Business.PosDB _db;
        public Customer(string connectionString, string providerName) {

            _db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                Customer.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Customer>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public Customer(){
             _db=new OBS.Pos.Business.PosDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public Customer(Expression<Func<Customer, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<Customer> GetRepo(string connectionString, string providerName){
            OBS.Pos.Business.PosDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new OBS.Pos.Business.PosDB();
            }else{
                db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            }
            IRepository<Customer> _repo;
            
            if(db.TestMode){
                Customer.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Customer>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<Customer> GetRepo(){
            return GetRepo("","");
        }
        
        public static Customer SingleOrDefault(Expression<Func<Customer, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            Customer single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static Customer SingleOrDefault(Expression<Func<Customer, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            Customer single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<Customer, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<Customer, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<Customer> Find(Expression<Func<Customer, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<Customer> Find(Expression<Func<Customer, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<Customer> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<Customer> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<Customer> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<Customer> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<Customer> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<Customer> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "CustomerId";
        }

        public object KeyValue()
        {
            return this.CustomerId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<long>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.CustomerName.ToString();
        }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(Customer)){
                Customer compare=(Customer)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        public string DescriptorValue()
        {
            return this.CustomerName.ToString();
        }

        public string DescriptorColumn() {
            return "CustomerName";
        }
        public static string GetKeyColumn()
        {
            return "CustomerId";
        }        
        public static string GetDescriptorColumn()
        {
            return "CustomerName";
        }
        
        #region ' Foreign Keys '
        public IQueryable<CustomerOut> CustomerOuts
        {
            get
            {
                
                  var repo=OBS.Pos.Business.CustomerOut.GetRepo();
                  return from items in repo.GetAll()
                       where items.CustomerId == _CustomerId
                       select items;
            }
        }

        public IQueryable<PayTran> PayTrans
        {
            get
            {
                
                  var repo=OBS.Pos.Business.PayTran.GetRepo();
                  return from items in repo.GetAll()
                       where items.CustomerId == _CustomerId
                       select items;
            }
        }

        public IQueryable<PaymentMode> PaymentModes
        {
            get
            {
                
                  var repo=OBS.Pos.Business.PaymentMode.GetRepo();
                  return from items in repo.GetAll()
                       where items.ModeId == _PaymentModeId
                       select items;
            }
        }

        #endregion
        

        long _CustomerId;
        public long CustomerId
        {
            get { return _CustomerId; }
            set
            {
                if(_CustomerId!=value){
                    _CustomerId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CustomerId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _CustomerName;
        public string CustomerName
        {
            get { return _CustomerName; }
            set
            {
                if(_CustomerName!=value){
                    _CustomerName=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CustomerName");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        long _PaymentModeId;
        public long PaymentModeId
        {
            get { return _PaymentModeId; }
            set
            {
                if(_PaymentModeId!=value){
                    _PaymentModeId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="PaymentModeId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Address;
        public string Address
        {
            get { return _Address; }
            set
            {
                if(_Address!=value){
                    _Address=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Address");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Email;
        public string Email
        {
            get { return _Email; }
            set
            {
                if(_Email!=value){
                    _Email=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Email");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _ContactFirstName;
        public string ContactFirstName
        {
            get { return _ContactFirstName; }
            set
            {
                if(_ContactFirstName!=value){
                    _ContactFirstName=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ContactFirstName");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _ContactLastName;
        public string ContactLastName
        {
            get { return _ContactLastName; }
            set
            {
                if(_ContactLastName!=value){
                    _ContactLastName=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ContactLastName");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _ContactPhone;
        public string ContactPhone
        {
            get { return _ContactPhone; }
            set
            {
                if(_ContactPhone!=value){
                    _ContactPhone=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ContactPhone");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _ContactEmail;
        public string ContactEmail
        {
            get { return _ContactEmail; }
            set
            {
                if(_ContactEmail!=value){
                    _ContactEmail=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ContactEmail");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _ContactAddress;
        public string ContactAddress
        {
            get { return _ContactAddress; }
            set
            {
                if(_ContactAddress!=value){
                    _ContactAddress=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ContactAddress");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        decimal _MinBalance;
        public decimal MinBalance
        {
            get { return _MinBalance; }
            set
            {
                if(_MinBalance!=value){
                    _MinBalance=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="MinBalance");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        decimal _MinCredit;
        public decimal MinCredit
        {
            get { return _MinCredit; }
            set
            {
                if(_MinCredit!=value){
                    _MinCredit=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="MinCredit");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        decimal _OpenBalance;
        public decimal OpenBalance
        {
            get { return _OpenBalance; }
            set
            {
                if(_OpenBalance!=value){
                    _OpenBalance=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="OpenBalance");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        DateTime? _CreatedOn;
        public DateTime? CreatedOn
        {
            get { return _CreatedOn; }
            set
            {
                if(_CreatedOn!=value){
                    _CreatedOn=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CreatedOn");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _CreatedBy;
        public string CreatedBy
        {
            get { return _CreatedBy; }
            set
            {
                if(_CreatedBy!=value){
                    _CreatedBy=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CreatedBy");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        DateTime? _ModifiedOn;
        public DateTime? ModifiedOn
        {
            get { return _ModifiedOn; }
            set
            {
                if(_ModifiedOn!=value){
                    _ModifiedOn=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ModifiedOn");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _ModifiedBy;
        public string ModifiedBy
        {
            get { return _ModifiedBy; }
            set
            {
                if(_ModifiedBy!=value){
                    _ModifiedBy=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ModifiedBy");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if (!_dirtyColumns.Any(x => x.Name.ToLower() == "modifiedon")) {
               this.ModifiedOn=DateTime.Now;
            }            
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            if(String.IsNullOrEmpty(this.ModifiedBy))
                this.ModifiedBy=Environment.UserName;
            this.ModifiedOn=DateTime.Now;
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
                public void Update(string username){
            
            this.ModifiedBy=username;
            Update();

        }
        public void Update(string username, IDataProvider provider){

            this.ModifiedBy=username;
            Update(provider);
        }
        
       
        public void Add(IDataProvider provider){

            
            this.CreatedOn=DateTime.Now;
            if(String.IsNullOrEmpty(this.CreatedBy))
                this.CreatedBy=Environment.UserName;
            this.ModifiedOn=DateTime.Now;
            if(String.IsNullOrEmpty(this.ModifiedBy))
                this.ModifiedBy=Environment.UserName;
            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                public void Add(string username){
            
            this.CreatedBy=username;
            Add();

        }
        public void Add(string username, IDataProvider provider){

            this.CreatedBy=username;
            Add(provider);
        }
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

                public void Save(string username, IDataProvider provider) {
            
           
            if (_isNew) {
                                Add(username,provider);
                            } else {
                                Update(username,provider);
                
            }
            
        }
        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<Customer, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the Currencies table in the Pos Database.
    /// </summary>
    public partial class Currency: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<Currency> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<Currency>(new OBS.Pos.Business.PosDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<Currency> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(Currency item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                Currency item=new Currency();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<Currency> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        OBS.Pos.Business.PosDB _db;
        public Currency(string connectionString, string providerName) {

            _db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                Currency.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Currency>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public Currency(){
             _db=new OBS.Pos.Business.PosDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public Currency(Expression<Func<Currency, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<Currency> GetRepo(string connectionString, string providerName){
            OBS.Pos.Business.PosDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new OBS.Pos.Business.PosDB();
            }else{
                db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            }
            IRepository<Currency> _repo;
            
            if(db.TestMode){
                Currency.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Currency>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<Currency> GetRepo(){
            return GetRepo("","");
        }
        
        public static Currency SingleOrDefault(Expression<Func<Currency, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            Currency single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static Currency SingleOrDefault(Expression<Func<Currency, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            Currency single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<Currency, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<Currency, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<Currency> Find(Expression<Func<Currency, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<Currency> Find(Expression<Func<Currency, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<Currency> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<Currency> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<Currency> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<Currency> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<Currency> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<Currency> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "CurrencyId";
        }

        public object KeyValue()
        {
            return this.CurrencyId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.CurrencyName.ToString();
        }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(Currency)){
                Currency compare=(Currency)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.CurrencyId;
        }
        
        public string DescriptorValue()
        {
            return this.CurrencyName.ToString();
        }

        public string DescriptorColumn() {
            return "CurrencyName";
        }
        public static string GetKeyColumn()
        {
            return "CurrencyId";
        }        
        public static string GetDescriptorColumn()
        {
            return "CurrencyName";
        }
        
        #region ' Foreign Keys '
        public IQueryable<PayTran> PayTrans
        {
            get
            {
                
                  var repo=OBS.Pos.Business.PayTran.GetRepo();
                  return from items in repo.GetAll()
                       where items.CurrencyId == _CurrencyId
                       select items;
            }
        }

        #endregion
        

        int _CurrencyId;
        public int CurrencyId
        {
            get { return _CurrencyId; }
            set
            {
                if(_CurrencyId!=value){
                    _CurrencyId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CurrencyId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _CurrencyName;
        public string CurrencyName
        {
            get { return _CurrencyName; }
            set
            {
                if(_CurrencyName!=value){
                    _CurrencyName=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CurrencyName");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Symbol;
        public string Symbol
        {
            get { return _Symbol; }
            set
            {
                if(_Symbol!=value){
                    _Symbol=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Symbol");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<Currency, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the PayTrans table in the Pos Database.
    /// </summary>
    public partial class PayTran: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<PayTran> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<PayTran>(new OBS.Pos.Business.PosDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<PayTran> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(PayTran item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                PayTran item=new PayTran();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<PayTran> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        OBS.Pos.Business.PosDB _db;
        public PayTran(string connectionString, string providerName) {

            _db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                PayTran.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<PayTran>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public PayTran(){
             _db=new OBS.Pos.Business.PosDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public PayTran(Expression<Func<PayTran, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<PayTran> GetRepo(string connectionString, string providerName){
            OBS.Pos.Business.PosDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new OBS.Pos.Business.PosDB();
            }else{
                db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            }
            IRepository<PayTran> _repo;
            
            if(db.TestMode){
                PayTran.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<PayTran>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<PayTran> GetRepo(){
            return GetRepo("","");
        }
        
        public static PayTran SingleOrDefault(Expression<Func<PayTran, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            PayTran single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static PayTran SingleOrDefault(Expression<Func<PayTran, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            PayTran single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<PayTran, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<PayTran, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<PayTran> Find(Expression<Func<PayTran, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<PayTran> Find(Expression<Func<PayTran, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<PayTran> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<PayTran> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<PayTran> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<PayTran> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<PayTran> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<PayTran> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "TransactionId";
        }

        public object KeyValue()
        {
            return this.TransactionId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<Guid>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.Memo.ToString();
        }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(PayTran)){
                PayTran compare=(PayTran)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        public string DescriptorValue()
        {
            return this.Memo.ToString();
        }

        public string DescriptorColumn() {
            return "Memo";
        }
        public static string GetKeyColumn()
        {
            return "TransactionId";
        }        
        public static string GetDescriptorColumn()
        {
            return "Memo";
        }
        
        #region ' Foreign Keys '
        public IQueryable<Currency> Currencies
        {
            get
            {
                
                  var repo=OBS.Pos.Business.Currency.GetRepo();
                  return from items in repo.GetAll()
                       where items.CurrencyId == _CurrencyId
                       select items;
            }
        }

        public IQueryable<Customer> Customers
        {
            get
            {
                
                  var repo=OBS.Pos.Business.Customer.GetRepo();
                  return from items in repo.GetAll()
                       where items.CustomerId == _CustomerId
                       select items;
            }
        }

        public IQueryable<PaymentMode> PaymentModes
        {
            get
            {
                
                  var repo=OBS.Pos.Business.PaymentMode.GetRepo();
                  return from items in repo.GetAll()
                       where items.ModeId == _PaymentModeId
                       select items;
            }
        }

        public IQueryable<TransactionType> TransactionTypes
        {
            get
            {
                
                  var repo=OBS.Pos.Business.TransactionType.GetRepo();
                  return from items in repo.GetAll()
                       where items.TransactionTypeId == _TransactionType
                       select items;
            }
        }

        #endregion
        

        Guid _TransactionId;
        public Guid TransactionId
        {
            get { return _TransactionId; }
            set
            {
                if(_TransactionId!=value){
                    _TransactionId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="TransactionId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        long _CustomerId;
        public long CustomerId
        {
            get { return _CustomerId; }
            set
            {
                if(_CustomerId!=value){
                    _CustomerId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CustomerId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Memo;
        public string Memo
        {
            get { return _Memo; }
            set
            {
                if(_Memo!=value){
                    _Memo=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Memo");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        short _TransactionType;
        public short TransactionType
        {
            get { return _TransactionType; }
            set
            {
                if(_TransactionType!=value){
                    _TransactionType=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="TransactionType");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _CurrencyId;
        public int? CurrencyId
        {
            get { return _CurrencyId; }
            set
            {
                if(_CurrencyId!=value){
                    _CurrencyId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CurrencyId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        long? _PaymentModeId;
        public long? PaymentModeId
        {
            get { return _PaymentModeId; }
            set
            {
                if(_PaymentModeId!=value){
                    _PaymentModeId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="PaymentModeId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _CardNum;
        public string CardNum
        {
            get { return _CardNum; }
            set
            {
                if(_CardNum!=value){
                    _CardNum=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CardNum");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        DateTime? _CardExpiryDate;
        public DateTime? CardExpiryDate
        {
            get { return _CardExpiryDate; }
            set
            {
                if(_CardExpiryDate!=value){
                    _CardExpiryDate=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CardExpiryDate");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        decimal _Amount;
        public decimal Amount
        {
            get { return _Amount; }
            set
            {
                if(_Amount!=value){
                    _Amount=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Amount");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<PayTran, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the Products table in the Pos Database.
    /// </summary>
    public partial class Product: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<Product> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<Product>(new OBS.Pos.Business.PosDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<Product> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(Product item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                Product item=new Product();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<Product> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        OBS.Pos.Business.PosDB _db;
        public Product(string connectionString, string providerName) {

            _db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                Product.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Product>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public Product(){
             _db=new OBS.Pos.Business.PosDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public Product(Expression<Func<Product, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<Product> GetRepo(string connectionString, string providerName){
            OBS.Pos.Business.PosDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new OBS.Pos.Business.PosDB();
            }else{
                db=new OBS.Pos.Business.PosDB(connectionString, providerName);
            }
            IRepository<Product> _repo;
            
            if(db.TestMode){
                Product.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Product>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<Product> GetRepo(){
            return GetRepo("","");
        }
        
        public static Product SingleOrDefault(Expression<Func<Product, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            Product single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static Product SingleOrDefault(Expression<Func<Product, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            Product single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<Product, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<Product, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<Product> Find(Expression<Func<Product, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<Product> Find(Expression<Func<Product, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<Product> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<Product> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<Product> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<Product> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<Product> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<Product> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "ProductId";
        }

        public object KeyValue()
        {
            return this.ProductId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<long>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.ProductCode.ToString();
        }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(Product)){
                Product compare=(Product)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        public string DescriptorValue()
        {
            return this.ProductCode.ToString();
        }

        public string DescriptorColumn() {
            return "ProductCode";
        }
        public static string GetKeyColumn()
        {
            return "ProductId";
        }        
        public static string GetDescriptorColumn()
        {
            return "ProductCode";
        }
        
        #region ' Foreign Keys '
        public IQueryable<ProductCategory> ProductCategories
        {
            get
            {
                
                  var repo=OBS.Pos.Business.ProductCategory.GetRepo();
                  return from items in repo.GetAll()
                       where items.ProductId == _ProductId
                       select items;
            }
        }

        public IQueryable<ProductStock> ProductStocks
        {
            get
            {
                
                  var repo=OBS.Pos.Business.ProductStock.GetRepo();
                  return from items in repo.GetAll()
                       where items.ProductId == _ProductId
                       select items;
            }
        }

        public IQueryable<ProductSupplier> ProductSuppliers
        {
            get
            {
                
                  var repo=OBS.Pos.Business.ProductSupplier.GetRepo();
                  return from items in repo.GetAll()
                       where items.ProductIId == _ProductId
                       select items;
            }
        }

        public IQueryable<StockCount> StockCounts
        {
            get
            {
                
                  var repo=OBS.Pos.Business.StockCount.GetRepo();
                  return from items in repo.GetAll()
                       where items.ProductId == _ProductId
                       select items;
            }
        }

        public IQueryable<UnitOfMeasurement> UnitOfMeasurements
        {
            get
            {
                
                  var repo=OBS.Pos.Business.UnitOfMeasurement.GetRepo();
                  return from items in repo.GetAll()
                       where items.MeasurementId == _MeasurementId
                       select items;
            }
        }

        #endregion
        

        long _ProductId;
        public long ProductId
        {
            get { return _ProductId; }
            set
            {
                if(_ProductId!=value){
                    _ProductId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ProductId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _ProductCode;
        public string ProductCode
        {
            get { return _ProductCode; }
            set
            {
                if(_ProductCode!=value){
                    _ProductCode=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ProductCode");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _ProductName;
        public string ProductName
        {
            get { return _ProductName; }
            set
            {
                if(_ProductName!=value){
                    _ProductName=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ProductName");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Description;
        public string Description
        {
            get { return _Description; }
            set
            {
                if(_Description!=value){
                    _Description=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Description");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        long? _MeasurementId;
        public long? MeasurementId
        {
            get { return _MeasurementId; }
            set
            {
                if(_MeasurementId!=value){
                    _MeasurementId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="MeasurementId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        byte[] _ProductImage;
        public byte[] ProductImage
        {
            get { return _ProductImage; }
            set
            {
                if(_ProductImage!=value){
                    _ProductImage=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ProductImage");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool _ApplyVAT;
        public bool ApplyVAT
        {
            get { return _ApplyVAT; }
            set
            {
                if(_ApplyVAT!=value){
                    _ApplyVAT=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ApplyVAT");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool _ApplyNHIL;
        public bool ApplyNHIL
        {
            get { return _ApplyNHIL; }
            set
            {
                if(_ApplyNHIL!=value){
                    _ApplyNHIL=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ApplyNHIL");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        decimal _UnitPrice;
        public decimal UnitPrice
        {
            get { return _UnitPrice; }
            set
            {
                if(_UnitPrice!=value){
                    _UnitPrice=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="UnitPrice");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        decimal _CostPrice;
        public decimal CostPrice
        {
            get { return _CostPrice; }
            set
            {
                if(_CostPrice!=value){
                    _CostPrice=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CostPrice");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool _UsedInSales;
        public bool UsedInSales
        {
            get { return _UsedInSales; }
            set
            {
                if(_UsedInSales!=value){
                    _UsedInSales=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="UsedInSales");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool _UsedInProduction;
        public bool UsedInProduction
        {
            get { return _UsedInProduction; }
            set
            {
                if(_UsedInProduction!=value){
                    _UsedInProduction=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="UsedInProduction");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        decimal _MinLevel;
        public decimal MinLevel
        {
            get { return _MinLevel; }
            set
            {
                if(_MinLevel!=value){
                    _MinLevel=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="MinLevel");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        decimal _ReOrderLevel;
        public decimal ReOrderLevel
        {
            get { return _ReOrderLevel; }
            set
            {
                if(_ReOrderLevel!=value){
                    _ReOrderLevel=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ReOrderLevel");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool _UseIfNotInStock;
        public bool UseIfNotInStock
        {
            get { return _UseIfNotInStock; }
            set
            {
                if(_UseIfNotInStock!=value){
                    _UseIfNotInStock=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="UseIfNotInStock");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<Product, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
}
