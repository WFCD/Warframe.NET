namespace WorldState.Enums
{
    /// <summary>
    /// Available languages to retrieve worldstate data in. Defaults to English.
    /// </summary>
    public enum WorldStateLanguage
    {
        [AcceptLanguage("en")]
        English,
        [AcceptLanguage("de")]
        German,
        [AcceptLanguage("es")]
        Spanish,
        [AcceptLanguage("fr")]
        French,
        [AcceptLanguage("it")]
        Italian,
        [AcceptLanguage("ko")]
        Korean,
        [AcceptLanguage("po")]
        Polish,
        [AcceptLanguage("pt")]
        Portuguese,
        [AcceptLanguage("ru")]
        Russian,
        [AcceptLanguage("zh")]
        Chinese,
    }
}