using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab2;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public abstract class UnitTestUnivercity
    {
        [TestClass]
        public class TestAddEntrant
        {
            [TestMethod]
            public void AddEntrants()
            {
                Univercity U = new Univercity("test");
                IPerson person1 = new Entrant(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Gender.Male);
                IPerson person2 = new Entrant(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Gender.Female);
                int result = 2;

                U.AddEntrant(person1);
                U.AddEntrant(person2);

                CollectionAssert.Contains(U.Entrants, person1);
                CollectionAssert.Contains(U.Entrants, person2);
                Assert.AreEqual(U.Entrants.Count, result);
            }
        }

        [TestClass]
        public class TestAddTeacher
        {
            [TestMethod]
            public void AddTeachers()
            {
                Univercity U = new Univercity("test");
                IPerson person1 = new Teacher(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Gender.Male, Title.Lecture);
                IPerson person2 = new Teacher(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Gender.Female, Title.Professor);
                int result = 2;

                U.AddTeacher(person1);
                U.AddTeacher(person2);

                CollectionAssert.Contains(U.Teachers, person1);
                CollectionAssert.Contains(U.Teachers, person2);
                Assert.AreEqual(U.Teachers.Count, result);
            }
        }

        [TestClass]
        public class TestAddSubject
        {
            [TestMethod]
            public void AddSubjects()
            {
                Univercity U = new Univercity("test");
                ISubject subject1 = new Subject("test", SubjectType.Credited);
                ISubject subject2 = new Subject("test2", SubjectType.Exem);
                int result = 2;

                U.AddSubject(subject1);
                U.AddSubject(subject2);

                CollectionAssert.Contains(U.Subjects, subject1);
                CollectionAssert.Contains(U.Subjects, subject2);
                Assert.AreEqual(U.Subjects.Count, result);
            }

            [TestMethod]
            public void NotAddSubjects()
            {
                Univercity U = new Univercity("test");
                ISubject subject1 = new Subject("test", SubjectType.Credited);
                ISubject subject2 = new Subject("test", SubjectType.Exem);
                int result = 1;

                U.AddSubject(subject1);
                U.AddSubject(subject2);

                CollectionAssert.Contains(U.Subjects, subject1);
                CollectionAssert.DoesNotContain(U.Subjects, subject2);
                Assert.AreEqual(U.Subjects.Count, result);
            }
        }

        [TestClass]
        public class TestAddGroup
        {
            [TestMethod]
            public void AddGroups()
            {
                Univercity U = new Univercity("test");
                IGroup group1 = new Group(new NumberGroup(Specialty.Service, DateTime.Now.Year));
                IGroup group2 = new Group(new NumberGroup(Specialty.StateAudit, DateTime.Now.Year));
                int result = 2;

                U.AddGroup(group1);
                U.AddGroup(group2);

                CollectionAssert.Contains(U.Groups, group1);
                CollectionAssert.Contains(U.Groups, group2);
                Assert.AreEqual(U.Groups.Count, result);
            }

            [TestMethod]
            public void NotAddGroups()
            {
                Univercity U = new Univercity("test");
                IGroup group1 = new Group(new NumberGroup(Specialty.Service, 2018));
                IGroup group2 = new Group(new NumberGroup(Specialty.Service, 2018));
                int result = 1;

                U.AddGroup(group1);
                U.AddGroup(group2);

                CollectionAssert.Contains(U.Groups, group1);
                CollectionAssert.DoesNotContain(U.Groups, group2);
                Assert.AreEqual(U.Groups.Count, result);
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentNullException))]
            public void ThrowsExcpetionNullArgument()
            {
                Univercity U = new Univercity("test");
                Group group = null;
                U.AddGroup(group);
            }
        }

        [TestClass]
        public class TestAddSession
        {
            [TestMethod]
            public void AddSessions()
            {
                Univercity U = new Univercity("test");
                ISession session1 = new Session(SessionType.Winter, DateTime.Now.Year, Specialty.Service);
                ISession session2 = new Session(SessionType.Summer, DateTime.Now.Year, Specialty.StateAudit);
                int result = 2;

                U.AddSession(session1);
                U.AddSession(session2);

                CollectionAssert.Contains(U.Sessions, session1);
                CollectionAssert.Contains(U.Sessions, session2);
                Assert.AreEqual(U.Sessions.Count, result);
            }

            [TestMethod]
            public void NotAddSessions()
            {
                Univercity U = new Univercity("test");
                ISession session1 = new Session(SessionType.Winter, DateTime.Now.Year, Specialty.Service);
                ISession session2 = new Session(SessionType.Winter, DateTime.Now.Year, Specialty.Service);
                ISession session3 = new Session(SessionType.Summer, DateTime.Now.Year, Specialty.Service);
                int result = 2;

                U.AddSession(session1);
                U.AddSession(session2);
                U.AddSession(session3);

                CollectionAssert.Contains(U.Sessions, session1);
                CollectionAssert.DoesNotContain(U.Sessions, session2);
                CollectionAssert.Contains(U.Sessions, session3);
                Assert.AreEqual(U.Sessions.Count, result);
            }
        }

        [TestClass]
        public class TestMoveEntrantInGroup
        {
            [TestMethod]
            public void MoveEntrantInGroup()
            {
                Univercity U = new Univercity("test");
                IGroup group = new Group(new NumberGroup(Specialty.Service, DateTime.Now.Year));
                IPerson person1 = new Entrant(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Gender.Male);
                IPerson person2 = new Entrant(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Gender.Female);
                string ng = group.NumberGroup.ToString();
                string id1 = person1.Id.ToString();
                string id2 = person2.Id.ToString();
                int result = 2;

                U.AddGroup(group);
                U.AddEntrant(person1);
                U.AddEntrant(person2);
                U.MoveEntrantInGroup(ng, id1);
                U.MoveEntrantInGroup(ng, id2);

                Assert.AreEqual(group.Persons.Count, result);
            }
        }

        [TestClass]
        public class TestAddSubjectToTeacher
        {
            [TestMethod]
            public void AddSubjectToTeacher()
            {
                Univercity U = new Univercity("test");
                ISubject subject1 = new Subject("test", SubjectType.Credited);
                ISubject subject2 = new Subject("test2", SubjectType.Exem);
                IPerson person = new Teacher(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Gender.Male, Title.Lecture);
                string ns1 = subject1.NameSubject.ToString();
                string ns2 = subject2.NameSubject.ToString();
                string id = person.Id.ToString();
                int result = 2;
                string result2 = person.Name.ToString();

                U.AddSubject(subject1);
                U.AddSubject(subject2);
                U.AddTeacher(person);

                U.AddSubjectToTeacher(id, ns1);
                U.AddSubjectToTeacher(id, ns2);

                Assert.AreEqual(person.Subjects.Count, result);
            }

            [TestMethod]
            public void AddTeacherToSubject()
            {
                Univercity U = new Univercity("test");
                ISubject subject1 = new Subject("test", SubjectType.Credited);
                ISubject subject2 = new Subject("test2", SubjectType.Exem);
                IPerson person = new Teacher(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Gender.Male, Title.Lecture);
                string ns1 = subject1.NameSubject.ToString();
                string ns2 = subject2.NameSubject.ToString();
                string id = person.Id.ToString();
                string result = person.Name.ToString();

                U.AddSubject(subject1);
                U.AddSubject(subject2);
                U.AddTeacher(person);

                U.AddSubjectToTeacher(id, ns1);
                U.AddSubjectToTeacher(id, ns2);

                Assert.AreEqual(subject1.NameTeacher.ToString(), result);
                Assert.AreEqual(subject2.NameTeacher.ToString(), result);
            }
        }

        [TestClass]
        public class TestMoveToAnotherGroup
        {
            [TestMethod]
            public void MoveToAnotherGroup()
            {
                Univercity U = new Univercity("test");
                IGroup group1 = new Group(new NumberGroup(Specialty.Service, DateTime.Now.Year));
                IGroup group2 = new Group(new NumberGroup(Specialty.StateAudit, DateTime.Now.Year));
                IPerson person1 = new Entrant(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Gender.Male);
                IPerson person2 = new Entrant(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Gender.Female);
                string ng1 = group1.NumberGroup.ToString();
                string ng2 = group2.NumberGroup.ToString();
                string id1 = person1.Id.ToString();
                string id2 = person2.Id.ToString();
                int result = 1;

                U.AddGroup(group1);
                U.AddGroup(group2);
                U.AddEntrant(person1);
                U.AddEntrant(person2);
                U.MoveEntrantInGroup(ng1, id1);
                U.MoveEntrantInGroup(ng1, id2);
                string idg = group1.Persons[0].Id.ToString();
                U.MoveToAnotherGroup(idg, ng1, ng2);

                Assert.AreEqual(group1.Persons.Count, result);
                Assert.AreEqual(group2.Persons.Count, result);
            }
        }

        [TestClass]
        public class TestRemoveEntrant
        {
            [TestMethod]
            public void RemoveEntrant()
            {
                Univercity U = new Univercity("test");
                IPerson person1 = new Entrant(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Gender.Male);
                IPerson person2 = new Entrant(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Gender.Female);
                string id1 = person2.Id.ToString();
                int result = 1;

                U.AddEntrant(person1);
                U.AddEntrant(person2);
                U.RemoveEntrant(id1);

                CollectionAssert.Contains(U.Entrants, person1);
                CollectionAssert.DoesNotContain(U.Entrants, person2);
                Assert.AreEqual(U.Entrants.Count, result);
            }
        }

        [TestClass]
        public class TestRemoveTeacher
        {
            [TestMethod]
            public void RemoveTeachers()
            {
                Univercity U = new Univercity("test");
                IPerson person1 = new Teacher(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Gender.Male, Title.Lecture);
                IPerson person2 = new Teacher(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Gender.Female, Title.Professor);
                string id2 = person2.Id.ToString();
                int result = 1;

                U.AddTeacher(person1);
                U.AddTeacher(person2);
                U.RemoveTeacher(id2);

                CollectionAssert.Contains(U.Teachers, person1);
                CollectionAssert.DoesNotContain(U.Teachers, person2);
                Assert.AreEqual(U.Teachers.Count, result);
            }
        }

        [TestClass]
        public class TestRemoveSubject
        {
            [TestMethod]
            public void RemoveSubjects()
            {
                Univercity U = new Univercity("test");
                ISubject subject1 = new Subject("test", SubjectType.Credited);
                ISubject subject2 = new Subject("test2", SubjectType.Exem);
                string ns2 = subject2.NameSubject.ToString();
                int result = 1;

                U.AddSubject(subject1);
                U.AddSubject(subject2);
                U.RemoveSubject(ns2);

                CollectionAssert.Contains(U.Subjects, subject1);
                CollectionAssert.DoesNotContain(U.Subjects, subject2);
                Assert.AreEqual(U.Subjects.Count, result);
            }
        }

        [TestClass]
        public class TestRemoveGroup
        {
            [TestMethod]
            public void RemoveGroups()
            {
                Univercity U = new Univercity("test");
                IGroup group1 = new Group(new NumberGroup(Specialty.Service, DateTime.Now.Year));
                IGroup group2 = new Group(new NumberGroup(Specialty.StateAudit, DateTime.Now.Year));
                string ng2 = group2.NumberGroup.ToString();
                int result = 1;

                U.AddGroup(group1);
                U.AddGroup(group2);
                U.RemoveGroup(ng2);

                CollectionAssert.Contains(U.Groups, group1);
                CollectionAssert.DoesNotContain(U.Groups, group2);
                Assert.AreEqual(U.Groups.Count, result);
            }
        }

        [TestClass]
        public class TestRemoveSession
        {
            [TestMethod]
            public void RemoveSessions()
            {
                Univercity U = new Univercity("test");
                ISession session1 = new Session(SessionType.Winter, DateTime.Now.Year, Specialty.Service);
                ISession session2 = new Session(SessionType.Summer, DateTime.Now.Year, Specialty.StateAudit);
                string s2 = session2.ToString();
                int result = 1;

                U.AddSession(session1);
                U.AddSession(session2);
                U.RemoveSession(s2);

                CollectionAssert.Contains(U.Sessions, session1);
                CollectionAssert.DoesNotContain(U.Sessions, session2);
                Assert.AreEqual(U.Sessions.Count, result);
            }
        }

        [TestClass]
        public class TestShowPersonInGroup
        {
            [TestMethod]
            public void ShowPersonInGroup()
            {
                Univercity U = new Univercity("test");
                IGroup group = new Group(new NumberGroup(Specialty.Service, DateTime.Now.Year));
                IPerson person1 = new Entrant(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Gender.Male);
                IPerson person2 = new Entrant(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Gender.Female);
                string ng = group.NumberGroup.ToString();
                string id1 = person1.Id.ToString();
                string id2 = person2.Id.ToString();

                U.AddGroup(group);
                U.AddEntrant(person1);
                U.AddEntrant(person2);
                U.MoveEntrantInGroup(ng, id1);
                U.MoveEntrantInGroup(ng, id2);
                U.ShowPersonsInGroup(ng);
            }
        }

        [TestClass]
        public class TestShowResultOfSession
        {
            [TestMethod]
            public void ShowResultOfSession()
            {
                Univercity U = new Univercity("test");
                IGroup group = new Group(new NumberGroup(Specialty.Service, DateTime.Now.Year));
                IPerson person1 = new Entrant(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Gender.Male);
                IPerson person2 = new Entrant(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Gender.Female);
                ISession session = new Session(SessionType.Winter, DateTime.Now.Year, Specialty.Service);
                ISubject subject = new Subject("test", SubjectType.Credited);
                string ng = group.NumberGroup.ToString();
                string id1 = person1.Id.ToString();
                string id2 = person2.Id.ToString();
                string s = session.ToString();
                string sn = subject.ToString();

                U.AddGroup(group);
                U.AddEntrant(person1);
                U.AddEntrant(person2);
                U.AddSession(session);
                U.AddSubject(subject);
                U.MoveEntrantInGroup(ng, id1);
                U.MoveEntrantInGroup(ng, id2);
                U.ShowResultOfSession(s, ng, sn);
            }
        }

        [TestClass]
        public class TestMoveResultSubject
        {
            [TestMethod]
            public void MoveResultSubject()
            {
                Univercity U = new Univercity("test");
                IGroup group = new Group(new NumberGroup(Specialty.Service, DateTime.Now.Year));
                IPerson person = new Entrant(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Gender.Male);
                ISession session = new Session(SessionType.Winter, DateTime.Now.Year, Specialty.Service);
                ISubject subject = new Subject("test", SubjectType.Credited);
                string ng = group.NumberGroup.ToString();
                string id = person.Id.ToString();
                string s = session.ToString();
                string sn = subject.ToString();
                Assessment a = Assessment.Five;

                U.AddGroup(group);
                U.AddEntrant(person);
                U.AddSession(session);
                U.AddSubject(subject);
                U.MoveEntrantInGroup(ng, id);
                session.AddSubjects(group, U.Subjects);

                U.MoveResultSubject(s, ng, sn, a);
            }
        }
    }

    [TestClass]
    public abstract class UnitTestPerson
    {
        [TestClass]
        public class TestAddSubject
        {
            [TestMethod]
            public void AddSubject()
            {
                Univercity U = new Univercity("test");
                ISubject subject1 = new Subject("test", SubjectType.Credited);
                ISubject subject2 = new Subject("test2", SubjectType.Exem);
                IGroup group = new Group(new NumberGroup(Specialty.Service, DateTime.Now.Year));
                var ng = group.NumberGroup;
                var id = new Id(ng, new Id());
                IPerson person1 = new Entrant(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Gender.Male);
                IPerson person2 = new Student(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Gender.Male, id);
                string id1 = person1.Id.ToString();
                string id2 = person2.Id.ToString();
                string ns1 = subject1.NameSubject.ToString();
                string ns2 = subject2.NameSubject.ToString();

                U.AddGroup(group);
                U.AddEntrant(person1);
                group.AddPerson(person2);
                person1.AddSubject(subject1);
                person1.AddSubject(subject2);
                person2.AddSubject(subject1);

                ReferenceEquals(person1.Subjects, subject1);
                ReferenceEquals(person1.Subjects, subject2);
                ReferenceEquals(person2.Subjects, subject1);
            }
        }
    }

    [TestClass]
    public abstract class UnitTestEntrant
    {
        [TestClass]
        public class TestAddAssessment
        {
            [TestMethod]
            public void AddAssessment()
            {
                Univercity U = new Univercity("test");
                IPerson person = new Entrant(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Gender.Male);
                ISession session = new Session(SessionType.Winter, DateTime.Now.Year, Specialty.Service);
                ISubject subject = new Subject("test", SubjectType.Credited);
                string ns = subject.ToString();
                string s = session.ToString();
                Assessment a = Assessment.Four;

                U.AddEntrant(person);
                U.AddSession(session);
                U.AddSubject(subject);
                session.AddSubjects(person, U.Subjects);
                session.MoveToSubjectAssessment(person, subject, a);
                var result = person.Subjects.Where(e => e.Assessment.Equals(a));

                ReferenceEquals(person.Subjects, result);
            }
        }
    }

    [TestClass]
    public abstract class UnitTestStudent
    {
        [TestClass]
        public class TestAddStudents
        {
            [TestMethod]
            public void AddStudents()
            {
                Univercity U = new Univercity("test");
                IGroup group = new Group(new NumberGroup(Specialty.Service, DateTime.Now.Year));
                var ng = group.NumberGroup;
                var id = new Id(ng, new Id());
                IPerson person1 = new Student(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Gender.Male, id);
                IPerson person2 = new Student(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Gender.Female, id);
                int result = 2;

                U.AddGroup(group);
                group.AddPerson(person1);
                group.AddPerson(person2);

                CollectionAssert.Contains(group.Persons, person1);
                CollectionAssert.Contains(group.Persons, person2);
                Assert.AreEqual(group.Persons.Count, result);
            }
        }

        [TestClass]
        public class TestAddAssessment
        {
            [TestMethod]
            public void AddAssessment()
            {
                Univercity U = new Univercity("test");
                IGroup group = new Group(new NumberGroup(Specialty.Service, DateTime.Now.Year));
                var ng = group.NumberGroup;
                var id = new Id(ng, new Id());
                IPerson person = new Student(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Gender.Male, id);
                ISubject subject = new Subject("test", SubjectType.Credited);
                ISession session = new Session(SessionType.Winter, DateTime.Now.Year, Specialty.Service);
                string s = session.ToString();
                Assessment a = Assessment.Four;

                U.AddGroup(group);
                group.AddPerson(person);
                U.AddSession(session);
                U.AddSubject(subject);
                session.AddSubjects(group, U.Subjects);
                session.MoveToSubjectAssessment(person, subject, a);
                var result = person.Subjects.Where(e => e.Assessment.Equals(a));

                ReferenceEquals(person.Subjects, result);
            }
        }
    }

    [TestClass]
    public abstract class UnitTestTeacher
    {
        [TestClass]
        public class TestAddSubject
        {
            [TestMethod]
            public void AddSubject()
            {
                Univercity U = new Univercity("test");
                IPerson person = new Teacher(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Gender.Male, Title.Lecture);
                Subject subject1 = new Subject("test", SubjectType.Credited);
                ISubject subject2 = new Subject("test2", SubjectType.Exem);
                int result = 2;

                U.AddTeacher(person);
                U.AddSubject(subject1);
                U.AddSubject(subject2);

                person.AddSubject(subject1);
                person.AddSubject(subject2);

                CollectionAssert.Contains(U.Subjects, subject1);
                CollectionAssert.Contains(U.Subjects, subject2);
                Assert.AreEqual(person.Subjects.Count, result);
            }
        }
    }

    [TestClass]
    public abstract class UnitTestGroup
    {
        [TestClass]
        public class TestAddPerson
        {
            [TestMethod]
            public void AddPerson()
            {
                Univercity U = new Univercity("test");
                IGroup group = new Group(new NumberGroup(Specialty.Service, DateTime.Now.Year));
                var ng = group.NumberGroup;
                var id = new Id(ng, new Id());
                IPerson person1 = new Student(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Gender.Male, id);
                IPerson person2 = new Student(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Gender.Female, id);
                int result = 2;

                U.AddGroup(group);
                group.AddPerson(person1);
                group.AddPerson(person2);

                CollectionAssert.Contains(group.Persons, person1);
                CollectionAssert.Contains(group.Persons, person2);
                Assert.AreEqual(group.Persons.Count, result);
            }
        }

        [TestClass]
        public class TestRemovePerson
        {
            [TestMethod]
            public void RemovePerson()
            {
                Univercity U = new Univercity("test");
                IGroup group = new Group(new NumberGroup(Specialty.Service, DateTime.Now.Year));
                var ng = group.NumberGroup;
                var id = new Id(ng, new Id());
                var id2 = new Id(ng, new Id());
                IPerson person1 = new Student(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Gender.Male, id);
                IPerson person2 = new Student(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Gender.Female, id2);
                string id3 = person2.Id.ToString();
                int result = 1;

                U.AddGroup(group);
                group.AddPerson(person1);
                group.AddPerson(person2);
                group.RemovePerson(id3);

                CollectionAssert.Contains(group.Persons, person1);
                CollectionAssert.DoesNotContain(group.Persons, person2);
                Assert.AreEqual(group.Persons.Count, result);
            }
        }

        [TestClass]
        public class TestGetPerson
        {
            [TestMethod]
            public void GetPerson()
            {
                Univercity U = new Univercity("test");
                IGroup group = new Group(new NumberGroup(Specialty.Service, DateTime.Now.Year));
                var ng = group.NumberGroup;
                var id = new Id(ng, new Id());
                IPerson person = new Student(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Gender.Male, id);
                string id1 = person.Id.ToString();
                int result = 1;

                U.AddGroup(group);
                group.AddPerson(person);
                var g = group.GetPerson(id1);

                CollectionAssert.Contains(group.Persons, g);
                Assert.AreEqual(group.Persons.Count, result);
            }
        }

        [TestClass]
        public class TestEquals
        {
            [TestMethod]
            public void TrueEqual()
            {
                Univercity U = new Univercity("test");
                IGroup group = new Group(new NumberGroup(Specialty.Service, DateTime.Now.Year));
                var ng = group.NumberGroup;
                var id = new Id(ng, new Id());
                IPerson person = new Student(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Gender.Male, id);

                U.AddGroup(group);
                group.AddPerson(person);
                var result = person.Equals(person);

                Assert.IsTrue(result);
            }

            [TestMethod]
            public void FalseEqual()
            {
                Univercity U = new Univercity("test");
                IGroup group = new Group(new NumberGroup(Specialty.Service, DateTime.Now.Year));
                var ng = group.NumberGroup;
                var id1 = new Id(ng, new Id());
                var id2 = new Id(ng, new Id());
                IPerson person1 = new Student(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Gender.Male, id1);
                IPerson person2 = new Student(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Gender.Male, id2);

                U.AddGroup(group);
                group.AddPerson(person1);
                group.AddPerson(person2);
                var result = person1.Equals(person2);

                Assert.IsFalse(result);
            }

            [TestMethod]
            public void FalseOneArgumentIsNull()
            {
                Univercity U = new Univercity("test");
                IGroup group = new Group(new NumberGroup(Specialty.Service, DateTime.Now.Year));
                var ng = group.NumberGroup;
                var id1 = new Id(ng, new Id());
                IPerson person1 = new Student(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Gender.Male, id1);
                IPerson person2 = null;

                U.AddGroup(group);
                group.AddPerson(person1);
                var result = person1.Equals(person2);

                Assert.IsFalse(result);
            }
        }
    }


    [TestClass]
    public abstract class UnitTestSubject
    {
        [TestClass]
        public class TestAddTeacher
        {
            [TestMethod]
            public void AddTeacher()
            {
                Univercity U = new Univercity("test");
                IPerson person = new Teacher(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Gender.Male, Title.Lecture);
                ISubject subject = new Subject("test", SubjectType.Credited);
                var result = person.Name;

                U.AddTeacher(person);
                U.AddSubject(subject);

                subject.AddTeacher(person);

                ReferenceEquals(subject.NameTeacher, result);
            }
        }

        [TestClass]
        public class TestGetSubject
        {
            [TestMethod]
            public void GetSubject()
            {
                Univercity U = new Univercity("test");
                IPerson person = new Teacher(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Gender.Male, Title.Lecture);
                ISubject subject = new Subject("test", SubjectType.Credited);

                U.AddTeacher(person);
                U.AddSubject(subject);
                var result = subject.GetSubject(subject);

                ReferenceEquals(subject, result);
            }
        }

        [TestClass]
        public class TestEquals
        {
            [TestMethod]
            public void TrueEqual()
            {
                Univercity U = new Univercity("test");
                IPerson person = new Teacher(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Gender.Male, Title.Lecture);

                U.AddTeacher(person);
                var result = person.Equals(person);

                Assert.IsTrue(result);
            }

            [TestMethod]
            public void FalseEqual()
            {
                Univercity U = new Univercity("test");
                IPerson person1 = new Teacher(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Gender.Male, Title.Lecture);
                IPerson person2 = new Teacher(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Gender.Male, Title.Lecture);

                U.AddTeacher(person1);
                U.AddTeacher(person2);
                var result = person1.Equals(person2);
                Assert.IsFalse(result);
            }

            [TestMethod]
            public void FalseOneArgumentIsNull()
            {
                Univercity U = new Univercity("test");
                IPerson person1 = new Teacher(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Gender.Male, Title.Lecture);
                IPerson person2 = null;

                U.AddTeacher(person1);
                var result = person1.Equals(person2);

                Assert.IsFalse(result);
            }
        }
    }

    [TestClass]
    public abstract class UnitTestSession
    {
        [TestClass]
        public class TestAddSubjects
        {
            [TestMethod]
            public void AddSubjects()
            {
                Univercity U = new Univercity("test");
                ISession session = new Session(SessionType.Winter, DateTime.Now.Year, Specialty.Service);
                ISubject subject1 = new Subject("test", SubjectType.Credited);
                ISubject subject2 = new Subject("test2", SubjectType.Credited);
                IGroup group = new Group(new NumberGroup(Specialty.Service, DateTime.Now.Year));
                var ng = group.NumberGroup;
                var id = new Id(ng, new Id());
                IPerson person = new Student(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Gender.Male, id);
                int result = 2;

                U.Groups.Add(group);
                group.AddPerson(person);
                U.Sessions.Add(session);
                U.Subjects.Add(subject1);
                U.Subjects.Add(subject2);
                session.AddSubjects(group, U.Subjects);

                Assert.AreEqual(session.Subjects.Count, result);
            }
        }

        [TestClass]
        public class TestAddSubject
        {
            [TestMethod]
            public void AddSubject()
            {
                Univercity U = new Univercity("test");
                ISession session = new Session(SessionType.Winter, DateTime.Now.Year, Specialty.Service);
                ISubject subject1 = new Subject("test", SubjectType.Credited);
                ISubject subject2 = new Subject("test2", SubjectType.Credited);
                IGroup group = new Group(new NumberGroup(Specialty.Service, DateTime.Now.Year));
                var ng = group.NumberGroup;
                var id = new Id(ng, new Id());
                IPerson person = new Student(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Gender.Male, id);
                int result = 2;

                U.Groups.Add(group);
                group.AddPerson(person);
                U.Sessions.Add(session);
                U.Subjects.Add(subject1);
                U.Subjects.Add(subject2);
                session.AddSubjects(person, U.Subjects);

                Assert.AreEqual(session.Subjects.Count, result);
            }
        }

        [TestClass]
        public class TestMoveToGroupSession
        {
            [TestMethod]
            public void MoveToGroupSession()
            {
                Univercity U = new Univercity("test");
                ISession session = new Session(SessionType.Winter, DateTime.Now.Year, Specialty.Service);
                ISubject subject = new Subject("test", SubjectType.Credited);
                IGroup group = new Group(new NumberGroup(Specialty.Service, DateTime.Now.Year));
                var ng = group.NumberGroup;
                var id = new Id(ng, new Id());
                IPerson person = new Student(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Gender.Male, id);
                Assessment a = Assessment.Four;

                U.Groups.Add(group);
                group.AddPerson(person);
                U.Sessions.Add(session);
                U.Subjects.Add(subject);
                session.AddSubjects(person, U.Subjects);

                session.MoveToSubjectAssessment(person, subject, a);
            }
        }

        [TestClass]
        public class TestEquals
        {
            [TestMethod]
            public void TrueEqual()
            {
                Univercity U = new Univercity("test");
                ISession session = new Session(SessionType.Winter, DateTime.Now.Year, Specialty.Service);
                ISubject subject = new Subject("test", SubjectType.Credited);

                U.Sessions.Add(session);
                var result = session.Equals(session);

                Assert.IsTrue(result);
            }

            [TestMethod]
            public void FalseEqual()
            {
                Univercity U = new Univercity("test");
                ISession session1 = new Session(SessionType.Winter, DateTime.Now.Year, Specialty.Service);
                ISession session2 = new Session(SessionType.Summer, DateTime.Now.Year, Specialty.Service);
                ISubject subject = new Subject("test", SubjectType.Credited);

                U.Sessions.Add(session1);
                U.Sessions.Add(session2);
                var result = session1.Equals(session2);

                Assert.IsFalse(result);
            }

            [TestMethod]
            public void FalseOneArgumentIsNull()
            {
                Univercity U = new Univercity("test");
                ISession session1 = new Session(SessionType.Winter, DateTime.Now.Year, Specialty.Service);
                ISession session2 = null;

                U.Sessions.Add(session1);
                U.Sessions.Add(session2);
                var result = session1.Equals(session2); 

                Assert.IsFalse(result);
            }
        }
    }
}


