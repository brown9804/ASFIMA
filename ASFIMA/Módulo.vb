Imports System.ComponentModel
Imports System.Globalization
Imports System.Threading.Thread

<Description("Control TextBox numérico personalizado.")>
    Public Class NumericTextBox

        Inherits System.Windows.Forms.TextBox

        Private m_decimalSeparator As Char
        Private m_negativeSign As Char
        Private m_positiveSign As Char

        Private Const WM_PASTE As Int32 = &H302

#Region "Constructor predeterminado."

        Public Sub New()

            ' Por defecto, el valor del texto estará alineado a la derecha(Ya no).
            '
            MyBase.TextAlign = HorizontalAlignment.Left

            ' Obtengo el carácter separador decimal existente
            ' actualmente en la configuración regional de Windows. 
            ' 
            Dim numberFormatInfo As NumberFormatInfo = CurrentThread.CurrentCulture.NumberFormat
            m_decimalSeparator = numberFormatInfo.NumberDecimalSeparator.Chars(0)

            m_negativeSign = numberFormatInfo.NegativeSign.Chars(0)
            m_positiveSign = numberFormatInfo.PositiveSign.Chars(0)

        End Sub

#End Region

        ''' <summary>
        ''' Mueve la selección actual del cuadro de texto al Portapapeles.
        ''' </summary>
        ''' <remarks></remarks>
        Public Overloads Sub Paste()

            ' Procesamos el mensaje WM_PASTE
            '
            Dim m As System.Windows.Forms.Message

            ' Pegar
            m.Msg = WM_PASTE
            m.HWnd = New IntPtr(Me.Handle.ToInt64)

            Me.WndProc(m)

            Application.DoEvents()

        End Sub

        Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)

            If (m.Msg = WM_PASTE) Then
                If (Not (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))) Then Return

                ' Comprobamos si el contenido del portapapeles es numérico.
                If (Not (ValidateClipboardText())) Then Return
            End If

            ' Procesamos los restantes mensajes
            MyBase.WndProc(m)

        End Sub

        Protected Overridable Function ValidateClipboardText() As Boolean

            ' La función comprobará el contenido del Portapapeles de Windows
            ' para verificar si su contenido es o no numérico.
            '
            If (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text)) Then

                Dim value As String = Clipboard.GetText(TextDataFormat.Text)

                ' Devolveremos True si el valor se puede convertir a Decimal.
                '
                Return ValidateText(value)

            Else
                Return False

            End If

        End Function

        Protected Overridable Function ValidateText(ByVal value As String) As Boolean

            ' Devolveremos True si el valor se puede convertir a Decimal.
            '
            Dim number As Decimal = 0D

            ' Siempre que el valor se pueda pasar a Decimal,
            ' se tratará de un número válido. Si el valor
            ' alfanumérico no se puede convertir a Decimal,
            ' la función devolverá False.
            '
            Return Decimal.TryParse(value, number)

        End Function

        Protected Overrides Sub OnKeyPress(ByVal e As KeyPressEventArgs)

            MyBase.OnKeyPress(e)

            If (e Is Nothing) Then Return

            Dim isDecimal, isSign, isValidChar, isPotencia, isDivision, isMultiplicacion As Boolean

            Select Case e.KeyChar
                Case "."c, ","c
                    ' Hacemos que el carácter tecleado coincida con el
                    ' carácter separador existentente en la configuración
                    ' regional.
                    '
                    e.KeyChar = m_decimalSeparator

                    ' Si el primer carácter que se teclea es el separador decimal,
                    ' o si bien, existe un signo en el primer carácter, envío la
                    ' combinación '0,'.
                    '
                    If (((TextLength = 0) OrElse (SelectionLength = TextLength)) OrElse
                    ((TextLength = 1) AndAlso ((Text.Contains(m_negativeSign)) OrElse
                                               (Text.Contains(m_positiveSign))))) Then

                        ' NOTA: Envío la combinación "0," mediante el método Send,
                        ' para que en el código cliente se desencadenen los
                        ' eventos de teclado.
                        '
                        SendKeys.Send("{0}")
                        SendKeys.Send("{" & m_decimalSeparator & "}")
                        e.Handled = True
                        Return

                    End If

                    ' Es un carácter válido.
                    '
                    isDecimal = True
                    isValidChar = True

                Case m_negativeSign, m_positiveSign ' Signos negativo y positivo
                    ' Es un carácter válido.
                    '
                    isSign = True
                    isValidChar = True

                Case "*"c
                    Dim longitud As Short
                    Dim ultcar As String
                    longitud = TextLength
                    ultcar = Strings.Right(Text, 1)
                    If (((TextLength = 0) OrElse (SelectionLength = TextLength)) OrElse
                    ((TextLength = 1) AndAlso ((Text.Contains(m_negativeSign)) OrElse
                                               (Text.Contains(m_positiveSign))))) Then

                        Text = Text & "0*"
                        SelectionStart = Val(longitud + 2)
                        e.Handled = True
                        Return

                    ElseIf ultcar = "*" Or ultcar = "/" Or ultcar = "^" Then
                        Text = Text & "0*"
                        SelectionStart = Val(longitud + 2)
                    ElseIf ultcar = m_decimalSeparator
                        Text = Text & "0*"
                        SelectionStart = Val(longitud + 2)
                    Else
                        Text = Text & "*"
                        SelectionStart = Val(longitud + 1)
                    End If

                    isMultiplicacion = True
                    isValidChar = True
                    e.Handled = True

                Case "/"c
                    Dim longitud As Short
                    Dim ultcar As String
                    longitud = TextLength
                    ultcar = Strings.Right(Text, 1)
                    If (((TextLength = 0) OrElse (SelectionLength = TextLength)) OrElse
                    ((TextLength = 1) AndAlso ((Text.Contains(m_negativeSign)) OrElse
                                               (Text.Contains(m_positiveSign))))) Then

                        Text = Text & "0/"
                        SelectionStart = Val(longitud + 2)
                        e.Handled = True
                        Return

                    ElseIf ultcar = "*" Or ultcar = "/" Or ultcar = "^" Then
                        Text = Text & "0/"
                        SelectionStart = Val(longitud + 2)
                    ElseIf ultcar = m_decimalSeparator
                        Text = Text & "0/"
                        SelectionStart = Val(longitud + 2)
                    Else
                        Text = Text & "/"
                        SelectionStart = Val(longitud + 1)
                    End If

                    isDivision = True
                    isValidChar = True
                    e.Handled = True

                Case "^"c
                    Dim longitud As Short
                    Dim ultcar As String
                    longitud = TextLength
                    ultcar = Strings.Right(Text, 1)
                    If (((TextLength = 0) OrElse (SelectionLength = TextLength)) OrElse
                    ((TextLength = 1) AndAlso ((Text.Contains(m_negativeSign)) OrElse
                                               (Text.Contains(m_positiveSign))))) Then

                        Text = Text & "0^"
                        SelectionStart = Val(longitud + 2)
                        e.Handled = True
                        Return

                    ElseIf ultcar = "*" Or ultcar = "/" Or ultcar = "^" Then
                        Text = Text & "0^"
                        SelectionStart = Val(longitud + 2)
                    ElseIf ultcar = m_decimalSeparator
                        Text = Text & "0^"
                        SelectionStart = Val(longitud + 2)
                    Else
                        Text = Text & "^"
                        SelectionStart = Val(longitud + 1)
                    End If

                    isPotencia = True
                    isValidChar = True
                    e.Handled = True

                Case Else
                    ' Sólo se admitirán números y la tecla de retroceso.
                    '
                    Dim isDigit As Boolean = Char.IsDigit(e.KeyChar)
                    Dim isControl As Boolean = Char.IsControl(e.KeyChar)

                    If ((isDigit) OrElse (isControl)) Then
                        isValidChar = True

                    Else
                        e.Handled = True
                        Return

                    End If

            End Select

            ' Si es un carácter válido, y el texto del control
            ' se encuentra totalmente seleccionado, elimino
            ' el valor actual del control.
            '
            If ((isValidChar) And (Me.SelectionLength = Me.TextLength)) Then
                Me.Text = String.Empty
            End If

            If (isSign) Then
                ' Admitimos los caracteres positivo y negativo, siempre y cuando
                ' sea el primer carácter del texto, y no exista ya ningún otro
                ' signo escrito en el control.
                '
                If ((Me.SelectionStart <> 0) OrElse
                (Me.Text.IndexOf(m_negativeSign) >= 0) OrElse
                (Me.Text.IndexOf(m_positiveSign) >= 0)) Then
                    e.Handled = True
                    Return
                End If
            End If

            If (isDivision) Then
                ' Si en el control hay ya escrito un separador decimal, 
                ' deshechamos insertar otro separador más. 
                ' 
                If (Me.Text.IndexOf("/") >= 0) Then
                    e.Handled = True
                    Return
                End If
            End If

            If (isPotencia) Then
                ' Si en el control hay ya escrito un separador decimal, 
                ' deshechamos insertar otro separador más. 
                ' 
                If (Me.Text.IndexOf("^") >= 0) Then
                    e.Handled = True
                    Return
                End If
            End If

            If (isMultiplicacion) Then
                ' Si en el control hay ya escrito un separador decimal, 
                ' deshechamos insertar otro separador más. 
                ' 
                If (Me.Text.IndexOf("*") >= 0) Then
                    e.Handled = True
                    Return
                End If
            End If

            If (isDecimal) Then
                ' Si en el control hay ya escrito un separador decimal, 
                ' deshechamos insertar otro separador más. 
                ' 
                If (Me.Text.IndexOf(m_decimalSeparator) >= 0) Then
                    e.Handled = True
                    Return
                End If
            End If
        End Sub

    End Class

Module Módulo
    Public inco1 As Double
    Public inco2 As Double
End Module

