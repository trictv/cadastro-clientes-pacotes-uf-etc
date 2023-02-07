Imports System.Data.SqlClient
Imports WindowsApp1.Dados.dados

Public Class Form1






    Private Sub Gravar()
        Dim objeto As New Cliente

        objeto.NomeCli = txtNome.Text.Trim()
        objeto.SobrenomeCli = txtSobrenome.Text.Trim()
        objeto.N_DocumentoCli = txtNDocumento.Text.Trim()
        If cbxTipoFJ.Text = "Fisico" Then
            objeto.TipoFJ_Cli = "0"
        Else
            objeto.TipoFJ_Cli = "1"
        End If
        objeto.EmailCli = txtEmail.Text.Trim()
        objeto.TelefoneCli = txtTelefone.Text.Trim()
        objeto.CepCli = txtCep.Text.Trim()
        objeto.CidadeCli = txtCidade.Text.Trim()
        objeto.EstadoCli = txtEstado.Text.Trim()
        objeto.PaisCli = txtPais.Text.Trim()
        objeto.RuaCli = txtRua.Text.Trim()
        objeto.NumeroCli = txtNumero.Text.Trim()
        objeto.BairroCli = txtBairro.Text.Trim()
        If chkAtivo.Checked Then
            objeto.AtivoCli = 0
        Else
            objeto.AtivoCli = 1
        End If
        objeto.GravarCliente(objeto)
    End Sub
    Private Sub ExcluirCliente(ByVal IdCliente As Integer)

        Dim objDados As New Cliente()
        objDados.ExcluirCliente(IdCliente)

    End Sub
    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        If Not VerificaVazio() Then
            Exit Sub
        End If
        Gravar()
        MessageBox.Show("cliente salvo")
        LimpaControles()

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        ExcluirCliente(Integer.Parse(txtID.Text.Trim))
        LimpaControles()
        AlteraEstado(eStatus.Insercao)
        MessageBox.Show("Cliente Excluido")
    End Sub

    Private Sub txtEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If txtNome.Enabled = False Then
            AlteraEstado(eStatus.Insercao)
            btnBuscarVoltar.Enabled = False
            txtID.Enabled = False
            btnNovo.Enabled = False
            btnNovo.Enabled = False
            btnEditar.Text = "Salvar"
            Exit Sub
        End If

        Editar()
        MessageBox.Show("Cliente Editado")
        btnEditar.Text = "Editar"
        LimpaControles()
    End Sub
    Public Enum eStatus
        Insercao = 0
        Visualizacao = 1
    End Enum
    Private Sub btnBuscarVoltar_Click(sender As Object, e As EventArgs) Handles btnBuscarVoltar.Click
        Dim objeto As New Cliente
        objeto.IdCli = Integer.Parse(txtID.Text.Trim)
        objeto.ConsultarClientes()
        If objeto.ConsultarClientes.Rows.Count = 0 Then
            MessageBox.Show("Cliente Não Cadastrado")
            txtID.Text = ""
            Exit Sub
        End If

        txtNome.Text = objeto.NomeCli
        txtSobrenome.Text = objeto.SobrenomeCli
        txtNDocumento.Text = objeto.N_DocumentoCli
        If objeto.TipoFJ_Cli = "0" Then
            cbxTipoFJ.Text = "Fisico"
        Else
            cbxTipoFJ.Text = "Juridico"
        End If
        AlteraEstado(eStatus.Visualizacao)
        txtEmail.Text = objeto.EmailCli
        txtTelefone.Text = objeto.TelefoneCli
        txtCep.Text = objeto.CepCli
        txtCidade.Text = objeto.CidadeCli
        txtEstado.Text = objeto.EstadoCli
        txtPais.Text = objeto.PaisCli
        txtRua.Text = objeto.RuaCli
        txtNumero.Text = objeto.NumeroCli
        txtBairro.Text = objeto.BairroCli
        If objeto.AtivoCli = 0 Then
            chkAtivo.Checked = True
        Else
            chkAtivo.Checked = False
        End If



        btnExcluir.Enabled = True
        btnEditar.Enabled = True
    End Sub



    Public Sub AlteraEstado(status As eStatus)
        Dim valor As Boolean = False

        If status = eStatus.Insercao Then
            valor = True
        End If
        btnNovo.Enabled = valor
        btnCancelar.Enabled = Not valor
        txtID.Enabled = valor
        btnBuscarVoltar.Enabled = valor
        txtNome.Enabled = valor
        txtSobrenome.Enabled = valor
        txtNDocumento.Enabled = valor
        cbxTipoFJ.Enabled = valor
        txtEmail.Enabled = valor
        txtTelefone.Enabled = valor
        txtCep.Enabled = valor
        txtCidade.Enabled = valor
        txtEstado.Enabled = valor
        txtPais.Enabled = valor
        txtRua.Enabled = valor
        txtNumero.Enabled = valor
        txtBairro.Enabled = valor
        chkAtivo.Checked = valor
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        AlteraEstado(eStatus.Insercao)
        LimpaControles()
    End Sub

    Public Sub LimpaControles()
        txtID.Text = ""
        txtNome.Text = ""
        txtSobrenome.Text = ""
        txtNDocumento.Text = ""
        cbxTipoFJ.Text = ""
        txtEmail.Text = ""
        txtTelefone.Text = ""
        txtCep.Text = ""
        txtCidade.Text = ""
        txtEstado.Text = ""
        txtPais.Text = ""
        txtRua.Text = ""
        txtNumero.Text = ""
        txtBairro.Text = ""
        chkAtivo.Checked = False
        cbxTipoFJ.SelectedIndex = -1
        btnEditar.Enabled = False
        btnExcluir.Enabled = False
        txtID.Enabled = True
        btnBuscarVoltar.Enabled = True
        btnNovo.Enabled = True
        txtID.Focus()
    End Sub

    Private Sub txtTelefone_TextChanged(sender As Object, e As EventArgs) Handles txtTelefone.TextChanged
        If Len(txtTelefone.Text) = 1 Then
            txtTelefone.Text = "(" & txtTelefone.Text
            txtTelefone.SelectionStart = Len(txtTelefone.Text) + 1
        ElseIf Len(txtTelefone.Text) = 3 Then
            txtTelefone.Text = txtTelefone.Text & ") "
            txtTelefone.SelectionStart = Len(txtTelefone.Text) + 1
        ElseIf Len(txtTelefone.Text) = 10 Then
            txtTelefone.Text = txtTelefone.Text & "-"
            txtTelefone.SelectionStart = Len(txtTelefone.Text) + 1
        End If
    End Sub

    Private Sub txtCep_TextChanged(sender As Object, e As EventArgs) Handles txtCep.TextChanged

        If Len(txtCep.Text) = 5 Then
            txtCep.Text = txtCep.Text & "-"
            txtCep.SelectionStart = Len(txtCep.Text) + 1

        End If

    End Sub

    Private Sub txtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then

            e.Handled = True

        End If
    End Sub



    Private Sub txtCep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCep.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then

            e.Handled = True

        End If
    End Sub

    Private Sub txtTelefone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefone.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then

            e.Handled = True

        End If
    End Sub

    Public Function VerificaVazio() As Boolean
        If txtNome.Text <> "" And txtSobrenome.Text <> "" And
           txtNDocumento.Text <> "" And cbxTipoFJ.Text <> "" And
           txtEmail.Text <> "" And txtTelefone.Text <> "" And
           txtCep.Text <> "" And txtCidade.Text <> "" And
           txtEstado.Text <> "" And txtPais.Text <> "" And
           txtRua.Text <> "" And txtNumero.Text <> "" And txtBairro.Text <> "" Then
            Return True
        Else
            MessageBox.Show("POR FAVOR PREENCHER TODOS OS CAMPOS!")
            Return False
        End If
    End Function

    Public Sub Editar()
        Dim objeto As New Cliente()

        objeto.IdCli = txtID.Text
        objeto.NomeCli = txtNome.Text.Trim()
        objeto.SobrenomeCli = txtSobrenome.Text.Trim()
        objeto.N_DocumentoCli = txtNDocumento.Text.Trim()
        If cbxTipoFJ.Text = "Fisico" Then
            objeto.TipoFJ_Cli = "0"
        Else
            objeto.TipoFJ_Cli = "1"
        End If
        objeto.EmailCli = txtEmail.Text.Trim()
        objeto.TelefoneCli = txtTelefone.Text.Trim()
        objeto.CepCli = txtCep.Text.Trim()
        objeto.CidadeCli = txtCidade.Text.Trim()
        objeto.EstadoCli = txtEstado.Text.Trim()
        objeto.PaisCli = txtPais.Text.Trim()
        objeto.RuaCli = txtRua.Text.Trim()
        objeto.NumeroCli = txtNumero.Text.Trim()
        objeto.BairroCli = txtBairro.Text.Trim()
        If chkAtivo.Checked Then
            objeto.AtivoCli = 0
        Else
            objeto.AtivoCli = 1
        End If
        objeto.EditaCliente(objeto)
    End Sub

    Private Sub txtNDocumento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNDocumento.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then

            e.Handled = True

        End If
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then

            e.Handled = True

        End If
    End Sub



    Private Sub txtNome_TextChanged(sender As Object, e As EventArgs) Handles txtNome.TextChanged, txtSobrenome.TextChanged, txtNDocumento.TextChanged, txtEmail.TextChanged, txtTelefone.TextChanged, txtCep.TextChanged, txtCidade.TextChanged, txtEstado.TextChanged, txtPais.TextChanged, txtRua.TextChanged, txtNumero.TextChanged, txtBairro.TextChanged
        If txtNome.Text <> "" Or txtSobrenome.Text <> "" Or
        txtNDocumento.Text <> "" Or cbxTipoFJ.Text <> "" Or
        txtEmail.Text <> "" Or txtTelefone.Text <> "" Or
        txtCep.Text <> "" Or txtCidade.Text <> "" Or
        txtEstado.Text <> "" Or txtPais.Text <> "" Or
        txtRua.Text <> "" Or txtNumero.Text <> "" Or txtBairro.Text <> "" Then
            btnCancelar.Enabled = True
        Else
            btnCancelar.Enabled = False
        End If
    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged
        'Dim objeto As New Cliente

        'Try
        '    objeto.IdCli = Integer.Parse(txtID.Text.Trim)
        'Catch ex As Exception

        'End Try

        'objeto.ConsultarClientes()
        'If objeto.ConsultarClientes.Rows.Count = 0 Then
        '    LimpaControles()
        '    AlteraEstado(eStatus.Insercao)
        '    Exit Sub
        'End If

        'txtNome.Text = objeto.NomeCli
        'txtSobrenome.Text = objeto.SobrenomeCli
        'txtNDocumento.Text = objeto.N_DocumentoCli
        'If objeto.TipoFJ_Cli = "0" Then
        '    cbxTipoFJ.Text = "Fisico"
        'Else
        '    cbxTipoFJ.Text = "Juridico"
        'End If
        'AlteraEstado(eStatus.Visualizacao)
        'txtEmail.Text = objeto.EmailCli
        'txtTelefone.Text = objeto.TelefoneCli
        'txtCep.Text = objeto.CepCli
        'txtCidade.Text = objeto.CidadeCli
        'txtEstado.Text = objeto.EstadoCli
        'txtPais.Text = objeto.PaisCli
        'txtRua.Text = objeto.RuaCli
        'txtNumero.Text = objeto.NumeroCli
        'txtBairro.Text = objeto.BairroCli
        'If objeto.AtivoCli = 0 Then
        '    chkAtivo.Checked = True
        'Else
        '    chkAtivo.Checked = False
        'End If



        'btnExcluir.Enabled = True
        'btnEditar.Enabled = True
    End Sub
End Class


