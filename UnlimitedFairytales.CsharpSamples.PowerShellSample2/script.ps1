# 色々と事前設定が必要です。後述のコメントを読んで設定してください
function MakePSCredential( $ID, $PlainPassword ){
    $SecurePassword = ConvertTo-SecureString -String $PlainPassword -AsPlainText -Force
    $Credential = New-Object System.Management.Automation.PSCredential($ID, $SecurePassword)
    Return $Credential
}
$Credential = MakePSCredential "PowerShellTestUser" "PowerShellTest"
$TargetServer = "localhost"
$PSSession = New-PSSession $TargetServer -Credential $Credential -Authentication Credssp
Invoke-Command -Session $PSSession -ScriptBlock { cd $env:userprofile\Desktop }
Invoke-Command -Session $PSSession -ScriptBlock { .\sample.ps1 }
# 【sample.ps1(PowerShellTestUserのデスクトップに置く)】
# $sum = 0;
# for ($i=0; $i -lt 100000000; $i++) {
#     $sum += $i;
# }
# echo $sum
# Get-ChildItem env:






# ------------------------------------------------------
# 用語集
# ------------------------------------------------------
# WinRM(Windows Remote Management)                   : PSセッションする場合に有効化必須
# WSMAN(Web Service for Management)                  : CredSSP認証の際の資格情報の委任などのやり取りをする際に使用される仕組みあるいはエンドポイントの指定など
# TERMSRV                                            : リモートデスクトップのホストのこと「未構成の場合はTERMSRV/*になる」とは、言い換えれば「未構成の場合はWNMAN/*は構成されない」、ということ
# Scope                                              : Process（現在のみ有効）、CurrentUser（ユーザに対して永続）、LocalMachine（マシン全体で永続。デフォルト）
# ネットワークプロファイル                           : Private（社内回線。信頼済み）、Public（公共回線。危険なので制限がかかる）
# セッション構成(PSSessionConfiguration)             : PSセッションにおけるサーバ側のユーザーアクセス許可の設定
# Administrators                                     : 管理者ユーザとほぼ同義
# NTLM認証                                           : Windowsに古くからあるネットワーク間認証の仕組み。ダブルホップ不可能
# KRB5認証                                           : AD認証の仕組みの具体的なプロトコルの1つ(ちなみにAD認証手順(SPnego)はデフォルト設定だとKRB5認証してだめならNTLM認証する、といったアプローチを取る)
# CredSSP認証                                        : ダブルホップ可能な認証方式。実際にはNTLM・KRB5・httpの複合利用される。認証完了後にユーザ・パスワードの生情報をサーバに送るため、そのサーバから2ndhopが（委任を許可すれば）可能となる
# 資格情報                                           : （不正確だが）ログイン情報のキャッシュ。デフォルトでは委任は許可されない
#
#
#
#
#
#
# ------------------------------------------------------
# 要約(localhostにループバック接続して実行する例)
# ------------------------------------------------------
# サーバ側の設定
# # 1. システム要件：Powershell3.0~、.NET fw4.x~、WinRM3.0~
# # 2. ユーザーのアクセス許可：以下で[既定のセッション構成]を編集可能
# Set-PSSessionConfiguration Microsoft.Powershell -ShowSecurityDescriptorUI
# # 3. Windows ネットワークの場所：プライベートネットワークモードであれば、以下でWinRMを有効化可能
# #    このコマンドは、Set-WSManQuickConfigやwinrm quickconfigで行われる内容すべてが行われ、かつWinRMなどの再起動なども実施されます
# Enable-PSRemoting
# # 4. 管理者として実行：NTLM認証でローカル コンピューターへのリモート接続（＝ループバック接続）する場合、管理者特権が必要
# # 5. 2ndhopや標準権限でのループバックをできるようにするため、Credsspを許可する場合
# Enable-WSManCredSSP -Role Server
# # スクリプトファイルを遠隔から実行許可(サーバ側)
# Set-ExecutionPolicy RemoteSigned -Force
#
#
# クライアント側の設定(CredSSP認証でlocalhostに接続する場合)
# 1. WinRM有効化
# Enable-PSRemoting
# 2. 2ndhopや標準権限ループバックをできるようにするため、Credssp認証を有効化し、ポリシーも許可する
# Enable-WSManCredSSP -Role Client -DelegateComputer localhost
# gpedit.msc
# # [コンピューターの構成] -> [管理用テンプレート] -> [システム] -> [資格情報の委任] -> [新しい資格情報の委任を許可する]
# # wsman/*
# # [コンピューターの構成] -> [管理用テンプレート] -> [システム] -> [資格情報の委任] -> [NTLM のみのサーバー認証で新しい資格情報の委任を許可する]
# # wsman/*
#
#
#
# 以下、必要な場合に設定する内容
# # クライアントのネットワークプロファイルがパブリックだが、プライベートにしてよい時
# # # 設定 > ネットワークとインターネット > (Wifi > 現在接続中の接続、など) > ネットワークプロファイル：Private（＝信頼済み）にする
# # Windows Defenderに阻まれる場合
# New-NetFirewallRule -DisplayName "@RemotePowerShell-enable" -Program "%SystemRoot%\System32\svchost.exe" -Profile Private -Direction Inbound -Protocol TCP -LocalPort RPC -Action Allow
# New-NetFirewallRule -DisplayName "@RemotePowerShell-enable" -Program "%SystemRoot%\System32\svchost.exe" -Profile Public -Direction Inbound -Protocol TCP -LocalPort RPC -Action Allow
# # リモートホストを信頼する必要がある場合
# Set-Item WSMan:\localhost\Client\TrustedHosts <リモートのIP>
#
#
#
# 参考
#
# about_Remote に関するページ  
# https://learn.microsoft.com/ja-jp/powershell/module/microsoft.powershell.core/about/about_remote?view=powershell-7.3
# 
# about_Remote_Requirements  
# https://learn.microsoft.com/ja-jp/powershell/module/microsoft.powershell.core/about/about_remote_requirements?view=powershell-7.3
# 
# about_Session_Configurations  
# https://learn.microsoft.com/ja-jp/powershell/module/microsoft.powershell.core/about/about_session_configurations?view=powershell-7.3
# 
# about_Remote_Troubleshooting
# https://learn.microsoft.com/ja-jp/powershell/module/microsoft.powershell.core/about/about_remote_troubleshooting?view=powershell-7.3
#
# Enable-PSRemoting または Set-WSManQuickConfig?
# https://www.enmimaquinafunciona.com/pregunta/128462/enable-psremoting-o-set-wsmanquickconfig
#
# Enable PowerShell "Second-Hop" Functionality with CredSSP
# https://devblogs.microsoft.com/scripting/enable-powershell-second-hop-functionality-with-credssp/
#
#
#
#
#
#
# ------------------------------------------------------
# トラブルシューティング1
# ------------------------------------------------------
# [localhost] Connecting to remote server localhost failed with the following error message :
# アクセスが拒否されました。
# For more information, see the about_Remote_Troubleshooting Help topic.
# ------------------------------------------------------
# 原因：
# ユーザーのアクセス許可がない
# 解決：
# 既定の[セッション構成](SessionConfiguration Microsoft.Powershell)側にユーザを追加する
# あるいはユーザ側を適切なグループに所属させる（「Remote Management Users」など）
# 例：
# サーバ側で以下を実施
# Set-PSSessionConfiguration Microsoft.Powershell -ShowSecurityDescriptorUI
#
#
#
# ------------------------------------------------------
# トラブルシューティング2
# ------------------------------------------------------
# [localhost] Connecting to remote server localhost failed with the following error message :
# WSMan サービスは指定された要求を処理するためのホスト プロセスを起動できません。
# WSMan プロバイダー ホスト サーバーおよびプロキシが正しく登録されているかどうかを確認してください。
# For more information, see the about_Remote_Troubleshooting Help topic.
# ------------------------------------------------------
# 原因：
# localhostにデフォルト認証(NTLM)でリモート接続する際、管理者権限で実行していない
# 解決：
# CredSSP認証で接続できるように各種設定し、CredSSP認証で接続する
# 例：
# CredSSP認証を有効にして設定するには、トラブルシューティング3以降を参考にしてください
#
#
#
# ------------------------------------------------------
# トラブルシューティング3
# ------------------------------------------------------
# [localhost] Connecting to remote server localhost failed with the following error message :
# WinRM クライアントは要求を処理できません。
# 現在のクライアント構成では、CredSSP 認証が無効にされています。
# クライアント構成を変更して、もう一度要求してください。
# CredSSP 認証はサーバー構成でも有効になっている必要があります。
# また、グループ ポリシーを編集して、ターゲット コンピューターへの資格情報の委任を許可する必要があります。
# gpedit.msc を使用して、[コンピューターの構成] -> [管理用テンプレート] -> [システム] -> [資格情報の委任] -> [新しい資格情報の委任を許可する] ポリシーを確認してください。
# このポリシーが有効になっており、ターゲット コンピューターの適切な SPN を使用して構成されている必要があります。
# たとえば、ターゲット コンピューター名が "myserver.domain.com" の場合、SPN は WSMAN/myserver.domain.com または WSMAN/*.domain.com のどちらかです。
# For more information, see the about_Remote_Troubleshooting Help topic.
# ------------------------------------------------------
# 原因：
# クライアント側のCredSSP認証が有効になっていない
# 解決：
# クライアント側のCredSSP認証を有効にする
# 例：
# クライアント側で以下を実施
# Enable-WSManCredSSP -Role Client -DelegateComputer <IPやホスト名。ワイルドカード*も使用可能>
#
#
#
# ------------------------------------------------------
# トラブルシューティング4
# ------------------------------------------------------
# [localhost] Connecting to remote server localhost failed with the following error message :
# WinRM クライアントは要求を処理できません。
# このユーザー資格情報をこのターゲット コンピューターに委任することは、コンピューター ポリシーにより許可されません。
# gpedit.msc を使用し、[コンピューターの構成] -> [管理用テンプレート] -> [システム] -> [資格情報の委任] -> [新しい資格情報の委任を許可する] ポリシーを確認してください。
# このポリシーが有効になっており、ターゲット コンピューターの適切な SPN を使用して構成されている必要があります。
# たとえば、ターゲット コンピューター名が "myserver.domain.com" の場合、SPN は WSMAN/myserver.domain.com または WSMAN/*.domain.com のいずれかです。
# For more information, see the about_Remote_Troubleshooting Help topic.
# ------------------------------------------------------
# 原因：
# CredSSP認証関連。クライアント側でgpedit.mscで資格の委任を設定していない
# 解決：
# CredSSP認証関連。クライアント側でgpedit.mscでエラーメッセージの通りに資格の委任をWSMANに対して有効にする
# 例：
# クライアント側で以下を実施
# gpedit.msc
# # [コンピューターの構成] -> [管理用テンプレート] -> [システム] -> [資格情報の委任] -> [新しい資格情報の委任を許可する]
# # # WSMAN/*
#
#
#
# ------------------------------------------------------
# トラブルシューティング5
# ------------------------------------------------------
# [localhost] Connecting to remote server localhost failed with the following error message :
# WinRM クライアントは要求を処理できません。
# クライアントから要求された認証機構がサーバーでサポートされていないか、または暗号化されていないトラフィックがサービスの構成で無効にされています。
# サービスの構成で、暗号化されていないトラフィックの設定を確認するか、またはサーバーによってサポートされている認証機構のいずれかを指定してください。
# Kerberos を使用するには、リモートの宛先としてコンピューター名を指定してください。
# また、クライアント コンピューターと宛先コンピューターが同じドメインに参加していることを確認してください。
# Basic を使用するには、リモートの宛先としてコンピューター名を指定し、Basic 認証を指定してユーザー名とパスワードを提供してください。
# サーバーからの報告によると次の認証機構を使用できます:     Negotiate
# For more information, see the about_Remote_Troubleshooting Help topic.
# ------------------------------------------------------
# 原因：
# CredSSP認証関連。サーバ側が要求した認証モードを許可していない
# 解決：
# CredSSP認証関連。サーバ側で要求した認証モードを許可する
# 例：
# サーバ側で以下を実施
# Enable-WSManCredSSP -Role Server
#
#
#
# ------------------------------------------------------
# トラブルシューティング6
# ------------------------------------------------------
# [localhost] Connecting to remote server localhost failed with the following error message :
# WinRM クライアントは要求を処理できません。
# このユーザー資格情報をこのターゲット コンピューターに委任することは、ターゲット コンピューターが信頼されていないため、コンピューター ポリシーにより許可されません。
# ターゲット コンピューターの ID を検証可能にするには、有効な証明書を使用するよう次のコマンドで WSMAN サービスを構成してください: winrm set winrm/config/service '@{CertificateThumbprint="<拇印>"}'
# または、イベント ビューアーを使用し、WSMAN/<コンピューターの FQDN> という SPN を作成できなかったことを示すイベントを確認してください。
# このイベントが記録されていた場合は、setspn.exe を使用して手動で SPN を作成できます。
# 該当する SPN が存在するにもかかわらず CredSSP で Kerberos を使用してターゲット コンピューターの ID を検証できない場合、ユーザー資格情報をターゲット コンピューターに委任できるようにするには、gpedit.msc を使用し、[コンピューターの構成] -> [管理用テンプレート] -> [システム] -> [資格情報の委任] -> [NTLM のみのサーバー認証で新しい資格情報を許可する]
# ポリシーを確認してください。
# このポリシーが有効になっており、ターゲット コンピューターの適切な SPN を使用して構成されている必要があります。
# たとえば、ターゲット コンピューター名が "myserver.domain.com" の場合、SPN は WSMAN/myserver.domain.com または WSMAN/*.domain.com のいずれかです。
# これらの変更を行ってから、要求を再試行してください。
# For more information, see the about_Remote_Troubleshooting Help topic.
# ------------------------------------------------------
# 原因：
# CredSSP認証関連
# パターン1：2ndhopしようとした
# パターン2：localhostへのループバック接続しようとした
# 解決：
# CredSSP認証関連。クライアント側でgpedit.mscでエラーメッセージの通りに資格の委任をWSMANに対して有効にする
# 例：
# クライアント側で以下を実施
# gpedit.msc
# # [コンピューターの構成] -> [管理用テンプレート] -> [システム] -> [資格情報の委任] -> [NTLM のみのサーバー認証で新しい資格情報の委任を許可する]
# # # WSMAN/*
#
#
#
# ------------------------------------------------------
# トラブルシューティング7
# ------------------------------------------------------
# このシステムではスクリプトの実行が無効になっているため、ファイル C:\Users\Ether\OneDrive\デスクトップ\sample.ps1 を読み込むことができません。
# 詳細については、「about_Execution_Policies」(https://go.microsoft.com/fwlink/?LinkID=135170) を参照してください。
# ------------------------------------------------------
# 原因：
# ExecutionPolicyの不備
# 解決：
# ExecutionPolicyを適切にする
# 例：
# サーバ側で以下を実施
# Set-ExecutionPolicy RemoteSigned -Force
