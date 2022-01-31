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
        void AddBrand(Brand brand, Model model);
        void AddModel(Model model, Generation generation);
        void AddGeneration(Generation generation, EngineType engineType);
        void AddEngineType(EngineType engineType, Generation generation);
        void AddTuningSpecification(TuningSpecification tuningSpecification, EngineType engineType);
        Booking AddBooking(EngineType engineType, Person person);
        #endregion

    }
}
