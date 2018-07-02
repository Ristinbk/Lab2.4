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
        public class TestAddStudent
        {
            [TestMethod]
            public void AddEntrants()
            {
                Univercity U = new Univercity("test");
                IStudent student1 = new Student(new FullName("test", "test", "test"), new DateTime(2000, 12, 14));
                IStudent student2 = new Student(new FullName("test", "test", "test"), new DateTime(2000, 12, 14));
                int result = 2;

                U.AddStudent(student1);
                U.AddStudent(student2);

                CollectionAssert.Contains(U.Students, student1);
                CollectionAssert.Contains(U.Students, student2);
                Assert.AreEqual(U.Students.Count, result);
            }
        }

        [TestClass]
        public class TestAddTeacher
        {
            [TestMethod]
            public void AddTeachers()
            {
                Univercity U = new Univercity("test");
                ITeacher teacher = new Teacher(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Title.Lecture);
                ITeacher teacher2 = new Teacher(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Title.Professor);
                int result = 2;

                U.AddTeacher(teacher);
                U.AddTeacher(teacher2);

                CollectionAssert.Contains(U.Teachers, teacher);
                CollectionAssert.Contains(U.Teachers, teacher2);
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
                ISession session1 = new Session(SessionType.Winter, DateTime.Now.Year);
                ISession session2 = new Session(SessionType.Summer, DateTime.Now.Year);
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
                ISession session1 = new Session(SessionType.Winter, DateTime.Now.Year);
                ISession session2 = new Session(SessionType.Winter, DateTime.Now.Year);
                ISession session3 = new Session(SessionType.Summer, DateTime.Now.Year);
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
        public class TestMoveStudentInGroup
        {
            [TestMethod]
            public void MoveStudentInGroup()
            {
                Univercity U = new Univercity("test");
                IGroup group = new Group(new NumberGroup(Specialty.Service, DateTime.Now.Year));
                IStudent student1 = new Student(new FullName("test", "test", "test"), new DateTime(2000, 12, 14));
                IStudent student2 = new Student(new FullName("test", "test", "test"), new DateTime(2000, 12, 14));
                string ng = group.NumberGroup.ToString();              
                int result = 2;

                U.AddGroup(group);
                U.AddStudent(student1);
                U.AddStudent(student2);
                string id1 = student1.Id.ToString();
                string id2 = student2.Id.ToString();
                U.MoveStudentInGroup(ng, id1);
                U.MoveStudentInGroup(ng, id2);

                Assert.AreEqual(group.Students.Count, result);
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
                ITeacher teacher = new Teacher(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Title.Lecture);
                string ns1 = subject1.NameSubject.ToString();
                string ns2 = subject2.NameSubject.ToString();
                string id = teacher.Id.ToString();
                int result = 2;
                string result2 = teacher.Name.ToString();

                U.AddSubject(subject1);
                U.AddSubject(subject2);
                U.AddTeacher(teacher);

                U.AddSubjectToTeacher(id, ns1);
                U.AddSubjectToTeacher(id, ns2);

                Assert.AreEqual(teacher.Subjects.Count, result);
            }

            [TestMethod]
            public void AddTeacherToSubject()
            {
                Univercity U = new Univercity("test");
                ISubject subject1 = new Subject("test", SubjectType.Credited);
                ISubject subject2 = new Subject("test2", SubjectType.Exem);
                ITeacher teacher = new Teacher(new FullName("test", "test", "test"), new DateTime(2000, 12, 14),Title.Lecture);
                string ns1 = subject1.NameSubject.ToString();
                string ns2 = subject2.NameSubject.ToString();
                string id = teacher.Id.ToString();
                string result = teacher.Name.ToString();

                U.AddSubject(subject1);
                U.AddSubject(subject2);
                U.AddTeacher(teacher);

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
                IStudent student1 = new Student(new FullName("test", "test", "test"), new DateTime(2000, 12, 14));
                IStudent student2 = new Student(new FullName("test", "test", "test"), new DateTime(2000, 12, 14));
                string ng1 = group1.NumberGroup.ToString();
                string ng2 = group2.NumberGroup.ToString();
                int result = 1;

                U.AddStudent(student1);
                U.AddStudent(student2);
                U.AddGroup(group1);
                U.AddGroup(group2);
                string id1 = student1.Id.ToString();
                U.MoveStudentInGroup(ng1, id1);

                string id2 = group1.Students[0].Id.ToString();
                U.MoveStudentToAnotherGroup(id2, ng2);

                Assert.AreEqual(group1.Students.Count, result);
                Assert.AreEqual(group2.Students.Count, result);
            }
        }

        [TestClass]
        public class TestRemoveEntrant
        {
            [TestMethod]
            public void RemoveEntrant()
            {
                Univercity U = new Univercity("test");
                IStudent entrant1 = new Student(new FullName("test", "test", "test"), new DateTime(2000, 12, 14));
                IStudent entrant2 = new Student(new FullName("test", "test", "test"), new DateTime(2000, 12, 14));
                string id1 = entrant2.Id.ToString();
                int result = 1;

                U.AddStudent(entrant1);
                U.AddStudent(entrant2);
                U.RemoveStudent(id1);

                CollectionAssert.Contains(U.Students, entrant1);
                CollectionAssert.DoesNotContain(U.Students, entrant2);
                Assert.AreEqual(U.Students.Count, result);
            }
        }

        [TestClass]
        public class TestRemoveTeacher
        {
            [TestMethod]
            public void RemoveTeachers()
            {
                Univercity U = new Univercity("test");
                ITeacher teacher1 = new Teacher(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Title.Lecture);
                ITeacher teacher2 = new Teacher(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Title.Professor);
                string id2 = teacher2.Id.ToString();
                int result = 1;

                U.AddTeacher(teacher1);
                U.AddTeacher(teacher2);
                U.RemoveTeacher(id2);

                CollectionAssert.Contains(U.Teachers, teacher1);
                CollectionAssert.DoesNotContain(U.Teachers, teacher2);
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
                ISession session1 = new Session(SessionType.Winter, DateTime.Now.Year);
                ISession session2 = new Session(SessionType.Summer, DateTime.Now.Year);
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
    }

    [TestClass]
    public abstract class UnitTestStudent
    {
        [TestClass]
        public class TestAddSubjects
        {
            [TestMethod]
            public void AddSubject()
            {
                Univercity U = new Univercity("test");
                ISubject subject1 = new Subject("test", SubjectType.Credited);
                ISubject subject2 = new Subject("test2", SubjectType.Exem);
                IStudent student = new Student(new FullName("test", "test", "test"), new DateTime(2000, 12, 14));

                U.AddStudent(student);
                U.Subjects.Add(subject1);
                U.Subjects.Add(subject1);
                student.AddSubjects(U.Subjects);

                ReferenceEquals(student.Subjects, subject1);
                ReferenceEquals(student.Subjects, subject2);
            }
        } 

        [TestClass]
        public class TestoveToSubjectAssessment
        {
            [TestMethod]
            public void ToSubjectAssessment()
            {
                Univercity U = new Univercity("test");
                IGroup group = new Group(new NumberGroup(Specialty.Service, DateTime.Now.Year));
                IStudent student = new Student(new FullName("test", "test", "test"), new DateTime(2000, 12, 14));
                ISession session = new Session(SessionType.Winter, DateTime.Now.Year);
                ISubject subject = new Subject("test", SubjectType.Credited);
                string ns = subject.ToString();
                string s = session.ToString();
                string ng = group.NumberGroup.ToString();
                string id = student.Id.ToString();
                Assessment a = Assessment.Four;
                U.AddGroup(group);
                U.AddStudent(student);
                U.AddSession(session);
                U.AddSubject(subject);
                U.MoveStudentInGroup(ng, id);
           //     session.AddSubjects(student, U.Subjects);
                session.MoveToSubjectAssessment(student, subject, a);
                var result = student.Subjects.Where(e => e.Assessment.Equals(a));

                ReferenceEquals(student.Subjects, result);
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
                ITeacher teacher = new Teacher(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Title.Lecture);
                Subject subject1 = new Subject("test", SubjectType.Credited);
                ISubject subject2 = new Subject("test2", SubjectType.Exem);
                int result = 2;

                U.AddTeacher(teacher);
                U.AddSubject(subject1);
                U.AddSubject(subject2);

                teacher.AddSubject(subject1);
                teacher.AddSubject(subject2);

                CollectionAssert.Contains(U.Subjects, subject1);
                CollectionAssert.Contains(U.Subjects, subject2);
                Assert.AreEqual(teacher.Subjects.Count, result);
            }
        }
    }

    [TestClass]
    public abstract class UnitTestGroup
    {
        [TestClass]
        public class TestAddStudent
        {
            [TestMethod]
            public void AddStudent()
            {
                Univercity U = new Univercity("test");
                IGroup group = new Group(new NumberGroup(Specialty.Service, DateTime.Now.Year));
                var ng = group.NumberGroup;
                var id = new Id(ng, new Id());
                IStudent student1 = new Student(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), id);
                IStudent student2 = new Student(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), id);
                int result = 2;

                U.AddGroup(group);
                group.AddStudent(student1);
                group.AddStudent(student2);

                CollectionAssert.Contains(group.Students, student1);
                CollectionAssert.Contains(group.Students, student2);
                Assert.AreEqual(group.Students.Count, result);
            }
        }

        [TestClass]
        public class TestRemoveStudent
        {
            [TestMethod]
            public void RemoveStudent()
            {
                Univercity U = new Univercity("test");
                IGroup group = new Group(new NumberGroup(Specialty.Service, DateTime.Now.Year));
                var ng = group.NumberGroup;
                var id = new Id(ng, new Id());
                var id2 = new Id(ng, new Id());
                IStudent student1 = new Student(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), id);
                IStudent student2 = new Student(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), id2);
                int result = 1;

                U.AddGroup(group);
                group.AddStudent(student1);
                group.AddStudent(student2);
                string id3 = group.Students[1].Id.ToString();
                group.RemoveStudent(id3.ToString());

                CollectionAssert.Contains(group.Students, student1);
                CollectionAssert.DoesNotContain(group.Students, student2);
                Assert.AreEqual(group.Students.Count, result);
            }
        }

        [TestClass]
        public class TestGetStudent
        {
            [TestMethod]
            public void GetStudent()
            {
                Univercity U = new Univercity("test");
                IGroup group = new Group(new NumberGroup(Specialty.Service, DateTime.Now.Year));
                var ng = group.NumberGroup;
                var id = new Id(ng, new Id());
                IStudent student = new Student(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), id);
                int result = 1;

                U.AddGroup(group);
                group.AddStudent(student);
                string id1 = group.Students[0].Id.ToString();
                var g = group.GetStudent(id1);

                CollectionAssert.Contains(group.Students, g);
                Assert.AreEqual(group.Students.Count, result);
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
                IStudent student = new Student(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), id);

                U.AddGroup(group);
                group.AddStudent(student);
                var result = student.Equals(student);

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
                IStudent student1 = new Student(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), id1);
                IStudent student2 = new Student(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), id2);

                U.AddGroup(group);
                group.AddStudent(student1);
                group.AddStudent(student2);
                var result = student1.Equals(student2);

                Assert.IsFalse(result);
            }

            [TestMethod]
            public void FalseOneArgumentIsNull()
            {
                Univercity U = new Univercity("test");
                IGroup group = new Group(new NumberGroup(Specialty.Service, DateTime.Now.Year));
                var ng = group.NumberGroup;
                var id1 = new Id(ng, new Id());
                IStudent student1 = new Student(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), id1);
                IStudent student2 = null;

                U.AddGroup(group);
                group.AddStudent(student1);
                var result = student1.Equals(student2);

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
                ITeacher teacher = new Teacher(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Title.Lecture);
                ISubject subject = new Subject("test", SubjectType.Credited);
                var result = teacher.Name;

                U.AddTeacher(teacher);
                U.AddSubject(subject);

                subject.AddTeacher(teacher);

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
                ITeacher teacher = new Teacher(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Title.Lecture);
                ISubject subject = new Subject("test", SubjectType.Credited);

                U.AddTeacher(teacher);
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
                ITeacher teacher = new Teacher(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Title.Lecture);

                U.AddTeacher(teacher);
                var result = teacher.Equals(teacher);

                Assert.IsTrue(result);
            }

            [TestMethod]
            public void FalseEqual()
            {
                Univercity U = new Univercity("test");
                ITeacher teacher1 = new Teacher(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Title.Lecture);
                ITeacher teacher2 = new Teacher(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Title.Lecture);

                U.AddTeacher(teacher1);
                U.AddTeacher(teacher2);
                var result = teacher1.Equals(teacher2);
                Assert.IsFalse(result);
            }

            [TestMethod]
            public void FalseOneArgumentIsNull()
            {
                Univercity U = new Univercity("test");
                ITeacher teacher1 = new Teacher(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), Title.Lecture);
                ITeacher teacher2 = null;

                U.AddTeacher(teacher1);
                var result = teacher1.Equals(teacher2);

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
                ISession session = new Session(SessionType.Winter, DateTime.Now.Year);
                ISubject subject1 = new Subject("test", SubjectType.Credited);
                ISubject subject2 = new Subject("test2", SubjectType.Credited);
                IGroup group = new Group(new NumberGroup(Specialty.Service, DateTime.Now.Year));
                var ng = group.NumberGroup;
                var id = new Id(ng, new Id());
                IStudent student = new Student(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), id);
                int result = 2;

                U.Groups.Add(group);
                group.AddStudent(student);
                U.Sessions.Add(session);
                U.Subjects.Add(subject1);
                U.Subjects.Add(subject2);
        //        session.AddSubjects(group, U.Subjects);

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
                ISession session = new Session(SessionType.Winter, DateTime.Now.Year);
                ISubject subject1 = new Subject("test", SubjectType.Credited);
                ISubject subject2 = new Subject("test2", SubjectType.Credited);
                IGroup group = new Group(new NumberGroup(Specialty.Service, DateTime.Now.Year));
                var ng = group.NumberGroup;
                var id = new Id(ng, new Id());
                IStudent student = new Student(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), id);
                int result = 2;

                U.Groups.Add(group);
                group.AddStudent(student);
                U.Sessions.Add(session);
                U.Subjects.Add(subject1);
                U.Subjects.Add(subject2); 
          //      session.AddSubjects(student, U.Subjects);

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
                ISession session = new Session(SessionType.Winter, DateTime.Now.Year);
                ISubject subject = new Subject("test", SubjectType.Credited);
                IGroup group = new Group(new NumberGroup(Specialty.Service, DateTime.Now.Year));
                var ng = group.NumberGroup;
                var id = new Id(ng, new Id());
                IStudent student = new Student(new FullName("test", "test", "test"), new DateTime(2000, 12, 14), id);
                Assessment a = Assessment.Four;

                U.Groups.Add(group);
                group.AddStudent(student);
                U.Sessions.Add(session);
                U.Subjects.Add(subject);   
        //        session.AddSubjects(student, U.Subjects);
                session.MoveToSubjectAssessment(student, subject, a);
                var result = student.Subjects.Find(s => s.Equals(subject)).Assessment;

                ReferenceEquals(a, result);
            }
        }

        [TestClass]
        public class TestEquals
        {
            [TestMethod]
            public void TrueEqual()
            {
                Univercity U = new Univercity("test");
                ISession session = new Session(SessionType.Winter, DateTime.Now.Year);
                ISubject subject = new Subject("test", SubjectType.Credited);

                U.Sessions.Add(session);
                var result = session.Equals(session);

                Assert.IsTrue(result);
            }

            [TestMethod]
            public void FalseEqual()
            {
                Univercity U = new Univercity("test");
                ISession session1 = new Session(SessionType.Winter, DateTime.Now.Year);
                ISession session2 = new Session(SessionType.Summer, DateTime.Now.Year);
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
                ISession session1 = new Session(SessionType.Winter, DateTime.Now.Year);
                ISession session2 = null;

                U.Sessions.Add(session1);
                U.Sessions.Add(session2);
                var result = session1.Equals(session2); 

                Assert.IsFalse(result);
            }
        }
    }
}


