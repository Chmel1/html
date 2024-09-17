using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;
using Microsoft.VisualBasic.Logging;
using System.Collections;

namespace Matan
{

    public partial class Enter_Data : Form

    {
        ClassDataBase dataBase = new ClassDataBase();

        public Enter_Data()

        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private bool IsPatientIdExists(string patientId)
        {
            bool exists = false;

            string query = "SELECT COUNT(1) FROM Patients WHERE patient_id = @patientId";


            using (SqlCommand cmd = new SqlCommand(query, dataBase.getConnection()))
            {
                // Добавляем параметр для предотвращения SQL-инъекций
                cmd.Parameters.AddWithValue("@patientId", patientId);

                try
                {
                    dataBase.openConnection();

                    // Выполняем запрос и проверяем результат
                    int count = (int)cmd.ExecuteScalar();

                    // Если в базе данных есть хотя бы одна запись с таким patient_id, результат будет больше 0
                    exists = count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при проверке patient_id: " + ex.Message);
                }
            }

            return exists;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Enter_Data_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label48_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            // Проверяем, является ли введенное значение числом
            if (double.TryParse(input, out double number))
            {
                // Если введено корректное число, копируем его в другие TextBox
                textBox2.Text = number.ToString();
                textBox3.Text = number.ToString();
                textBox4.Text = number.ToString();
                textBox5.Text = number.ToString();
                textBox7.Text = number.ToString();


            }
            else
            {
                // Если введено не число, очищаем остальные TextBox
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox7.Clear();
            }
        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string patientId = textBox1.Text;

            // Проверяем, введено ли значение
            if (!string.IsNullOrEmpty(patientId))
            {
                // Вызываем метод проверки, существует ли такой patient_id в базе данных
                if (IsPatientIdExists(patientId))
                {
                    MessageBox.Show("Пациент с таким ID существует.");
                }
                else
                {
                    MessageBox.Show("Пациент с таким ID не найден.");
                }
            }
            else
            {
                MessageBox.Show("Введите patient_id.");
            }
        }

        private void button_Examinations_Click(object sender, EventArgs e)
        {
            string examinationDate = Examinations_date_TextBox.Text;
            string complaints = Complaints_TextBox.Text;
            string physicalExamination = Physical_examination_TextBox.Text;
            string additionalTests = Additional_text_TextBox.Text;
            string patientid = textBox3.Text;

            // Проверка на пустые поля
            if (string.IsNullOrEmpty(examinationDate) || string.IsNullOrEmpty(complaints) ||
                string.IsNullOrEmpty(physicalExamination) || string.IsNullOrEmpty(additionalTests))
            {
                MessageBox.Show("Заполните все поля.");
                return;
            }

            // SQL-запрос для вставки данных в таблицу
            string query = "INSERT INTO Examinations (patient_id,Examination_date, complaints, Physical_examination_results, additional_tests) " +
                           "VALUES (@PatientID,@ExaminationDate, @Complaints, @PhysicalExamination, @AdditionalTests)";

            // Используем SqlConnection и SqlCommand для выполнения запроса


            using (SqlCommand cmd = new SqlCommand(query, dataBase.getConnection()))
            {
                // Добавляем параметры для предотвращения SQL-инъекций
                cmd.Parameters.AddWithValue("@ExaminationDate", examinationDate);
                cmd.Parameters.AddWithValue("@Complaints", complaints);
                cmd.Parameters.AddWithValue("@PhysicalExamination", physicalExamination);
                cmd.Parameters.AddWithValue("@AdditionalTests", additionalTests);
                cmd.Parameters.AddWithValue("@PatientID", patientid);

                try
                {
                    // Открываем подключение и выполняем запрос
                    dataBase.openConnection();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Данные успешно добавлены.");
                }
                catch (Exception ex)
                {
                    // Обработка ошибок
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }

        }

        private void button_Patients_Click(object sender, EventArgs e)
        {
            // Получаем данные из текстовых полей
            string firstName = First_name_TextBox.Text;
            string lastName = Last_name_TextBox.Text;
            string middleName = Middle_name_TextBox.Text;
            string dateOfBirth = Date_of_birth_TextBox.Text;
            string gender = Gender_TextBox.Text;
            string contactNumber = Contact_number_TextBox.Text;
            string email = Email_TextBox.Text;
            string address = Addres_TextBox.Text;
            string insurancePolicyNumber = Insurance_policy_number_TextBox.Text;
            string insuranceCompany = Incurance_company_TextBox.Text;

            // Проверка на пустые поля (вы можете улучшить проверку в зависимости от ваших требований)
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(dateOfBirth) ||
                string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(contactNumber))
            {
                MessageBox.Show("Заполните все обязательные поля.");
                return;
            }

            // SQL-запрос для вставки данных в таблицу Patients
            string query = "INSERT INTO Patients (first_name, last_name, middle_name, date_of_birth, gender, contact_number, email, address, insurance_policy_number, insurance_company) " +
                           "VALUES (@FirstName, @LastName, @MiddleName, @DateOfBirth, @Gender, @ContactNumber, @Email, @Address, @InsurancePolicyNumber, @InsuranceCompany)";

            // Используем SqlConnection и SqlCommand для выполнения запроса


            using (SqlCommand cmd = new SqlCommand(query, dataBase.getConnection()))
            {
                // Добавляем параметры для предотвращения SQL-инъекций
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@MiddleName", middleName);
                cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@ContactNumber", contactNumber);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@InsurancePolicyNumber", insurancePolicyNumber);
                cmd.Parameters.AddWithValue("@InsuranceCompany", insuranceCompany);

                try
                {
                    // Открываем подключение и выполняем запрос
                    dataBase.openConnection();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Пациент успешно добавлен.");
                }
                catch (Exception ex)
                {
                    // Обработка ошибок
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }

        }

