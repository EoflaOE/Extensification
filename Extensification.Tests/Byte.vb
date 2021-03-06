﻿
'    Extensification  Copyright (C) 2020-2021  EoflaOE
'
'    This file is part of Extensification
'
'    Extensification is free software: you can redistribute it and/or modify
'    it under the terms of the GNU General Public License as published by
'    the Free Software Foundation, either version 3 of the License, or
'    (at your option) any later version.
'
'    Extensification is distributed in the hope that it will be useful,
'    but WITHOUT ANY WARRANTY; without even the implied warranty of
'    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'    GNU General Public License for more details.
'
'    You should have received a copy of the GNU General Public License
'    along with this program.  If not, see <https://www.gnu.org/licenses/>.

Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Extensification.ByteExts

<TestClass>
Public Class ByteTests

    ''' <summary>
    ''' Tests byte incrementation
    ''' </summary>
    <TestMethod>
    Public Sub TestIncrement()
        Dim ExpectedByte As Byte = 5
        Dim TargetByte As Byte = 3
        TargetByte = TargetByte.Increment(2)
        Assert.AreEqual(ExpectedByte, TargetByte)
    End Sub

    ''' <summary>
    ''' Tests byte decrementation
    ''' </summary>
    <TestMethod>
    Public Sub TestDecrement()
        Dim ExpectedByte As Byte = 3
        Dim TargetByte As Byte = 5
        TargetByte = TargetByte.Decrement(2)
        Assert.AreEqual(ExpectedByte, TargetByte)
    End Sub

    ''' <summary>
    ''' Tests byte digit listing
    ''' </summary>
    <TestMethod>
    Public Sub TestListDigits()
        Dim ExpectedDigits() As Byte = {7, 5}
        Dim TargetNumber As Byte = 75
        Assert.IsTrue(ExpectedDigits.SequenceEqual(TargetNumber.ListDigits))
    End Sub

    ''' <summary>
    ''' Tests byte Armstrong number detection
    ''' </summary>
    <TestMethod>
    Public Sub TestIsArmstrong()
        Dim TargetNumber As Byte = 153
        Assert.IsTrue(TargetNumber.IsArmstrong)
    End Sub

End Class
