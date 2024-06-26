namespace Empleados{
    public enum Cargos{
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }
    public class Empleado{
        public required string Nombre;
        public required string Apellido;
        public DateTime Nacimiento;
        public char EstadoCivil;
        public DateTime Ingreso;
        public double Sueldo;
        public Cargos Cargo;
        public int calcularAntiguedad(){
            DateTime fechaActual=DateTime.Now;
            int añosAntiguedad=fechaActual.Year-this.Ingreso.Year;
            if (this.Ingreso.Date > fechaActual.AddYears(-añosAntiguedad)){
                añosAntiguedad--;
            }
            return añosAntiguedad;
        }
        public int calcularEdad(){
            DateTime fechaActual=DateTime.Today;
            int edad=fechaActual.Year-this.Nacimiento.Year;
            if(this.Nacimiento.Date>fechaActual.AddYears(-edad)){
                edad--;
            }
            return edad;
        }
        public int calcularJubilacion(){
            int edad=calcularEdad();
            if(edad<65){
                int tiempoParaJubilarse=65-edad;
                return tiempoParaJubilarse;
            }else{
                return 0;
            }
        }
        public double calcularSalario(){
            int antiguedad=calcularAntiguedad();
            double Salario;
            double adicional;
            if(antiguedad<20){
                adicional=(0.01*this.Sueldo)*antiguedad;
            }else{
                adicional=this.Sueldo*0.25;
            }
            if(this.Cargo==Cargos.Ingeniero || this.Cargo==Cargos.Especialista){
                adicional*=1.5;
            }
            if(this.EstadoCivil=='c'){
                adicional+=150000;
            }
            Salario=this.Sueldo+adicional;
            return Salario;
        }
    }
}