        private void Date_of_birth_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Payments_Click(object sender, EventArgs e)
        {
            // Получаем данные из текстовых полей
            string patientid = textBox2.Text;
            string paymentDate = Payment_date_TextBox.Text;
            string amount = Amount_TextBox.Text;
            string paymentMethod = Payment_method_TextBox.Text;
            string invoiceNumber = Invoice_number_TextBox.Text;

            // Проверка на пустые поля (вы можете улучшить проверку в зависимости от требований)
            if (string.IsNullOrEmpty(paymentDate) || string.IsNullOrEmpty(amount) ||
                string.IsNullOrEmpty(paymentMethod) || string.IsNullOrEmpty(invoiceNumber))
            {
                MessageBox.Show("Заполните все поля.");
                return;
            }

            // SQL-запрос для вставки данных в таблицу Payments
            string query = "INSERT INTO Payments (Payment_date, Amount, Payment_method, Invoice_number) " +
                           "VALUES (@PaymentDate, @Amount, @PaymentMethod, @InvoiceNumber)";

            // Используем SqlConnection и SqlCommand для выполнения запроса


            using (SqlCommand cmd = new SqlCommand(query, dataBase.getConnection()))
            {
                // Добавляем параметры для предотвращения SQL-инъекций
                cmd.Parameters.AddWithValue("@PaymentDate", paymentDate);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                cmd.Parameters.AddWithValue("@InvoiceNumber", invoiceNumber);

                try
                {
                    // Открываем подключение и выполняем запрос
                    dataBase.openConnection();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Платеж успешно добавлен.");
                }
                catch (Exception ex)
                {
                    // Обработка ошибок
                    MessageBox.Show("Ошибка: " + ex.Message);
                }


            }
        }

        private void button_Surgeries_Click(object sender, EventArgs e)
        {
            // Получаем данные из текстовых полей
            int patientId;
            bool isPatientIdValid = int.TryParse(textBox7.Text, out patientId);
            string dateOfSurgery = Date_of_surgery_TextBox.Text;
            string typeOfSurgery = Type_of_surgery_TextBox.Text;
            string surgeon = Surgeon_TextBox.Text;
            string anesthesiologist = Anesthesiologist_TextBox.Text;
            string surgeryDescription = Surgery_discription_TextBox.Text;
            string complications = Complications_TextBox.Text;
            string outcome = Outcome_TextBox.Text;

            // Проверка на пустые поля и корректность данных
            if (!isPatientIdValid || string.IsNullOrEmpty(dateOfSurgery) || string.IsNullOrEmpty(typeOfSurgery) ||
                string.IsNullOrEmpty(surgeon) || string.IsNullOrEmpty(anesthesiologist))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.");
                return;
            }

