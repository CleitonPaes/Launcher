using System.Collections.Generic;

namespace Launcher
{
    internal class Texts
    {
        private static readonly Dictionary<string, string> Text = new Dictionary<string, string>
        {
            {"UNKNOWNERROR",                    "Impossível conectar ao servidor: \n{0}"},
            {"MISSINGBINARY",                   "O jogo não pode iniciar {0} esta faltando."},
            {"CANNOTSTART",                     "Não foi Possível iniciar o jogo"},
            {"NONETWORK",                       "Não é possivel conectar ao servidor."},
            {"CONNECTING",                      "Conectando ao servidor.."},
            {"LISTDOWNLOAD",                    "Baixando informações do servidor..."},
            {"CHECKFILE",                       "{0} Verificando..."},
            {"DOWNLOADFILE",                    "{0} Baixando... {1}/ {2}"},
            {"COMPLETEPROGRESS",                "Progresso: {0}%"},
            {"CURRENTPROGRESS",                 "Baixando Arquivos: {0}%  |  {1} kb/s"},
            {"CHECKCOMPLETE",                   "Os Arquivos estão atualizados, bom jogo!"},
            {"DOWNLOADCOMPLETE",                "Os Arquivos estão atualizados, bom jogo!"},
            {"DOWNLOADSPEED",                   "{0} kb/s"}
        };

        public static string GetText(string Key, params object[] Arguments)
        {
            foreach (KeyValuePair<string, string> currentItem in Text)
            {
                if (currentItem.Key == Key)
                {
                    return string.Format(currentItem.Value, Arguments);
                }
            }

            return null;
        }
    }
}
