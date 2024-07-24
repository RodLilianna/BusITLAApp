using BusITLAApp.Data.Entities;
using NUnit.Framework;

namespace BusITLAApp.Data.Test
{
    [TestFixture]
    public class CourseTests
    {
        private List<Course> _fakeCourses;

        [SetUp]
        public void SetUp()
        {
            _fakeCourses = new List<Course>
            {
                new Course
                {
                    Id = 1,
                    Title = "Course 1",
                    TicketId = 1,
                    Description = "Description 1",
                    Credits = 3
                },
                new Course
                {
                    Id = 2,
                    Title = "Course 2",
                    TicketId = 2,
                    Description = "Description 2",
                    Credits = 4
                },
                new Course
                {
                    Id = 3,
                    Title = "Course 3",
                    TicketId = 3,
                    Description = "Description 3",
                    Credits = 5
                }
            };
        }

        [Test]
        public void FakeCourses_ListCount_ShouldBe3()
        {
            Assert.That(_fakeCourses.Count, Is.EqualTo(3), "The list should contain 3 elements.");
        }

        [Test]
        public void FakeCourses_UniqueIds_ShouldBeUnique()
        {
            var ids = _fakeCourses.Select(c => c.Id).ToList();
            Assert.That(ids.Distinct().Count(), Is.EqualTo(ids.Count), "The IDs should be unique.");
        }

        [Test]
        public void FakeCourses_Titles_ShouldNotBeNullOrEmpty()
        {
            foreach (var course in _fakeCourses)
            {
                Assert.That(course.Title, Is.Not.Null.Or.Empty, "The Title should not be null or empty.");
            }
        }

        [Test]
        public void FakeCourses_Descriptions_ShouldNotBeNullOrEmpty()
        {
            foreach (var course in _fakeCourses)
            {
                Assert.That(course.Description, Is.Not.Null.Or.Empty, "The Description should not be null or empty.");
            }
        }

        [Test]
        public void FakeCourses_Credits_ShouldBeGreaterThanZero()
        {
            foreach (var course in _fakeCourses)
            {
                Assert.That(course.Credits, Is.GreaterThan(0), "The Credits should be greater than 0.");
            }
        }

        [Test]
        public void FakeCourses_DepartmentIds_ShouldBeGreaterThanZero()
        {
            foreach (var course in _fakeCourses)
            {
                Assert.That(course.TicketId, Is.GreaterThan(0), "The DepartmentId should be greater than 0.");
            }
        }

        [Test]
        public void FakeCourses_Titles_ShouldNotContainOnlyWhitespace()
        {
            foreach (var course in _fakeCourses)
            {
                Assert.That(course.Title?.Trim(), Is.Not.Empty, "The Title should not contain only whitespace.");
            }
        }

        [Test]
        public void FakeCourses_Credits_ShouldNotExceedSix()
        {
            foreach (var course in _fakeCourses)
            {
                Assert.That(course.Credits, Is.LessThanOrEqualTo(6), "The Credits should not exceed 6.");
            }
        }

        [Test]
        public void FakeCourses_SumOfCredits_ShouldBeEqualTo12()
        {
            var totalCredits = _fakeCourses.Sum(c => c.Credits);
            Assert.That(totalCredits, Is.EqualTo(12), "The total Credits should be equal to 12.");
        }

        [Test]
        public void FakeCourses_Descriptions_ShouldNotBeEmpty()
        {
            foreach (var course in _fakeCourses)
            {
                Assert.That(course.Description, Is.Not.Empty, "The Description should not be empty.");
            }
        }
    }
}
