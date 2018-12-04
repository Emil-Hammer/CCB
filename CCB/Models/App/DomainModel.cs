using System;
using System.Threading.Tasks;
using CCB.Models.Catalog;

namespace CCB.Models.App
{
    public class DomainModel
    {
        #region Instance fields
        private InventoryCatalog _inventoryCatalog;
        private ProjectCatalog _projectCatalog;
        private StaffCatalog _staffCatalog;
        #endregion

        #region Events
        public event Action LoadBegins;
        public event Action LoadEnds;
        public event Action SaveBegins;
        public event Action SaveEnds;
        #endregion

        #region Singleton implementation
        private static DomainModel _instance;
        public static DomainModel Instance
        {
            get
            {
                _instance = _instance ?? (_instance = new DomainModel());
                return _instance;
            }
        }

        public static DomainModel Catalogs { get { return Instance; } }
        #endregion

        #region Constructor
        private DomainModel()
        {
            _inventoryCatalog = new InventoryCatalog();
            _projectCatalog = new ProjectCatalog();
            _staffCatalog = new StaffCatalog();
        }
        #endregion

        #region Properties
        public InventoryCatalog Cars { get { return _inventoryCatalog; } }
        public ProjectCatalog Customers { get { return _projectCatalog; } }
        public StaffCatalog Employees { get { return _staffCatalog; } }
        #endregion

        #region Persistency methods
        public async Task LoadAsync()
        {
            LoadBegins?.Invoke();

            await _inventoryCatalog.LoadAsync();
            await _projectCatalog.LoadAsync();
            await _staffCatalog.LoadAsync();

            LoadEnds?.Invoke();
        }

        public async Task SaveAsync()
        {
            SaveBegins?.Invoke();

            await _inventoryCatalog.SaveAsync();
            await _projectCatalog.SaveAsync();
            await _staffCatalog.SaveAsync();

            SaveEnds?.Invoke();
        }
        #endregion

    }
}