/*Define a class Student, which contains data about a student – 
 * first, 
 * middle and 
 * last name, 
 * SSN, 
 * permanent address, 
 * mobile phone, 
 * e-mail, 
 * course, 
 * 
 * Enumerations:
 * specialty, 
 * university, 
 * faculty. 
 * Use an enumeration for the specialties, universities and faculties.
 
 Override the standard methods, inherited by System.Object: 
 * Equals(), 
 * ToString(), 
 * GetHashCode() and 
 * operators == and != */
namespace _01_03.Student
{
    using System;
    using System.Text;

    public class Student : ICloneable, IComparable<Student>
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string SSN { get; set; }

        public string PermanentAddress { get; set; }

        public string MobilePhone { get; set; }

        public string Email { get; set; }

        public int Course { get; set; }

        public University University { get; set; }

        public Faculty Faculty { get; set; }

        public Specialty Specialty { get; set; }

        public Student(string firstName, string middleName, string lastName, string ssn,
            string permanentAddress, string mobilePhone, string email, int course,
            University university, Faculty faculty, Specialty specialty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.University = university;
            this.Faculty = faculty;
            this.Specialty = specialty;
        }
        public override bool Equals(object obj)
        {
            if (!this.FirstName.Equals((obj as Student).FirstName)) return false;
            if (!this.MiddleName.Equals((obj as Student).MiddleName)) return false;
            if (!this.LastName.Equals((obj as Student).LastName)) return false;
            if (!this.SSN.Equals((obj as Student).SSN)) return false;
            if (!this.MobilePhone.Equals((obj as Student).MobilePhone)) return false;
            if (!this.PermanentAddress.Equals((obj as Student).PermanentAddress)) return false;
            if (!this.Email.Equals((obj as Student).Email)) return false;
            if (!this.Faculty.Equals((obj as Student).Faculty)) return false;
            if (!this.Course.Equals((obj as Student).Course)) return false;
            if (!this.University.Equals((obj as Student).University)) return false;
            if (!this.Specialty.Equals((obj as Student).Specialty)) return false;

            return true;
        }

        public override int GetHashCode()
        {
            //http://stackoverflow.com/questions/7924892/how-can-i-make-a-hashcode-for-a-custom-data-structure
            // http://ericlippert.com/2011/02/28/guidelines-and-rules-for-gethashcode/

            return string.Format("{0}-{1}-{2}-{3}", this.SSN, this.FirstName, this.MiddleName, this.LastName).GetHashCode();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(string.Format("{0} {1} {2}", this.FirstName, this.MiddleName, this.LastName));
            sb.AppendLine(string.Format("Course : {0}, SSN: {1}", this.Course, this.SSN));
            sb.AppendLine(string.Format("Address: {0}", this.PermanentAddress));
            sb.AppendLine(string.Format("Phone number: {0}, E-mail:", this.MobilePhone, this.Email));
            sb.Append(string.Format("University: {0}, Faculty: {1}, Specialty: {2}", this.University.ToString(), this.Faculty.ToString(), this.Specialty.ToString()));

            return sb.ToString();
        }


        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return firstStudent.Equals(secondStudent);
        }
        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !firstStudent.Equals(secondStudent);
        }

        /*Problem 2. ICloneable
        
         * Add implementations of the ICloneable interface. 
         * The Clone() method should deeply copy all object's fields into a new object of type Student.*/
        public object Clone()
        {

            string firstName = this.FirstName.Clone() as string;
            string middleName = this.MiddleName.Clone() as string;
            string lastName = this.LastName.Clone() as string;
            string SSN = this.SSN.Clone() as string;
            string permanentAddress = this.PermanentAddress.Clone() as string;
            var mobilePhone = this.MobilePhone.Clone() as string;
            var email = this.Email.Clone() as string;
            var course = this.Course;
            var university = this.University;
            var faculty = this.Faculty;
            var specialty = this.Specialty;
            var newStudent = new Student(firstName, middleName, lastName, SSN, permanentAddress, mobilePhone, email, course, university, faculty, specialty);
            return newStudent;
        }

        /*Problem 3. IComparable
            Implement the IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) 
         * and by social security number (as second criteria, in increasing order).*/
       
        public int CompareTo(Student otherStudent)
        {
            if (this.FirstName.CompareTo(otherStudent.FirstName) != 0)
            {
                return this.FirstName.CompareTo(otherStudent.FirstName);
            }

            if (this.MiddleName.CompareTo(otherStudent.MiddleName) != 0)
            {
                return this.MiddleName.CompareTo(otherStudent.MiddleName);
            }

            if (this.LastName.CompareTo(otherStudent.LastName) != 0)
            {
                return this.LastName.CompareTo(otherStudent.LastName);
            }

            if (this.SSN.CompareTo(otherStudent.SSN) != 0)
            {
                return this.SSN.CompareTo(otherStudent.SSN);
            }

            return 0;
        }
    }
}
