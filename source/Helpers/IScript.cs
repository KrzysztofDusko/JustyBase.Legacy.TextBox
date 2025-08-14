using System;

namespace FastColoredTextBoxNS.Helpers;

public interface IScript
{
    string ScriptText { get; set; }
    event Action<string> OnError;
    void RunScript();
    event Action<string> OnStart;
    event Action<string> OnEnd;
    event Action<string> OnBegin;
    event Action<string> OnUsingStart;
    event Action<string> OnGoStart;
    event Action<string> OnBeforeCommand;
    event Action<string> OnAfterCommand;
    event Action<string> OnIf;
    event Action<string, string> OnErrorCommand;
    event Action<int> OnBeforeLine;
    event Action OnBreak;
    void FullBreak();
}
