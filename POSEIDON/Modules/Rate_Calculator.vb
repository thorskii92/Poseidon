Module Rate_Calculator

    Public Function ServiceFees(ServID As Integer) As Double
        Dim servFee As Double
        If ServID = 0 Then
            'New Connection
            servFee = 1500
        ElseIf ServID = 1 Then
            'Transfer of Water Meter
            servFee = 250
        ElseIf ServID = 2 Then
            'Reconnection
            servFee = 250
        ElseIf ServID = 3 Then
            'Transfer of Ownership
            servFee = 500
        End If
        ServiceFees = servFee
    End Function
    Public Function Consumption(classID As Integer, Cubits As Integer) As Double
        Dim tempConsump As Double
        Dim tempCube As Integer
        Dim addConsump As Double
        Dim finalConsump As Double
        tempConsump = 0
        finalConsump = 0
        addConsump = 0
        If classID = 1 Then
            'residential/institutional/government consuption
            If Cubits < 11 Then
                finalConsump = 150
            ElseIf Cubits > 10 And Cubits < 16 Then
                tempConsump = 150
                tempCube = Cubits - 10
                addConsump = tempCube * 20
                finalConsump = tempConsump + addConsump
            ElseIf Cubits > 15 And Cubits < 21 Then
                tempConsump = 250
                tempCube = Cubits - 15
                addConsump = tempCube * 23
                finalConsump = tempConsump + addConsump
            ElseIf Cubits > 20 And Cubits < 26 Then
                tempConsump = 365
                tempCube = Cubits - 20
                addConsump = tempCube * 27
                finalConsump = tempConsump + addConsump
            ElseIf Cubits > 25 And Cubits < 31 Then
                tempConsump = 500
                tempCube = Cubits - 25
                addConsump = tempCube * 32
                finalConsump = tempConsump + addConsump
            Else
                tempConsump = 660
                tempCube = Cubits - 30
                addConsump = tempCube * 38
                finalConsump = tempConsump + addConsump
            End If
        ElseIf classID = 2 Then
            'commercial consumption
            If Cubits < 11 Then
                finalConsump = 250
            ElseIf Cubits > 10 And Cubits < 21 Then
                tempConsump = 250
                tempCube = Cubits - 10
                addConsump = tempCube * 27
                finalConsump = tempConsump + addConsump
            ElseIf Cubits > 20 And Cubits < 31 Then
                tempConsump = 520
                tempCube = Cubits - 20
                addConsump = tempCube * 32
                finalConsump = tempConsump + addConsump
            ElseIf Cubits > 30 Then
                tempConsump = 840
                tempCube = Cubits - 30
                addConsump = tempCube * 38
                finalConsump = tempConsump + addConsump
            End If
        ElseIf classID = 3 Then
            'industrial consuption
            If Cubits < 11 Then
                finalConsump = 250
            Else
                tempConsump = 250
                tempCube = Cubits - 10
                addConsump = tempCube * 32
                finalConsump = tempConsump + addConsump
            End If
        ElseIf classID = 4 Then
            'water traders/bulk sales domestic
            If Cubits = 1 Then
                finalConsump = 270
            Else
                tempConsump = 270
                tempCube = Cubits - 1
                addConsump = tempCube * tempCube
                finalConsump = tempConsump + addConsump
            End If
        End If
        Consumption = finalConsump
    End Function

End Module
