# ローカルクライアント側  :192.168.3.2
# リモートホスト側        :192.168.3.8 PowerShellTestUser/p@55w0rd
#
# 【PowerShell基礎知識】
# WinRM                                              : Windows Remote Management。PSをリモートする場合には有効にすることが必須
# Scope                                              : Process（現在のみ有効）、CurrentUser（ユーザに対して永続）、LocalMachine（マシン全体で永続）
#    各コマンドのデフォルトスコープ
#    Set-ExecutionPolicy  : LocalMachine
#    Set-WSManQuickConfig : LocalMachine
#
# 【各コマンド概要】
# Set-ExecutionPolicy                                : スクリプトの実行やリモート、信頼された/されていないなどをどこまで許可するか
# Set-WSManQuickConfig                               : リモートからの操作を受け付けるようにする
# Enable-PSRemoting                                  : Set-WSManQuickConfigのエイリアス？とは違うけどほぼ同じ
# winrm quickconfig                                  : WinRMを許可したうえで起動するなど
# Set-Item WSMan:\localhost\Client\TrustedHosts <IP> : クライアントから見て信頼するホストを追加する。必須
# New-NetFirewallRule                                : Windows Defenderの設定変更。iptablesやfirewalldの親戚。PrivateモードのInboundのTCPのRPC動的ポート（RPCを指定すればよい）を開ける必要あり。
#
# 【リモートホスト側の事前設定】
# 設定 > ネットワークとインターネット > (Wifi > 現在接続中の接続、など) > ネットワークプロファイル：Private（＝信頼済み）にする
# Set-PSSessionConfiguration Microsoft.PowerShell -ShowSecurityDescriptorUI
#    使用したいリモートホスト側の管理者ユーザのフルコントロールを許可
#    ※ 管理者ユーザでないとうまくいかない。接続しようとする時に、以下のエラーが出る
#     新しいPSSession： [computerName]リモートサーバーlocalhostへの接続が失敗し、次のエラーメッセージが表示されました。WSManサービスは、指定された要求を処理するためのホストプロセスを起動できませんでした。 WSManプロバイダーのホストサーバーとプロキシが正しく登録されていることを確認してください。詳細については、about_Remote_Troubleshootingヘルプトピックを参照してください。」
# Set-ExecutionPolicy RemoteSigned -Force
# Set-WSManQuickConfig -Force
# Enable-PSRemoting -SkipNetworkProfileCheck -Force
# FWの許可（例：Windows Defender）
# New-NetFirewallRule -DisplayName "@RemotePowerShell-enable" -Program "%SystemRoot%\System32\svchost.exe" -Profile Private -Direction Inbound -Protocol TCP -LocalPort RPC -Action Allow
#
# 【ローカルクライアント側の事前設定】
# Set-ExecutionPolicy RemoteSigned -Force
# winrm quickconfig -force
# Set-Item WSMan:\localhost\Client\TrustedHosts <リモートのIP> -Force
#
# 【sample.ps1】
# $sum = 0;
# for ($i=0; $i -lt 100000000; $i++) {
#     $sum += $i;
# }
# echo $sum
# Get-ChildItem env:

function MakePSCredential( $ID, $PlainPassword ){
    $SecurePassword = ConvertTo-SecureString -String $PlainPassword -AsPlainText -Force
    $Credential = New-Object System.Management.Automation.PSCredential($ID, $SecurePassword)
    Return $Credential
}
$Credential = MakePSCredential "PowerShellTestUser" "p@55w0rd"
$TargetServer = "192.168.3.8"
$PSSession = New-PSSession $TargetServer -Credential $Credential
Invoke-Command -Session $PSSession -ScriptBlock { cd $env:userprofile\desktop }
Invoke-Command -Session $PSSession -ScriptBlock { .\sample.ps1 }