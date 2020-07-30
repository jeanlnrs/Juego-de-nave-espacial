<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Proyecto2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Proyecto2))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblVida = New System.Windows.Forms.Label()
        Me.lblNivel = New System.Windows.Forms.Label()
        Me.lblNivelValor = New System.Windows.Forms.Label()
        Me.lblVidaValor = New System.Windows.Forms.Label()
        Me.lblPuntoValor = New System.Windows.Forms.Label()
        Me.lblPuntos = New System.Windows.Forms.Label()
        Me.TimerNave = New System.Windows.Forms.Timer(Me.components)
        Me.TimerBasura = New System.Windows.Forms.Timer(Me.components)
        Me.TimerAsteroide = New System.Windows.Forms.Timer(Me.components)
        Me.lblCargaValor = New System.Windows.Forms.Label()
        Me.lblCarga = New System.Windows.Forms.Label()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.picNave = New System.Windows.Forms.PictureBox()
        Me.picBase = New System.Windows.Forms.PictureBox()
        Me.PicFondo = New System.Windows.Forms.PictureBox()
        Me.TimerContenedor = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picNave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicFondo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Constantia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(20, 57)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(98, 26)
        Me.lblTitulo.TabIndex = 2
        Me.lblTitulo.Text = "COHETE"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblVida
        '
        Me.lblVida.AutoSize = True
        Me.lblVida.BackColor = System.Drawing.Color.Transparent
        Me.lblVida.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVida.ForeColor = System.Drawing.Color.White
        Me.lblVida.Location = New System.Drawing.Point(21, 594)
        Me.lblVida.Name = "lblVida"
        Me.lblVida.Size = New System.Drawing.Size(94, 24)
        Me.lblVida.TabIndex = 3
        Me.lblVida.Text = "Vidas :"
        Me.lblVida.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblNivel
        '
        Me.lblNivel.AutoSize = True
        Me.lblNivel.BackColor = System.Drawing.Color.Transparent
        Me.lblNivel.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNivel.ForeColor = System.Drawing.Color.White
        Me.lblNivel.Location = New System.Drawing.Point(21, 628)
        Me.lblNivel.Name = "lblNivel"
        Me.lblNivel.Size = New System.Drawing.Size(94, 24)
        Me.lblNivel.TabIndex = 4
        Me.lblNivel.Text = "Nivel :"
        Me.lblNivel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblNivelValor
        '
        Me.lblNivelValor.AutoSize = True
        Me.lblNivelValor.BackColor = System.Drawing.Color.Transparent
        Me.lblNivelValor.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNivelValor.ForeColor = System.Drawing.Color.White
        Me.lblNivelValor.Location = New System.Drawing.Point(121, 628)
        Me.lblNivelValor.Name = "lblNivelValor"
        Me.lblNivelValor.Size = New System.Drawing.Size(22, 24)
        Me.lblNivelValor.TabIndex = 5
        Me.lblNivelValor.Text = "1"
        Me.lblNivelValor.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblVidaValor
        '
        Me.lblVidaValor.AutoSize = True
        Me.lblVidaValor.BackColor = System.Drawing.Color.Transparent
        Me.lblVidaValor.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVidaValor.ForeColor = System.Drawing.Color.White
        Me.lblVidaValor.Location = New System.Drawing.Point(114, 594)
        Me.lblVidaValor.Name = "lblVidaValor"
        Me.lblVidaValor.Size = New System.Drawing.Size(22, 24)
        Me.lblVidaValor.TabIndex = 6
        Me.lblVidaValor.Text = "5"
        Me.lblVidaValor.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPuntoValor
        '
        Me.lblPuntoValor.AutoSize = True
        Me.lblPuntoValor.BackColor = System.Drawing.Color.Transparent
        Me.lblPuntoValor.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPuntoValor.ForeColor = System.Drawing.Color.White
        Me.lblPuntoValor.Location = New System.Drawing.Point(133, 94)
        Me.lblPuntoValor.Name = "lblPuntoValor"
        Me.lblPuntoValor.Size = New System.Drawing.Size(22, 24)
        Me.lblPuntoValor.TabIndex = 8
        Me.lblPuntoValor.Text = "0"
        Me.lblPuntoValor.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPuntos
        '
        Me.lblPuntos.AutoSize = True
        Me.lblPuntos.BackColor = System.Drawing.Color.Transparent
        Me.lblPuntos.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPuntos.ForeColor = System.Drawing.Color.White
        Me.lblPuntos.Location = New System.Drawing.Point(21, 94)
        Me.lblPuntos.Name = "lblPuntos"
        Me.lblPuntos.Size = New System.Drawing.Size(106, 24)
        Me.lblPuntos.TabIndex = 7
        Me.lblPuntos.Text = "Puntos :"
        Me.lblPuntos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TimerNave
        '
        Me.TimerNave.Interval = 200
        '
        'TimerBasura
        '
        Me.TimerBasura.Interval = 200
        '
        'TimerAsteroide
        '
        Me.TimerAsteroide.Interval = 200
        '
        'lblCargaValor
        '
        Me.lblCargaValor.AutoSize = True
        Me.lblCargaValor.BackColor = System.Drawing.Color.Transparent
        Me.lblCargaValor.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCargaValor.ForeColor = System.Drawing.Color.White
        Me.lblCargaValor.Location = New System.Drawing.Point(104, 24)
        Me.lblCargaValor.Name = "lblCargaValor"
        Me.lblCargaValor.Size = New System.Drawing.Size(22, 24)
        Me.lblCargaValor.TabIndex = 11
        Me.lblCargaValor.Text = "0"
        Me.lblCargaValor.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCarga
        '
        Me.lblCarga.AutoSize = True
        Me.lblCarga.BackColor = System.Drawing.Color.Transparent
        Me.lblCarga.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarga.ForeColor = System.Drawing.Color.White
        Me.lblCarga.Location = New System.Drawing.Point(21, 24)
        Me.lblCarga.Name = "lblCarga"
        Me.lblCarga.Size = New System.Drawing.Size(94, 24)
        Me.lblCarga.TabIndex = 10
        Me.lblCarga.Text = "Carga :"
        Me.lblCarga.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.BackColor = System.Drawing.Color.Transparent
        Me.lblMensaje.Font = New System.Drawing.Font("Consolas", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.ForeColor = System.Drawing.Color.White
        Me.lblMensaje.Location = New System.Drawing.Point(356, 169)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(310, 56)
        Me.lblMensaje.TabIndex = 12
        Me.lblMensaje.Text = "Has Ganado!"
        Me.lblMensaje.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblMensaje.Visible = False
        '
        'btnIniciar
        '
        Me.btnIniciar.BackColor = System.Drawing.Color.Transparent
        Me.btnIniciar.BackgroundImage = Global.Proyecto2.My.Resources.Resources.galaxia
        Me.btnIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIniciar.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciar.Image = CType(resources.GetObject("btnIniciar.Image"), System.Drawing.Image)
        Me.btnIniciar.Location = New System.Drawing.Point(351, 228)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(332, 318)
        Me.btnIniciar.TabIndex = 1
        Me.btnIniciar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnIniciar.UseVisualStyleBackColor = False
        '
        'picNave
        '
        Me.picNave.BackColor = System.Drawing.Color.Transparent
        Me.picNave.Location = New System.Drawing.Point(473, 302)
        Me.picNave.Name = "picNave"
        Me.picNave.Size = New System.Drawing.Size(75, 75)
        Me.picNave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picNave.TabIndex = 0
        Me.picNave.TabStop = False
        Me.picNave.Visible = False
        '
        'picBase
        '
        Me.picBase.BackColor = System.Drawing.Color.Transparent
        Me.picBase.Image = Global.Proyecto2.My.Resources.Resources.contenedor
        Me.picBase.Location = New System.Drawing.Point(378, 594)
        Me.picBase.Name = "picBase"
        Me.picBase.Size = New System.Drawing.Size(212, 96)
        Me.picBase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBase.TabIndex = 9
        Me.picBase.TabStop = False
        Me.picBase.Visible = False
        '
        'PicFondo
        '
        Me.PicFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PicFondo.Image = CType(resources.GetObject("PicFondo.Image"), System.Drawing.Image)
        Me.PicFondo.Location = New System.Drawing.Point(4, 4)
        Me.PicFondo.MaximumSize = New System.Drawing.Size(1017, 690)
        Me.PicFondo.MinimumSize = New System.Drawing.Size(1017, 690)
        Me.PicFondo.Name = "PicFondo"
        Me.PicFondo.Size = New System.Drawing.Size(1017, 690)
        Me.PicFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicFondo.TabIndex = 13
        Me.PicFondo.TabStop = False
        '
        'TimerContenedor
        '
        '
        'Proyecto2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1025, 685)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.lblCargaValor)
        Me.Controls.Add(Me.lblCarga)
        Me.Controls.Add(Me.lblPuntoValor)
        Me.Controls.Add(Me.lblPuntos)
        Me.Controls.Add(Me.lblVidaValor)
        Me.Controls.Add(Me.lblNivelValor)
        Me.Controls.Add(Me.lblNivel)
        Me.Controls.Add(Me.lblVida)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.picNave)
        Me.Controls.Add(Me.picBase)
        Me.Controls.Add(Me.PicFondo)
        Me.MaximumSize = New System.Drawing.Size(1041, 797)
        Me.MinimumSize = New System.Drawing.Size(894, 539)
        Me.Name = "Proyecto2"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Text = "Ecologia Espacial"
        CType(Me.picNave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicFondo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picNave As PictureBox
    Friend WithEvents btnIniciar As Button
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblVida As Label
    Friend WithEvents lblNivel As Label
    Friend WithEvents lblNivelValor As Label
    Friend WithEvents lblVidaValor As Label
    Friend WithEvents lblPuntoValor As Label
    Friend WithEvents lblPuntos As Label
    Friend WithEvents TimerNave As Timer
    Friend WithEvents TimerBasura As Timer
    Friend WithEvents TimerAsteroide As Timer
    Friend WithEvents picBase As PictureBox
    Friend WithEvents lblCargaValor As Label
    Friend WithEvents lblCarga As Label
    Friend WithEvents lblMensaje As Label
    Friend WithEvents TimerContenedor As Timer
    Friend WithEvents PicFondo As PictureBox
End Class
