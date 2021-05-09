<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AngelFruit = New System.Windows.Forms.Button()
        Me.Pudding = New System.Windows.Forms.Button()
        Me.Macaron = New System.Windows.Forms.Button()
        Me.RollCake = New System.Windows.Forms.Button()
        Me.BlackForest = New System.Windows.Forms.Button()
        Me.RedVelvet = New System.Windows.Forms.Button()
        Me.CheeseCake = New System.Windows.Forms.Button()
        Me.Tiramisu = New System.Windows.Forms.Button()
        Me.IceCream = New System.Windows.Forms.Button()
        Me.OreoMilkshake = New System.Windows.Forms.Button()
        Me.IcedMilkTea = New System.Windows.Forms.Button()
        Me.IcedTea = New System.Windows.Forms.Button()
        Me.MalikaIcedCoffee = New System.Windows.Forms.Button()
        Me.IcedMocha = New System.Windows.Forms.Button()
        Me.CoffeeLatte = New System.Windows.Forms.Button()
        Me.Expresso = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cboPayment = New System.Windows.Forms.ComboBox()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnC = New System.Windows.Forms.Button()
        Me.BtnDot = New System.Windows.Forms.Button()
        Me.Btn0 = New System.Windows.Forms.Button()
        Me.Btn9 = New System.Windows.Forms.Button()
        Me.Btn8 = New System.Windows.Forms.Button()
        Me.Btn7 = New System.Windows.Forms.Button()
        Me.Btn6 = New System.Windows.Forms.Button()
        Me.Btn5 = New System.Windows.Forms.Button()
        Me.Btn4 = New System.Windows.Forms.Button()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemoveItem = New System.Windows.Forms.Button()
        Me.Pay = New System.Windows.Forms.Button()
        Me.Print = New System.Windows.Forms.Button()
        Me.Clear = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Info
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Segoe Script", 36.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(537, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(368, 82)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cafe Kitakita"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Info
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.AngelFruit)
        Me.Panel1.Controls.Add(Me.Pudding)
        Me.Panel1.Controls.Add(Me.Macaron)
        Me.Panel1.Controls.Add(Me.RollCake)
        Me.Panel1.Controls.Add(Me.BlackForest)
        Me.Panel1.Controls.Add(Me.RedVelvet)
        Me.Panel1.Controls.Add(Me.CheeseCake)
        Me.Panel1.Controls.Add(Me.Tiramisu)
        Me.Panel1.Controls.Add(Me.IceCream)
        Me.Panel1.Controls.Add(Me.OreoMilkshake)
        Me.Panel1.Controls.Add(Me.IcedMilkTea)
        Me.Panel1.Controls.Add(Me.IcedTea)
        Me.Panel1.Controls.Add(Me.MalikaIcedCoffee)
        Me.Panel1.Controls.Add(Me.IcedMocha)
        Me.Panel1.Controls.Add(Me.CoffeeLatte)
        Me.Panel1.Controls.Add(Me.Expresso)
        Me.Panel1.Location = New System.Drawing.Point(32, 156)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(500, 502)
        Me.Panel1.TabIndex = 1
        '
        'AngelFruit
        '
        Me.AngelFruit.BackgroundImage = CType(resources.GetObject("AngelFruit.BackgroundImage"), System.Drawing.Image)
        Me.AngelFruit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AngelFruit.Location = New System.Drawing.Point(375, 376)
        Me.AngelFruit.Name = "AngelFruit"
        Me.AngelFruit.Size = New System.Drawing.Size(100, 100)
        Me.AngelFruit.TabIndex = 15
        Me.AngelFruit.UseVisualStyleBackColor = True
        '
        'Pudding
        '
        Me.Pudding.BackgroundImage = CType(resources.GetObject("Pudding.BackgroundImage"), System.Drawing.Image)
        Me.Pudding.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pudding.Location = New System.Drawing.Point(259, 376)
        Me.Pudding.Name = "Pudding"
        Me.Pudding.Size = New System.Drawing.Size(100, 100)
        Me.Pudding.TabIndex = 14
        Me.Pudding.UseVisualStyleBackColor = True
        '
        'Macaron
        '
        Me.Macaron.BackgroundImage = CType(resources.GetObject("Macaron.BackgroundImage"), System.Drawing.Image)
        Me.Macaron.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Macaron.Location = New System.Drawing.Point(143, 376)
        Me.Macaron.Name = "Macaron"
        Me.Macaron.Size = New System.Drawing.Size(100, 100)
        Me.Macaron.TabIndex = 13
        Me.Macaron.UseVisualStyleBackColor = True
        '
        'RollCake
        '
        Me.RollCake.BackgroundImage = CType(resources.GetObject("RollCake.BackgroundImage"), System.Drawing.Image)
        Me.RollCake.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RollCake.Location = New System.Drawing.Point(26, 376)
        Me.RollCake.Name = "RollCake"
        Me.RollCake.Size = New System.Drawing.Size(100, 100)
        Me.RollCake.TabIndex = 12
        Me.RollCake.UseVisualStyleBackColor = True
        '
        'BlackForest
        '
        Me.BlackForest.BackgroundImage = CType(resources.GetObject("BlackForest.BackgroundImage"), System.Drawing.Image)
        Me.BlackForest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BlackForest.Location = New System.Drawing.Point(375, 264)
        Me.BlackForest.Name = "BlackForest"
        Me.BlackForest.Size = New System.Drawing.Size(100, 100)
        Me.BlackForest.TabIndex = 11
        Me.BlackForest.UseVisualStyleBackColor = True
        '
        'RedVelvet
        '
        Me.RedVelvet.BackgroundImage = CType(resources.GetObject("RedVelvet.BackgroundImage"), System.Drawing.Image)
        Me.RedVelvet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RedVelvet.Location = New System.Drawing.Point(259, 264)
        Me.RedVelvet.Name = "RedVelvet"
        Me.RedVelvet.Size = New System.Drawing.Size(100, 100)
        Me.RedVelvet.TabIndex = 10
        Me.RedVelvet.UseVisualStyleBackColor = True
        '
        'CheeseCake
        '
        Me.CheeseCake.BackgroundImage = CType(resources.GetObject("CheeseCake.BackgroundImage"), System.Drawing.Image)
        Me.CheeseCake.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheeseCake.Location = New System.Drawing.Point(143, 264)
        Me.CheeseCake.Name = "CheeseCake"
        Me.CheeseCake.Size = New System.Drawing.Size(100, 100)
        Me.CheeseCake.TabIndex = 9
        Me.CheeseCake.UseVisualStyleBackColor = True
        '
        'Tiramisu
        '
        Me.Tiramisu.BackgroundImage = CType(resources.GetObject("Tiramisu.BackgroundImage"), System.Drawing.Image)
        Me.Tiramisu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Tiramisu.Location = New System.Drawing.Point(26, 264)
        Me.Tiramisu.Name = "Tiramisu"
        Me.Tiramisu.Size = New System.Drawing.Size(100, 100)
        Me.Tiramisu.TabIndex = 8
        Me.Tiramisu.UseVisualStyleBackColor = True
        '
        'IceCream
        '
        Me.IceCream.BackgroundImage = CType(resources.GetObject("IceCream.BackgroundImage"), System.Drawing.Image)
        Me.IceCream.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IceCream.Location = New System.Drawing.Point(375, 146)
        Me.IceCream.Name = "IceCream"
        Me.IceCream.Size = New System.Drawing.Size(100, 100)
        Me.IceCream.TabIndex = 7
        Me.IceCream.UseVisualStyleBackColor = True
        '
        'OreoMilkshake
        '
        Me.OreoMilkshake.BackgroundImage = CType(resources.GetObject("OreoMilkshake.BackgroundImage"), System.Drawing.Image)
        Me.OreoMilkshake.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OreoMilkshake.Location = New System.Drawing.Point(259, 146)
        Me.OreoMilkshake.Name = "OreoMilkshake"
        Me.OreoMilkshake.Size = New System.Drawing.Size(100, 100)
        Me.OreoMilkshake.TabIndex = 6
        Me.OreoMilkshake.UseVisualStyleBackColor = True
        '
        'IcedMilkTea
        '
        Me.IcedMilkTea.BackgroundImage = CType(resources.GetObject("IcedMilkTea.BackgroundImage"), System.Drawing.Image)
        Me.IcedMilkTea.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IcedMilkTea.Location = New System.Drawing.Point(143, 146)
        Me.IcedMilkTea.Name = "IcedMilkTea"
        Me.IcedMilkTea.Size = New System.Drawing.Size(100, 100)
        Me.IcedMilkTea.TabIndex = 5
        Me.IcedMilkTea.UseVisualStyleBackColor = True
        '
        'IcedTea
        '
        Me.IcedTea.BackgroundImage = CType(resources.GetObject("IcedTea.BackgroundImage"), System.Drawing.Image)
        Me.IcedTea.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IcedTea.Location = New System.Drawing.Point(26, 146)
        Me.IcedTea.Name = "IcedTea"
        Me.IcedTea.Size = New System.Drawing.Size(100, 100)
        Me.IcedTea.TabIndex = 4
        Me.IcedTea.UseVisualStyleBackColor = True
        '
        'MalikaIcedCoffee
        '
        Me.MalikaIcedCoffee.BackgroundImage = CType(resources.GetObject("MalikaIcedCoffee.BackgroundImage"), System.Drawing.Image)
        Me.MalikaIcedCoffee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MalikaIcedCoffee.Location = New System.Drawing.Point(375, 27)
        Me.MalikaIcedCoffee.Name = "MalikaIcedCoffee"
        Me.MalikaIcedCoffee.Size = New System.Drawing.Size(100, 100)
        Me.MalikaIcedCoffee.TabIndex = 3
        Me.MalikaIcedCoffee.UseVisualStyleBackColor = True
        '
        'IcedMocha
        '
        Me.IcedMocha.BackgroundImage = CType(resources.GetObject("IcedMocha.BackgroundImage"), System.Drawing.Image)
        Me.IcedMocha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IcedMocha.Location = New System.Drawing.Point(259, 27)
        Me.IcedMocha.Name = "IcedMocha"
        Me.IcedMocha.Size = New System.Drawing.Size(100, 100)
        Me.IcedMocha.TabIndex = 2
        Me.IcedMocha.UseVisualStyleBackColor = True
        '
        'CoffeeLatte
        '
        Me.CoffeeLatte.BackgroundImage = CType(resources.GetObject("CoffeeLatte.BackgroundImage"), System.Drawing.Image)
        Me.CoffeeLatte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CoffeeLatte.Location = New System.Drawing.Point(143, 27)
        Me.CoffeeLatte.Name = "CoffeeLatte"
        Me.CoffeeLatte.Size = New System.Drawing.Size(100, 100)
        Me.CoffeeLatte.TabIndex = 1
        Me.CoffeeLatte.UseVisualStyleBackColor = True
        '
        'Expresso
        '
        Me.Expresso.BackgroundImage = CType(resources.GetObject("Expresso.BackgroundImage"), System.Drawing.Image)
        Me.Expresso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Expresso.Location = New System.Drawing.Point(26, 27)
        Me.Expresso.Name = "Expresso"
        Me.Expresso.Size = New System.Drawing.Size(100, 100)
        Me.Expresso.TabIndex = 0
        Me.Expresso.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Info
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.cboPayment)
        Me.Panel2.Controls.Add(Me.lblChange)
        Me.Panel2.Controls.Add(Me.lblCost)
        Me.Panel2.Controls.Add(Me.lblTotal)
        Me.Panel2.Controls.Add(Me.lblTax)
        Me.Panel2.Controls.Add(Me.lblSubTotal)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(928, 156)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(394, 243)
        Me.Panel2.TabIndex = 2
        '
        'cboPayment
        '
        Me.cboPayment.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPayment.FormattingEnabled = True
        Me.cboPayment.Location = New System.Drawing.Point(219, 124)
        Me.cboPayment.Name = "cboPayment"
        Me.cboPayment.Size = New System.Drawing.Size(160, 35)
        Me.cboPayment.TabIndex = 11
        '
        'lblChange
        '
        Me.lblChange.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblChange.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.Location = New System.Drawing.Point(219, 201)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(160, 27)
        Me.lblChange.TabIndex = 10
        Me.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCost
        '
        Me.lblCost.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCost.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(219, 165)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(160, 27)
        Me.lblCost.TabIndex = 9
        Me.lblCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTotal.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(219, 88)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(160, 27)
        Me.lblTotal.TabIndex = 8
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTax
        '
        Me.lblTax.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTax.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(219, 52)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(160, 27)
        Me.lblTax.TabIndex = 7
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblSubTotal.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.Location = New System.Drawing.Point(219, 16)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(160, 27)
        Me.lblSubTotal.TabIndex = 6
        Me.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 201)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 27)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Change"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 27)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Cost"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(194, 27)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Method of Payment"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 27)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Total"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 27)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tax (10%)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 27)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Sub Total"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Peru
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.BtnC)
        Me.Panel3.Controls.Add(Me.BtnDot)
        Me.Panel3.Controls.Add(Me.Btn0)
        Me.Panel3.Controls.Add(Me.Btn9)
        Me.Panel3.Controls.Add(Me.Btn8)
        Me.Panel3.Controls.Add(Me.Btn7)
        Me.Panel3.Controls.Add(Me.Btn6)
        Me.Panel3.Controls.Add(Me.Btn5)
        Me.Panel3.Controls.Add(Me.Btn4)
        Me.Panel3.Controls.Add(Me.Btn3)
        Me.Panel3.Controls.Add(Me.Btn2)
        Me.Panel3.Controls.Add(Me.Btn1)
        Me.Panel3.Location = New System.Drawing.Point(928, 405)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(201, 253)
        Me.Panel3.TabIndex = 3
        '
        'BtnC
        '
        Me.BtnC.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnC.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnC.Location = New System.Drawing.Point(130, 184)
        Me.BtnC.Name = "BtnC"
        Me.BtnC.Size = New System.Drawing.Size(50, 50)
        Me.BtnC.TabIndex = 11
        Me.BtnC.Text = "C"
        Me.BtnC.UseVisualStyleBackColor = False
        '
        'BtnDot
        '
        Me.BtnDot.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnDot.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDot.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDot.Location = New System.Drawing.Point(74, 184)
        Me.BtnDot.Name = "BtnDot"
        Me.BtnDot.Size = New System.Drawing.Size(50, 50)
        Me.BtnDot.TabIndex = 10
        Me.BtnDot.Text = ","
        Me.BtnDot.UseVisualStyleBackColor = False
        '
        'Btn0
        '
        Me.Btn0.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn0.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn0.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn0.Location = New System.Drawing.Point(18, 184)
        Me.Btn0.Name = "Btn0"
        Me.Btn0.Size = New System.Drawing.Size(50, 50)
        Me.Btn0.TabIndex = 9
        Me.Btn0.Text = "0"
        Me.Btn0.UseVisualStyleBackColor = False
        '
        'Btn9
        '
        Me.Btn9.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn9.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn9.Location = New System.Drawing.Point(130, 16)
        Me.Btn9.Name = "Btn9"
        Me.Btn9.Size = New System.Drawing.Size(50, 50)
        Me.Btn9.TabIndex = 8
        Me.Btn9.Text = "9"
        Me.Btn9.UseVisualStyleBackColor = False
        '
        'Btn8
        '
        Me.Btn8.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn8.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn8.Location = New System.Drawing.Point(74, 16)
        Me.Btn8.Name = "Btn8"
        Me.Btn8.Size = New System.Drawing.Size(50, 50)
        Me.Btn8.TabIndex = 7
        Me.Btn8.Text = "8"
        Me.Btn8.UseVisualStyleBackColor = False
        '
        'Btn7
        '
        Me.Btn7.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn7.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn7.Location = New System.Drawing.Point(18, 16)
        Me.Btn7.Name = "Btn7"
        Me.Btn7.Size = New System.Drawing.Size(50, 50)
        Me.Btn7.TabIndex = 6
        Me.Btn7.Text = "7"
        Me.Btn7.UseVisualStyleBackColor = False
        '
        'Btn6
        '
        Me.Btn6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn6.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn6.Location = New System.Drawing.Point(130, 72)
        Me.Btn6.Name = "Btn6"
        Me.Btn6.Size = New System.Drawing.Size(50, 50)
        Me.Btn6.TabIndex = 5
        Me.Btn6.Text = "6"
        Me.Btn6.UseVisualStyleBackColor = False
        '
        'Btn5
        '
        Me.Btn5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn5.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn5.Location = New System.Drawing.Point(74, 72)
        Me.Btn5.Name = "Btn5"
        Me.Btn5.Size = New System.Drawing.Size(50, 50)
        Me.Btn5.TabIndex = 4
        Me.Btn5.Text = "5"
        Me.Btn5.UseVisualStyleBackColor = False
        '
        'Btn4
        '
        Me.Btn4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn4.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn4.Location = New System.Drawing.Point(18, 72)
        Me.Btn4.Name = "Btn4"
        Me.Btn4.Size = New System.Drawing.Size(50, 50)
        Me.Btn4.TabIndex = 3
        Me.Btn4.Text = "4"
        Me.Btn4.UseVisualStyleBackColor = False
        '
        'Btn3
        '
        Me.Btn3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn3.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn3.Location = New System.Drawing.Point(130, 128)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(50, 50)
        Me.Btn3.TabIndex = 2
        Me.Btn3.Text = "3"
        Me.Btn3.UseVisualStyleBackColor = False
        '
        'Btn2
        '
        Me.Btn2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn2.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn2.Location = New System.Drawing.Point(74, 128)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(50, 50)
        Me.Btn2.TabIndex = 1
        Me.Btn2.Text = "2"
        Me.Btn2.UseVisualStyleBackColor = False
        '
        'Btn1
        '
        Me.Btn1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn1.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn1.Location = New System.Drawing.Point(18, 128)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(50, 50)
        Me.Btn1.TabIndex = 0
        Me.Btn1.Text = "1"
        Me.Btn1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.DataGridView1.Location = New System.Drawing.Point(7, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(352, 442)
        Me.DataGridView1.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.HeaderText = "Item"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Quantity"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Amount"
        Me.Column3.Name = "Column3"
        '
        'RemoveItem
        '
        Me.RemoveItem.BackColor = System.Drawing.Color.Peru
        Me.RemoveItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RemoveItem.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveItem.ForeColor = System.Drawing.SystemColors.Info
        Me.RemoveItem.Location = New System.Drawing.Point(69, 469)
        Me.RemoveItem.Name = "RemoveItem"
        Me.RemoveItem.Size = New System.Drawing.Size(235, 42)
        Me.RemoveItem.TabIndex = 5
        Me.RemoveItem.Text = "Remove Item"
        Me.RemoveItem.UseVisualStyleBackColor = False
        '
        'Pay
        '
        Me.Pay.BackColor = System.Drawing.Color.Peru
        Me.Pay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pay.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pay.ForeColor = System.Drawing.SystemColors.Info
        Me.Pay.Location = New System.Drawing.Point(1161, 420)
        Me.Pay.Name = "Pay"
        Me.Pay.Size = New System.Drawing.Size(135, 42)
        Me.Pay.TabIndex = 6
        Me.Pay.Text = "Pay"
        Me.Pay.UseVisualStyleBackColor = False
        '
        'Print
        '
        Me.Print.BackColor = System.Drawing.Color.Peru
        Me.Print.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Print.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Print.ForeColor = System.Drawing.SystemColors.Info
        Me.Print.Location = New System.Drawing.Point(1161, 480)
        Me.Print.Name = "Print"
        Me.Print.Size = New System.Drawing.Size(135, 42)
        Me.Print.TabIndex = 7
        Me.Print.Text = "Print"
        Me.Print.UseVisualStyleBackColor = False
        '
        'Clear
        '
        Me.Clear.BackColor = System.Drawing.Color.Peru
        Me.Clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Clear.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear.ForeColor = System.Drawing.SystemColors.Info
        Me.Clear.Location = New System.Drawing.Point(1161, 541)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(135, 42)
        Me.Clear.TabIndex = 8
        Me.Clear.Text = "Clear All"
        Me.Clear.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.DarkOrange
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Font = New System.Drawing.Font("Kristen ITC", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label14.Location = New System.Drawing.Point(54, 139)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(132, 31)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "List Menu"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Info
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.DataGridView1)
        Me.Panel4.Controls.Add(Me.RemoveItem)
        Me.Panel4.Location = New System.Drawing.Point(546, 156)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(368, 519)
        Me.Panel4.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.DarkOrange
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Font = New System.Drawing.Font("Kristen ITC", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label13.Location = New System.Drawing.Point(666, 139)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(135, 31)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "List Order"
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1350, 690)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Print)
        Me.Controls.Add(Me.Pay)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents AngelFruit As Button
    Friend WithEvents Pudding As Button
    Friend WithEvents Macaron As Button
    Friend WithEvents RollCake As Button
    Friend WithEvents BlackForest As Button
    Friend WithEvents RedVelvet As Button
    Friend WithEvents CheeseCake As Button
    Friend WithEvents Tiramisu As Button
    Friend WithEvents IceCream As Button
    Friend WithEvents OreoMilkshake As Button
    Friend WithEvents IcedMilkTea As Button
    Friend WithEvents IcedTea As Button
    Friend WithEvents MalikaIcedCoffee As Button
    Friend WithEvents IcedMocha As Button
    Friend WithEvents CoffeeLatte As Button
    Friend WithEvents Expresso As Button
    Friend WithEvents BtnC As Button
    Friend WithEvents BtnDot As Button
    Friend WithEvents Btn0 As Button
    Friend WithEvents Btn9 As Button
    Friend WithEvents Btn8 As Button
    Friend WithEvents Btn7 As Button
    Friend WithEvents Btn6 As Button
    Friend WithEvents Btn5 As Button
    Friend WithEvents Btn4 As Button
    Friend WithEvents Btn3 As Button
    Friend WithEvents Btn2 As Button
    Friend WithEvents Btn1 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents cboPayment As ComboBox
    Friend WithEvents lblChange As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RemoveItem As Button
    Friend WithEvents Pay As Button
    Friend WithEvents Print As Button
    Friend WithEvents Clear As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
