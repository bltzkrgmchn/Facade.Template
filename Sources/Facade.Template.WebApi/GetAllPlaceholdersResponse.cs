using System.Collections.Generic;

namespace Facade.Template.WebApi
{
    /// <summary>
    /// Placeholder.
    /// </summary>
    public class Placeholder
    {
        /// <summary>
        /// �������������� ����� ��������� ������ <see cref="Placeholder"/>.
        /// </summary>
        /// <param name="id">������������� Placeholder.</param>
        public Placeholder(string id)
        {
            this.Id = id;
        }

        /// <summary>
        /// �������� ������������� Placeholder.
        /// </summary>
        public string Id { get; private set; }
    }

    /// <summary>
    /// Ответ на команду получения списка Placeholder.
    /// </summary>
    public class GetAllPlaceholdersResponse
    {
        /// <summary>
        /// Получает или задает список Placeholder.
        /// </summary>
        public List<Placeholder> Placeholders { get; set; }

        /// <summary>
        /// Получает или задает результат обработки команды.
        /// </summary>
        public string Result { get; set; }
    }
}