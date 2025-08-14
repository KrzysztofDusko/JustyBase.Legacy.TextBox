namespace FastColoredTextBoxNS.Helpers;
public interface IAutocompleteClass
{
    void AddAutocompleteForGeneral(int selectionStart, string _cleanSqlText);
    void AddAutocompleteForNZ(int selectionStart, string _cleanSqlText);
    int LastSelect(ref string innerString, bool doTrim = true);
    int FirstFrom(string afterSelect);
    int FirstWhereGroupLimit(string txt);
}