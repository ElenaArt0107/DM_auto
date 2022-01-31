using System.Collections.ObjectModel;
using DMAutoserviceModel;

namespace DMAutoserviceModel
{
    public interface IDataService
    {
        bool CheckCredentials(string name, string password);

        Login Login(string name);

        ObservableCollection<Brand> GetAllBrands();
        ObservableCollection<Model> GetAllModelsOFBrand(Brand brand);
        ObservableCollection<Generation> GetAllGenerationsOfModel(Model model);
        ObservableCollection<EngineType> GetAllEngineTypeOfGeneration(Generation generation);
        TuningSpecification GetAllTuningSpecificationsOfEngineType(EngineType engineType);
        ObservableCollection<Options> GetAllOptionsOfEngineTypeTuning();

        ObservableCollection<Login> GetAllLogins();

        #region Adding specifications
        void AddBrand(Brand brand);
        void AddModel(Model model);
        void AddGeneration(Generation generation);
        void AddEngineType(EngineType engineType);
        void AddTuningSpecification(TuningSpecification tuningSpecification, EngineType engineType);
        #endregion

    }
}
