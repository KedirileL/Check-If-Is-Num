﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnTest = New Button()
        txtNum = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnTest
        ' 
        btnTest.Location = New Point(329, 267)
        btnTest.Name = "btnTest"
        btnTest.Size = New Size(112, 34)
        btnTest.TabIndex = 0
        btnTest.Text = "Testing"
        btnTest.UseVisualStyleBackColor = True
        ' 
        ' txtNum
        ' 
        txtNum.Location = New Point(409, 131)
        txtNum.Name = "txtNum"
        txtNum.Size = New Size(150, 31)
        txtNum.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(172, 137)
        Label1.Name = "Label1"
        Label1.Size = New Size(156, 25)
        Label1.TabIndex = 2
        Label1.Text = "Enter You Number"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(txtNum)
        Controls.Add(btnTest)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTest As Button
    Friend WithEvents txtNum As TextBox
    Friend WithEvents Label1 As Label
End Class
