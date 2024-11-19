using MauiPages.Repositories;

namespace MauiPages;

public partial class Pagina1 : ContentPage
{
	public Pagina1()
	{
		InitializeComponent();
		EstudinateUDLARepository estudinateUDLARepository = new EstudinateUDLARepository();
		var info_estudiante = estudinateUDLARepository.DevuelveInfoEstudainte();

        Label_ID.Text= info_estudiante.ID;
		Label_nombre = info_estudiante.Nombre;
        Label_carrera = info_estudiante.Carrera;




    }
}