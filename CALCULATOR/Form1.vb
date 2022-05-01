Public Class Form1
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged


        Dim T_TS, T_YS, T_YM, T_PR As Double

        T_YM = 410
        T_PR = 0.28
        T_YS = 750
        T_TS = 980

        TextBox1_YM.Text = T_YM
        TextBox2_PR.Text = T_PR
        TextBox3_YS.Text = T_YS
        TextBox4_TS.Text = T_TS

        TextBox2_TS2.Text = T_TS
        TextBox1_YM2.Text = T_YM


    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged


        Dim G_TS, G_YS, G_YM, G_PR As Double

        G_YM = 79
        G_PR = 0.42
        G_YS = 205
        G_TS = 220

        TextBox1_YM.Text = G_YM
        TextBox2_PR.Text = G_PR
        TextBox3_YS.Text = G_YS
        TextBox4_TS.Text = G_TS

        TextBox2_TS2.Text = G_TS
        TextBox1_YM2.Text = G_YM

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged


        Dim S_TS, S_YS, S_YM, S_PR As Double

        S_YM = 200
        S_PR = 0.3
        S_YS = 800
        S_TS = 1100

        TextBox1_YM.Text = S_YM
        TextBox2_PR.Text = S_PR
        TextBox3_YS.Text = S_YS
        TextBox4_TS.Text = S_TS

        TextBox2_TS2.Text = S_TS
        TextBox1_YM2.Text = S_YM

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged


        Dim C_TS, C_YS, C_YM, C_PR As Double

        C_YM = 120
        C_PR = 0.35
        C_YS = 33
        C_TS = 210

        TextBox1_YM.Text = C_YM
        TextBox2_PR.Text = C_PR
        TextBox3_YS.Text = C_YS
        TextBox4_TS.Text = C_TS

        TextBox2_TS2.Text = C_TS
        TextBox1_YM2.Text = C_YM

    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged


        Dim I_TS, I_YS, I_YM, I_PR As Double

        I_YM = 210
        I_PR = 0.29
        I_YS = 50
        I_TS = 540

        TextBox1_YM.Text = I_YM
        TextBox2_PR.Text = I_PR
        TextBox3_YS.Text = I_YS
        TextBox4_TS.Text = I_TS

        TextBox2_TS2.Text = I_TS
        TextBox1_YM2.Text = I_YM

    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged


        Dim N_TS, N_YS, N_YM, N_PR As Double

        N_YM = 200
        N_PR = 0.31
        N_YS = 110
        N_TS = 345

        TextBox1_YM.Text = N_YM
        TextBox2_PR.Text = N_PR
        TextBox3_YS.Text = N_YS
        TextBox4_TS.Text = N_TS

        TextBox2_TS2.Text = N_TS
        TextBox1_YM2.Text = N_YM

    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged


        Dim P_TS, P_YS, P_YM, P_PR As Double

        P_YM = 168
        P_PR = 0.38
        P_YS = 70
        P_TS = 150

        TextBox1_YM.Text = P_YM
        TextBox2_PR.Text = P_PR
        TextBox3_YS.Text = P_YS
        TextBox4_TS.Text = P_TS

        TextBox2_TS2.Text = P_TS
        TextBox1_YM2.Text = P_YM

    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged


        Dim B_TS, B_YS, B_YM, B_PR As Double

        B_YM = 110
        B_PR = 0.34
        B_YS = 95
        B_TS = 315

        TextBox1_YM.Text = B_YM
        TextBox2_PR.Text = B_PR
        TextBox3_YS.Text = B_YS
        TextBox4_TS.Text = B_TS

        TextBox2_TS2.Text = B_TS
        TextBox1_YM2.Text = B_YM

    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged


        Dim S_TS, S_YS, S_YM, S_PR As Double

        S_YM = 83
        S_PR = 0.37
        S_YS = 45
        S_TS = 110

        TextBox1_YM.Text = S_YM
        TextBox2_PR.Text = S_PR
        TextBox3_YS.Text = S_YS
        TextBox4_TS.Text = S_TS

        TextBox2_TS2.Text = S_TS
        TextBox1_YM2.Text = S_YM

    End Sub

    Private Sub Button1_Stress_Click(sender As Object, e As EventArgs) Handles Button1_Stress.Click

        Dim f, a As Double

        f = TextBox1_F.Text
        a = TextBox2_Ao.Text
        TextBox3_Stress.Text = f / a


    End Sub
    Private Sub Button1_Strain_Click(sender As Object, e As EventArgs) Handles Button1_Strain.Click

        Dim DL, Lo As Double

        DL = TextBox1_ΔL.Text
        Lo = TextBox2_Lo.Text
        TextBox3_Stain.Text = DL / Lo


    End Sub

    Private Sub Button1_Fmax_Click(sender As Object, e As EventArgs) Handles Button1_Fmax.Click

        Dim TS, AO As Double

        TS = TextBox2_TS2.Text
        AO = TextBox3_Ao2.Text
        TextBox1_Fmax.Text = TS * AO


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim F, LO, Ao, YM As Double

        F = TextBox2_F2.Text
        LO = TextBox4_Lo2.Text
        Ao = TextBox3_Ao3.Text
        YM = TextBox1_YM2.Text
        TextBox5_DL2.Text = F * LO / Ao / YM


    End Sub

    Private Sub Button_Close_Click(sender As Object, e As EventArgs) Handles Button_Close.Click

        Me.Close()

    End Sub
End Class