            // SQL-запрос для вставки данных в таблицу Surgeries
            string query = "INSERT INTO Surgeries (patient_id, date_of_surgery, type_of_surgery, surgeon, anesthesiologist, surgery_description, complications, outcome) " +
                           "VALUES (@PatientID, @DateOfSurgery, @TypeOfSurgery, @Surgeon, @Anesthesiologist, @SurgeryDescription, @Complications, @Outcome)";

            // Используем SqlConnection и SqlCommand для выполнения запроса


            using (SqlCommand cmd = new SqlCommand(query, dataBase.getConnection()))
            {
                // Добавляем параметры для предотвращения SQL-инъекций
                cmd.Parameters.AddWithValue("@PatientID", patientId);
                cmd.Parameters.AddWithValue("@DateOfSurgery", dateOfSurgery);
                cmd.Parameters.AddWithValue("@TypeOfSurgery", typeOfSurgery);
                cmd.Parameters.AddWithValue("@Surgeon", surgeon);
                cmd.Parameters.AddWithValue("@Anesthesiologist", anesthesiologist);
                cmd.Parameters.AddWithValue("@SurgeryDescription", surgeryDescription);
                cmd.Parameters.AddWithValue("@Complications", complications);
                cmd.Parameters.AddWithValue("@Outcome", outcome);

                try
                {
                    // Открываем подключение и выполняем запрос
                    dataBase.openConnection();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Информация о операции успешно добавлена.");
                }
                catch (Exception ex)
                {
                    // Обработка ошибок
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }

        }

        private void button_Medical_history_Click(object sender, EventArgs e)
        {
            // Получаем данные из текстовых полей
            int patientId;
            bool isPatientIdValid = int.TryParse(textBox4.Text, out patientId);
            string chronicDiseases = Chronic_diseases__TextBox.Text;
            string previousOperations = Previous_operations_TextBox.Text;
            string allergies = Allergies_TextBox.Text;
            string currentMedications = Current_medications_TextBox.Text;
            string diagnoses = Diagnoses_TextBox.Text;
            string labResults = Lab_results_TextBox.Text;

            // Проверка на пустые поля и корректность данных
            if (!isPatientIdValid || string.IsNullOrEmpty(chronicDiseases) || string.IsNullOrEmpty(previousOperations) ||
                string.IsNullOrEmpty(allergies) || string.IsNullOrEmpty(currentMedications) ||
                string.IsNullOrEmpty(diagnoses) || string.IsNullOrEmpty(labResults))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.");
                return;
            }

            // SQL-запрос для вставки данных в таблицу Medical_History
            string query = "INSERT INTO Medical_History (patient_id, chronic_diseases, previous_operations, allergies, current_medications, diagnoses, lab_results) " +
                           "VALUES (@PatientID, @ChronicDiseases, @PreviousOperations, @Allergies, @CurrentMedications, @Diagnoses, @LabResults)";

            // Используем SqlConnection и SqlCommand для выполнения запроса


            using (SqlCommand cmd = new SqlCommand(query, dataBase.getConnection()))
            {
                // Добавляем параметры для предотвращения SQL-инъекций
                cmd.Parameters.AddWithValue("@PatientID", patientId);
                cmd.Parameters.AddWithValue("@ChronicDiseases", chronicDiseases);
                cmd.Parameters.AddWithValue("@PreviousOperations", previousOperations);
                cmd.Parameters.AddWithValue("@Allergies", allergies);
                cmd.Parameters.AddWithValue("@CurrentMedications", currentMedications);
                cmd.Parameters.AddWithValue("@Diagnoses", diagnoses);
                cmd.Parameters.AddWithValue("@LabResults", labResults);

                try
                {
                    // Открываем подключение и выполняем запрос
                    dataBase.openConnection();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Медицинская история успешно добавлена.");
                }
                catch (Exception ex)
                {
                    // Обработка ошибок
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }

        }

