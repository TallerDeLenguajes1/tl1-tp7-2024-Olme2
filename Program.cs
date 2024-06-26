using Empleados;
Empleado[] empleados=new Empleado[3];
empleados[0]=new Empleado{
    Nombre="Jose",
    Apellido="Ramirez",
    Nacimiento=new DateTime(1990, 7, 20),
    EstadoCivil='c',
    Ingreso=new DateTime(2005,9,11),
    Sueldo=254000,
    Cargo=Cargos.Auxiliar
};
empleados[1]=new Empleado{
    Nombre="Micaela",
    Apellido="Noli Moyano",
    Nacimiento=new DateTime(2004, 3, 23),
    EstadoCivil='s',
    Ingreso=new DateTime(2018,03,30),
    Sueldo=254000,
    Cargo=Cargos.Especialista
};
empleados[2]=new Empleado{
    Nombre="Valentino",
    Apellido="Olmedo",
    Nacimiento=new DateTime(2003, 12, 26),
    EstadoCivil='c',
    Ingreso=new DateTime(2012,05,23),
    Sueldo=254000,
    Cargo=Cargos.Ingeniero
};
double total=0;
int i=0;
int guardar=0;
int menor=1000;
foreach(var empleado in empleados){
    total+=empleado.calcularSalario();
    if(empleado.calcularJubilacion()<menor){
       menor=empleado.calcularJubilacion();
       guardar=i;
    }
    i++;
}
Console.WriteLine($"TOTAL A PAGAR EN CONCEPTO DE SALARIOS:${total:N2}");
Console.WriteLine($"\n||EMPLEADO MAS CERCANO A JUBILARSE||\nEMPLEADO:{empleados[guardar].Nombre} {empleados[guardar].Apellido}\nFECHA DE NACIMIENTO:{empleados[guardar].Nacimiento.Day}/{empleados[guardar].Nacimiento.Month}/{empleados[guardar].Nacimiento.Year}\nESTADO CIVIL:{empleados[guardar].EstadoCivil}\nINGRESO A LA EMPRESA:{empleados[guardar].Ingreso.Day}/{empleados[guardar].Ingreso.Month}/{empleados[guardar].Ingreso.Year}\nSUELDO:${empleados[guardar].Sueldo:N2}\nCARGO:{empleados[guardar].Cargo}\nSALARIO FINAL:${empleados[guardar].calcularSalario():N2}\nTIEMPO PARA JUBILARSE:{empleados[guardar].calcularJubilacion()} años\nANTIGUEDAD EN LA EMPRESA:{empleados[guardar].calcularAntiguedad()} años\nEDAD:{empleados[guardar].calcularEdad()} años");