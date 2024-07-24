using BusITLAApp.Data.Entities;
using NUnit.Framework;


namespace BusITLAApp.Data.Test
{
    [TestFixture]
    public class DepartmentTests
    {
        private List<Ticket> _fakeResults;

        [SetUp]
        public void SetUp()
        {
            _fakeResults = new List<Ticket>
            {
                new Ticket
                {
                    Id = 1,
                    Name = "Test 1",
                    Administrador = 1,
                    StartTime = DateTime.Now,
                    Budget = 5
                },
                new Ticket
                {
                    Id = 2,
                    Name = "Test 2",
                    Administrador = 2,
                    StartTime = DateTime.Now,
                    Budget = 4
                },
                new Ticket
                {
                    Id = 3,
                    Name = "Test 3",
                    Administrador = 3,
                    StartTime = DateTime.Now,
                    Budget = 2
                }
            };
        }

        [Test]
        public void FakeResults_ListCount_ShouldBe3()
        {
            Assert.That(_fakeResults.Count, Is.EqualTo(3), "The list should contain 3 elements.");
        }

        [Test]
        public void FakeResults_UniqueIds_ShouldBeUnique()
        {
            var ids = _fakeResults.Select(d => d.Id).ToList();
            Assert.That(ids.Distinct().Count(), Is.EqualTo(ids.Count), "The IDs should be unique.");
        }

        [Test]
        public void FakeResults_Names_ShouldNotBeNullOrEmpty()
        {
            foreach (var department in _fakeResults)
            {
                Assert.That(department.Name, Is.Not.Null.Or.Empty, "The Name should not be null or empty.");
            }
        }

        [Test]
        public void FakeResults_Budgets_ShouldBeGreaterThanZero()
        {
            foreach (var department in _fakeResults)
            {
                Assert.That(department.Budget, Is.GreaterThan(0), "The Budget should be greater than 0.");
            }
        }

        [Test]
        public void FakeResults_AdministradorIds_ShouldBeGreaterThanZero()
        {
            foreach (var department in _fakeResults)
            {
                Assert.That(department.Administrador, Is.GreaterThan(0), "The Administrador ID should be greater than 0.");
            }
        }

        [Test]
        public void FakeResults_Names_ShouldNotContainOnlyWhitespace()
        {
            foreach (var department in _fakeResults)
            {
                Assert.That(department.Name.Trim(), Is.Not.Empty, "The Name should not contain only whitespace.");
            }
        }

        [Test]
        public void FakeResults_StartTime_ShouldNotBeInTheFuture()
        {
            foreach (var department in _fakeResults)
            {
                Assert.That(department.StartTime, Is.LessThanOrEqualTo(DateTime.Now), "The StartTime should not be in the future.");
            }
        }

        [Test]
        public void FakeResults_Ids_ShouldBeGreaterThanZero()
        {
            foreach (var department in _fakeResults)
            {
                Assert.That(department.Id, Is.GreaterThan(0), "The ID should be greater than 0.");
            }
        }

        [Test]
        public void FakeResults_Budgets_ShouldNotExceedTen()
        {
            foreach (var department in _fakeResults)
            {
                Assert.That(department.Budget, Is.LessThanOrEqualTo(10), "The Budget should not exceed 10.");
            }
        }

        [Test]
        public void FakeResults_BudgetSum_ShouldBeEqualTo11()
        {
            var totalBudget = _fakeResults.Sum(d => d.Budget);
            Assert.That(totalBudget, Is.EqualTo(11), "The total Budget should be equal to 11.");
        }
    }
}
