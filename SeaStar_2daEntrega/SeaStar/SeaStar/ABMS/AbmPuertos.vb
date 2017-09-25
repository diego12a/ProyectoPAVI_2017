Public Class AbmPuertos

    Friend row_selected As DataGridViewRow
    'creo la variable bd que es de tipo bdHelper
    Dim bd As New BDHelperPuerto

    'este metodo se ejecuta cuando se carga el formulario
    Private Sub AbmPuertos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'utilizo la variable bd para conocer los puertos que existen en la base de datos invocando el metodo "conocer puertos de la bdHelperPuerto" y al resultado de esto se lo paso como 
        'parametro al metodo de ESTA clase (AbmPuertos) llamado llenar_grid
        llenar_grid(bd.conocer_puertos())
        limpiar()
    End Sub
    'este metodo  valida si las cajas donde se deben ingresar informacion por parte del usuario tienen algo o estan vacias
    Private Function validar_campos() As Boolean
        'le pregunto al objeto txtNombre (TextBox) si su propiedad .text (osea lo que se le ingresa dentro) esta vacia 
        If txtNombre.Text = " " Then
            'retorna false porque esta vacia
            MessageBox.Show("No se ingreso nombre", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Else
            'retorna verdadero porque no esta vacia
            Return True
        End If
    End Function

    'este metodo se produce solo al hacer doble click al btnGuardar generado en el form
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'creo las variables puerto que es un Puerto, bd que es un bdHelper
        Dim puerto As New Puerto
        'pregunto si el metodo validar campos devuelve como resultado true o false
        If validar_campos() = True Then
            'cargo al objeto puerto con la propiedad .nombre asignandole el txtNombre.text (anterior mente explicado para que sirve el .text) NO CARGO LA PROPIEDAD
            'puerto.cod_puerto = txtCodPuerto.Text PORQUE NO ES NECESARIO YA QUE LA BASE DE DATOS GENERARA EL CODIGO DEL PUERTO ELLA SOLA Y DE FORMA SECUENCIAL!!!!
            puerto.nombre = txtNombre.Text
            puerto.borrado = 0
            'utilizo la variable bd para llamar el metodo guardar_puerto del bdHelper y le paso como parametro el puerto creado
            bd.guardar_puerto(puerto)
            llenar_grid(bd.conocer_puertos())
            limpiar()

        End If
    End Sub
    'este como todos los metodos que de los botones que hay que hacerle click se generarn solos al hacerle doble click al btn
    'llama al metodo limpiar()
    Private Sub btnResetear_Click(sender As Object, e As EventArgs) Handles btnResetear.Click
        limpiar()
        llenar_grid(bd.conocer_puertos())
    End Sub
    'este metodo edita un puerto de la grilla
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        'creo variables
        Dim puerto As New Puerto
        'pregunto por validar campos
        If validar_campos() = True Then
            'cargo las propiedades del puerto, SI CARGO EL puerto.Nombre PORQUE LO NECESITO PARA EDITAR UN UNICO PUERTO!!!
            puerto.cod_puerto = txtCodPuerto.Text
            puerto.nombre = txtNombre.Text
            puerto.borrado = 0
            'llamo al metodo modificar_puerto() de la bdHelper y le paso por parametro el puerto 
            bd.modificar_puerto(puerto)
            'llamo al metodo limpiar
            limpiar()
            'lleno la grilla para mostrar los puertos, incluso el modificado recien
            llenar_grid(bd.conocer_puertos())

        End If
    End Sub
    'limpia las cajas de texto!
    Private Sub limpiar()
        txtNombre.Text = " "
        txtCodPuerto.Text = " "
        btnEditar.Enabled = False
        btnGuardar.Enabled = True
        btnEliminar.Enabled = True
        txtNombre.Focus()
    End Sub
    'elimina un puerto de la base de datos
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminarPuerto.ShowDialog()
    End Sub
    'este metodo llena la grilla con puertos, recibe como parametro una dataTable
    Private Sub llenar_grid(ByVal source As DataTable)
        'limpio la grilla
        gridPuertos.Rows.Clear()
        'creo la variable c 
        Dim c As Integer = 0
        'recorro la datTable utilizando la variable c
        For c = 0 To source.Rows.Count - 1
            'cargo la grilla con los distintos puertos, "cod_puerto" y "nombre" tienen que estar en el mismo orden y nombre como esta en la base de datos!!!
            gridPuertos.Rows.Add(source.Rows(c)("cod_puerto"), _
                               source.Rows(c)("nombre"))
        Next
    End Sub
    'este metodo te deja seleccionar una fila de la grilla para despues poder modificarla o eliminarla, pero no se bien como hacerlo despues le pregunto a la profe!
  
    Private Sub gridPuertos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridPuertos.CellContentClick
        btnEditar.Enabled = True
        btnEliminar.Enabled = False
        btnGuardar.Enabled = False
        row_selected = gridPuertos.CurrentRow
        txtCodPuerto.Text = gridPuertos.CurrentRow.Cells.Item("colID").Value
        txtNombre.Text = gridPuertos.CurrentRow.Cells.Item("colNombre").Value
    End Sub


End Class