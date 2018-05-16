using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Services.Interfaces;
using Services.Models;
using System.Collections.Generic;
using Services.Services;

namespace Services.Test
{
    [TestClass]
    public class ServiceTest
    {
        private Mock<IRepository> _moqRepository;

        private IService _service;

        [TestInitialize]
        public void Initialize()
        {
            _moqRepository = new Mock<IRepository>();
            
        }
        [TestMethod]
        public void GetAllBandColors_must_call_getcolorBand_AtleastOnce()
        {
            // ARANGE
            _moqRepository.Setup(x => x.GetColorBand()).Returns(new List<ColorBand>());

            //ACT
            _service = new Service(_moqRepository.Object);
            _service.GetAllBandColors();

            _moqRepository.Verify(x => x.GetColorBand(), Times.AtLeastOnce);
        }

        [TestMethod]
        public void CalculateResistor_For_BandA_Empty_returns_NegativeOne()
        {
            // ARANGE
            var bandA = "";

            //ACT
            _service = new Service(_moqRepository.Object);
            var result=_service.CalculateResistor(String.Empty,"7","100","");

            //ASSERT
            Assert.AreEqual(-1, result);
        }
        [TestMethod]
        public void CalculateResistor_For_BandB_Empty_returns_NegativeOne()
        {
            // ARANGE
            var bandA = "";

            //ACT
            _service = new Service(_moqRepository.Object);
            var result = _service.CalculateResistor("7",String.Empty, "100", "");

            //ASSERT
            Assert.AreEqual(-1, result);
        }
        [TestMethod]
        public void CalculateResistor_For_ValidInputs_Return_valid_result()
        {
            // ARANGE
            _moqRepository.Setup(x => x.GetColorBand()).Returns(new List<ColorBand>()
            {
                new ColorBand()
                {
                    Code="GD",IsBandColor=false,Multiplier=100,Name="Gold",SignificantNumber="4",Tolerance=5.00M
                }
            });

            //ACT
            _service = new Service(_moqRepository.Object);
            var result = _service.CalculateResistor("7", "4", "100", "GD");

            //ASSERT
            Assert.IsTrue(result>0);
        }
    }
}
