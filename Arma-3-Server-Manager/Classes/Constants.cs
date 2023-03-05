using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arma_3_Server_Manager.Classes
{
    public class Constants
    {
        public const string Name = "hostname";
        public const string Password = "password";
        public const string PasswordAdmin = "passwordAdmin";
        public const string MaxPlayers = "maxPlayers";
        public const string Persistent = "persistent";
        public const string DisableVON = "disableVoN";
        public const string vonCodecQuality = "vonCodecQuality";
        public const string voteMissionPlayers = "voteMissionPlayers";
        public const string voteThreshold = "voteThreshold";

        public const string motd = "motd[]";
        public const string motdInterval = "motdInterval";

        public const string timestampFormat = "timeStampFormat";
        public const string logFile = "logFile";

        public const string BattleEye = "BattleEye";
        public const string verifySignatures = "verifySignatures";
        public const string kickDuplicate = "kickDuplicate";
        public const string allowedFilePatching = "allowedFilePatching";

        public const string upnp = "upnp";
    }

    public class DefaultSettingsArrays
    {
        public const string allowedVotes = "allowedVoteCmds[] = { { \"admin\", false, false}, { \"kick\", false, true, 0.51}, { \"missions\", false, false}, { \"mission\", false, false},{ \"restart\", false, false},{ \"reassign\", false, false} };";
        public const string missions = "class Missions { }";
        public const string allowedFiles = "allowedLoadFileExtensions[] =       { \"hpp\",\"sqs\",\"sqf\",\"fsm\",\"cpp\",\"paa\",\"txt\",\"xml\",\"inc\",\"ext\",\"sqm\",\"ods\",\"fxy\",\"lip\",\"csv\",\"kb\",\"bik\",\"bikb\",\"html\",\"htm\",\"biedi\"};";
        public const string allowedPreProcessFiles = "allowedPreprocessFileExtensions[] =       { \"hpp\",\"sqs\",\"sqf\",\"fsm\",\"cpp\",\"paa\",\"txt\",\"xml\",\"inc\",\"ext\",\"sqm\",\"ods\",\"fxy\",\"lip\",\"csv\",\"kb\",\"bik\",\"bikb\",\"html\",\"htm\",\"biedi\"};";
        public const string allowedHTML = "allowedHTMLLoadExtensions[] = { \"htm\",\"html\",\"php\",\"xml\",\"txt\"};";

    }

    public class EventScripts
    {
        public const string onUserConnected = "";
        public const string onUserDisconnected = "";
        public const string doubleIdDetected = "";
        public const string onUnsignedData = "kick (_this select 0)";
        public const string onHackedData = "kick (_this select 0)";
    }

    public class ClientsArrays
    {
        public const string headlessClients = "headlessClients[] = = { \"127.0.0.1\"}";
        public const string localClient = "localClient[] = = { \"127.0.0.1\"}";
    }

    public class SteamURLS
    {
        public const string arma3ServerUrl = "";
    }

    public class ManagerConstants
    {
        public const string loggingFolderName = "\\Arma 3 Server Manager Logs";
        public const string modDirectory = "E:\\Arma 3 Server For C# Project\\Arma 3 Server";
    }
}