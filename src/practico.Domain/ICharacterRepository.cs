using System.Linq.Expressions;
namespace practico.Domain;

public interface ICharacterRepository
{
    ICollection<Character> MetodoGet();
}
