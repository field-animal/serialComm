Imports System.ComponentModel
Imports System.IO.Ports
Imports System.Threading
'Imports System.Windows.Forms


Public Class frmMain
    Public returnStr As String = ""
    Private WithEvents serialPort As SerialPort
    Private receivingThread As Thread
    Private keepReceiving As Boolean = True

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '첫 실행 시, 시리얼 포트 목록을 획득
        GetSerialPortNames()

        TreeView1.ExpandAll()

    End Sub

    'HW의 포트 구성요소를 획득하여 드랍다운 아이템에 추가
    Public Sub GetSerialPortNames()
        Dim indexNum As Integer = 0
        tsSplitbtnPort.DropDownItems.Clear()
        For Each sp As String In My.Computer.Ports.SerialPortNames

            tsSplitbtnPort.DropDownItems.Add(sp)
            indexNum = +1
        Next

        If tsSplitbtnPort.DropDownItems.Count <= 0 Then
            tsSplitbtnPort.Enabled = False
        Else
            tsSplitbtnPort.Enabled = True
        End If
    End Sub

    '드랍다운 아이템에서 선택한 아이템을 컴포넌트의 텍스트로 적용
    Private Sub tsSplitbtnPort_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsSplitbtnPort.DropDownItemClicked
        tsSplitbtnPort.Text = e.ClickedItem.Text
    End Sub

    Private Sub tsBtnConnect_Click(sender As Object, e As EventArgs) Handles tsBtnConnect.Click
        If tsBtnConnect.Text = "disConnect" Then
            ClosePort()
            Exit Sub
        End If

        Try
            serialPort = New SerialPort(tsSplitbtnPort.Text, 115200, Parity.None, 8, StopBits.One)
            serialPort.Open()

            '정상적으로 연결되었는지 확인하기 위한 테스트 코드
            'SendData(Now() & ": 시리얼 통신 시작" & vbCrLf)
            'serialPort.ReadTimeout = 10000
            keepReceiving = True
            tsBtnConnect.Text = "disConnect"

        Catch ex As TimeoutException
            returnStr = "error : 시리얼 포트가 대답을 안함"
            MsgBox(returnStr)
        Catch ex As Exception
            returnStr = "error : 연결 거절 당해뜸, 시부레"
            MsgBox(returnStr)
        Finally
            'If serialPort IsNot Nothing Then serialPort.Close()
        End Try
        Console.WriteLine(serialPort.ReceivedBytesThreshold)
    End Sub

    ' 데이터 수신을 위한 비동기 이벤트 핸들러
    Public Sub serialPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles serialPort.DataReceived
        '수신된 메시지 자동 응답 함수 실행
        autoAnswer(serialPort.ReadExisting(), "$", "*", "<<")

    End Sub

    Private Function autoAnswer(ByVal receviedValue As String, startLetter As String, checksumLetter As String, msgDirect As String)
        '수신 데이터에 복수의 데이터가 포함되어 있을 수 있으므로, 수신 데이터를 $로 구분하여 배열에 저장
        Dim receivedDATAs() As String = Split(receviedValue, startLetter)
        '수신 데이터 배열의 인덱스를 구분하기 위한 변수
        Dim indexOfreceviedData As Integer = 0

        For indexOfreceviedData = 1 To receivedDATAs.Count - 1
            '수신 데이터이므로 <<를 추가
            DataAddToList(Now() & msgDirect & receivedDATAs(indexOfreceviedData), False)
            If receivedDATAs(indexOfreceviedData).Contains(checksumLetter) = True Then


                Dim autoSendValue As String = vbNullString
                Dim i As Integer = 0
                Dim idx_childNode As Integer = 0
                '수신 데이터의 명령을 트리뷰에서 찾아서 자식 노드의 응답값으로 자동 송신
                autoSendValue = vbNullString
                Dim strSearchstring As String
                '수신 데이터에서 체크섬 이후의 값을 삭제하여 검색어 생성.
                strSearchstring = Microsoft.VisualBasic.Strings.Left(receivedDATAs(indexOfreceviedData), InStr(receivedDATAs(indexOfreceviedData), checksumLetter) - 1)

                '트리 노드의 개수 만큼 for문 반복하여 각 노드의 정보 획득
                For i = 0 To TreeView1.Nodes.Count - 1
                    If TreeView1.Nodes.Item(i).Checked AndAlso TreeView1.Nodes.Item(i).Text = strSearchstring Then 'i 인덱스의 루트 노드가 체크되어 있으면, 루트노드에서 검색어가 포함되어 있는지 확인
                        ''검색어가 포함되어 있을 경우 자식 노드에서 자동 응답값을 검색하는 반복문 실행
                        For idx_childNode = 0 To TreeView1.Nodes.Item(i).Nodes.Count - 1 '0부터 자식노드의 개수만큼 반복문 실행
                            If TreeView1.Nodes.Item(i).Nodes.Item(idx_childNode).Checked = True Then
                                autoSendValue = TreeView1.Nodes.Item(i).Nodes.Item(idx_childNode).Text '자식 노드에 체크되어 있으면 자동응답값은 체크된 자식 노드의 텍스트로 설정
                                Exit For '응답값을 획득 했으므로 반복문 종료
                            End If
                        Next
                        If autoSendValue = vbNullString Then autoSendValue = TreeView1.Nodes.Item(i).Nodes.Item(0).Text '자식 노드가 체크되어 있지 않다면, 첫번째 자식 노드를 자동 응답값으로 설정
                        SendData(autoSendValue)
                    End If
                    Console.WriteLine(i & strSearchstring)
                Next
            End If
        Next
        '절차를 완료하면 true 반환 (이 값이 자동 응답을 했다는 보장을 하지 못함)
        Return True
    End Function


    ' 데이터 송신
    Public Function SendData(ByVal data As String) As Boolean
        Console.WriteLine(Me.Text & "포트 열림 상태" & serialPort.IsOpen)

        If serialPort IsNot Nothing AndAlso serialPort.IsOpen Then
            Console.WriteLine("데이터 전송합니다." & data)
            Try
                serialPort.WriteLine(data) '시리얼포트로 전송
                DataAddToList(Now() & " >> " & data, True) ' 리스트 박스 목록에 값을 item으로 추가
                Console.WriteLine("송신: " & data)
                Return True
            Catch ex As Exception

                Console.WriteLine("===============")
                Console.WriteLine("송신 오류: " & ex.Message)
                Console.WriteLine("오류 내용" & ex.GetBaseException.ToString)
                Console.WriteLine("===============")
                Return False
            End Try
        Else
            Console.WriteLine("포트 안 열려있는뎅")
            Return False
        End If
    End Function

    'Data를 List Box에 추가
    Public Sub DataAddToList(ByVal str_addDATA As String, isSendData As Boolean)
        If ListBox1.InvokeRequired Then
            ListBox1.Invoke(Sub() ListBox1.Items.Add(str_addDATA))
            If ListBox1.Items.Count > 0 Then ListBox1.Invoke(Sub() ListBox1.TopIndex = ListBox1.Items.Count - 1) '가장 마지막 항목으로 자동 스크롤
        Else
            ListBox1.Items.Add(str_addDATA)
            ListBox1.TopIndex = ListBox1.Items.Count - 1 '가장 마지막 항목으로 자동 스크롤
        End If

    End Sub

    ' 데이터 송신  버튼의 이벤트 핸들러
    Private Sub Btn_DataSend_Click(sender As Object, e As EventArgs) Handles btn_DataSend.Click
        Dim data As String = tb_sendMessage.Text
        If SendData(data) Then
            Console.WriteLine("송신 성공: " & data)
        Else
            Console.WriteLine("송신 실패")
        End If
    End Sub

    ' 시리얼 포트 닫기
    Public Sub ClosePort()
        Try
            keepReceiving = False
            If serialPort IsNot Nothing AndAlso serialPort.IsOpen Then
                serialPort.Close()
                Console.WriteLine("시리얼 포트가 닫혔습니다.")
                tsBtnConnect.Text = "Connect"
            End If
        Catch ex As Exception
            Console.WriteLine("포트 닫기 오류: " & ex.Message)

        End Try
    End Sub

    Private Sub ListBox1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles ListBox1.DrawItem
        If tsBtnConnect.Text = "Connect" Then
            Exit Sub
        Else
            Console.WriteLine("리스트 박스 아이템의 수 : " & ListBox1.Items.Count)
            If ListBox1.Items.Count <= 0 Then Exit Sub
            e.DrawBackground()
            Dim brush As Brush = Brushes.Black
            Dim direction As String = ListBox1.Items(e.Index).ToString

            '수발신 데이터에 << 가 포함되어 있으면 수신, >>가 포함되어 있으면 송신으로 판단
            If direction.IndexOf("<<") > 0 Then
                direction = "<<"
            Else
                direction = ">>"
            End If
            ' 수발신 데이터에 따라 색상을 다르게 표시
            If direction = "<<" Then
                brush = Brushes.HotPink
            Else
                brush = Brushes.DarkGreen
            End If

            If e.Index >= 0 Then
                e.Graphics.DrawString(ListBox1.Items(e.Index).ToString(), e.Font, brush, e.Bounds, StringFormat.GenericDefault)
            End If
        End If
    End Sub

    Private Sub TreeView1_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseDoubleClick
        tb_sendMessage.Text = e.Node.Text
        SendData(tb_sendMessage.Text)
    End Sub

    Private Sub TreeView1_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
        tb_sendMessage.Text = e.Node.Text
    End Sub

    Private Sub tb_sendMessage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_sendMessage.KeyPress
        If e.KeyChar.Equals(Keys.Enter) Then SendData(tb_sendMessage.Text)
    End Sub

    Private Sub ts_LogClear_Click(sender As Object, e As EventArgs) Handles ts_LogClear.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If serialPort.IsOpen Then serialPort.Close()
    End Sub
End Class


