using System;

namespace Dtos
{
    public class TranslationDto
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public LanguageDto Languaje { get; set; }

    }
    public class LanguageDto
    {
        public Guid Id { get; set; }
        public string LanguageName { get; set; }
    }
}