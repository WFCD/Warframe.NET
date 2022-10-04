namespace WarframeNet.WorldState.Enums
{
    /// <summary>
    /// Available languages to retrieve worldstate data in. Defaults to English.
    /// </summary>
    public enum WorldStateLanguage
    {
        [QueryLanguage("en")]
        English,
        [QueryLanguage("de")]
        German,
        [QueryLanguage("es")]
        Spanish,
        [QueryLanguage("fr")]
        French,
        [QueryLanguage("it")]
        Italian,
        [QueryLanguage("ko")]
        Korean,
        [QueryLanguage("po")]
        Polish,
        [QueryLanguage("pt")]
        Portuguese,
        [QueryLanguage("ru")]
        Russian,
        [QueryLanguage("zh")]
        Chinese,
    }
}