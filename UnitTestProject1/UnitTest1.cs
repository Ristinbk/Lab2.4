using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab2;

namespace UnitTestProject1
{
    [TestClass]
    public abstract class UnitTestUnivercity
    {
        [TestClass]
        public class TestAddUnivercity
        {
            [TestMethod]
            public void AddGroups()
            {
                var testU = new Univercity("test");
                IGroup group1 = new Group(Specialty.Enrollee);
                IGroup group2 = new Group(Specialty.Service);
                testU.AddGroup(group1);
                testU.AddGroup(group2);
                CollectionAssert.Contains(testU.Groups, group1);
                CollectionAssert.Contains(testU.Groups, group2);
                Assert.IsTrue(testU.Groups.Count == 2);
            }

            [TestMethod]
            public void DoesNotAddSameGroups()
            {
                var testU = new Univercity("test");
                IGroup group1 = new Group(Specialty.Enrollee);
                IGroup sameTypeGroup = new Group(Specialty.Service);
                testU.AddGroup(group1);
                testU.AddGroup(sameTypeGroup);
                CollectionAssert.Contains(testU.Groups, group1);
                CollectionAssert.Contains(testU.Groups, sameTypeGroup);
                Assert.IsTrue(testU.Groups.Count == 1);
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentNullException))]
            public void ThrowsExcpetionNullArgument()
            {
                var u = new Univercity("test");
                Group group = null;
                u.AddGroup(group);
            }
        }

        [TestClass]
        public class TestAddStudents
        {
            [TestMethod]
            public void AddStudent()
            {
                var testU = new Univercity("test");
                IGroup group = new Group(Specialty.Enrollee);
                IPerson student1 = new Student(new FullName("Илья", "Иванов", "Андреевич"), new DateTime(2000, 12, 14), Gender.Male);
                IPerson student2 = new Student(new FullName("Иван", "Петров", "Олегович"), new DateTime(2001, 8, 11), Gender.Male);
                testU.AddGroup(group);
                testU.AddStudentInGroup(group.NumberGroup.ToString(), student1);
                testU.AddStudentInGroup(group.NumberGroup.ToString(), student1);
                CollectionAssert.Contains(testU.Groups[0].Persons, student1);
                CollectionAssert.Contains(testU.Groups[0].Persons, student2);
                Assert.IsTrue(testU.Groups[0].Persons.Count == 2);
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentNullException))]
            public void ThrowsExcpetionsNullArgument()
            {
                var u = new Univercity("test");
                Group group = null;
                u.AddGroup(group);
            }
        }

        [TestClass]
        public class TestAddTeachers
        {
            [TestMethod]
            public void AddTeacher()
            {
                var testU = new Univercity("test");
                IPerson teacher1 = new Student(new FullName("Илья", "Иванов", "Андреевич"), new DateTime(1989, 12, 14), Gender.Male);
                IPerson teacher2 = new Student(new FullName("Иван", "Петров", "Олегович"), new DateTime(1991, 8, 11), Gender.Male);                
                testU.AddTeacher(teacher1);
                testU.AddTeacher(teacher2);
                CollectionAssert.Contains(testU.Teachers, teacher1);
                CollectionAssert.Contains(testU.Teachers, teacher2);
                Assert.IsTrue(testU.Teachers.Count == 2);
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentNullException))]
            public void ThrowsExcpetionsNullArgument()
            {
                var u = new Univercity("test");
                IPerson teacher1 = new Student(new FullName("Иван", "Петров", "Олегович"), new DateTime(1991, 8, 11), Gender.Male);
                u.AddTeacher(teacher1);
            }
        }

        [TestClass]
        public class TestAddSession
        {
            [TestMethod]
            public void AddSession()
            {
                var testU = new Univercity("test");
                ISession sesion1 = new Session(SessionType.Winter, testU.Groups);
                ISession session2 = new Session(SessionType.Winter, testU.Groups);
                testU.AddSession(sesion1);
                testU.AddSession(session2);
                CollectionAssert.Contains(testU.Groups, sesion1);
                CollectionAssert.Contains(testU.Groups, session2);
                Assert.IsTrue(testU.Groups.Count == 2);
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentNullException))]
            public void ThrowsExcpetionsNullArgument()
            {
                var u = new Univercity("test");
                ISession sesion1 = new Session(SessionType.Winter, u.Groups);
                u.AddSession(sesion1);
            }
        }
    }
}
