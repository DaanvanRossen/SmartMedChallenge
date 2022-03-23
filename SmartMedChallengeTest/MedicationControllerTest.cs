using Xunit;
using SmartMedChallenge.Controllers;
using SmartMedChallenge.Models;
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace SmartMedChallengeTest
{
    public class MedicationControllerTest
    {

        [Fact]
        public void InsertMedicationGoodRequestTest()
        {
            DateTime now = DateTime.Now;
            Medication medication = new Medication("Test", 35, now);
            MedicationController controller = new MedicationController();

            var result = controller.InsertMedication(medication);
            var okResult = result as OkResult;

            Assert.NotNull(okResult);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }
    }
}