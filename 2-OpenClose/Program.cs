using OpenClose;

ShowSalaryMonthly(new List<Employee>() {
    new EmployeeFullTime("Pepito Pérez", 160),
    new EmployeePartTime("Manuel Lopera", 180),
    new EmployeeContractor("Tito",120)
});

//Se removió el método CalculateSalaryMonthlyl a la clase Employee
//Se cambio el tipo de dato Object a Employee
void ShowSalaryMonthly(List<Employee> employees) 
{
    foreach (var employee in employees)

    {        
        Console.WriteLine($"Empleado: {employee.Fullname}, Pago: {employee.CalculateSalaryMonthly():C1} ");
    }

}