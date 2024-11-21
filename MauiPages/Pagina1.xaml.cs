using MauiPages.Modelos;
using MauiPages.Repositories;

namespace MauiPages;

public partial class Pagina1 : ContentPage
{
	Estudiante _estudiante;
	public Pagina1()
	{
		InitializeComponent();
		EstudinateUDLARepository estudinateUDLARepository = new EstudinateUDLARepository();
		 _estudiante = estudinateUDLARepository.DevuelveInfoEstudainte();
		BindingContext= _estudiante;

		//Label_ID.Text = infoEstudiante.Id.ToString();
		//Label_nombre.Text = infoEstudiante.Nombre;
		//Label_carrera.Text = infoEstudiante.Carrera;





    }

    private void CambiaNombre_Clicked(object sender, EventArgs e)
    {
		_estudiante.Nombre = "Cambiar Nombre";
    }
}