        private void button_Precriptions_Click(object sender, EventArgs e)
        {
            // Получаем данные из текстовых полей
            int patientId;
            bool isPatientIdValid = int.TryParse(textBox4.Text, out patientId);
            string date = Date_TextBox.Text;
            string medications = Medications_TextBox.Text;
            string dosage = Dosage_TextBox.Text;
            string recommendations = Recommendations_TextBox.Text;

            // Проверка на пустые поля и корректность данных
            if (!isPatientIdValid || string.IsNullOrEmpty(date) || string.IsNullOrEmpty(medications) ||
                string.IsNullOrEmpty(dosage) || string.IsNullOrEmpty(recommendations))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.");
                return;
            }

            // SQL-запрос для вставки данных в таблицу Prescriptions
            string query = "INSERT INTO Prescriptions (patient_id, date, medications, dosage, recommendations) " +
                           "VALUES (@PatientID, @Date, @Medications, @Dosage, @Recommendations)";

            // Используем SqlConnection и SqlCommand для выполнения запроса

            using (SqlCommand cmd = new SqlCommand(query, dataBase.getConnection()))
            {
                // Добавляем параметры для предотвращения SQL-инъекций
                cmd.Parameters.AddWithValue("@PatientID", patientId);
                cmd.Parameters.AddWithValue("@Date", date);
                cmd.Parameters.AddWithValue("@Medications", medications);
                cmd.Parameters.AddWithValue("@Dosage", dosage);
                cmd.Parameters.AddWithValue("@Recommendations", recommendations);

                try
                {
                    // Открываем подключение и выполняем запрос
                    dataBase.openConnection();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Рецепт успешно добавлен.");
                }
                catch (Exception ex)
                {
                    // Обработка ошибок
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }

        }
        private bool IsLoginExists(string login)
        {
            bool exists = false;

            // SQL-запрос для проверки наличия логина
            string query = "SELECT COUNT(1) FROM Users WHERE Login = @Login";

            using (SqlCommand cmd = new SqlCommand(query, dataBase.getConnection()))
            {
                // Добавляем параметр для предотвращения SQL-инъекций
                cmd.Parameters.AddWithValue("@Login", login);

                try
                {
                    // Открываем соединение
                    dataBase.openConnection();

                    // Выполняем запрос и получаем результат
                    int count = (int)cmd.ExecuteScalar();

                    // Если найдено хотя бы одно совпадение, логин существует
                    exists = count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при проверке логина: " + ex.Message);
                }
                finally
                {
                    // Закрываем соединение
                    dataBase.closeConnection();
                }
            }

            return exists;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string Login =Login_TextBox.Text;
            string Password = Password_TextBox.Text;

            if(string.IsNullOrEmpty(Login) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Пожалуйста, введите логин и пароль.");
                return;
            }

            if (IsLoginExists(Login))
            {
                MessageBox.Show("Пользователь с таким логином уже существует. Пожалуйста, выберите другой логин.");
                return;
            }

            string request_for_registration = "INSERT INTO Users (Login, Password, Role) VALUES (@Login, @Password, @Role)";

            using (SqlCommand cmd = new SqlCommand(request_for_registration, dataBase.getConnection()))
            {
                // Добавляем параметры для предотвращения SQL-инъекций
                cmd.Parameters.AddWithValue("@Login", Login);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.Parameters.AddWithValue("@Role", "Doctor"); // Устанавливаем роль doctor

                try
                {
                    // Открываем подключение и выполняем запрос
                    dataBase.openConnection();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Пользователь успешно добавлен с ролью doctor.");
                }
                catch (Exception ex)
                {
                    // Обработка ошибок
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
                finally
                {
                    // Закрываем соединение
                    dataBase.closeConnection();
                }
            }
        }
    }
}

