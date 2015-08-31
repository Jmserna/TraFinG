Public Class Form3
    'Public HasBeenChanged, DGVFaunisticaChanged As Boolean
   
    Private Sub LancesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles LancesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.LancesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDpescamedDataSet1)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'BDpescamedDataSet1.Especies' table. You can move, or remove it, as needed.
            Me.EspeciesTableAdapter.Fill(Me.BDpescamedDataSet1.Especies)
            'TODO: This line of code loads data into the 'BDpescamedDataSet1.Faunistica' table. You can move, or remove it, as needed.
            Me.FaunisticaTableAdapter.Fill(Me.BDpescamedDataSet1.Faunistica)
            'TODO: This line of code loads data into the 'BDpescamedDataSet1.Lances' table. You can move, or remove it, as needed.
            Me.LancesTableAdapter.Fill(Me.BDpescamedDataSet1.Lances)

            ' llenar el combo tiposDeArte
            Dim sqlX As String = "select Ta_codarte, Ta_descripcion from artes order by ta_descripcion"
            Dim DaXX As New SqlClient.SqlDataAdapter(sqlX, GetConnectionString())
            Dim DTp As New DataTable
            DaXX.Fill(DTp)
            ComboBoxTiposArte.DataSource = DTp
            ComboBoxTiposArte.ValueMember = "Ta_Codarte"
            ComboBoxTiposArte.DisplayMember = "Ta_Descripcion"
            ComboBoxTiposArte.SelectedValue = TL_TipoArteTextBox.Text

            ' llenar el combo Barcos
            sqlX = "select tb_codbuque, tb_nombrebuque from buques order by tb_nombrebuque"
            Dim DaXX2 As New SqlClient.SqlDataAdapter(sqlX, GetConnectionString())
            Dim DTp2 As New DataTable
            DaXX2.Fill(DTp2)
            ComboBoxBarcos.DataSource = DTp2
            ComboBoxBarcos.ValueMember = "Tb_CodBuque"
            ComboBoxBarcos.DisplayMember = "Tb_nombreBuque"
            ComboBoxBarcos.SelectedValue = TL_CodBarcoTextBox.Text

            ' Llamamos a la funcion para formatear el DataGridView de Faunistica
            LLena_DGW_con_FaunisticaDElLance()
            LanceActivo = DimePrimerLance()

        Catch ex As Exception
            MsgBox("Error inesperado en la carga del formulario", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
  

    Private Sub TL_NuloTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TL_NuloTextBox.KeyPress
        If InStr(1, "SNsn," & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub ButtonNextLance_Click(sender As Object, e As EventArgs) Handles ButtonNextLance.Click
        Try
            LancesBindingSource.MoveNext()
            ComboBoxTiposArte.SelectedValue = TL_TipoArteTextBox.Text
            ComboBoxBarcos.SelectedValue = TL_CodBarcoTextBox.Text
            LLena_DGW_con_FaunisticaDElLance()
            LanceActivo = TL_CodLanceTextBox.Text
        Catch ex As Exception
            MsgBox("Error inesperado accediendo a siguiente lance.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ButtonPrevioLance_Click(sender As Object, e As EventArgs) Handles ButtonPrevioLance.Click
        Try
            LancesBindingSource.MovePrevious()
            ComboBoxTiposArte.SelectedValue = TL_TipoArteTextBox.Text
            ComboBoxBarcos.SelectedValue = TL_CodBarcoTextBox.Text
            LLena_DGW_con_FaunisticaDElLance()
            LanceActivo = TL_CodLanceTextBox.Text
        Catch ex As Exception
            MsgBox("Error inesperado accediendo a lance anterior.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ButtonLancePrimero_Click(sender As Object, e As EventArgs) Handles ButtonLancePrimero.Click
        Try
            LancesBindingSource.MoveFirst()
            ComboBoxTiposArte.SelectedValue = TL_TipoArteTextBox.Text
            ComboBoxBarcos.SelectedValue = TL_CodBarcoTextBox.Text
            LLena_DGW_con_FaunisticaDElLance()
            LanceActivo = TL_CodLanceTextBox.Text
        Catch ex As Exception
            MsgBox("Error inesperado accediendo a primer lance.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ButtonLanceUltimo_Click(sender As Object, e As EventArgs) Handles ButtonLanceUltimo.Click
        Try
            LancesBindingSource.MoveLast()
            ComboBoxTiposArte.SelectedValue = TL_TipoArteTextBox.Text
            ComboBoxBarcos.SelectedValue = TL_CodBarcoTextBox.Text
            LLena_DGW_con_FaunisticaDElLance()
            LanceActivo = TL_CodLanceTextBox.Text
        Catch ex As Exception
            MsgBox("Error inesperado accediendo a último lance.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ComboBoxTiposArte_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBoxTiposArte.SelectionChangeCommitted
        TL_TipoArteTextBox.Text = ComboBoxTiposArte.SelectedValue
    End Sub

    Private Sub ComboBoxBarcos_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBoxBarcos.SelectionChangeCommitted
        TL_CodBarcoTextBox.Text = ComboBoxBarcos.SelectedValue
    End Sub

   
    Private Sub BotonNuevoLance_Click(sender As Object, e As EventArgs) Handles BotonNuevoLance.Click
        Me.LancesBindingSource.AddNew()
        TL_FechaLanceDateTimePicker.Value = Date.Today
        TL_FirmesFechaDateTimePicker.Value = Date.Today
        TL_ViradaFechaDateTimePicker.Value = Date.Today
        TL_CodLanceTextBox.Focus()
    End Sub

    Public Sub LLena_DGW_con_FaunisticaDElLance()

        Try
            'Formateamos el DataGridView y filtramos para el lance.
            Me.FaunisticaDataGridView.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular)
            FaunisticaDataGridView.Columns(0).HeaderText = "Cod Lance"
            FaunisticaDataGridView.Columns(0).Width = 110
            FaunisticaDataGridView.Columns(1).HeaderText = "Cod Especie"
            FaunisticaDataGridView.Columns(1).Width = 200
            FaunisticaDataGridView.Columns(2).HeaderText = "Fracción"
            FaunisticaDataGridView.Columns(2).Width = 70

            FaunisticaDataGridView.Columns(3).HeaderText = "Peso Tot"
            FaunisticaDataGridView.Columns(3).Width = 110

            FaunisticaDataGridView.Columns(4).HeaderText = "Nº Ind"
            FaunisticaDataGridView.Columns(4).Width = 100

            FaunisticaDataGridView.Columns(5).HeaderText = "Peso Muest."
            FaunisticaDataGridView.Columns(5).Width = 130

            FaunisticaDataGridView.Columns(6).HeaderText = "Nº Ind Muestr."
            FaunisticaDataGridView.Columns(6).Width = 140

            FaunisticaDataGridView.Columns(7).HeaderText = "Talla I"
            FaunisticaDataGridView.Columns(7).Width = 100

            FaunisticaDataGridView.Columns(8).HeaderText = "Talla F"
            FaunisticaDataGridView.Columns(8).Width = 100

            FaunisticaBindingSource.Filter = "TF_codlance=" & Me.TL_CodLanceTextBox.Text
            FaunisticaBindingSource.Sort = "TF_codespecie"

        Catch ex As Exception
            MsgBox("Error inesperado completando faunística.", MsgBoxStyle.Critical, "Error")
        End Try


    End Sub
    Private Sub BotonActualizaFaunistica_Click(sender As Object, e As EventArgs) Handles BotonActualizaFaunistica.Click
        Try
            'Actualizamos los datos
            Me.FaunisticaTableAdapter.Update(BDpescamedDataSet1)
            ' Mostramos un mensaje
            MessageBox.Show("Se ha actualizado la lista faunística.")

        Catch ex As DBConcurrencyException
            MessageBox.Show("Error de concurrencia: " & vbCrLf & ex.Message)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BotonEliminaEspecieFaunistica_Click(sender As Object, e As EventArgs) Handles BotonEliminaEspecieFaunistica.Click
        Try
            Dim Buttons As MessageBoxButtons = MessageBoxButtons.YesNo
            Dim Result As DialogResult
            Result = MessageBox.Show("Borrar especie?", "Aviso", Buttons)
            If Result = System.Windows.Forms.DialogResult.Yes Then
                If FaunisticaDataGridView.SelectedRows.Count = 1 Then
                    Me.FaunisticaDataGridView.Rows.RemoveAt(FaunisticaDataGridView.SelectedCells.Item(0).RowIndex)
                Else
                    MsgBox("Seleccione una especie de la lista", MsgBoxStyle.Information, "Aviso")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error inesperado eliminando especie de faunística.", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub FaunisticaDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles FaunisticaDataGridView.CellClick
        ' Cuando entramos en el DGV en codLance, ponemos el valor del lance activo
        ' Pasamos a la siguiente columna
        Try
            If e.ColumnIndex <> -1 Then
                If FaunisticaDataGridView.Columns(e.ColumnIndex).Name = "DataGridViewTextBoxColumn1" Then
                    FaunisticaDataGridView.CurrentCell.Value = TL_CodLanceTextBox.Text
                    FaunisticaDataGridView.CurrentCell = FaunisticaDataGridView.Rows(e.RowIndex).Cells("DataGridViewComboBoxColumn2")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error inesperado en faunística.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub FaunisticaDataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles FaunisticaDataGridView.EditingControlShowing
        ' Se produce cuando un control de edición que una celda aparece.
        ' Ponemos la fracción en mayúscula
        Dim dgv As DataGridView = TryCast(sender, DataGridView)
        Dim tb As TextBox = TryCast(dgv.EditingControl, TextBox)
        If dgv.CurrentCell.ColumnIndex = 2 Then
            tb.CharacterCasing = CharacterCasing.Upper
        End If
    End Sub

    Private Sub FaunisticaDataGridView_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles FaunisticaDataGridView.CellValidating
        ' VAlidar la entrada de datos del DataGridView
        If FaunisticaDataGridView.Columns(e.ColumnIndex).Name = "DataGridViewComboBoxColumn2" Then
            If String.IsNullOrEmpty(e.FormattedValue.ToString()) Then
                e.Cancel = True
                MsgBox("Especie no puede quedar vacía.", MsgBoxStyle.Information, "Aviso")
            End If
        End If

        '------------------------------------------------
        If FaunisticaDataGridView.Columns(e.ColumnIndex).Name = "DataGridViewTextBoxColumn3" Then
            If String.IsNullOrEmpty(e.FormattedValue.ToString()) Then
                e.Cancel = True
                MsgBox("Fracción no puede quedar vacía.", MsgBoxStyle.Information, "Aviso")
                FaunisticaDataGridView.Rows(e.RowIndex).Cells(2).Selected = True
            Else
                If (e.FormattedValue.ToString() <> "D" And e.FormattedValue.ToString() <> "C") Then
                    e.Cancel = True
                    MsgBox("Fracción debe ser C o D", MsgBoxStyle.Information, "Aviso")
                    FaunisticaDataGridView.Rows(e.RowIndex).Cells(2).Selected = True
                End If
            End If
        End If
        '--------------------------------------------------------

        Dim PT, PM As Object
        If FaunisticaDataGridView.Columns(e.ColumnIndex).Name = "DataGridViewTextBoxColumn6" Then
            PT = FaunisticaDataGridView.CurrentRow.Cells(3).Value.ToString
            PM = e.FormattedValue.ToString()
            If Not String.IsNullOrEmpty(PT.ToString) And Not String.IsNullOrEmpty(PM.ToString) Then
                If (Val(PT) < Val(PM)) Then
                    e.Cancel = True
                    MsgBox("Peso de la Muestra debe ser menor que Peso Total.", MsgBoxStyle.Information, "Aviso")
                End If
            End If
        End If

        '--------------------------------------------------------
        Dim Ti, Tf As Object
        If FaunisticaDataGridView.Columns(e.ColumnIndex).Name = "DataGridViewTextBoxColumn9" Then
            If String.IsNullOrEmpty(FaunisticaDataGridView.CurrentRow.Cells(7).Value.ToString) And String.IsNullOrEmpty(FaunisticaDataGridView.CurrentRow.Cells(8).Value.ToString) Then
            Else ' Ti o Tf están rellenas
                Ti = FaunisticaDataGridView.CurrentRow.Cells(7).Value.ToString
                Tf = e.FormattedValue.ToString()
                If String.IsNullOrEmpty(Ti) Or String.IsNullOrEmpty(Tf) Then
                    e.Cancel = True
                    MsgBox("Error en Talla Inicial o Talla final, valor no puede ser nulo", MsgBoxStyle.Information, "Aviso")
                Else
                    If (Val(Tf) < Val(Ti)) Then
                        e.Cancel = True
                        MsgBox("Talla final debe ser mayor o igual que talla inicial", MsgBoxStyle.Information, "Aviso")
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Dime_SIel_lance_tiene_EspeciesEnFAunistica(TL_CodLanceTextBox.Text) = True Then
            LanceActivo = TL_CodLanceTextBox.Text
            Form4.Show()
        Else
            MsgBox("Lista faunística vacia. Introduzca alguna especie o acepte cambios.", MsgBoxStyle.Information, "Aviso")
        End If

    End Sub

    Private Sub BotonAbreFormularioCTD_Click(sender As Object, e As EventArgs) Handles BotonAbreFormularioCTD.Click
        Form6.Show()
    End Sub

    Private Sub BotonAbreFormularioGPS_Click(sender As Object, e As EventArgs) Handles BotonAbreFormularioGPS.Click
        Form7.Show()
    End Sub
    Public Function validaDatosEntrada() As Boolean
        Try
            If String.IsNullOrEmpty(TL_CodLanceTextBox.Text) Then
                MsgBox("El código de lance no puede ser nulo.", vbExclamation, "Error")
                TL_CodLanceTextBox.Focus()
                Return (False)
            End If
            If String.IsNullOrEmpty(TL_NuloTextBox.Text) Then
                MsgBox("El Campo NULO debe ser S o N.", vbExclamation, "Error")
                TL_nudosVelocidadTextBox.Focus()
                Return (False)
            End If
            If String.IsNullOrEmpty(TL_CodBarcoTextBox.Text) Then
                MsgBox("El Campo CÓDIGO DE BARCO no puede ser nulo", vbExclamation, "Error")
                ComboBoxBarcos.Focus()
                Return (False)
            End If
            If String.IsNullOrEmpty(TL_FechaLanceDateTimePicker.Text) Then
                MsgBox("El Campo FECHA DE LANCE no puede ser nulo", vbExclamation, "Error")
                TL_FechaLanceDateTimePicker.Focus()
                Return (False)
            End If
            If String.IsNullOrEmpty(TL_NumLanceTextBox.Text) Then
                MsgBox("El Campo NÚMERO DE LANCE no puede ser nulo", vbExclamation, "Error")
                TL_NumLanceTextBox.Focus()
                Return (False)
            End If
            If String.IsNullOrEmpty(TL_TipoArteTextBox.Text) Then
                MsgBox("El Campo TIPO DE ARTE no puede ser nulo", vbExclamation, "Error")
                ComboBoxTiposArte.Focus()
                Return (False)
            End If
            Return True

        Catch ex As Exception
            MsgBox("Error inesperado validando datos del lance.", MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Sub BotonAceptaCambios_Click(sender As Object, e As EventArgs) Handles BotonAceptaCambios.Click
        Try
            'Validamos entrada
            If validaDatosEntrada() = True Then
                'Actualizamos los datos

                Me.Validate()
                Me.LancesBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.BDpescamedDataSet1)
                ' Mostramos un mensaje
                MessageBox.Show("Se ha actualizado la base de datos.")
                LanceActivo = TL_CodBarcoTextBox.Text
                FaunisticaBindingSource.DataSource = FaunisticaTableAdapter.GetData()
                FaunisticaBindingSource.ResetBindings(False)
                LLena_DGW_con_FaunisticaDElLance()
            Else
            End If

        Catch ex As DBConcurrencyException
            MessageBox.Show("Error confirmando cambios. Error de concurrencia: " & vbCrLf & ex.Message)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    
    Private Sub TL_CodLanceTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TL_CodLanceTextBox.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    
    Private Sub TL_NumLanceTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TL_NumLanceTextBox.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BotonBorrarLance_Click(sender As Object, e As EventArgs) Handles BotonBorrarLance.Click
        Try
            Dim Buttons As MessageBoxButtons = MessageBoxButtons.YesNo
            Dim Result As DialogResult
            Result = MessageBox.Show("Confirmar borrado de lance.", "Aviso", Buttons)
            If Result = System.Windows.Forms.DialogResult.Yes Then
                Me.LancesBindingSource.RemoveCurrent()
                LancesBindingSource.MovePrevious()
                LLena_DGW_con_FaunisticaDElLance()
            End If
        Catch ex As Exception
            MsgBox("Error inesperado borrando lance.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub RefrescaListaFaunistica_Click(sender As Object, e As EventArgs) Handles RefrescaListaFaunistica.Click
        Try
            FaunisticaBindingSource.DataSource = FaunisticaTableAdapter.GetData()
            FaunisticaBindingSource.ResetBindings(False)
            FaunisticaDataGridView.Refresh()
        Catch ex As Exception
            MsgBox("Error inesperado recargando lista faunística.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub BotonIrA_Click(sender As Object, e As EventArgs) Handles BotonIrA.Click
        Try
            Dim NumLance As Object
            NumLance = InputBox("Introduce numero de lance.", "Ir a lance concreto")
            If Not String.IsNullOrEmpty(NumLance) Then
                If Not IsNumeric(NumLance) Then
                    MsgBox("Introduzca un número", MsgBoxStyle.Critical, "Error")
                Else ' es un número
                    If DimeSIElLanceEXISTE(NumLance) Then
                        LanceActivo = NumLance
                        Me.LancesBindingSource.Position = Me.LancesBindingSource.Find("TL_Codlance", LanceActivo)
                        LLena_DGW_con_FaunisticaDElLance()
                    Else
                        MsgBox("Lance inexistente", vbCritical)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error inesperado accediendo a lance concreto.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub


    Private Sub TL_TipoArteTextBox_Enter(sender As Object, e As EventArgs) Handles TL_TipoArteTextBox.Enter
        ComboBoxTiposArte.Focus() 'se obliga a elegir un arte de la lista desplegable
    End Sub

    Private Sub TL_CodBarcoTextBox_Enter(sender As Object, e As EventArgs) Handles TL_CodBarcoTextBox.Enter
        ComboBoxBarcos.Focus() 'Se obliga a elegir un barco de la lista desplegable
    End Sub

    Private Sub TL_PesoPuertaTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TL_PesoPuertaTextBox.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TL_PesoTotalDescarteTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TL_PesoTotalDescarteTextBox.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TL_PesoTotalComercialTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TL_PesoTotalComercialTextBox.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TL_RumboTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TL_RumboTextBox.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TL_nudosVelocidadTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TL_nudosVelocidadTextBox.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            If Char.IsPunctuation(e.KeyChar) Then 'permitimos el separador decimal
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub FaunisticaDataGridView_DefaultValuesNeeded(sender As Object, e As DataGridViewRowEventArgs) Handles FaunisticaDataGridView.DefaultValuesNeeded
        e.Row.Cells("DataGridViewTextBoxColumn1").Value = TL_CodLanceTextBox.Text
    End Sub

    Private Sub BotonBuscarLance_Click(sender As Object, e As EventArgs) Handles BotonBuscarLance.Click
        Form9.Show()
    End Sub
End Class