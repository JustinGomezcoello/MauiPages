using MauiPages.Repositories;

namespace MauiPages;

public partial class Pagina1 : ContentPage
{
	public Pagina1()
	{
		InitializeComponent();
		EstudinateUDLARepository estudinateUDLARepository = new EstudinateUDLARepository();
		var infoEstudiante= estudinateUDLARepository.DevuelveInfoEstudainte();

		Label_ID.Text = infoEstudiante.Id.ToString();
		Label_nombre.Text = infoEstudiante.Nombre;
		Label_carrera.Text = infoEstudiante.Carrera;





    }
}