using DMAutoservice.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DMAutoservice.Domain

{
    public static class DataSeeder
    {
        private static DMAutoserviceContext _context;

        public static void SeedData(DMAutoserviceContext context)
        {
            _context = context;
            //return; //(not to be in the production)

            // Database will be removed from servr
            // ...and will be again initialized
            // context.Database.EnsureDeleted();
           context.Database.EnsureCreated();

            if (context.Brands.Any())
            {
                return;
            }

            //ensure presense of rights in the DB:
            foreach (var rightCode in RightsList.Rights)
            {
                var rightInDb = context.Rights
                .Where(x => x.InternalCode == rightCode)
                .FirstOrDefault();

                // Bestaat nog niet in databank
                if (rightInDb == null)
                {
                    var newRight = new Right
                    {
                        InternalCode = rightCode
                    };

                    context.Rights.Add(newRight);
                }
            }
            context.SaveChanges();

          


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
            context.Brands.Add(alfa);
            context.Brands.Add(fiat);
            context.Brands.Add(bmw);
            context.Brands.Add(porsche);

            context.SaveChanges();

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
            context.Models.Add(alfa1);
            context.Models.Add(alfa2);
            context.Models.Add(fiat1);
            context.Models.Add(fiat2);
            context.Models.Add(bmw1);
            context.Models.Add(bmw2);
            context.Models.Add(porsche1);
            context.Models.Add(porsche2);

            context.SaveChanges();
            #endregion

            #region Generations
            Generation generationGulietta = new Generation
            {
                GenerationName = "2016 ->",
                ModelType = alfa1
            };
            context.Generations.Add(generationGulietta);

            Generation generationMiTo = new Generation
            {
                GenerationName = "2016 ->",
                ModelType = alfa2
            };
            context.Generations.Add(generationMiTo);


            Generation generation500 = new Generation
            {
                GenerationName = "2007 - 2015",
                ModelType = fiat1
            };
            context.Generations.Add(generation500);

            Generation generation124 = new Generation
            {
                GenerationName = "2016 ->",
                ModelType = fiat2
            };
            context.Generations.Add(generation124);
            context.SaveChanges();

            #endregion

            #region Engine types and specifications

            Engine engineTypeGenerationGulietta = new Engine
            {
                EngineType = "1.4 Turbo Multitiair 170pk",
                PowerStandard = 170,
                PowerAfterTuning = 185,
                //PowerDifference = 15,
                TorqueStandard = 250,
                TorqueAfterTuning = 290,
                // TorqueDifference = 40,
                Fuel = "Petrol",
                GenerationType = generationGulietta

            };
            context.Engines.Add(engineTypeGenerationGulietta);

            Engine engineTypeGenerationMiTo = new Engine
            {
                EngineType = "1.4 Turbo Multitiair 170pk",
                PowerStandard = 170,
                PowerAfterTuning = 185,
                //PowerDifference = 15,
                TorqueStandard = 250,
                TorqueAfterTuning = 290,
                // TorqueDifference = 40,
                Fuel = "Petrol",
                GenerationType = generationMiTo
            };
            context.Engines.Add(engineTypeGenerationMiTo);

            Engine engineTypeGeneration500 = new Engine
            {
                EngineType = "1.4 T-Jet 120pk",
                PowerStandard = 120,
                PowerAfterTuning = 150,
                // PowerDifference = 30,
                TorqueStandard = 206,
                TorqueAfterTuning = 250,
                // TorqueDifference = 40,
                Fuel = "Petrol",
                GenerationType = generation500
            };
            context.Engines.Add(engineTypeGeneration500);

            Engine engineTypeGeneration124 = new Engine
            {
                EngineType = "1.4 Multitiair Turbo 170pk",
                PowerStandard = 170,
                PowerAfterTuning = 185,
                //PowerDifference = 15,
                TorqueStandard = 250,
                TorqueAfterTuning = 290,
                //TorqueDifference = 40,
                Fuel = "Petrol",
                GenerationType = generation124
            };
            context.Engines.Add(engineTypeGeneration124);


            #region TODO TuningSpecification
            //TuningSpecification tuningSpecificationAlfa = new TuningSpecification
            //{
            //    CompresionRatio = "9,8 : 1",
            //    CylinderCapacity = "1368 CC",
            //    EcuType = "Marelli MM8GMF",
            //    BoreXStroke = "72,0 X 84,0 mm",
            //    EngineNumber = "940A2000",
            //    TypeEngin = engineTypeGenerationGulietta
            //};

            //TuningSpecification tuningSpecificationMito = new TuningSpecification
            //{
            //    CompresionRatio = "9,8 : 1",
            //    CylinderCapacity = "1368 CC",
            //    EcuType = "Marelli MM8GMF",
            //    BoreXStroke = "72,0 X 84,0 mm",
            //    EngineNumber = "940A2000",
            //    TypeEngin = engineTypeGenerationMiTo
            //};

            //TuningSpecification tuningSpecification500 = new TuningSpecification
            //{
            //    CompresionRatio = "10,8 : 1",
            //    CylinderCapacity = "1368 CC",
            //    EcuType = "Bosh ME17.3.0",
            //    BoreXStroke = "72,0 X 84,0 mm",
            //    TypeEngin = engineTypeGeneration500
            //};

            //TuningSpecification tuningSpecification124 = new TuningSpecification
            //{
            //    CompresionRatio = "9,8 : 1",
            //    CylinderCapacity = "1368 CC",
            //    EcuType = "Marelli MM8GMF",
            //    BoreXStroke = "72,0 X 84,0 mm",
            //    EngineNumber = "55253268",
            //    TypeEngin = engineTypeGeneration124
            //};
            #endregion
            #endregion

            #region User
            User u1 = new User
            {
                UserName = "Admin"
            };
            User u2 = new User
            {
                UserName = "Customer"
            };
            context.Users.Add(u1);
            context.Users.Add(u2);

            context.SaveChanges();

            #endregion

            #region People
            Person p1 = new Person
            {
                Name = "Simon",
                Surname = "Bolivar", //how to update info in table where typo
                Email = null,
                PhoneNumber = 0990030703
            };

            Person p2 = new Person
            {
                Name = "Patrick",
                Surname = "Domingo", //how to update info in table where typo
                Email = "patrick@gmail.com",
                PhoneNumber = 050848940

            };


            context.People.Add(p1);
            context.People.Add(p2);

            context.SaveChanges();
            #endregion

            #region UserCar
            UserCar uC1 = new UserCar
            {
                PersonId = p1.Id,
                BrandId = bmw.Id
            };

            UserCar uC2 = new UserCar
            {
                PersonId = p2.Id,
                BrandId = bmw.Id
            };
            UserCar uC3 = new UserCar
            {
                PersonId = p1.Id,
                BrandId = alfa.Id
            };
            UserCar uC4 = new UserCar
            {
                PersonId = p2.Id,
                BrandId = fiat.Id
            };
            context.UsersCars.Add(uC1);
            context.UsersCars.Add(uC2);
            context.UsersCars.Add(uC4);
            context.UsersCars.Add(uC3);
            context.SaveChanges();

            #endregion

            if (!context.Accounts.Any())
            {
                #region Accounts
                Account admin = new Account
                {
                    LoginName = "DMAuto",
                    Password = "11111",
                    PersonId = p2.Id

                };

                //no user role  determined yet
                context.Accounts.Add(admin);

                Account readOnly = new Account
                {
                    LoginName = "randomAuto",
                    Password = "11111",
                    PersonId = p1.Id

                };
                context.Accounts.Add(readOnly);
                context.SaveChanges();
                #endregion

                #region AccountRights
                #region Admin Rights
                AccountRights adminRigtCreate = new AccountRights
                {
                    AccountId = admin.Id,
                    RightId = GetRightIdFromInternalCode(RightsList.CreateBrand)
                };

                AccountRights adminRigtEdit = new AccountRights
                {
                    AccountId = admin.Id,
                    RightId = GetRightIdFromInternalCode(RightsList.EditBrand)
                };
                AccountRights adminRigtShowList = new AccountRights
                {
                    AccountId = admin.Id,
                    RightId = GetRightIdFromInternalCode(RightsList.ShowBrandDetails)
                };
                AccountRights adminRigtShowDetails = new AccountRights
                {
                    AccountId = admin.Id,
                    RightId = GetRightIdFromInternalCode(RightsList.ShowDetailsAccount)
                };
                AccountRights adminRigtDelete = new AccountRights
                {
                    AccountId = admin.Id,
                    RightId = GetRightIdFromInternalCode(RightsList.DeleteBrand)
                };
                AccountRights adminRigtBrandList = new AccountRights
                {
                    AccountId = admin.Id,
                    RightId = GetRightIdFromInternalCode(RightsList.ShowBrandList)
                };
                #endregion

                #region Read Only Rights
                AccountRights readOnlyRigtShowDetails = new AccountRights
                {
                    AccountId = readOnly.Id,
                    RightId = GetRightIdFromInternalCode(RightsList.ShowDetailsAccount)
                };
                //AccountRights readOnlyDelete = new AccountRights
                //{
                //    AccountId = readOnly.Id,
                //    RightId = GetRightIdFromInternalCode(RightsList.DeleteAccount)
                //};
                //AccountRights readOnlyCreate = new AccountRights
                //{
                //    AccountId = readOnly.Id,
                //    RightId = GetRightIdFromInternalCode(RightsList.DeleteAccount)
                //};
                context.AccountRights.Add(adminRigtCreate);
                context.AccountRights.Add(adminRigtEdit);
                context.AccountRights.Add(adminRigtDelete);
                context.AccountRights.Add(adminRigtShowList);
                context.AccountRights.Add(adminRigtShowDetails);
                context.AccountRights.Add(adminRigtBrandList);
                context.AccountRights.Add(readOnlyRigtShowDetails);
                context.SaveChanges();

                #endregion


                #endregion


            }

        }

        private static int GetRightIdFromInternalCode(string internalCode)
        {
            return _context.Rights
            .Where(x => x.InternalCode == internalCode)
            .Select(x => x.Id)
            .FirstOrDefault();
        }
    }
}
