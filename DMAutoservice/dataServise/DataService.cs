using DMAutoserviceModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMAutoserviceModel
{

    public class DataService : IDataService//, INotifyPropertyChanged

    {
        #region Collections

        public ObservableCollection<Brand> Brands { get; set; } = new ObservableCollection<Brand>();

        public ObservableCollection<Model> Models { get; set; } = new ObservableCollection<Model>();

        public ObservableCollection<Generation> Generations { get; set; } = new ObservableCollection<Generation>();

        public ObservableCollection<EngineType> EngineTypes { get; set; } = new ObservableCollection<EngineType>();

        public ObservableCollection<TuningSpecification> TuningSpecifications { get; set; } = new ObservableCollection<TuningSpecification>();

        public ObservableCollection<Options> Options { get; set; } = new ObservableCollection<Options>();
        public ObservableCollection<Booking> Bookings { get; set; } = new ObservableCollection<Booking>();

        public ObservableCollection<Login> Logins { get; set; } = new ObservableCollection<Login>();

        /// <summary>
        /// not from interface collections:
        /// </summary>
        /// 
        public ObservableCollection<Person> People { get; set; } = new ObservableCollection<Person>();
        public ObservableCollection<Admin> SiteOwners
        {
            get
            {
                ObservableCollection<Admin> admins = new ObservableCollection<Admin>();
                foreach (var person in People)
                {
                    if (person is Admin admin)
                    {
                        admins.Add(admin);
                    }
                }
                return admins;
            }
        }
        public ObservableCollection<Customer> Customers
        {
            get
            {
                ObservableCollection<Customer> customers = new ObservableCollection<Customer>();
                foreach (var person in People)
                {
                    if (person is Customer customer)
                    {
                        customers.Add(customer);
                    }
                }
                return customers;
            }
        }

        #endregion

        #region Properties

        Login Log { get; set; } = new Login();
        EngineType TypeOFEngine { get; set; } = new EngineType();

        #endregion

        public DataService()
        {
            CreateData();
        }
        private void CreateData()
        {
            #region Brands
            Brand alfa = new Brand
            {
                BrandName = "Alfa Romeo"
            };
            Brand fiat = new Brand
            {
                BrandName = "Fiat"
            };
            Brand bmw = new Brand
            {
                BrandName = "BMW"
            };
            Brand porsche = new Brand
            {
                BrandName = "Porsche"
            };

            #endregion

            #region Models

            Model alfa1 = new Model
            {
                ModelName = "Gulietta",
                Brand = alfa

            };
            
            Model alfa2 = new Model
            {
                ModelName = "MiTo",
                Brand = alfa
            };
            alfa.Models.Add(alfa1);
            alfa.Models.Add(alfa2);

            Model fiat1 = new Model
            {
                ModelName = "500 / 595 / 695",
                Brand = fiat
            };

            Model fiat2 = new Model
            {
                ModelName = "124 spider",
                Brand = fiat
            };
            fiat.Models.Add(fiat1);
            fiat.Models.Add(fiat2);

            Model bmw1 = new Model
            {
                ModelName = "5 serie",
                Brand = bmw
            };

            Model bmw2 = new Model
            {
                ModelName = "5 serie GT",
                Brand = bmw
            };
            bmw.Models.Add(bmw1);
            bmw.Models.Add(bmw2);

            Model porsche1 = new Model
            {
                ModelName = "Carrera GT",
                Brand = porsche
            };

            Model porsche2 = new Model
            {
                ModelName = "Panamera",
                Brand = porsche
            };
            porsche.Models.Add(porsche1);
            porsche.Models.Add(porsche2);

            //Models.Add(alfa1);
            //Models.Add(alfa2);
            //Models.Add(fiat1);
            //Models.Add(fiat2);
            //Models.Add(bmw1);
            //Models.Add(bmw2);
            //Models.Add(porsche1);
            //Models.Add(porsche2);
            #endregion

            #region Generations
            Generation generationGulietta = new Generation
            {
                GenerationName = "2016 ->",
                ModelType = alfa1
            };
            alfa1.Generations.Add(generationGulietta);

            Generation generationMiTo = new Generation
            {
                GenerationName = "2016 ->",
                ModelType = alfa2
            };
            alfa2.Generations.Add(generationMiTo);


            Generation generation500 = new Generation
            {
                GenerationName = "2007 - 2015",
                ModelType = fiat1
            };
            fiat1.Generations.Add(generation500);

            Generation generation124 = new Generation
            {
                GenerationName = "2016 ->",
                ModelType = fiat2
            };
            fiat2.Generations.Add(generation124);

            //Generations.Add(generationGulietta);
            //Generations.Add(generationMiTo);
            //Generations.Add(generation500);
            //Generations.Add(generation124);

            #endregion

            #region Engine types and specifications

            EngineType engineTypeGenerationGulietta = new EngineType
            {
                TypeEngine = "1.4 Turbo Multitiair 170pk",
                PowerStandard = 170,
                PowerAfterTuning = 185,
                //PowerDifference = 15,
                TorqueStandard = 250,
                TorqueAfterTuning = 290,
               // TorqueDifference = 40,
                Fuel = "Petrol",
                GenerationType = generationGulietta

            };
            generationGulietta.EngineTypes.Add(engineTypeGenerationGulietta);

            EngineType engineTypeGenerationMiTo = new EngineType
            {
                TypeEngine = "1.4 Turbo Multitiair 170pk",
                PowerStandard = 170,
                PowerAfterTuning = 185,
                //PowerDifference = 15,
                TorqueStandard = 250,
                TorqueAfterTuning = 290,
               // TorqueDifference = 40,
                Fuel = "Petrol",
                GenerationType = generationMiTo
            };
            generationMiTo.EngineTypes.Add(engineTypeGenerationMiTo);

            EngineType engineTypeGeneration500 = new EngineType
            {
                TypeEngine = "1.4 T-Jet 120pk",
                PowerStandard = 120,
                PowerAfterTuning = 150,
               // PowerDifference = 30,
                TorqueStandard = 206,
                TorqueAfterTuning = 250,
               // TorqueDifference = 40,
                Fuel = "Petrol",
                GenerationType = generation500
            };
            generation500.EngineTypes.Add(engineTypeGeneration500);

            EngineType engineTypeGeneration124 = new EngineType
            {
                TypeEngine = "1.4 Multitiair Turbo 170pk",
                PowerStandard = 170,
                PowerAfterTuning = 185,
                //PowerDifference = 15,
                TorqueStandard = 250,
                TorqueAfterTuning = 290,
                //TorqueDifference = 40,
                Fuel = "Petrol",
                GenerationType = generation124
        };
            generation124.EngineTypes.Add(engineTypeGeneration124);

            //EngineTypes.Add(engineTypeGenerationGulietta);
            //EngineTypes.Add(engineTypeGenerationMiTo);
            //EngineTypes.Add(engineTypeGeneration500);
            //EngineTypes.Add(engineTypeGeneration124);

            TuningSpecification tuningSpecificationAlfa = new TuningSpecification
            {
                CompresionRatio = "9,8 : 1",
                CylinderCapacity = "1368 CC",
                EcuType = "Marelli MM8GMF",
                BoreXStroke = "72,0 X 84,0 mm",
                EngineNumber = "940A2000",
                TypeEngin = engineTypeGenerationGulietta
            };

            TuningSpecification tuningSpecificationMito = new TuningSpecification
            {
                CompresionRatio = "9,8 : 1",
                CylinderCapacity = "1368 CC",
                EcuType = "Marelli MM8GMF",
                BoreXStroke = "72,0 X 84,0 mm",
                EngineNumber = "940A2000",
                TypeEngin = engineTypeGenerationMiTo
            };

            TuningSpecification tuningSpecification500 = new TuningSpecification
            {
                CompresionRatio = "10,8 : 1",
                CylinderCapacity = "1368 CC",
                EcuType = "Bosh ME17.3.0",
                BoreXStroke = "72,0 X 84,0 mm",
                TypeEngin = engineTypeGeneration500
            };

            TuningSpecification tuningSpecification124 = new TuningSpecification
            {
                CompresionRatio = "9,8 : 1",
                CylinderCapacity = "1368 CC",
                EcuType = "Marelli MM8GMF",
                BoreXStroke = "72,0 X 84,0 mm",
                EngineNumber = "55253268",
                TypeEngin = engineTypeGeneration124
            };

            Brands.Add(alfa);
            Brands.Add(fiat);
            Brands.Add(bmw);
            Brands.Add(porsche);
            engineTypeGeneration124.SpecificationTuning = tuningSpecification124;
            engineTypeGeneration500.SpecificationTuning = tuningSpecification500;
            engineTypeGenerationMiTo.SpecificationTuning = tuningSpecificationMito;
            engineTypeGenerationGulietta.SpecificationTuning = tuningSpecificationAlfa;
            #endregion

            #region Logins
            Login l = new Login
            {
                LoginName = "diauto",
                Password = "11111"
            };
            Logins.Add(l);

            Login l1 = new Login
            {
                LoginName = "miauto",
                Password = "11111"
            };
            Logins.Add(l1);
            #endregion
        }


        #region implementing IDataServise

        public bool CheckCredentials(string loginName, string password)
        {
            foreach (Login login in Logins)
            {
                if (login.Password == password && login.LoginName == loginName)
                {
                    return true;
                }
            }
            return false;
        }

        public Login Login(string name)
        {
            foreach (Login login in Logins)
            {
                if (login.LoginName == name)
                {
                    return login;
                }
            }
            throw new Exception($"{name} is incorrect");
        }

        public ObservableCollection<Brand> GetAllBrands()
        {
            return Brands;
        }

        public ObservableCollection<Model> GetAllModelsOFBrand(Brand brand)
        {
            return brand.Models;
        }

        public ObservableCollection<Generation> GetAllGenerationsOfModel(Model model)
        {
            return model.Generations;
        }

        public ObservableCollection<EngineType> GetAllEngineTypeOfGeneration(Generation generation)
        {
            return generation.EngineTypes;
        }

        public TuningSpecification GetAllTuningSpecificationsOfEngineType(EngineType engineType)
        {
            return engineType.SpecificationTuning;
        }

        public ObservableCollection<Options> GetAllOptionsOfEngineTypeTuning()
        {
            return Options;
        }

        public ObservableCollection<Login> GetAllLogins()
        {
            return Logins;
        }

        public void AddBrand(Brand brand, Model model)
        {
            brand.Models.Add(model);
            model.Brand = brand;

            Brands.Add(brand);
        }

        public void AddModel(Model model, Generation generation)
        {
            model.Generations.Add(generation);
            generation.ModelType = model;

            Models.Add(model);
        }

        public void AddGeneration(Generation generation, EngineType engineType)
        {
            generation.EngineTypes.Add(engineType);
            engineType.GenerationType = generation;

            Generations.Add(generation);
        }

        public void AddEngineType(EngineType engineType, Generation generation)
        {
            engineType.GenerationType = generation;
            EngineTypes.Add(engineType);
        }

        public void AddTuningSpecification(TuningSpecification tuningSpecification, EngineType engineType)
        {
            // TypeOFEngine = eT;
            engineType.SpecificationTuning = tuningSpecification;
        }

        public Booking AddBooking(EngineType engineType, Person person)
        {
            Booking booking = new Booking
            {
                EngineType = engineType,
                Person = person
            };

            person.Bookings.Add(booking);
            if (engineType != null)
            {
                engineType.Bookings.Add(booking);
            }
            else
            {
                engineType = new EngineType();
                engineType.Bookings.Add(booking);
            }//Object reference not set to an instance of an object if the engine type has not been given


            People.Add(person);
            Bookings.Add(booking);

            return booking;
        }
        #endregion

        // used library instead of:
        //public event PropertyChangedEventHandler PropertyChanged;

        //void RaisePropertyChanged(string propName)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        //}

    }
}
